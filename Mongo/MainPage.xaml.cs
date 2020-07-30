using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongo.viewmodel;
using Xamarin.Forms;

namespace Mongo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {   
        public MainViewModel mainViewModel =   new viewmodel.MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = mainViewModel;
        }

 
        void OnTextChanged(object sender, EventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            //var r = ContactsList;
            var SearchResult = ContactsClass.GetInstance;

            var filterResult=SearchResult.Where(c => c.name.Contains(searchBar.Text) ||  (c.nickName != null && c.nickName.Contains(searchBar.Text) )|| (c.company!=null &&
            c.company!.Contains(searchBar.Text)));
            ContactsList.ItemsSource = filterResult;
         }

        void ContactsList_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
             
            mainViewModel.NavigateCommand.Execute(e.Item);
         }
    }
}
