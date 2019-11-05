using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nav_test
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage , IViewFor<MainPageViewModel>
    {
        readonly CompositeDisposable _bindingsDisposable = new CompositeDisposable();

        public MainPage() {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindCommand(ViewModel, vm => vm.NextPage, v => v.Next).DisposeWith(_bindingsDisposable);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _bindingsDisposable.Clear();
        }

        public MainPageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel {
            get { return ViewModel; }
            set { ViewModel = (MainPageViewModel)value; }
        }
    }
}
