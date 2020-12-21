using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface ICars
    {
        IEnumerable <Car> getAllCars { get; }
        IEnumerable <Car> getFavCars { get; }
        Car getSpecCars(int carID);
    }
}
