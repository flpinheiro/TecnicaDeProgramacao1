using System;

namespace UnBCineFlix.Models
{
    public class Ticket
    {
        public int TicketNumber { get; set; }
        public float Value { get; set; }
        public Session Session { get; set; }
        public Chair Chair { get; set; }
    }
}
