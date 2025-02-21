using System.ComponentModel.Design;

namespace FitnessTrackerLast
{
    public class FitnessTracker
    {
        
        public string DeviceName { get; set; }
        public int BatteryLife { get; set; }

        public int TotalSteps { get; set; }

        public List<string> Users { get; set; } = new List<string>();
        public FitnessTracker(string deviceName)
        {
            DeviceName = deviceName;
            BatteryLife = 24;
            TotalSteps = 0;
            Users = new List<string>();
        }


        public void TrackSteps(int steps)
        {
            if (steps > 1 && steps < 50000)
            {
                TotalSteps += steps;
                Console.WriteLine($"Tracked {steps} steps. Total steps: {TotalSteps}");
            }
            else
            {
                Console.WriteLine("Duzgun addim araligi daxil edin");
            }
        }


        public void AddUser(string userName)
        {
            if (Users.Count >= 3)
            {
                Console.WriteLine("Limite catmisiniz, 3-den cox user elave etmek olmaz");
                
            }
            else
            {
                Users.Add(userName);
                Console.WriteLine($"User {userName} elave edildi"); 
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Device {DeviceName}, Battery {BatteryLife} hours, Total Steps {TotalSteps}, Users: {Users.Count}");  
        }

    }


}
