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
                    options.LoginPath = "/Users/Login"; // Giriþ yapmamýþ kullanýcýlar bu sayfaya yönlendirilecek.
                    options.LogoutPath = "/Users/Logout"; // Çýkýþ yapan kullanýcýlar bu sayfaya yönlendirilecek.
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
                app.UseHsts(); // Güvenlik için HSTS eklemek genellikle önerilir
            }

            app.UseHttpsRedirection(); // HTTPS yönlendirmesi
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication(); // Kimlik doðrulama
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
