using System;
namespace Mongo
{
    public class ContactClass
    {
        public ContactClass()
        {

            Phones = new System.Collections.ObjectModel.ObservableCollection<ContactPhone>()
            {
            new ContactPhone()
            { Phone=""
            }
            };

            Emails = new System.Collections.ObjectModel.ObservableCollection<ContactMail>()
            {
            new ContactMail()
            { Email=""
            }
        };



        }
        public String name { get; set; }
        public String nickName { get; set; }
        public String address { get; set; }
        public String company { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<ContactPhone> Phones { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<ContactMail> Emails { get; set; }

    }
}
