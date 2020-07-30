
using System;

namespace Mongo
{
    public interface INavigationService
    {
        void NavigateToContact(ContactClass obj);
        void NavigateBack();

    }
}
