using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nav_test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DummyPage : ContentPage, IViewFor<DummyPageViewModel>
    {
        public DummyPage() {
            InitializeComponent();
        }
        public DummyPageViewModel ViewModel { get; set; }
        object IViewFor.ViewModel {
            get { return ViewModel; }
            set { ViewModel = (DummyPageViewModel)value; }
        }

        
    }
}