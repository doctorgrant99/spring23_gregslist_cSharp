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

        internal int CreateHouse(House houseData)
        {
            string sql = @"
            INSERT INTO houses(
                year, bathrooms, bedrooms, description, price
            )
            values(
                @Year, @Bathrooms, @Bedrooms, @Description, @Price
            );
            SELECT LAST_INSERT_ID();";

            int id = _db.ExecuteScalar<int>(sql, houseData);

            return id;
        }

        internal List<House> GetAll()
        {
            string sql = "SELECT * FROM houses;";

            List<House> houses = _db.Query<House>(sql).ToList();
            return houses;
        }

        internal House GetOne(int houseId)
        {
            string sql = "SELECT * FROM houses WHERE id = @houseId;";

            House house = _db.Query<House>(sql, new { houseId }).FirstOrDefault();
            return house;
        }
    }
}