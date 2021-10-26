using Fatec.Domain.Enums;
using Fatec.Domain.Repositories.Interfaces;
using Fatec.Domain.Repositories.Transaction;
using Fatec.Domain.Services.Interfaces.Request;
using System;
using System.Threading.Tasks;
using RequestEntity = Fatec.Domain.Entities.Request.Request;


namespace Fatec.Domain.Services.Request
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RequestService(IRequestRepository requestRepository, IUnitOfWork unitOfWork)
        {
            _requestRepository = requestRepository ?? throw new ArgumentNullException(nameof(requestRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<bool> CreateRequest(RequestEntity request) 
        {
            request.RequestStatusId = 1;
            _requestRepository.Add(request);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}
