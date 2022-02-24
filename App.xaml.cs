using Reservoom.Exceptions;
using Reservoom.Models;
using Reservoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reservoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // TESTING OUR MODEL LAYER
            //Hotel hotel = new Hotel("Niklaston Suites");

            //try
            //{
            //    hotel.MakeReservation(new Reservation(
            //    new RoomID(1, 2),
            //    "Niklas",
            //    new DateTime(2000, 1, 1),
            //    new DateTime(2000, 1, 2)
            //    ));

            //    hotel.MakeReservation(new Reservation(
            //        new RoomID(1, 3),
            //        "Niklas",
            //        new DateTime(2000, 1, 3),
            //        new DateTime(2000, 1, 4)
            //        ));
            //} catch(ReservationConflictException ex)
            //{

            //}

            // IEnumerable<Reservation> reservations = hotel.GetReservationsForUser("Niklas");

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
