using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgenda
{
    internal class Contact
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }

        public Contact(string n, string p)
        {
            this.Name = n;
            this.Address = new Address();
            this.Phone = p;
        }

        public void EditPhone(string p)
        {
            this.Phone = p;
        }

        public void EditEmail(string e)
        {
            this.Email = e;
        }

        public override string ToString()
        {
            return $"Nome: {Name}\nTelefone: {Phone}\n{Address}";
        }
    }
}
