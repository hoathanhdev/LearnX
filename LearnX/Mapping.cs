using AutoMapper;
using Infractructures.Entities;
using LearnX.Models;

namespace LearnX
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
        }
    }
}
