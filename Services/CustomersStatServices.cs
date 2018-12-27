using System.Linq;
using System.Threading.Tasks;

namespace UsingInject.Services
{
    public class CustomersStatServices
    {
        private CustomersServices _cs = new CustomersServices();

        public async Task<int> GetCustomersCount()
        {
            return await Task.FromResult(_cs.GetAllCustomersData().Count());
        }
        public async Task<int> GetCustomersCountByGender(string gender)
        {
            return await Task.FromResult(_cs.GetAllCustomersDataByGender(gender).Count());
        }
        public async Task<int> GetCustomersCountByAddress(string address)
        {
            return await Task.FromResult(_cs.GetAllCustomersDataByAddress(address).Count());
        }
    }
}