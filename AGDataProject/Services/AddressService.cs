using AddressAPI.Models;

namespace AddressAPI.Services
{
    public class AddressService : IAddressService
    {
        public async Task<AddressInfo> ProcessAddressAsync(AddressInfo addressInfo)
        {
            // Simulating some processing delay
            await Task.Delay(100);
            return addressInfo;
        }
    }
}