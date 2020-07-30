using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Mongo.viewmodel
{
    public class MainViewModel:INotifyPropertyChanged
    {
        public ICommand NavigateCommand => new Command<ContactClass>(Navigate);

        private void Navigate(ContactClass obj)
        {
            var service = new NavigationService();
            service.NavigateToContact(obj);
        }

         

        public MainViewModel()
        {

        }

         public ObservableCollection<ContactClass> contacts {
            get
            {
                return ContactsClass.GetInstance;

            }

            set
            {
                contacts = value;
            }
            }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
