

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/// <summary>
/// Repos
/// </summary>
/// 
//builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepositoryImp<>));

builder.Services.AddTransient<IVehicleRepo, VehicleRepoImp>();

builder.Services.AddTransient<IVehicleServices, VehicleServicesImp>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//AutoMapper
//builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddAutoMapper(options=>options.AddProfile<MappingProfile>());

//CORS Services
builder.Services.AddCors();

builder.Services.AddSwaggerGen();

//add the context db
//DbContext configuration
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection"),
    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))); //here i am going to specify where to find application dbcontext


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//add use cors
app.UseCors(c=> c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
