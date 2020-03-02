using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowPrivacy : PopupPage
    {
        public ShowPrivacy()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        { await PopupNavigation.PopAsync(true); }
    }
}