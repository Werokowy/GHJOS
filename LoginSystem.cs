using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workplease
{
    class LoginSystem
    {
        public static void addUser(string user,string pass)
        {
           
            Directory.CreateDirectory(@"0:\OS\Users\" + user + @"\");

            Directory.CreateDirectory(@"0:\OS\Users\" + user + @"\pass" + pass);
        }
        public static void registerMachineName()
        {
           if(!Directory.Exists(@"0:\OS\MachineInfo\"))
            {
                Directory.CreateDirectory(@"0:\OS\MachineInfo\");
                
            }
           if(File.Exists(@"0:\OS\MachineInfo\machinename.ini"))
            {
                Kernel.machinename = File.ReadAllText(@"0:\OS\MachineInfo\machinename.ini");
            }
           if(!File.Exists(@"0:\OS\MachineInfo\machinename.ini"))
            {
                File.Create(@"0:\OS\MachineInfo\machinename.ini");
                Console.WriteLine("Nie znaleziono nazwy maszyny, prosimy ustalic nazwe komputera:");
                Console.Write("Machine Name > ");
                var input = Console.ReadLine();
                File.WriteAllText(@"0:\OS\MachineInfo\machinename.ini",input);
                Console.WriteLine("Pomyslnie zapisano nazwe maszyny!");
                Kernel.machinename = input;
            }
           
        }
        public static void LogIn()
        {
            try
            {
                if (!Directory.Exists(@"0:\OS\"))
                {
                    Directory.CreateDirectory(@"0:\OS\");
                }
                if (!Directory.Exists(@"0:\OS\Users\"))
                {
                    Directory.CreateDirectory(@"0:\OS\Users\");
                }
                if (!Directory.Exists(@"0:\OS\Users\registry\"))
                {
                    Directory.CreateDirectory(@"0:\OS\Users\Registry\");
                }
            }
            catch (FileNotFoundException)
            {
                OSApi.BSOD("DISK_NOT_FOUND_OR_FAT32_REQUIRED", "0x091");
                return;
            }
            if (File.Exists(@"0:\OS\Users\registry\defined.reg"))
            {
                Console.WriteLine("Prosze sie zalogowac uzywajac loginu i hasla...");
                morgo:
                Console.Write("User > ");
                var input = Console.ReadLine();
                string user = input;
                Console.Write("Pass > ");
                input = Console.ReadLine();
                string pass = input;
                if (Directory.Exists(@"0:\OS\Users\" + user + @"\"))
                {
                    if (Directory.Exists(@"0:\OS\Users\" + user + @"\pass" + pass))
                    {
                        Kernel.loggeduser = "yes";
                        Kernel.username = user;
                        return;
                    }
                    else
                    {
                        /*
                        Console.WriteLine("Niepoprawne haslo!");
                        return; */
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("Haslo jest niepoprawne!");
                        Console.WriteLine(" ");
                        goto morgo;
                       
                    }
                }
                else
                {/*
                    Console.WriteLine("Nie znaleziono uzytkownika!");
                return; */
                    System.Threading.Thread.Sleep(2000);
                    
                    Console.WriteLine("Login jest niepoprawny!");
                    Console.WriteLine(" ");
                    
                    goto morgo;
                    return;
                }
            }
            if (!File.Exists(@"0:\OS\Users\registry\defined.reg"))
            {
                Console.WriteLine("Nie zdefiniowales jeszcze uzytkownika, zdefiniuj teraz!");
                Console.WriteLine(" ");
                Console.Write("User > ");
                var user = Console.ReadLine();
                Console.Write("Haslo > ");
                var haslo = Console.ReadLine();
                Console.Write("Powtorz haslo > ");
                var haslo1 = Console.ReadLine();
                if (haslo == haslo1)
                {
                    File.Create(@"0:\OS\Users\registry\defined.reg");
                    Directory.CreateDirectory(@"0:\OS\Users\" + user + @"\");

                    Directory.CreateDirectory(@"0:\OS\Users\" + user + @"\pass" + haslo1);
                    Console.WriteLine("Pomyslnie zarejestrowano, teraz sie zaloguj");
                    Console.Clear();
                    LogIn();
                    return;
                }
                else
                {
                    Console.WriteLine("Hasla sa rozne!");
                    Console.ReadKey();
                }
            }
        }
    }
}
