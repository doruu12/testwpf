using Microsoft.AspNetCore.Mvc;

using WebApp1.Models;
using WebApp1.Models.Api;

namespace WebApp1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        [HttpGet(Name = "LoadAllPositions")]
        public IEnumerable<SoldierPositionResponse> Load()
        {
            using (var context = new LocalDBMSSQLLocalDBContext())
            {
                return context.Soldiers.Select(soldier => new SoldierPositionResponse
                        {
                            Id = soldier.Id,
                            SoldierPositions = soldier.SoldierPositions.ToList()
                        })
                        .ToList();
            }
        }

        [HttpGet(Name = "LoadSoldierMovement")]
        public IEnumerable<SoldierPosition> LoadSoldierMovement(int soldierId)
        {
            using (var context = new LocalDBMSSQLLocalDBContext())
            {
                return context.SoldierPositions
                        .Where(x => x.SoldierId == soldierId)
                        .ToList();
            }
        }

        [HttpPost(Name = "UpdatePosition")]
        public void UpdatePosition(UpdatePositionRequest request)
        {
            // call cache api to batch update positions in db
        }
    }
}
