using AutoMapper;
using BLL.DTOs;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class RoleService
    {
        RoleRepo roleRepo;
        Mapper mapper;
        public RoleService(RoleRepo roleRepo)
        {
            this.roleRepo = roleRepo;
            mapper = MapperConfig.GetMapper();
        }

        public List<RoleDTO> Get()
        {
            var data = roleRepo.Get();
            return mapper.Map<List<RoleDTO>>(data);
        }

        public RoleDTO GetById(int id)
        {
            var data = roleRepo.GetById(id);
            return mapper.Map<RoleDTO>(data);
        }
    }
}
