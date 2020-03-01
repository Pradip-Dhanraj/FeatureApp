using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FeatureApp.Viewmodels
{
    public class LoginViewmodel : BaseViewmodel
    {
        public LoginViewmodel()
        {
        }

        public Command LoginCommand => new Command(LoginMethod);

        async private void LoginMethod(object obj)
        {
            ShowLoaderCommand.Execute(null);
            await Task.Delay(3000);
            await NavigateTo(new MyPage());
            HideLoader.Execute(null);
        }
    }
}
