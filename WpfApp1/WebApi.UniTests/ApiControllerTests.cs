using Microsoft.EntityFrameworkCore;

using WebApp1.Controllers;
using WebApp1.Models;
using WebApp1.Models.Api;

namespace WebApi.UniTests
{
    /// <summary>
    /// Todo - add fakes for EF Core (e.g. NSubstitute)
    /// </summary>
    [TestClass]
    public class ApiControllerTests
    {
        [TestMethod]
        public void TestLoadAllPositions()
        {
            //// Arrange
            //var options = new DbContextOptionsBuilder<LocalDBMSSQLLocalDBContext>()
            //    .UseInMemoryDatabase(databaseName: "TestDatabase")
            //    .Options;

            //using (var context = new LocalDBMSSQLLocalDBContext(options))
            //{
            //    context.Soldiers.Add(new Soldier
            //    {
            //        Id = 1,
            //        SoldierPositions = new List<SoldierPosition>
            //{
            //    new SoldierPosition { Id = 1, SoldierId = 1, Position = "Position1" }
            //}
            //    });
            //    context.SaveChanges();
            //}

            //using (var context = new LocalDBMSSQLLocalDBContext(options))
            //{
            //    var controller = new ApiController(context);

            //    // Act
            //    var result = controller.Load();

            //    // Assert
            //    Assert.IsNotNull(result);
            //    Assert.IsInstanceOfType(result, typeof(IEnumerable<SoldierPositionResponse>));
            //    Assert.AreEqual(1, result.Count());
            //    Assert.AreEqual(1, result.First().Id);
            //}
        }

        [TestMethod]
        public void TestLoadSoldierMovement()
        {
            //// Arrange
            //var options = new DbContextOptionsBuilder<LocalDBMSSQLLocalDBContext>()
            //    .UseInMemoryDatabase(databaseName: "TestDatabase")
            //    .Options;

            //using (var context = new LocalDBMSSQLLocalDBContext(options))
            //{
            //    context.SoldierPositions.Add(new SoldierPosition { Id = 1, SoldierId = 1, Position = "Position1" });
            //    context.SaveChanges();
            //}

            //using (var context = new LocalDBMSSQLLocalDBContext(options))
            //{
            //    var controller = new ApiController(context);
            //    int soldierId = 1;

            //    // Act
            //    var result = controller.LoadSoldierMovement(soldierId);

            //    // Assert
            //    Assert.IsNotNull(result);
            //    Assert.IsInstanceOfType(result, typeof(IEnumerable<SoldierPosition>));
            //    Assert.AreEqual(1, result.Count());
            //    Assert.AreEqual(1, result.First().Id);
            //}
        }
    }
}