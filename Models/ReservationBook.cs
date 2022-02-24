using Reservoom.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class ReservationBook
    {
        // private readonly Dictionary<RoomID, List<Reservation>> _roomsToReservations;
        // changed Dictionary to List
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            // _roomsToReservations = new Dictionary<RoomID, List<Reservation>>();
            // changed Dictionary to List
            _reservations = new List<Reservation>();
        }

        /* 
        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservations.Where(r => r.Username == username);
        }
        */

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservations;
        }

        public void AddReservation(Reservation reservation)
        {
            foreach(Reservation existingReservation in _reservations)
            {
                if(existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }
            // if we get passed all the conflict checks we'll add the reservation
            _reservations.Add(reservation);
        }
    }
}
