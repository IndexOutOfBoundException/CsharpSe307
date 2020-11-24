using System;

namespace Se307.Lab2
{
    public class ActivityRoom
    {
        private int numPeople;
        private int capacity;
        private int cumulativeAge;
       

        public ActivityRoom(int numPeople, int capacity, int cumulativeAge)
        {
            try
            {
                if (capacity > 12 && capacity < 4)
                {
                    Console.WriteLine("Invalid capacity!\n");
                    
                }
                else
                {
                    this.capacity = capacity;
                    
                }
            
                if (numPeople < 0 || capacity<numPeople)
                {
                    Console.WriteLine("Invalid number of people!\n");
                }
                else
                {
                    this.numPeople = numPeople;   
                }
            
             
                if(cumulativeAge>= 0)
                    this.cumulativeAge = cumulativeAge;
                else Console.WriteLine("Invalid cumulative age!\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
        }
        

        public int NumPeople
        {
            
            get => numPeople;
            set => numPeople = value;
        }

        public int Capacity
        {
            get => capacity;
            set => capacity = value;
        }

        public int CumulativeAge
        {
            get => cumulativeAge;
            set => cumulativeAge = value;
        }

        public bool isFull()
        {
            if (numPeople == capacity)
                return true;
            return false;
        }
        public void AcceptAPerson(int age)
        {
            if(isFull())
                Console.WriteLine("Capacity is full! No permission!\n");
            else if(age<13)
                Console.WriteLine(age+" is invalid age to be accepted.\n");
            else
            {
                Console.WriteLine("A person aged " +age+" added into the room.\n");
                numPeople++;
                cumulativeAge += age;
             
                
            }
        }

        public void LeaveTheRoom(int age)
        {
            if (age < 13)
            {
                Console.WriteLine("Invalid age!\n");
            }
            else
            {
                Console.WriteLine("A person aged "+age+" left the room.\n");
                numPeople--;
                cumulativeAge -= age;
              
            }
            
        }

        public double CalculateAverageAgeOfPeople()
        {
            try
            {
                return cumulativeAge / numPeople;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return -1;

        }

        public void DisplayActivityRoomInformation()
        {
            Console.WriteLine("\nNumber of people: " +numPeople);
            Console.WriteLine("Average age: " +CalculateAverageAgeOfPeople());
            Console.WriteLine("Cumulative age: " +cumulativeAge);
            Console.WriteLine("Capacity: " +capacity+"\n");
            
            
        }
        
    }
}