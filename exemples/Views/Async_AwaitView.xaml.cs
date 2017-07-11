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
using exemples.Models;
using exemples.ViewModels;

namespace exemples.Views
{
    /// <summary>
    /// Interaction logic for EventHandlerView.xaml
    /// </summary>
    public partial class Async_AwaitView : UserControl
    {
        private Async_AwaitViewModel Async_AwaitViewModel { get; set; }

        public Async_AwaitView()
        {
            InitializeComponent();
            this.Async_AwaitViewModel = new Async_AwaitViewModel();
            DataContext = this.Async_AwaitViewModel;
        }

        private void Async_Await_OnClick(object sender, RoutedEventArgs e)
        {
            this.Async_AwaitViewModel.Async_Await_OnClick();
        }
    }
}
