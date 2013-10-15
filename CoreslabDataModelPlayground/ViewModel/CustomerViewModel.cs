using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace CoreslabDataModelPlayground.ViewModel
{
    public class CustomerViewModel : ReactiveObject, IModelMyView
    {
        #region Nasty Hacks For Rapidity's Sake
        private static Random _random = new Random(0);
        #endregion

        public CustomerViewModel(IScreen host)
        {
            HostScreen = host;

            var isInputValid = Observable.CombineLatest(this.ObservableForProperty(x => x.Name),
                    this.ObservableForProperty(x => x.Location),
                    this.ObservableForProperty(x => x.Plan))
                .Select(x => x.All(y => y.Value != null && y.Value != ""));

            ID = _random.Next(1000, 9999).ToString();

            _title = this.WhenAnyValue(x => x.Name)
                .Select(x => x == null || x.Trim() == "" ? "Customer" : x.Trim())
                .ToProperty(this, x => x.Title);

            Ok = new ReactiveCommand(isInputValid, false);
            Ok.Subscribe(_ => HostScreen.Router.Navigate.Execute(new SuccessViewModel(HostScreen)));
        }

        #region Dependent Properties
        private ObservableAsPropertyHelper<string> _title;
        public string Title
        {
            get { return _title.Value; }
        }
        #endregion

        #region Boilerplate Properties
        private string _name;
        public string Name
        {
            get { return _name; }
            set { this.RaiseAndSetIfChanged(ref _name, value); }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set { this.RaiseAndSetIfChanged(ref _location, value); }
        }

        private string _plan;
        public string Plan
        {
            get { return _plan; }
            set { this.RaiseAndSetIfChanged(ref _plan, value); }
        }

        private string _id;
        public string ID
        {
            get { return _id; }
            set { this.RaiseAndSetIfChanged(ref _id, value); }
        }
        #endregion

        #region Boilerplate Commands
        public IReactiveCommand Ok { get; private set; }
        #endregion

        #region Implents IScreen
        public IScreen HostScreen { get; private set; }

        public string UrlPathSegment
        {
            get { return typeof(CustomerViewModel).FullName; }
        }
        #endregion
    }
}
