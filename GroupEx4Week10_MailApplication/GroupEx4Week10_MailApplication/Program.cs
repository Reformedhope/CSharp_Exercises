using System;

namespace GroupEx4Week10_MailApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();

            c.CollectNameInput();
            c.CollectBirthDate();
            c.CollectPurchaseOfSub();
            c.CollectZip();
            c.CustomerCode();
        }
    }
}
