using ECommerce.Service.RestExtension;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using SimApi.Base;


namespace ECommerce.Service;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddResponseCompression();
        services.AddMemoryCache();
        services.AddCustomSwaggerExtension();
        services.AddDbContextExtension(Configuration);
        services.AddMapperExtension();
        services.AddRepositoryExtension();
        services.AddServiceExtension();
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();

        }

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.DefaultModelsExpandDepth(-1);
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sim Company");
            c.DocumentTitle = "SimApi Company";
        });

        ////DI
        //app.AddExceptionHandler();
        //app.AddDIExtension();
        //app.UseHangfireDashboard();

        //app.UseMiddleware<HeartBeatMiddleware>();
        //app.UseMiddleware<ErrorHandlerMiddleware>();
        //Action<RequestProfilerModel> requestResponseHandler = requestProfilerModel =>
        //{
        //    Log.Information("-------------Request-Begin------------");
        //    Log.Information(requestProfilerModel.Request);
        //    Log.Information(Environment.NewLine);
        //    Log.Information(requestProfilerModel.Response);
        //    Log.Information("-------------Request-End------------");
        //};
        //app.UseMiddleware<RequestLoggingMiddleware>(requestResponseHandler);

        app.UseHttpsRedirection();

        // add auth 
        app.UseAuthentication();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
