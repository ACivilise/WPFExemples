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
    public partial class EventHandlerView : UserControl
    {
        private EventHandlerViewModel EventHandlerViewModel {get; set; }

        public EventHandlerView(EventHandlerModel eventHandlerModel)
        {
            InitializeComponent();
            EventHandlerViewModel = new EventHandlerViewModel(eventHandlerModel);
        }

        private void Event_Handler_OnClick(object sender, RoutedEventArgs e)
        {
            this.EventHandlerViewModel.Event_Handler_OnClick();
        }
    }
}
