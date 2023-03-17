using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgenda
{
    internal class Address
    {
        public string Street;
        public string City;
        public string State;
        public string PostalCode;
        public string Country;

        public Address()
        {

        }

        public void EditStreet(string s)
        {
            this.Street = s;
        }

        public void EditCity(string c)
        {
            this.City = c;
        }
        public void EditState(string s)
        {
            this.State = s;
        }

        public void EditPostalCode(string p)
        {
            this.PostalCode = p;
        }
        public void EditCountry(string c)
        {
            this.Country = c;
        }

        public override string ToString()
        {
            return "\nEndereço: "+Street+"\nEstado: "+State+"\nCidade: "
                +City+"\nPaís: "+Country+"\nCEP: "+PostalCode+"\n\n";
        }

    }
}
