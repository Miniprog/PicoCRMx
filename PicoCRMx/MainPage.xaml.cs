


using PicoCRMx.Objects.Contact;
using PicoCRMx.Objects.ViewModel;

namespace PicoCRMx;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
        Routing.RegisterRoute("LogInView", typeof(View.LogInView));
        
		Shell.Current.GoToAsync("LogInView" , true );
			
	}



}

