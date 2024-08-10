using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Account
    {
        public Account(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return $"id:{ id}, Name: {name}";
        }
        public override bool Equals(object? obj)
        {
            Account account= (Account)obj;
            return this.id == account.id && this.name == account.name;
        }

    }
}
