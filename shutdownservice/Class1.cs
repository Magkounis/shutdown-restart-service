using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Management;

namespace shutdownservice
{
   public class Class1 :Threade
    {
       
       // public static  string hour;
       // public static string minutes;
       // public static string mode;
        public void RequestStop()
        {
            _shouldStop = true;
         
        }
        public  void RequestStart()
        {
            _shouldStop = false;
            
        }
        
        public  void whileloop()
        {
             Readfromxml("C:\\sht\\config.sht");


             _shouldStop = false;
            Thread.CurrentThread.Priority = ThreadPriority.Lowest;//set the main thread priority to lowest
            while (!_shouldStop)
            {
                Thread.Sleep(1);//check the time exery 1 ms
               string str= DateTime.Now.TimeOfDay.ToString().Substring(0,5);//take the time hour:minutes from system
               if (str==hour+":"+minutes)
                {
                    
                    System.Diagnostics.Process.Start("shutdown.exe", "-"+mode+" -t 0");
                    

                }
                str = null;
            }
        }
        private static volatile bool _shouldStop=false;


        



    }
}
