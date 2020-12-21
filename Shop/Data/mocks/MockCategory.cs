using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> getAllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName="Электромобили", info = "Экологичный современный вид транспорта"},
                    new Category{categoryName="Топливные автомобили", info = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
