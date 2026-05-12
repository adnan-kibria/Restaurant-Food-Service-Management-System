using AutoMapper;
using BLL.DTOs;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class CustomerService
    {
        CustomerRepo CustomerRepo;
        AddressRepo addressRepo;
        UserRepo userRepo;
        Mapper mapper;
        public CustomerService(CustomerRepo CustomerRepo, AddressRepo addressRepo, UserRepo userRepo)
        {
            this.CustomerRepo = CustomerRepo;
            this.addressRepo = addressRepo;
            this.userRepo = userRepo;
            mapper = MapperConfig.GetMapper();
        }

        public bool Add(RegistrationDTO res)
        {
            var formAddress = addressRepo.Add(res.AddressLine, res.Area, res.City);
            var addressId = addressRepo.GetByAddressLine(res.AddressLine);
            var user = userRepo.GetByEmail(res.Email);
            return CustomerRepo.Add(res.Name, res.Phone, addressId, user.Id);
        }
    }
}
