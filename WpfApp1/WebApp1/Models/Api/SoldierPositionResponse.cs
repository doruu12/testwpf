namespace WebApp1.Models.Api
{
    public class SoldierPositionResponse
    {
        public int Id { get; set; }

        public List<SoldierPosition> SoldierPositions { get; set; } = new List<SoldierPosition>();
    }
}
