using System.Threading.Tasks;
using AddressEntity = Fatec.Domain.Entities.Address.Address;

namespace Fatec.Domain.Services.Interfaces.Address
{
    public interface IAddressService
    {
        public Task<bool> UpdateAddress(long id, AddressEntity request);
    }
}
