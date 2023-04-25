using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}