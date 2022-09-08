using System;
using System.Collections.Generic;
using System.Text;

namespace FooDrink
{
    public enum JobTitle
    {
        Waiter,
        Casher,
        Barista,
        Manager,
        Owner
    }
    public abstract class Person
    {
        public string PersonID { get; set; }
        public string PersonName { get; set; }
        public string PersonNationalNumber { get; set; }
        public string PersonPhoneNumber { get; set; }
        public JobTitle Title { get; set; }

    }
}
