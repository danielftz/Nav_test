using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nav_test
{
    public class DummyPageViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "Dummy";

        public IScreen HostScreen { get; }

        public DummyPageViewModel(IScreen hostScreen) { HostScreen = hostScreen; }
    }
}
