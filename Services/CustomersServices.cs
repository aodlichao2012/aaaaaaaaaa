using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingInject.Models;

namespace UsingInject.Services
{
    public class CustomersServices
    {
        List<Customers> lst;

        public CustomersServices()
        {
            lst = new List<Customers>
            {
                new Customers
                {
                    ID = "C001",
                    FullName = "ศุภรัตน์ เจริญพิทักษ์",
                    Gender = "M",
                    Address = "กรุงเทพ"
                }
            };
        }

        public IEnumerable<Customers> GetAllCustomersData()
        {
            return lst;
        }

        public List<Customers> GetAllCustomersDataByGender(string gender)
        {
            return lst.Where(i => i.Gender.Equals(gender)).ToList();
        }

        public List<Customers> GetAllCustomersDataByAddress(string address)
        {
            return lst.Where(i => i.Address.Equals(address)).ToList();
        }
    }
}