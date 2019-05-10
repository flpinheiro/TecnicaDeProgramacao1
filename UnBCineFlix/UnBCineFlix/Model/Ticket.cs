using System;

namespace UnBCineFlix.Model
{
    class Ticket
    {
        public int TicketNumber { get; set; }
        public float Value { get; set; }
        public Session Session { get; set; }
        public Chair Chair { get; set; }
    }
}
