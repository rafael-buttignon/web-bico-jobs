using Fatec.Domain.Repositories.Interfaces;
using Fatec.Domain.Repositories.Transaction;
using Fatec.Domain.Services.Interfaces.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RequestEntity = Fatec.Domain.Entities.Request.Request;

namespace Fatec.Domain.Services.Request
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IUnitOfWork _unitOfWork;

        private const int NEW_STATUS = 1;

        public RequestService(IRequestRepository requestRepository, IUnitOfWork unitOfWork)
        {
            _requestRepository = requestRepository ?? throw new ArgumentNullException(nameof(requestRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<bool> CreateRequest(RequestEntity request) 
        {
            request.RequestStatusId = NEW_STATUS;
            _requestRepository.Add(request);
            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<RequestEntity>> GetRequests()
        {
            return await _requestRepository.GetAllAsync();
        }

        public async Task<RequestEntity> GetById(long id)
        {
            return await _requestRepository.FindById(id);
        }
    }
}
