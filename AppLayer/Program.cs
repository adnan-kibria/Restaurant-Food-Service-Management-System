using BLL.Services;
using DAL;
using DAL.EF;
using DAL.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Repositories Dependency
builder.Services.AddScoped<AddressRepo>();
builder.Services.AddScoped<AuditLogRepo>();
builder.Services.AddScoped<BillRepo>();
builder.Services.AddScoped<CategoryRepo>();
builder.Services.AddScoped<ChefRepo>();
builder.Services.AddScoped<CustomerRepo>();
builder.Services.AddScoped<DeliveryManRepo>();
builder.Services.AddScoped<FoodRepo>();
builder.Services.AddScoped<FoodsIngredientRepo>();
builder.Services.AddScoped<IngredientRepo>();
builder.Services.AddScoped<IngredientStockStatusRepo>();
builder.Services.AddScoped<ManagerRepo>();
builder.Services.AddScoped<NotificationRepo>();
builder.Services.AddScoped<NotificationStatusRepo>();
builder.Services.AddScoped<OrderRepo>();
builder.Services.AddScoped<OrderDetailRepo>();
builder.Services.AddScoped<OrderStatusRepo>();
builder.Services.AddScoped<RecommendationRepo>();
builder.Services.AddScoped<ReservationRepo>();
builder.Services.AddScoped<ReservationStatusRepo>();
builder.Services.AddScoped<RoleRepo>();
builder.Services.AddScoped<TableRepo>();
builder.Services.AddScoped<TableStatusRepo>();
builder.Services.AddScoped<UserRepo>();
builder.Services.AddScoped<UserStatusRepo>();
builder.Services.AddScoped<WaiterRepo>();

//Services Dependency
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<AuditLogService>();
builder.Services.AddScoped<BillService>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<ChefService>();
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<DeliveryManService>();
builder.Services.AddScoped<FoodService>();
builder.Services.AddScoped<FoodsIngredientService>();
builder.Services.AddScoped<IngredientService>();
builder.Services.AddScoped<IngredientStockStatusService>();
builder.Services.AddScoped<ManagerService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<NotificationStatusService>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<OrderDetailService>();
builder.Services.AddScoped<OrderStatusService>();
builder.Services.AddScoped<RecommendationService>();
builder.Services.AddScoped<ReservationService>();
builder.Services.AddScoped<ReservationStatusService>();
builder.Services.AddScoped<RoleService>();
builder.Services.AddScoped<TableService>();
builder.Services.AddScoped<TableStatusService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<UserStatusService>();
builder.Services.AddScoped<WaiterService>();
builder.Services.AddScoped<AuthService>();

//Database Context Dependency
builder.Services.AddDbContext<RestaurantFoodServiceContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConn"));
});

//Session Dependency
builder.Services.AddSession(opt =>
{
    opt.IdleTimeout = TimeSpan.FromMinutes(30);
    opt.Cookie.HttpOnly = true;
    opt.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseSession();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();