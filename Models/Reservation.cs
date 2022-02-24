using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public string Username { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Length => EndTime.Subtract(StartTime);

        public Reservation(RoomID roomID, string username, DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            Username = username;
            StartTime = startTime;
            EndTime = endTime;
        }

        public bool Conflicts(Reservation reservation)
        {
            // There is no conflict if the roomIDs don't match
            if(reservation.RoomID != RoomID)
            {
                return false;
            }

            // the reservations will conflict (return true) if the incoming reservation has a starttime that is before the existing reservation's endtime
            // AND if the incoming reservation has an endtime that is after the existing reservation's starttime
            return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
        }
    }
}
