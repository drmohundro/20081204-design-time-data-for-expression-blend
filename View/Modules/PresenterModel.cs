using System.Collections.ObjectModel;

namespace WpfApplication1
{
    public class PresenterModel
    {
        private readonly ObservableCollection<Account> _accounts = new ObservableCollection<Account>();
        public ObservableCollection<Account> Accounts
        {
            get
            {
                return _accounts;
            }
        }
    }
}