using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using exemples.Models;

namespace exemples.ViewModels
{
    public class Async_AwaitViewModel : INotifyPropertyChanged
    {

        private Async_AwaitModel async_AwaitModel;

        public Async_AwaitModel Async_AwaitModel
        {
            get { return async_AwaitModel; }
            set
            {
                async_AwaitModel = value;
                OnPropertyChanged("Async_AwaitModel");
            }
        }

        public Async_AwaitViewModel()
        {
            this.async_AwaitModel = new Async_AwaitModel();
        }

        public async void Async_Await_OnClick()
        {
            //Do Stuff asyn, long actions here
            while (this.async_AwaitModel.ProgressBarValue < 100)
            {
                await Task.Delay(1000);
                //Wait for this to be done
                await task();
            }
            //Do Stuff asyn, long actions here
        }

        private Task task()
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    this.Async_AwaitModel.ProgressBarValue = this.Async_AwaitModel.ProgressBarValue + 10;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
