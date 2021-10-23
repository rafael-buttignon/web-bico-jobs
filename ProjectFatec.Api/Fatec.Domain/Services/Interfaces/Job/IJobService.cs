﻿using System.Threading.Tasks;
using JobEntity = Fatec.Domain.Entities.Job.Job;

namespace Fatec.Domain.Services.Interfaces.Job
{
    public interface IJobService
    {
        public Task<bool> CreateJob(JobEntity request);
    }
}
