using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using exemples.Models;

namespace exemples.ViewModels
{
    public class ConverterViewModel : INotifyPropertyChanged
    {
        private ConverterModel converterModel;

        public ConverterModel ConverterModel
        {
            get { return converterModel; }
            set
            {
                converterModel = value;
                OnPropertyChanged("ConverterModel");
            }
        }

        public ConverterViewModel()
        {
            ConverterModel = new ConverterModel();
        }

        public void Converter_OnClick()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
