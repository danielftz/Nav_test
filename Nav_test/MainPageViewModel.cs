using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Reactive.Linq;
using System.Reactive;

namespace Nav_test
{
    public class MainPageViewModel : ReactiveObject, IRoutableViewModel {
        public string UrlPathSegment => "Main";

        public IScreen HostScreen { get; set; }

        public ICommand NextPage { get; private set; }

        public MainPageViewModel(IScreen hostScreen) {
            HostScreen = hostScreen;
            this.NextPage = ReactiveCommand.Create(
                () => {
                    HostScreen.Router.Navigate.Execute(new DummyPageViewModel(hostScreen)).Subscribe();
                }
            );
            
        }
        

    }
}
