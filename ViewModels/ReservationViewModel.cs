using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservoom.Models;

namespace Reservoom.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;

        public string RoomID => _reservation.RoomID?.ToString(); // the values come from the reservation fields
        public string Username => _reservation.Username;

        //public DateTime StartDate => _reservation.StartTime.Date;
        // I changed DateTime into string because I want to show only the Date and not Date+Time
        public string StartDate => _reservation.StartTime.ToString("d");
        public string EndDate => _reservation.EndTime.ToString("d");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
