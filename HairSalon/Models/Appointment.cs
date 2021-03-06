namespace HairSalon.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int StylistId { get; set; }
        public int ClientId { get; set; }
        public string DateTime  { get; set; }
        public virtual Client Client { get; set; }
        public virtual Stylist Stylist { get; set; }

    }
}