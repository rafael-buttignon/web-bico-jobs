using Fatec.Domain.Repositories.Interfaces;
using Fatec.Domain.Repositories.Transaction;
using Fatec.Domain.Services.Interfaces.Job;
using System;
using System.Threading.Tasks;
using JobEntity = Fatec.Domain.Entities.Job.Job;

namespace Fatec.Domain.Services.Job
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IUnitOfWork _unitOfWork;

        public JobService(IJobRepository jobRepository, IUnitOfWork unitOfWork)
        {
            _jobRepository = jobRepository ?? throw new ArgumentNullException(nameof(jobRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<bool> CreateJob(JobEntity request)
        {
            _jobRepository.Add(request);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}
