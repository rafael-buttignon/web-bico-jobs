using System.Threading.Tasks;
using RequestEntity = Fatec.Domain.Entities.Request.Request;    

namespace Fatec.Domain.Services.Interfaces.Request
{
    public interface IRequestService
    {
        public Task<bool> CreateRequest(RequestEntity request);
    }
}
