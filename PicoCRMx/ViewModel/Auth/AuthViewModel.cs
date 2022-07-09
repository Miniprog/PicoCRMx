using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PicoCRMx.Objects.Contact;
using PicoCRMx.Auth;
namespace PicoCRMx.Objects.ViewModel
{
    public partial  class AuthViewModel : ObservableObject
    {
        AuthService authService = new AuthService();

        public AuthViewModel()
        {

        }
        
        [ObservableProperty]
        public string username;
        [ObservableProperty]
        public string password;

     


        [RelayCommand]
        async Task DoLogIn()
        {
            try
            {
                if (username is not null )
                {
                 
                    var result = await authService.GetContactByID(username);
                 
                    if (result is not null )

                    {

                        await Shell.Current.DisplayAlert($"Dear {result.properties.firstname} {result.properties.lastname} A Verfication Code Was Send To Your Phone", "OTP Sent", "ok");
                    }

                    else
                    {
                        await Shell.Current.DisplayAlert("Validation Error", "The UserName you are entering is not valid", "Cancel");
                    }
                }
                else
                {
                    await Shell.Current.DisplayAlert("Validation Error", "Username Can Not Be empty", "Cancel");
                }
            }


            catch (Exception ex)
            {
             
                
                    await Shell.Current.DisplayAlert("Validation Error", ex.Message, "Cancel");

                

            }
        }

      
        int GenerateOTP()
       
        {
            Random random = new Random();
         
            return   random.Next(125202, 999999);
        }
    }
}
