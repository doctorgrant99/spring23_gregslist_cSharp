using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using spring23_gregslist_cSharp.Models;

namespace spring23_gregslist_cSharp.Repositories
{
    public class HousesRepository
    {
        private readonly IDbConnection _db;

        public HousesRepository(IDbConnection db)
        {
            _db = db;
        }

    }
}