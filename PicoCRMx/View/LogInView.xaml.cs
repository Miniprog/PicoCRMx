using PicoCRMx.Objects.ViewModel;

namespace PicoCRMx.View;

public partial class LogInView : ContentPage
{
	public LogInView()
	{
		InitializeComponent();

		BindingContext = new AuthViewModel();
	}
}