using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nav_test
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage , IViewFor<MainPageViewModel>
    {
        public MainPage() {
            InitializeComponent();
        }

        public MainPageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel {
            get { return ViewModel; }
            set { ViewModel = (MainPageViewModel)value; }
        }
    }
}
