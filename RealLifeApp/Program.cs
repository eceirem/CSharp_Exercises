using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealLifeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
            RealLifeInterface[] realLifeInterfaces = new RealLifeInterface[3]
            {
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal(),
                new SqlServerCustomerDal()
            };
            foreach (var realLifeInterface in realLifeInterfaces)
            {
                realLifeInterface.Add();
                realLifeInterface.Delete();
                realLifeInterface.Update();
            }
            Console.ReadLine();
        }
    }
}
