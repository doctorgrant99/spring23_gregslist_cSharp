using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using spring23_gregslist_cSharp.Models;
using spring23_gregslist_cSharp.Repositories;

namespace spring23_gregslist_cSharp.Services
{
    public class HousesService
    {
        private readonly HousesRepository _housesRepo;

        public HousesService(HousesRepository housesRepo)
        {
            _housesRepo = housesRepo;
        }

        internal House CreateHouse(House houseData)
        {
            int id = _housesRepo.CreateHouse(houseData);

            House house = this.GetOne(id);

            return house;
        }

        internal List<House> GetAll()
        {
            List<House> houses = _housesRepo.GetAll();
            return houses;
        }

        internal House GetOne(int houseId)
        {
            House house = _housesRepo.GetOne(houseId);
            if (house == null)
            {
                throw new Exception($"BAD ID: {houseId}");
            }
            return house;
        }
    }
}