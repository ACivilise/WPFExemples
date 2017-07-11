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
    public partial class ConverterView : UserControl
    {
        private ConverterViewModel ConverterViewModel { get; set; }

        public ConverterView()
        {
            InitializeComponent();
            this.ConverterViewModel = new ConverterViewModel();
            DataContext = this.ConverterViewModel;
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            if (sender != null && sender is ComboBox)
            {
                ComboBox comboBox = (ComboBox)sender;
                if (null != comboBox.SelectedItem && comboBox.SelectedItem is ComboBoxItem)
                {
                    ComboBoxItem comboBoxItem = (ComboBoxItem)comboBox.SelectedItem;
                    if (comboBoxItem.Content is string)
                    {
                        this.ConverterViewModel.ConverterModel.Nombre = (string)comboBoxItem.Content;
                    }
                }
            }
        }

        private void ComboBox2_Selected(object sender, RoutedEventArgs e)
        {
            if (sender != null && sender is ComboBox)
            {
                ComboBox comboBox = (ComboBox)sender;
                if (null != comboBox.SelectedItem && comboBox.SelectedItem is ComboBoxItem)
                {
                    ComboBoxItem comboBoxItem = (ComboBoxItem)comboBox.SelectedItem;
                    if (comboBoxItem.Content is string)
                    {
                        this.ConverterViewModel.ConverterModel.Status = (string)comboBoxItem.Content;
                    }
                }
            }
        }
    }
}
