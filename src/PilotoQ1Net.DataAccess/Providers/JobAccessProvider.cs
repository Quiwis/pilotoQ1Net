using System;
using System.Collections.Generic;
using System.Linq;
using PilotoQ1Net.Models.Interface;
using PilotoQ1Net.Models.Dtos;
using Microsoft.Extensions.Logging;

namespace PilotoQ1Net.DataAccess.Providers
{
    // >dotnet ef migration add testMigration
    public class JobAccessProvider : IJob
    {
        private DomainModelContext _db;
        private ILogger _logger;
        public JobAccessProvider(DomainModelContext model, ILoggerFactory loggerFactory)
        {
            _db = model;
            _logger = loggerFactory.CreateLogger("JobAccessProvider");
        }

        public Job Add(Job data)
        {
            _db.JobModel.Add(data);
            _db.SaveChanges();
            return data;
        }

        public Job Update(long Id, Job data)
        {
            try
            {
                _db.JobModel.Update(data);
                _db.SaveChanges();
                return data;
            }
            catch
            {
                return null;
            }
        }

        public bool Delete(long Id)
        {
            try
            {
                var entity = _db.JobModel.First(obj => obj.Id == Id);
                _db.JobModel.Remove(entity);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Job Get(long Id)
        {
            try
            {
                return _db.JobModel.First(obj => obj.Id == Id);
            }
            catch
            {
                return null;
            }
        }

        public List<Job> Get()
        {
            return _db.JobModel.ToList();
        }

    }
}
