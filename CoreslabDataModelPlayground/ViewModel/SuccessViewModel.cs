using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreslabDataModelPlayground.ViewModel
{
    public sealed class SuccessViewModel : ReactiveObject, IModelMyView
    {
        public SuccessViewModel(IScreen host)
        {
            HostScreen = host;

            Ok = HostScreen.Router.NavigateBack;
        }

        public string SuccessMessage
        {
            get { return "Success!"; }
        }

        public IReactiveCommand Ok { get; private set; }

        public IScreen HostScreen { get; private set; }

        public string UrlPathSegment
        {
            get { return "success"; }
        }
    }
}
