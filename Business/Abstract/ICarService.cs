using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByCarId(int carId);
        IDataResult<List<Car>> GetByColorId(int colorId);
        IDataResult<List<Car>> GetByBrandId(int brandId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IResult TransactionalOperation(Car car);
    }
}
