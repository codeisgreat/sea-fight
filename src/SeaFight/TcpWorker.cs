using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SeaFight
{
    public class TcpWorker
    {
        private TcpClient _client;
        private TcpListener _listener;
      //  private NetworkStream _clientStream;

        public event Action<string> RecieveMessagesEvent;
        
        protected virtual void OnRecieveMessagesEvent(string obj)
        {
            Action<string> handler = RecieveMessagesEvent;
            if (handler != null) handler(obj);
        }

        public void Reset()
        {
            if (_listener != null)
                _listener.Stop();

            //if (_clientStream != null)
            //    _clientStream.Close();

            if (_client != null) 
                _client.Close();
        }

        /// <summary>
        /// Вызовет SocketException если порт  уже слушается
        /// </summary>
        /// <param name="port"></param>
        public void Listen(int port)
        {
            _listener = new TcpListener(IPAddress.Any,port);
            _listener.Start();
            _client = _listener.AcceptTcpClient();//повесит программу до подключения клиента
            StartRecieve();

        }

        public void Join(string ip, int port)
        {
            try
            {
                _client = new TcpClient(ip, port);
                //_clientStream = _client.GetStream();
            }
            catch (SocketException e)
            {//возможно порт никем не слушается
                Join(ip,port);//сделаем цикл до коннекта, программа будет висеть
            }
            StartRecieve();

        }


        public void SendMessage(string message)
        {
            try
            {
                //  if (_recieveResult != null)
                //      _recieveResult.AsyncWaitHandle.WaitOne();//с этим ограничением будет обмен сообщениями строго по очереди с другим игроком
                //в случае попытки послать 2 сообщение программа зависнет. 
                //Можно убрать по обстоятельствам (но тогда может послаться второе подряд сообщение, причем возможно прочитано это будет как одно длинное сообщение)
                byte[] encodedMessage = Encoding.ASCII.GetBytes(message);
                _client.GetStream().Write(encodedMessage, 0, encodedMessage.Length);

                
            }
            catch (InvalidOperationException)//при обрыве другой программы клиента
            {
            }


        }

        private IAsyncResult _recieveResult;
        private void StartRecieve()
        {

            var recieveData = new byte[1024];
            var networkStream = _client.GetStream();
            _recieveResult = networkStream.BeginRead(recieveData, 0, recieveData.Length, (IAsyncResult result) =>
             {
                 try
                 {
                     var stream = (NetworkStream) result.AsyncState;
                     int length = stream.EndRead(result);
                     if (length > 0)
                     {
                         string message = Encoding.ASCII.GetString(recieveData, 0, length);
                         OnRecieveMessagesEvent(message);
                         
                     }
                     StartRecieve();
                 }
                 catch (ObjectDisposedException)
                 {
                 } //при сообщении close
                 catch (IOException)
                 {
                 } //при обрыве другой программы клиента

             }, networkStream);
        }

    }
}