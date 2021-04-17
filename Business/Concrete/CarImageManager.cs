using Business.Abstract;
using Business.Constants;
using Core.Utilities.BusinessRule;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(IFormFile formFile, CarImage carImage)
        {

            IResult result=BusinessRules.Run(CheckCarImageCount(carImage.CarId));
            if(result!=null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Add(formFile);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.ImageAdded);


        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.ImageDeleted);

        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.ImageListed);
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(ci => ci.CarId == carId), Messages.ImageListed);
        }

        public IResult Update(IFormFile formFile, CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.ImageUpdated);
        }

        private IResult CheckCarImageCount(int carId)
        {
            var carImageCount = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (carImageCount > 5)
            {
                return new ErrorResult(Messages.CarImageLimit);
            }
            return new SuccessResult(Messages.ImageAdded);
        }

    }
}
