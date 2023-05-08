using System.Diagnostics;
using AutoMapper;
using Infractructures.Entities;
using Infractructures.Service;
using LearnX.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearnX.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public HomeController(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(userService.GetUsers());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            UserModels data = new UserModels();
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI TÀI KHOẢN" : "CẬP NHẬT TÀI KHOẢN";
            
            if(id != 0)
            {
                User res = userService.GetUser(id);
                data = mapper.Map<UserViewModel>(res);
                if(data == null)
                {
                    return NotFound;
                }
            }    
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, UserModel data)
        {
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI TÀI KHOẢN" : "CẬP NHẬT TÀI KHOẢN";

            if (ModelState.IsValid)
            {
                try
                {
                    User res = mapper.Map<User>(data);
                    if(id != 0)
                    {
                        userService.UpdateUser(res);
                    }
                    else
                    {
                        res.CreatDate = DateTime.Now;
                        userService.InsertUser(res);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound;
                }
                return RedirectToAction("Index", "User");

            }
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            User res = userService.GetUser(id);
            userService.DeleteUser(res);

            return  RedirectToAction("Index", "User");

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}