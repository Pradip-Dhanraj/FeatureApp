using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FeatureApp.Controls
{
    public partial class LiveBackgroundPage : ContentPage
    {
        public LiveBackgroundPage()
        {
            InitializeComponent();
        }

        public string LiveBackgroundSource
        {
            get { return (string)GetValue(LiveBackgroundSourceProperty); }
            set { SetValue(LiveBackgroundSourceProperty, value); }
        }

        public readonly BindableProperty LiveBackgroundSourceProperty = BindableProperty.Create(nameof(LiveBackgroundSource),
                                                                    typeof(string),
                                                                    typeof(LiveBackgroundPage),
                                                                    null,
                                                                    BindingMode.TwoWay
                                                                    );
        public View CustomContentpage {
            get { return (View)GetValue(CustomContentpageProperty); }
            set { SetValue(CustomContentpageProperty, value); }
        }

        public readonly BindableProperty CustomContentpageProperty = BindableProperty.Create(nameof(CustomContentpage),
                                                                    typeof(View),
                                                                    typeof(LiveBackgroundPage),
                                                                    null,
                                                                    BindingMode.TwoWay
                                                                    );


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}
