using System;
using System.Collections.Generic;

using System.Text;

using System.Threading;
using System.Xml;


namespace shutdownservice
{
    public  class Threade
    {

        public  string hour;
        public  string minutes;
        public  string mode;

        public void  Readfromxml(string namexml)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(namexml);
            XmlNode node = doc.DocumentElement.SelectSingleNode("hour");
            hour = node.InnerText;
            XmlNode node2 = doc.DocumentElement.SelectSingleNode("minutes");
            minutes = node2.InnerText;
            XmlNode node3 = doc.DocumentElement.SelectSingleNode("mode");
            mode = node3.InnerText;
            doc = null;
            node = null;




        }


    }

    }

/*  for the main thread


     // Create the thread object. This does not start the thread.
                Threade workerObject = new Threade();
                Thread workerThread = new Thread(workerObject.DoWork);
                workerThread.Priority = ThreadPriority.Lowest;
                // Start the worker thread.
                workerThread.Start();
                button2.Text = "main thread: Starting worker thread...";

                // Loop until worker thread activates. 
                while (!workerThread.IsAlive) ;

                // Put the main thread to sleep for 1 millisecond to 
                // allow the worker thread to do some work:




                // Use the Join method to block the current thread  
                // until the object's thread terminates.
                // workerThread.Join();




    */

