using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Mongo
{
    public sealed class ContactsClass
    {
        private ContactsClass()
        {
        }

        public static ObservableCollection<ContactClass> Contacts;
        private static ObservableCollection<ContactClass> instance = null;
        public static ObservableCollection<ContactClass> GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new ObservableCollection<ContactClass>();
                return instance;
            }
        }
    }
}
