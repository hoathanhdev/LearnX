using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infractructures.Entities;
using Infractructures.Repository;

namespace Infractructures.Service
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void DeleteUser(User user)
        {
            userRepository.Delete(user);
        }

        public User GetUser(int id)
        {
            return userRepository.GetById(id);
        }

        public IQueryable<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }
    }
}
