using IdoApp.Helpers;
using IdoApp.Services;
using IdoApp.ViewModels;

namespace IdoApp.Views;

public partial class SignInPage : ContentPage
{
    public SignInPage()
	{
		InitializeComponent();
        BindingContext = new SignInViewModel();   
    }  
}