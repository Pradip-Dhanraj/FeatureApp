using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FeatureApp.Helpers;
using Xamarin.Forms;

namespace FeatureApp.Viewmodels
{
    public class BaseViewmodel : INotifyPropertyChanged
    {
        internal Helpers.AnimateObject ViewAnimation;
        public BaseViewmodel()
        {
            ViewAnimation = App.ViewAnimation;
        }

        public Command HideLoader => new Command(HideLoaderMethod);

        private void HideLoaderMethod(object pageinstace)
        {
            if (CanRemovePageFromPoup(typeof(AnimatedLoader)))
                Rg.Plugins.Popup.Services.PopupNavigation.Instance.PopAsync();
        }

        public Command ShowLoaderCommand => new Command(ShowLoader);

        public event PropertyChangedEventHandler PropertyChanged;

        private void ShowLoader(object obj)
        {
             var _page= new AnimatedLoader();
            if (CanPushPage(_page))
                Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(_page);
        }

        bool CanPushPage(Page page)
        {
            return !Rg.Plugins.Popup.Services.
                PopupNavigation.
                Instance.
                PopupStack.ToList().
                Exists(p => p.GetType() == page.GetType());
        }

        bool CanRemovePageFromPoup(Type type)
        {
            var _lastpage = Rg.Plugins.Popup.Services.
                PopupNavigation.
                Instance.
                PopupStack.ToList().Last().GetType() == type;
            var _present = Rg.Plugins.Popup.Services.
                PopupNavigation.
                Instance.
                PopupStack.ToList().
                Exists(p => p.GetType() == type);

            return _lastpage && _present;
        }

        async internal Task NavigateTo(Page page)
        {
            if(CanNavigateToPage(page))
            await (Xamarin.Forms.Application.Current.MainPage as NavigationPage)?.PushAsync(page);
        }

        bool CanNavigateToPage(Page page)
        {
            return !(Xamarin.Forms.Application.Current.MainPage as NavigationPage).
                Navigation.
                NavigationStack.ToList().
                Exists(p => p.GetType() == page.GetType());
        }

    }
}
