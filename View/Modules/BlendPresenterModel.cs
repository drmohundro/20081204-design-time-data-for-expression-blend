using System.Collections.Generic;

namespace WpfApplication1
{
    public class BlendPresenterModel : PresenterModel
    {
        public BlendPresenterModel()
        {
            var accounts = new List<Account>
                               {
                                   new Account
                                       {
                                           Name = "Bob's Stuff",
                                           Balance = 1000000
                                       },
                                   new Account
                                       {
                                           Name = "Cheap Skate",
                                           Balance = -100
                                       }
                               };
            foreach (var acct in accounts)
                Accounts.Add(acct);
        }
    }
}