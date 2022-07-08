using PicoCRMx.Objects.Contact;
using PicoCRMx.Objects.ViewModel;

namespace PicoCRMx;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddSingleton<ContactViewModel>();
        builder.Services.AddTransient<CreateModel>();
		builder.Services.AddTransient<ContactService>();

		builder.Services.AddSingleton <AuthViewModel>();
        builder.Services.AddTransient<GetContactModel>();
		
        builder.Services.AddTransient<ContactService>();
        builder.Services.AddTransient<View.LogInView>();
        return builder.Build();
	}
}
