using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WebStore.Areas.Identity.IdentityHostingStartup))]
namespace WebStore.Areas.Identity
{
	public class IdentityHostingStartup : IHostingStartup
	{
		public void Configure(IWebHostBuilder builder)
		{
			builder.ConfigureServices((context, services) =>
			{
			});
		}
	}
}