using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System;
using System.Collections.Generic;
using PicoCRMx.Objects.Contact;
using System.Diagnostics;

namespace PicoCRMx.Objects.ViewModel
{
    
    public partial class ContactViewModel : ObservableObject 

    {
      

        public ContactViewModel()
        {
           
        }

      

        [RelayCommand]
        async Task CreateContact()
        {

            await  Shell.Current.DisplayAlert("NetWork Is Not Availbale" , "Error" , "Cansel");
            
            
           
        }
    }
}
