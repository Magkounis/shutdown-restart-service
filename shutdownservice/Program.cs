using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Text;

namespace shutdownservice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {

            
          

            if (Environment.UserInteractive)
            {

                Service1 service1 = new Service1();
                service1.TestStartupAndStop();
            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new Service1()
                };
                ServiceBase.Run(ServicesToRun);
            }


           



        }
    }
}
