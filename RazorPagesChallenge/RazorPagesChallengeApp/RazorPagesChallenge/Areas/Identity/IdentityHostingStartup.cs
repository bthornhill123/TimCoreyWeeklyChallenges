using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesChallenge.Areas.Identity.Data;
using RazorPagesChallenge.Models;

[assembly: HostingStartup(typeof(RazorPagesChallenge.Areas.Identity.IdentityHostingStartup))]
namespace RazorPagesChallenge.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RazorPagesChallengeContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("RazorPagesChallengeContextConnection")));

                services.AddDefaultIdentity<RazorPagesChallengeUser>()
                    .AddEntityFrameworkStores<RazorPagesChallengeContext>();
            });
        }
    }
}