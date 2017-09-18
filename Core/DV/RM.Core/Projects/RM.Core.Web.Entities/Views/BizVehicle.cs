namespace RM.Core.Web.Entities.Views
{
    public class WebVehicle
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Plates { get; set; }
        public string Model { get; set; }
        public bool Active { get; set; }
    }
}
