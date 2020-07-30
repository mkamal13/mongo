using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Mongo
{
    public partial class Contact : ContentPage
    {
        public ContactViewModel contactViewModel = new ContactViewModel();
        public Contact(ContactClass model)

        {  if(model!=null)
             contactViewModel.contactClass = model;
            InitializeComponent();
            this.BindingContext = contactViewModel;
        }

         private new  void OnPropertyChanged(string propertyName)
        {

        }

        void AddEmail_Clicked(System.Object sender, System.EventArgs e)
        {
         var emails = (System.Collections.ObjectModel.ObservableCollection<ContactMail>)Emails.ItemsSource;
             emails.Add(new ContactMail { Email = "" });
           }

        void AddPhone_Clicked(System.Object sender, System.EventArgs e)
        {
            var phones = (System.Collections.ObjectModel.ObservableCollection<ContactPhone>)PhonesList.ItemsSource;
            phones.Add(new ContactPhone { Phone = "" });
         }

        void SaveButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (NameEntry.Text==null||NameEntry.Text.Length ==0) 
            DisplayAlert("Alert", "You cannot save without a name!", "OK");

        }
    }
}
