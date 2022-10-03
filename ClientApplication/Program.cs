﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataProcessing());

            Console.WriteLine("Client Started");

            string address = "net.pipe://localhost/AstroServer";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            //ChannelFactory<IAstroContract> pipeFactory = new ChannelFactory<IAstroContract>(new NetNamedPipeBinding(), new EndpointAddress("net.pipe://localhost/AstroServer"));
           // IAstroContract pipeProxy = pipeFactory.CreateChannel();

            //---------------------------------------
            //while (true)
            //{
            //    string str = Console.ReadLine();
            //    double convertFromString = Convert.ToDouble(str);
            //    Console.WriteLine("pipe: " + pipeProxy.StarDistance(convertFromString), pipeProxy.TempInKelvin(convertFromString),
            //        pipeProxy.StarVelocity(convertFromString, convertFromString), pipeProxy.EventHorizon(convertFromString));
            //}
        }
    }
}
