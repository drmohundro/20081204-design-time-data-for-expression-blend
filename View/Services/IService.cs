using System.Collections.Generic;

namespace WpfApplication1
{
    public interface IService
    {
        IEnumerable<Account> GetAccounts();
    }
}