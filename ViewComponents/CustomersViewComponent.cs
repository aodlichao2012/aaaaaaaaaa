using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UsingInject.Models;
using UsingInject.Services;

namespace UsingInject.ViewComponents
{
    public class CustomersViewComponent : ViewComponent
    {
        private Task<IEnumerable<Customers>> GetCustomersDataByAddressAsync(string address)
        {
            CustomersServices _cs = new CustomersServices();
            IEnumerable<Customers> _data = _cs.GetAllCustomersDataByAddress(address);

            return Task.FromResult(_data);
        }
        public async Task<IViewComponentResult> InvokeAsync(string address)
        {
            var customerslists = await GetCustomersDataByAddressAsync(address);
            return View("Default",customerslists);
        }
    }
}