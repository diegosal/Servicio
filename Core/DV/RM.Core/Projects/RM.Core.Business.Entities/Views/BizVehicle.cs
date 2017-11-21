namespace RM.Core.Business.Entities.Views
{
    public class BizVehicle
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Plates { get; set; }
        public string Model { get; set; }
        public string Nombre { get; set; }
        public bool Active { get; set; }
    }
}
