using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Threading;


namespace shutdownservice
{
    public partial class Service1 : ServiceBase 
    {
        Class1 cs = new Class1();
        
        public Service1()
        {
            InitializeComponent();

           
        }

        protected override void OnStart(string[] args)
        {
            base.OnStart(null);

            
            
            
           
        
           
            startthread();

        }

        protected override void OnStop()
        {
            

            cs.RequestStop();
           
            
        }

        protected override void OnContinue()
        {
            base.OnContinue();
           

           

        }

        internal void TestStartupAndStop()
        {
            this.OnStart(null);
            Console.ReadLine();
            this.OnStop();
        }


        private  void startthread()
        {
            
            // Create the thread object. This does not start the thread.
          //  Class1 workerObject = new Class1();
            cs.RequestStart();
            
            Thread workerThread = new Thread(cs.whileloop);//here i start the while loop to check the system time
            workerThread.Priority = ThreadPriority.Lowest;
            // Start the worker thread.
            workerThread.Start();
           
            //button2.Text = "main thread: Starting worker thread...";

            // Loop until worker thread activates. 
            while (!workerThread.IsAlive) ;

            // Put the main thread to sleep for 1 millisecond to 
            // allow the worker thread to do some work:





        }


    }
}
