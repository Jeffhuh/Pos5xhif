using Microsoft.EntityFrameworkCore;
using Spg_Hotelmanager.Application.Infrastructure;
using System;
using Xunit;

namespace Spg_Hotelmanager.Test
{
    public class DbContextTests
    {
        [Fact]
        public void DbCreationTest()
        {
            var options = new DbContextOptionsBuilder()
                .UseSqlite("Data Source=Hotel.db")
                .Options;

            using (var db = new HotelContext(options))
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                db.Import("data.sql");
                //db.Seed();
                Assert.True(true);
            }
        }
    }
}
