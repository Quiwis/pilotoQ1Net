using System;
using System.Collections.Generic;
using System.Linq;
using PilotoQ1Net.Models.Interface;
using PilotoQ1Net.Models.Dtos;
using Microsoft.Extensions.Logging;

namespace PilotoQ1Net.DataAccess.Providers
{
    // >dotnet ef migration add testMigration
    public class UserAccessProvider : IUser
    {
        private readonly DomainModelContext _db;
        private readonly ILogger _logger;

        public UserAccessProvider(DomainModelContext model, ILoggerFactory loggerFactory)
        {
            _db = model;
            _logger = loggerFactory.CreateLogger("UserAccessProvider");
        }

        public User Add(User data)
        {
            _db.UserModel.Add(data);
            _db.SaveChanges();
            return data;
        }

        public User Update(long Id, User data)
        {
            try
            {
                _db.UserModel.Update(data);
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
                var entity = _db.UserModel.First(obj => obj.Id == Id);
                _db.UserModel.Remove(entity);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public User Get(long Id)
        {
            try
            {
                return _db.UserModel.First(obj => obj.Id == Id);
            }
            catch
            {
                return null;
            }
        }

        public List<User> Get()
        {
            return _db.UserModel.ToList();
        }
    }
}
