using AutoMapper;
using BLL.DTOs;
using BLL.Helper;
using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class AuthService
    {
        UserRepo userRepo;
        Mapper mapper;
        public AuthService(UserRepo userRepo)
        {
            this.userRepo = userRepo;
            mapper = MapperConfig.GetMapper();
        }

        public LoginDTO Get(LoginDTO user)
        {
            var data = userRepo.GetByEmail(user.Email);
            if (data != null && HashPassword.Verify(user.Password, data.Password))
            {
                return mapper.Map<LoginDTO>(data);
            }

            return null;
        }
    }
}
