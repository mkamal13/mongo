using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
namespace Mongo
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand SaveCommand => new Command(SaveContact);
        public ICommand BackCommand => new Command(goBack);
        public ICommand DelCommand => new Command(delContact);
        public bool newContactFlag;
        private void delContact(object obj)
        {
            var contacts = ContactsClass.GetInstance;
            contacts.Remove(contactClass);
            goBack(null);
        }

        private void goBack(object obj)
        {
            NavigationService service = new NavigationService();
            service.NavigateBack();
        }

        public ContactClass contactClass;

        private void SaveContact(object obj)
        {
            if (contactClass.name == null || contactClass.name.Length==0)
            {
                  return;
            }
            contactClass??= new ContactClass()
            {
                name = Name,
                address = Address,
                company = Company,
                nickName = NickName,
                Emails = this.selectedEmail,
                Phones = this.Phones
 
            };

            var emptyPhones= Phones.Where(a => a.Phone.Length == 0).ToList();
            
            foreach(var phone in emptyPhones)
            {
                Phones.Remove(phone);
            }

            var emptyEmails = selectedEmail.Where(a => a.Email.Length == 0).ToList();

            foreach (var mail in emptyEmails)
            {
                selectedEmail.Remove(mail);
            }
            if (newContactFlag)
            {
                var contacts = ContactsClass.GetInstance;
                contacts.Add(contactClass);
            }
            NavigationService service = new NavigationService();
            service.NavigateBack();
        }

        public ContactViewModel()
        {
             contactClass = new ContactClass();
        }


         
        public System.Collections.ObjectModel.ObservableCollection<ContactPhone> Phones
        {
            get { return contactClass.Phones; }
            set
            {
                contactClass.Phones = value;
                PropertyChanged(this, new PropertyChangedEventArgs("selectedphone"));

            }
        }


         
        public System.Collections.ObjectModel.ObservableCollection<ContactMail> selectedEmail
        {
            get { return contactClass.Emails; }
            set
            {
                contactClass.Emails = value;
                PropertyChanged(this, new PropertyChangedEventArgs("selectedemail"));

            }
        }

         public String Name
        {
            get { return contactClass.name; }
            set
            {
                contactClass.name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("name"));

            }
        }

         public String NickName
        {
            get { return contactClass.nickName; }
            set
            {
                contactClass.nickName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("nickname"));

            }
        }
         public String Address
        {
            get { return contactClass.address; }
            set
            {
                contactClass.address = value;
                PropertyChanged(this, new PropertyChangedEventArgs("address"));

            }
        }
         public String Company
        {
            get { return contactClass.company; }
            set
            {
                contactClass.company = value;
                PropertyChanged(this, new PropertyChangedEventArgs("company"));

            }
        }


    }
}
