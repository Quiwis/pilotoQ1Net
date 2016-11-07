using System.Collections.Generic;
using PilotoQ1Net.Models.Dtos;

namespace PilotoQ1Net.Models.Interface
{
    public interface IStatus
    {
        Status Add(Status data);
        Status Update(long Id, Status data);
        bool Delete(long Id);
        Status Get(long Id);
        List<Status> Get();
    }
}