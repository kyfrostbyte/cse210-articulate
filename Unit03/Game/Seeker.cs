using System;


namespace Unit03.Game
{
    // Class Declaration
    public class Seeker
    {
        int _location = 0;

    // Constructor
        public Seeker()
        {

        }
        
    // Gets location of the seeker and returns it
        public int GetLocation()
        {
            return _location;
        }
        

    // Updates the seekers location
        public void MoveLocation(int location)
        {
            _location = location;
        }
    }
    
}