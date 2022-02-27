using System.Collections.Generic;

namespace WpfApplication1
{
    internal class RealService : IService
    {
        #region IService Members

        public IEnumerable<Account> GetAccounts()
        {
            return new List<Account>
                       {
                           new Account
                               {
                                   Name = "Bob's Stuff",
                                   Balance = 1000000
                               },
                           new Account
                               {
                                   Name = "Bob's Other Stuff",
                                   Balance = 1002343000
                               },
                           new Account
                               {
                                   Name = "Somebody else",
                                   Balance = 10000
                               },
                           new Account
                               {
                                   Name = "Cheap Skate",
                                   Balance = -100
                               }
                       };
        }

        #endregion
    }
}