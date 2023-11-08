using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusinessLogic.Tests
{
    public static class TestHelper
    {
        public static DeliverContext GetForumDbContext()
        {
            var options = new DbContextOptionsBuilder<DeliverContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            return new DeliverContext(options);
        }
    }
}