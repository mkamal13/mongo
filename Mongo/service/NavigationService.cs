using System;
using Xamarin.Forms;
using System.Linq;
namespace Mongo
{
    public class NavigationService:INavigationService
    {
        public NavigationService()
        {

        }

        public async void NavigateBack()
        {
          await  getCurrentPage().Navigation.PopModalAsync();
        }

        //public async void NavigateToContact()
        //{
        //}

        public async void NavigateToContact(ContactClass obj)
        {
            Contact page;
            if (obj != null)
                page = new Contact(obj);
            else
            {
                page = new Contact(null);
                page.contactViewModel.newContactFlag = true;
            }
            //page.contactViewModel.contactClass = obj;
            await getCurrentPage().Navigation.PushModalAsync(page);
        }

        private Page getCurrentPage()
        {
            if (Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault() == null)
                return Application.Current.MainPage;
            return Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();
        }
    }
}
