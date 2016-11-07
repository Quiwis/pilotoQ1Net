using System.Collections.Generic;
using PilotoQ1Net.Models.Dtos;

namespace PilotoQ1Net.Models.Interface
{
    public interface IUser
    {
        User Add(User data);
        User Update(long Id, User data);
        bool Delete(long Id);
        User Get(long Id);
        List<User> Get();
    }
}