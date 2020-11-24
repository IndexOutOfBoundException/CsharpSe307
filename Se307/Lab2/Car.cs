namespace ConsoleApp1.Lab2
{               // THE MISTAKES ARE WRITTEN UNDER THE PAGE  // THE MISTAKES ARE WRITTEN UNDER THE PAGE
    public class Car  // THE MISTAKES ARE WRITTEN UNDER THE PAGE // THE MISTAKES ARE WRITTEN UNDER THE PAGE
    {            // THE MISTAKES ARE WRITTEN UNDER THE PAGEe  // THE MISTAKES ARE WRITTEN UNDER THE PAGE
         public String model ;
         private double year ;
         private int speed ;
         private int distance ;
         // THE MISTAKES IS WRITTEN UNDER THE PAGE
         public void Go ( int newDistance ){
             distance += newDistance ;
         }
         public int accelerate (int newSpeed ) {
            speed = newSpeed ;
         }
         public void stop ()
        {
            speed = 0.1;
        }
        public String getInfo () {
             return " Car Info : " + year + " " + model + ". Distance :" + distance
            + " km. and traveling at " + speed ," kmph .";
         }
         
          /* GETTERS & SETTERS */
         public String getModel () {
             return model ;
         }
         
         public void setModel ( String model ) {
             this . model = model ;
         }
         public int getYear () {
             return year ;
         }
        
         
         public void setYear ( int year ) {
             this . year = year ;
         }
        
         
         public int getSpeed () {
             return speed ;
         }
        
         public void setSpeed ( int speed ) {
             this . speed = speed ;
         }
        
         public int getDistance () {
             return distance ;
         }
        
         public void setDistance (int distance ) {
             this . distance = distance ;
         }
    }
    
        /*
         * 
         * 1-Syntax error: Not "String" must be "string".
         * 2-"model" variable should be private because there are setters and getters for that var.
         * 3-In Line 13, accelerate method must return an integer or should convert to void method.
         * 4-In line 18, speed is an int value however it's assigned as double.
         * 5-In line 22, strings must be concatenated with using "+" not  ",".  
         * 6-In line 34, year is assigned as double value and returned as integer. Must be initiated as integer and returned.
         * 
         */
     
    
}