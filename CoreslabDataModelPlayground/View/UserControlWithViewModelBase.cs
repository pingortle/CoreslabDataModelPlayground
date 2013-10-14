using System.Windows;
using System.Windows.Controls;

namespace CoreslabDataModelPlayground.View
{
    //***Old stab at this problem; keeping it around for a bit.***
    //public class UserControlWithViewModelBase : UserControl
    //{
    //    static UserControlWithViewModelBase()
    //    {
    //        DefaultStyleKeyProperty.OverrideMetadata(typeof(UserControlWithViewModelBase), new FrameworkPropertyMetadata(typeof(UserControlWithViewModelBase)));
    //    }

    //    public object ViewModel
    //    {
    //        get { return GetValue(ViewModelProperty); }
    //        set { SetValue(ViewModelProperty, value); }
    //    }
    //    public static readonly DependencyProperty ViewModelProperty =
    //        DependencyProperty.Register("ViewModel", typeof(object), typeof(UserControlWithViewModelBase), new PropertyMetadata(null));
    //}

    public class UserControlWith<TViewModel> : UserControl where TViewModel : class
    {
        public TViewModel ViewModel { get; set; }
    }
}
