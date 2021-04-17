using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcers.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Business.BusinessAscpects.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [PerformanceAspect(5)]
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")] 
        public IResult Add(Car car)
        {
            //var context = new ValidationContext<Car>(car);
            //CarValidator carvalidator = new CarValidator();
            //carvalidator.Validate(context);
           
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [TransactionScopeAspect]
        public IResult TransactionalOperation(Car car)
        {
            _carDal.Update(car);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarUpdated);
        }
        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
         
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.BrandId==brandId), Messages.CarListed);

        }
        [CacheAspect]
        public IDataResult<List<Car>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.CarId == carId), Messages.CarListed);

        }

        public IDataResult<List<Car>> GetByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId ==colorId), Messages.CarListed);

        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
       
    }
}
