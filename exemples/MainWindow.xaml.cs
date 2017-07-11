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
using exemples.Views;
using log4net.Config;

namespace exemples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitLog4Net();
            InitializeComponent();
        }

        #region Event_Handler
        private void Event_Handler_OnClick(object sender, RoutedEventArgs e)
        {
            EventHandlerModel eventHandlerModel = new EventHandlerModel();

            eventHandlerModel.eventHandlerDelegate += MethodCalledWhenEventHandlerDelegateIsCalled;

            Window EventHandlerWindow = new Window
            {
                Title = "EventHandlerView Window",
                Content = new EventHandlerView(eventHandlerModel),
                Height = 70,
                Width = 70
            };
            EventHandlerWindow.ShowDialog();
        }
        private void MethodCalledWhenEventHandlerDelegateIsCalled(string input)
        {
            MessageBox.Show("input is " + input, "Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        #endregion Event_Handler

        #region Async_Await
        private void Async_Await_OnClick(object sender, RoutedEventArgs e)
        {
            Window Async_AwaitWindow = new Window
            {
                Title = "Async_AwaitView Window",
                Content = new Async_AwaitView(),
                Height = 100,
                Width = 200
            };
            Async_AwaitWindow.ShowDialog();
        }
        #endregion Async_Await

        #region Converter
        private void Converter_OnClick(object sender, RoutedEventArgs e)
        {
            Window ConverterWindow = new Window
            {
                Title = "Converter Window",
                Content = new ConverterView(),
                Height = 150,
                Width = 200
            };
            ConverterWindow.ShowDialog();
        }
        #endregion Converter

        #region Log4 net
        private void InitLog4Net()
        {
            string configPath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Log4Net.config";
            // Lire la configuration du fichier de log Log4Net
            System.IO.FileInfo fi = new System.IO.FileInfo(configPath);
            if (fi.Exists)
            {
                // Lecture du fichier de configuration
                XmlConfigurator.ConfigureAndWatch(fi);
            }
            else
            {
                throw new Exception(String.Format("Init log exception: file {0} not found", configPath));
            }
        }
        #endregion
    }
}
