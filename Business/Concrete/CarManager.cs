using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _ıCarDal;
        public CarManager(ICarDal ıcardal)
        {
            _ıCarDal = ıcardal;

        }
        public List<Car> GetAll()
        {
            return _ıCarDal.GetAll();
        }
    }
}
