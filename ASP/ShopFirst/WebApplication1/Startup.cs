using WebApplication1.Data.interfaces;
using WebApplication1.Data.Moks;

namespace WebApplication1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllCars, MockCars>();

       
        }
    }
}
