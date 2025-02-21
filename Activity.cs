using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerLast
{
    public abstract class Activity
    {
        public string ActivityName { get; private set; }
        public int Duration { get; private set; }
        public int CaloriesBurned { get; protected set; }

        public Activity(string activityName, int duration)
        {
            ActivityName = activityName;
            Duration = duration;
        }

        public abstract void CalculateCalories();
    }

    public class Running : Activity
    {
        public Running(string activityName, int duration) : base(activityName, duration) { }

        public override void CalculateCalories()
        {
            CaloriesBurned = Duration * 10;
            Console.WriteLine($"Running '{ActivityName}' burned {CaloriesBurned} calories in {Duration} minutes.");
        }
    }

    public class Cycling : Activity
    {
        public Cycling(string activityName, int duration) : base(activityName, duration) { }

        public override void CalculateCalories()
        {
            CaloriesBurned = Duration * 8;
            Console.WriteLine($"Cycling '{ActivityName}' burned {CaloriesBurned} calories in {Duration} minutes.");
        }
    }

}
