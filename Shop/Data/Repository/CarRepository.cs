using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CarRepository : ICars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> getAllCars => appDBContent.manageCars.Include(c=>c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.manageCars.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getSpecCars(int carID) => appDBContent.manageCars.FirstOrDefault(p => p.id == carID);
    }
}
