using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitnessTrackerLast
{
    public class FitTrackPro : FitnessTracker
    {
        public FitTrackPro(string deviceName) : base(deviceName)
        {
            BatteryLife = 48;
        }

        public virtual void TrackSteps(int steps)
        {
            if (steps >= 1 && steps <= 100000)
            {
                TotalSteps += steps;
                Console.WriteLine($"Tracked {steps} steps. Total steps: {TotalSteps}.");
            }
            else
            {
                Console.WriteLine("Yanlish araliq, 1 ile 100000 arasi eded daxil et ");
            }
        }

        public virtual void AddUser(string userName)
        {
            if (Users.Count >= 5)
            {
                Console.WriteLine("Limite catmisiniz, 5-den cox user elave etmek olmaz.");
            }
            else
            {
                Users.Add(userName);
                Console.WriteLine($"User {userName} elave edildi");
            }
        }
    }

}
