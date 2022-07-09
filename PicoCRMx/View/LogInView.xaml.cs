using PicoCRMx.Objects.ViewModel;
using PicoCRMx.Communication.SMS;
namespace PicoCRMx.View;

public partial class LogInView : ContentPage
{
	public LogInView()
	{
		InitializeComponent();

		BindingContext = new AuthViewModel();
	}

	private void ContentPage_Loaded(object sender, EventArgs e)
	{
		String[] dd = new String[] {"1"};


        FarazSMS farazSMS = new FarazSMS("", "sendpattern","" ,dd);

    }
}