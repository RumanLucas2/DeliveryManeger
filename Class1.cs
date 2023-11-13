using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Internet
    {
        public static bool Connection { get; private set; }
        public async static void Start()
        {
            while(true)
            {
                Connection = GetInternetConnecton();
                await Task.Delay(15000);
            }
        }

        private static bool GetInternetConnecton()
        {
            {
                try
                {
                    Ping ping = new Ping();
                    PingReply reply = ping.Send("www.google.com");

                    if (reply != null && reply.Status == IPStatus.Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }

    public class Forma : Form
    {
        public static void Kill(Form form)
        {
            form.Close();
        }
    }
}
    
