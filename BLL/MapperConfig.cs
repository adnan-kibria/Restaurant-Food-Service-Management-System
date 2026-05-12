using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;

namespace BLL
{
    public class MapperConfig
    {
        public static MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<User, LoginDTO>().ReverseMap();
            cfg.CreateMap<User, RegistrationDTO>().ReverseMap();
            cfg.CreateMap<Customer, RegistrationDTO>().ReverseMap();
            cfg.CreateMap<Manager, RegistrationDTO>().ReverseMap();
            cfg.CreateMap<Chef, RegistrationDTO>().ReverseMap();
            cfg.CreateMap<Waiter, RegistrationDTO>().ReverseMap();
            cfg.CreateMap<DeliveryMan, RegistrationDTO>().ReverseMap();
            cfg.CreateMap<Address, AddressDTO>().ReverseMap();   
            cfg.CreateMap<AuditLog, AuditLogDTO>().ReverseMap();   
            cfg.CreateMap<Bill, BillDTO>().ReverseMap();   
            cfg.CreateMap<Category, CategoryDTO>().ReverseMap();   
            cfg.CreateMap<Chef, ChefDTO>().ReverseMap();   
            cfg.CreateMap<Customer, CustomerDTO>().ReverseMap();   
            cfg.CreateMap<DeliveryMan, DeliveryManDTO>().ReverseMap();   
            cfg.CreateMap<Food, FoodDTO>().ReverseMap();   
            cfg.CreateMap<FoodsIngredient, FoodsIngredientDTO>().ReverseMap();   
            cfg.CreateMap<Ingredient, IngredientDTO>().ReverseMap();   
            cfg.CreateMap<IngredientStockStatus, IngredientStockStatusDTO>().ReverseMap();   
            cfg.CreateMap<Manager, ManagerDTO>().ReverseMap();   
            cfg.CreateMap<Notification, NotificationDTO>().ReverseMap();   
            cfg.CreateMap<Order, OrderDTO>().ReverseMap();   
            cfg.CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();   
            cfg.CreateMap<OrderStatus, OrderStatusDTO>().ReverseMap();   
            cfg.CreateMap<Recommendation, RecommendationDTO>().ReverseMap();   
            cfg.CreateMap<Reservation, ReservationDTO>().ReverseMap();   
            cfg.CreateMap<ReservationStatus, ReservationStatusDTO>().ReverseMap();   
            cfg.CreateMap<Role, RoleDTO>().ReverseMap();   
            cfg.CreateMap<Table, TableDTO>().ReverseMap();   
            cfg.CreateMap<TableStatus, TableStatusDTO>().ReverseMap();   
            cfg.CreateMap<User, UserDTO>().ReverseMap();   
            cfg.CreateMap<UserStatus, UserStatusDTO>().ReverseMap();   
            cfg.CreateMap<Waiter, WaiterDTO>().ReverseMap();
            
        });

        public static Mapper GetMapper()
        {
            return new Mapper(config);
        }

    }
}
