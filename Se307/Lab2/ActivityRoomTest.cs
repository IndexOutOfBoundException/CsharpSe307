using System;

namespace Se307.Lab2
{
    public class ActivityRoomTest
    {
        public static void Main(string[] args)
        {
            ActivityRoom activityRoom = new ActivityRoom(0,4,0);
            activityRoom.AcceptAPerson(20);
            activityRoom.DisplayActivityRoomInformation();
            activityRoom.AcceptAPerson(55);
            activityRoom.AcceptAPerson(45);
            activityRoom.AcceptAPerson(23);
            activityRoom.AcceptAPerson(10);
            activityRoom.AcceptAPerson(32);
            activityRoom.DisplayActivityRoomInformation();
            Console.WriteLine("Average age: " +activityRoom.CalculateAverageAgeOfPeople());
            activityRoom.DisplayActivityRoomInformation();
            activityRoom.AcceptAPerson(30);
            activityRoom.LeaveTheRoom(23);
            Console.WriteLine("Average age: "+ activityRoom.CalculateAverageAgeOfPeople());
            activityRoom.DisplayActivityRoomInformation();
            activityRoom.AcceptAPerson(30);
            Console.WriteLine("Average age: " +activityRoom.CalculateAverageAgeOfPeople());
            activityRoom.DisplayActivityRoomInformation();
            
            
        }
    }
}