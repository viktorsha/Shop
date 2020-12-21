using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : ICars
    {
        private readonly ICarsCategory _carCategory = new MockCategory();

        public IEnumerable<Car> getAllCars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name ="Tesla",
                        shortInfo ="Tesla 2019",
                        longInfo ="status, expensive, modern, fast, cool",
                        img ="https://www.tesla.com/sites/default/files/modelsx-new/social/model-x-social.jpg",
                        price =45000,
                        isFavourite =true,
                        isAvailable =true,
                        Category = _carCategory.getAllCategories.First()
                    },
                    new Car
                    {
                        name ="Volkswagen tiguan",
                        shortInfo ="Tiduan 2020",
                        longInfo ="status, expensive, modern, fast, cool",
                        img ="https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2020-volkswagen-tiguan-mmp-1-1566247993.jpg?crop=0.962xw:0.719xh;0.0385xw,0.209xh&resize=1200:*",
                        price =30000,
                        isFavourite =true,
                        isAvailable =true,
                        Category = _carCategory.getAllCategories.Last()
                    },
                    new Car
                    {
                        name ="Toyota Camry",
                        shortInfo ="Toyota 2019",
                        longInfo ="status, expensive, modern, fast, cool",
                        img ="https://www.thetorquereport.com/wp-content/uploads/2020/06/2020-Toyota-Camry-Hybrid-Review-0001.jpeg",
                        price =45000,
                        isFavourite =false,
                        isAvailable =true,
                        Category = _carCategory.getAllCategories.First()
                    },
                    new Car
                    {
                        name ="Audi Q8",
                        shortInfo ="Audi 2020",
                        longInfo ="status, expensive, modern, fast, cool",
                        img ="https://cdn.motor1.com/images/mgl/3XB1K/s1/audi-q8.jpg",
                        price =45000,
                        isFavourite =true,
                        isAvailable =false,
                        Category = _carCategory.getAllCategories.Last()
                    },
                    new Car
                    {
                        name ="Range Rover",
                        shortInfo ="Range Rover 2020",
                        longInfo ="status, expensive, modern, fast, cool",
                        img ="https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-land-rover-range-rover-sport-mmp-1-1595270011.jpg",
                        price =45000,
                        isFavourite =true,
                        isAvailable =true,
                        Category = _carCategory.getAllCategories.Last()
                    },
                    new Car
                    {
                        name ="Porsche Taycan",
                        shortInfo ="Porsche 2021",
                        longInfo ="status, expensive, modern, fast, cool",
                        img ="https://carsguide-res.cloudinary.com/image/upload/f_auto,fl_lossy,q_auto,t_cg_hero_large/v1/editorial/Taycan_Turbo_S_2019_1001x565p-%282%29.jpg",
                        price =40000,
                        isFavourite =false,
                        isAvailable =false,
                        Category = _carCategory.getAllCategories.First()
                    }
                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getSpecCars(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
