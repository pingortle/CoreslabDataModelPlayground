using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using CoreslabDataModelPlayground.View;
using CoreslabDataModelPlayground.ViewModel;

namespace CoreslabDataModelPlayground
{
    public sealed class AppViewModel : ReactiveObject, IScreen
    {
        public AppViewModel(IMutableDependencyResolver dependencyResolver = null, IRoutingState routingState = null)
        {
            Router = routingState ?? new RoutingState();
            dependencyResolver = dependencyResolver ?? RxApp.MutableResolver;

            RegisterDependencies(dependencyResolver);

            LogHost.Default.Level = LogLevel.Debug;

            Router.Navigate.Execute(new CustomerViewModel(dependencyResolver.GetService<IScreen>()));
        }

        #region Implements IScreen
        public IRoutingState Router { get; private set; }
        #endregion

        #region Private Configuration Logic
        // This is where we configure the composition of our components.
        private void RegisterDependencies(IMutableDependencyResolver dr)
        {
            dr.RegisterConstant(this, typeof(IScreen));
            dr.Register(() => new CustomerView(), typeof(IViewFor<CustomerViewModel>));
            dr.Register(() => new SuccessView(), typeof(IViewFor<SuccessViewModel>));
        }
        #endregion
    }
}
