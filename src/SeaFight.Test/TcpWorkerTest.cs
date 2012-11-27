using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeaFight.Test
{
    [TestClass]
    public class TcpWorkerTest
    {

        [TestMethod]
        public void ConnectTest()
        {
            var worker = new TcpWorker();
            Action a = () =>
            {
                worker.Listen(3000);


            };
            var r = a.BeginInvoke(null, null);
            
            var clientWorker = new TcpWorker();
            clientWorker.Join("127.0.0.1",3000);
            r.AsyncWaitHandle.WaitOne();
            worker.Reset();
            clientWorker.Reset();

        }

        [TestMethod]
        public void SendTest()
        {
            var worker = new TcpWorker();

            Action a = () =>
                           {
                               worker.Listen(3000);


                           };
            var r = a.BeginInvoke(null, null);

            var clientWorker = new TcpWorker();
            clientWorker.Join("127.0.0.1", 3000);

            r.AsyncWaitHandle.WaitOne();

            worker.RecieveMessagesEvent += worker_RecieveMessagesEvent;
            clientWorker.RecieveMessagesEvent += clientWorker_RecieveMessagesEvent;

            clientWorker.SendMessage("test");
            worker.SendMessage("test2");
            Thread.Sleep(500);
            worker.SendMessage("test2-1");
           // Thread.Sleep(500);
            worker.SendMessage("test2-2");

            //Thread.Sleep(500);
            worker.SendMessage("test2-2");
            //Thread.Sleep(500);
            worker.SendMessage("test2-2");
            
            clientWorker.SendMessage("test1");

            worker.SendMessage("test5");
      
            clientWorker.SendMessage("test4");
            worker.SendMessage("test3");

            Thread.Sleep(1000);
            worker.Reset();
            clientWorker.Reset();
            
            //Thread.Sleep(1000);
            
        }

        void clientWorker_RecieveMessagesEvent(string obj)
        {
            Console.WriteLine("client: "+obj);
        }

        void worker_RecieveMessagesEvent(string obj)
        {
            Console.WriteLine("server: "+ obj);
            
        }
    }
}
