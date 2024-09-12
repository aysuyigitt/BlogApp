using DataEntitesLayer;
using DataEntitesLayer.Abstract;
using DataEntitesLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlogApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BlogContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddScoped<SeedData>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Users/Login"; // Giri� yapmam�� kullan�c�lar bu sayfaya y�nlendirilecek.
                    options.LogoutPath = "/Users/Logout"; // ��k�� yapan kullan�c�lar bu sayfaya y�nlendirilecek.
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts(); // G�venlik i�in HSTS eklemek genellikle �nerilir
            }

            app.UseHttpsRedirection(); // HTTPS y�nlendirmesi
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication(); // Kimlik do�rulama
            app.UseAuthorization(); // Yetkilendirme

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "posts_details",
                    pattern: "posts/details/{url}",
                    defaults: new { controller = "Posts", action = "Details" });

                endpoints.MapControllerRoute(
                     name: "posts_by_tag",
                     pattern: "posts/tag/{tag}",
                      defaults: new { controller = "Posts", action = "Index" });

                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Posts}/{action=Index}/{id?}");
            });

            SeedData.TestVerileriniDoldur(app.ApplicationServices);
        }
    }
}
