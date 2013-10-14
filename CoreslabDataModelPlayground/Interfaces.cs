using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreslabDataModelPlayground
{
    public interface IModelMyView : IRoutableViewModel { }

    //public interface ICustomerViewModel : IModelMyView
    //{
    //    string Name { get; set; }
    //    string Location { get; set; }
    //    string Plan { get; set; }
    //    string ID { get; set; }

    //    IReactiveCommand Ok { get; }
    //}

    //public interface ISuccessViewModel : IModelMyView
    //{
    //    string SuccessMessage { get; }

    //    IReactiveCommand Ok { get; }
    //}
}
