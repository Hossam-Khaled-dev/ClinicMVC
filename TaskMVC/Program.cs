


using Clinic.BL;
using Clinic.DAL;
using Microsoft.EntityFrameworkCore;




var builder = WebApplication.CreateBuilder(args);


builder.Configuration.AddJsonFile("appsettings.json");
var configuration = builder.Configuration;

var dbSection = configuration.GetConnectionString("ConnStr");


builder.Services.AddDbContext<ClinicContext>(options =>
        options.UseSqlServer(dbSection));

builder.Services.AddControllersWithViews();





builder.Services.AddScoped<IDoctorServices, DoctorServices>();
builder.Services.AddScoped<IAppointmentServices, AppointmentServices>();
builder.Services.AddScoped<IPatientServices, PatientServices>();
builder.Services.AddScoped<IAppointmentServices, AppointmentServices>();
builder.Services.AddTransient(typeof(IGenericRepo<>), typeof(GenericRepo<>));
builder.Services.AddScoped<IDoctorRepo, DoctorRepo>();
builder.Services.AddScoped<IAppointmentRepo, AppointmentRepo>();
builder.Services.AddScoped<IPatientRepo, PatientRepo>();
builder.Services.AddScoped<IDatabaseRepo, DatabaseRepo>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();



var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        
 