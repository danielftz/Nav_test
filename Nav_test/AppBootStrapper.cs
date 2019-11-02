using ReactiveUI;
using ReactiveUI.XamForms;
using Splat;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Nav_test
{
    public class AppBootStrapper : ReactiveObject, IScreen
    {
        public RoutingState Router { get; private set; }
        public AppBootStrapper(IMutableDependencyResolver dependencyResolver = null, RoutingState router=null) {
            //BlobCache.ApplicationName = Configuration.ApplicationName;
            Router = router ?? new RoutingState();
            RegisterParts(dependencyResolver ?? Locator.CurrentMutable);
            Router.Navigate.Execute(new MainPageViewModel(this));
        }

        private void RegisterParts(IMutableDependencyResolver dependencyResolver) {
            dependencyResolver.RegisterConstant(this, typeof(IScreen));
            dependencyResolver.Register(() => new MainPage(), typeof(IViewFor<MainPageViewModel>));
            dependencyResolver.Register(() => new DummyPage(), typeof(IViewFor<DummyPageViewModel>));

        }
        public Page CreateMainPage() {
            return new RoutedViewHost();
        }

    }
}
