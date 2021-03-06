using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetByUserId(int id);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
