
using Application;
using Application.Exceptions;
using Application.Handler;
using Application.Mapper;
using Application.Model;
using Application.Validator;
using AutoMapper;
using FluentValidation;
using Infrastructure.Repository;
using MediatR;
using System.Reflection;
using static Application.Handler.CreateEmployeeCommand;
using static Application.Handler.GetAllEmployeeQuery;

namespace CQRSWithMediatr
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddSwaggerGen();
            services
           .AddScoped<IRequestHandler<GetAllEmployeeQuery, List<EmployeeReadModel>>, GetAllEmployeeQueryHandler>();
            services
            .AddScoped<IRequestHandler<CreateEmployeeCommand, EmployeeReadModel>, CreateEmployeeCommandHandler>();
            services.AddAutoMapper(typeof(EmployeeProfile).Assembly);
            services.AddScoped<IEmployeeQueryRepository, EmployeeQueryRepository>();
            services.AddScoped<IEmployeeCommandRepository, EmployeeCommandRepository>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
            services.AddTransient<ExceptionHandlingMiddleware>();

            // services.AddTransient<IValidator<CreateEmployeeCommand>, CreateEmployeeCommandValidator>();

            services.AddValidatorsFromAssembly(typeof(EmployeeProfile).Assembly);
        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseMiddleware<ExceptionHandlingMiddleware>();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }

    public static class MappingProfile
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EmployeeProfile());  //mapping between Web and Business layer objects
            });

            return config;
        }
    }
}