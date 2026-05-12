using AutoMapper;
using BLL.DTOs;
using BLL.Helper;
using DAL.EF;
using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class UserService
    {
        UserRepo userRepo;
        UserStatusRepo repoUserStatus;
        Mapper mapper;
        public UserService(UserRepo userRepo, UserStatusRepo repoUserStatus)
        {
            this.userRepo = userRepo;
            mapper = MapperConfig.GetMapper();
            this.repoUserStatus = repoUserStatus;
        }
        public UserDTO GetByEmail(string email)
        {
            var data = userRepo.GetByEmail(email);
            return mapper.Map<UserDTO>(data);
        }

        public UserStatusDTO Get(int id)
        {
            var data = repoUserStatus.Get(id);
            return mapper.Map<UserStatusDTO>(data);
        }

        public bool Add(RegistrationDTO register) {
            var hashedPass = HashPassword.Hash(register.Password);
            var statusId = 1;
            return userRepo.Add(register.Email, hashedPass, register.RoleId, statusId);
        }

    }
}
