using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;

namespace PicoCRMx.ViewModel
{
    public partial  class OTPVerifyViewModel : ObservableObject
    {
        public OTPVerifyViewModel()
        {

        }

        public string PhoneNumber;


        [RelayCommand]
            
        async Task VerifyOTP()
        {

        }

    }
}
