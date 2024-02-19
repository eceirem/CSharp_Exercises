using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    internal class Customer
    {
        //set ile değer vermiş ve get ile de değeri almış oluyorum.
        public string City  { get; set; }
        public int id { get; set; }
        private string _Name;
        public string Name
        {

            get { return "Mr. " + _Name; }
            set { _Name = value; }
        }
        public string Surname { get; set; }
    }
}
