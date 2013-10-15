using CoreslabDataModelPlayground.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using ReactiveUI.Xaml;
using System.Reactive.Linq;

namespace CoreslabDataModelPlayground.View
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl, IViewFor<CustomerViewModel>
    {
        public CustomerView()
        {
            InitializeComponent();

            this.Bind(ViewModel, x => x.Name, x => x.CustomerName.Text);
            this.Bind(ViewModel, x => x.Location, x => x.Location.Text);
            this.Bind(ViewModel, x => x.Plan, x => x.Plan.Text);
            this.Bind(ViewModel, x => x.ID, x => x.ID.Content);

            this.OneWayBind(ViewModel, x => x.Title, x => x.CustomerTitle.Content);

            this.BindCommand(ViewModel, x => x.Ok, x => x.Ok);
        }

        public CustomerViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (CustomerViewModel)value; }
        }
    }
}
