using CoreslabDataModelPlayground.ViewModel;
using ReactiveUI;
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

namespace CoreslabDataModelPlayground.View
{
    /// <summary>
    /// Interaction logic for SuccessView.xaml
    /// </summary>
    public partial class SuccessView : UserControl, IViewFor<SuccessViewModel>
    {
        public SuccessView()
        {
            InitializeComponent();

            this.Bind(ViewModel, x => x.SuccessMessage, x => x.SuccessMessage.Content);

            this.BindCommand(ViewModel, x => x.Ok, x => x.Ok);
        }

        public SuccessViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (SuccessViewModel)value; }
        }
    }
}
