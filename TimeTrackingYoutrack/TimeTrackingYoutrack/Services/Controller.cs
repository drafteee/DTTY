using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTrackingYoutrack.Services
{
    public class Controller
    {
        public Controller()
        {
            //Action a = StopTimer; 
        }

        [Http("stopTimer")]
        public int StopTimer(int a)
        {
            a = 7;

            return a;
        }
    }
}
