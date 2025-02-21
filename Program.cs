using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerLast
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FitnessTracker fitnessTracker = new FitnessTracker("Base Tracker");
            fitnessTracker.TrackSteps(10000);
            fitnessTracker.AddUser("Akif");
            fitnessTracker.AddUser("Samir");
            fitnessTracker.AddUser("Nazim");
            fitnessTracker.AddUser("Habil"); // bunu artig add etmeyecey 
            fitnessTracker.PrintInfo();

            FitTrackPro fitTrackPro = new FitTrackPro("Pro Tracker");
            fitTrackPro.TrackSteps(60000);
            fitTrackPro.AddUser("Turac");
            fitTrackPro.AddUser("Sema");
            fitTrackPro.AddUser("Senan");
            fitTrackPro.AddUser("Kamil");
            fitTrackPro.AddUser("Vugar");
            fitTrackPro.AddUser("Asim"); // bunu artig add etmeyecey 
            fitTrackPro.PrintInfo();

            Running running = new Running("Morning Run", 30);
            running.CalculateCalories();

            Cycling cycling = new Cycling("Evening Ride", 45);
            cycling.CalculateCalories();
        }
    }

}
