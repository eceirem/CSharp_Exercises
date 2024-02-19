using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    class CustomerManager
    {
        private int _count = 10;
        //CustomerManager adında bir methodum var. 
        //ctor yazınca ulaşabiliyorum.
        
        public CustomerManager(int a) 
        { 
            _count = a;
        }
        public CustomerManager()
        {

        }
        public void add()
        {
            Console.WriteLine("Customer added.");
        }
        public void update()
        {
            Console.WriteLine("Customer updated.");
        }
        //constructors
        public void List()
        {
            Console.WriteLine("Listed {0} items.", _count);
        }
    }

}
