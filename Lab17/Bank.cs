using System;
using System.Collections.Generic;
using System.Text;

namespace Lab17
{
    class Bank<T>
    {
        public T AccountName { get; set; }
        public double Price { get; set; }
        public string NamePerson { get; set; }
        public Bank(T account, double price,string name)
        {
            this.AccountName = account;
            this.Price = price;
            this.NamePerson = name;
        }
        public string Info()
        {
            return $"{AccountName} {Price} {NamePerson}";
        }
    }
}
