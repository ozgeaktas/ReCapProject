using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintananceTime);
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<User> GetById(int Id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u=>u.Id == Id));
        }

        public IResult Update(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
