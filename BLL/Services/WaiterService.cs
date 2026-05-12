using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class WaiterService
    {
        WaiterRepo waiterRepo;
        AddressRepo addressRepo;
        UserRepo userRepo;
        Mapper mapper;
        public WaiterService(WaiterRepo waiterRepo, AddressRepo addressRepo, UserRepo userRepo)
        {
            this.waiterRepo = waiterRepo;
            mapper = MapperConfig.GetMapper();
            this.addressRepo = addressRepo;
            this.userRepo = userRepo;
        }

        public bool Add(RegistrationDTO res)
        {
            var formAddress = addressRepo.Add(res.AddressLine, res.Area, res.City);
            var addressId = addressRepo.GetByAddressLine(res.AddressLine);
            var user = userRepo.GetByEmail(res.Email);
            return waiterRepo.Add(res.Name, res.Phone, addressId, user.Id);
        }
    }
}
