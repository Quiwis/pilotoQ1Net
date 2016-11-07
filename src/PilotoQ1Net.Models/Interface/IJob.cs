using System.Collections.Generic;
using PilotoQ1Net.Models.Dtos;

namespace PilotoQ1Net.Models.Interface
{
    public interface IJob
    {
        Job Add(Job data);
        Job Update(long Id, Job data);
        bool Delete(long Id);
        Job Get(long Id);
        List<Job> Get();
    }
}