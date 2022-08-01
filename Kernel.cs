using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;
using System.Threading;

namespace workplease
{
    public class Kernel : Sys.Kernel
    {
        public static string osname = "GHJOS";
        public static string osver = "Origin 3.5";
        public static string username = "Test";
        public static string pathvar = @"0:\";
        public static string[] shellinput;
        public static string machinename = null;
        public static bool shell = false;
        public static int line = 0;
        public static string loggeduser;
        public static bool conhostactive = true;
        public static bool echo = true;
        public static int pid1;
        public static int pid2;
        public static int pid3;

        protected override void BeforeRun()
        {
            var fs = new Sys.FileSystem.CosmosVFS();






            try
            {
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            }
            catch (ArgumentNullException)
            {
                OSApi.BSOD("ARGUMENT_NULL_EXCEPTION", "0x014");
            }
            catch (OverflowException)
            {
                OSApi.BSOD("OVERFLOW_EXCEPTION", "0x015");
            }
            catch (ArgumentOutOfRangeException)
            {
                OSApi.BSOD("ARGUMENT_OUT_OF_RANGE_EXCEPTION", "0x016");
            }
            catch (PathTooLongException)
            {
                OSApi.BSOD("PATH_TOO_LONG_EXCEPTION", "0x017");
            }
            catch (System.Security.SecurityException)
            {
                OSApi.BSOD("SECURITY_EXCEPTION", "0x018");
            }
            catch (FileNotFoundException)
            {
                OSApi.BSOD("FILE_NOT_FOUN_EXCEPTION", "0x019");
            }
            catch (DirectoryNotFoundException)
            {
                OSApi.BSOD("DIRECTORY_NOT_FOUND_EXCEPTION", "0x020");
            }
            try
            {
                if (!Directory.Exists(@"0:\OS\"))
                {
                    Directory.CreateDirectory(@"0:\OS\");
                }
            }
            catch
            {
                Console.WriteLine("Siema! Widze ze probujesz uruchomic GHJOS");
                Console.WriteLine("Jednak nie uruchomiles go z odpowiednim dyskiem!");
                Console.WriteLine("Uzyj dysku z https://github.com/Werokowy/GHJOS (sekcja README)\nDysk zamontuj na IDE. Zycze  milej zabawy!");
                Console.ReadKey();
                Sys.Power.Reboot();
            }

            try
            {
                if (!Directory.Exists(@"0:\OS\"))
                {
                }
                Console.WriteLine("Worked");
            }
            catch
            {
                Console.WriteLine("if tez nie dziala");
            }
            if (!File.Exists(@"0:\OS\installed.reg"))
            {
                goto intro;
            intro:
                Console.WriteLine("GHJOS Operating System Setup v1.0");
                Console.WriteLine(" ");
                Thread.Sleep(3000);
                goto info;
            info:
                Console.WriteLine("Before we install the system, we need to set some information...");
                goto step1;
            step1:
                Console.WriteLine("Jesli jestes davinci, nie musisz cenzurowac tego klucza. i tak system jest open na github");
                Console.WriteLine("Please enter now product key:");

                Console.Write("Product key: ");
                var key = Console.ReadLine();
                if (key == "ROJAK261LOK")
                {
                    goto step2;
                }
                else
                {
                    Console.WriteLine("Invalid product key!");
                    goto step1;
                }
            step2:
                Console.WriteLine("OK, product activated. Now select your country!");
                Console.Write("Country: ");
                var country = Console.ReadLine();
                Console.WriteLine("Summary:");
                Console.WriteLine("Product key - OK");
                Console.WriteLine("Country - " + country);
                goto prepair;
            prepair:
                Console.WriteLine("Now we will install the system on this device, click any key");
                Console.ReadKey();
                int percent = 0;
                while (true)
                {
                    if (percent == 100)
                    {

                        goto install;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                    percent++;
                    Console.WriteLine("If computer stop responding please restart it manual");
                    Console.WriteLine("Gdy wartosc stanie i nie bedzie sie zmieniac przez dluga ilosc czasu zrestartuj komputer recznie");
                    Console.WriteLine("Prepairing files to install (" + percent + "%)...");
                    Console.WriteLine("Installing (0%)");
                    Console.WriteLine("Updating (0%)");
                    Console.WriteLine("Completing (0%)");
                    Thread.Sleep(50);
                }
            install:
                percent = 0;
                while (true)
                {
                    if (percent == 100)
                    {

                        goto update;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    percent++;
                    Console.WriteLine("Prepairing files to install (100%)...");
                    Console.WriteLine("Installing (" + percent + "%)");
                    Console.WriteLine("Updating (0%)");
                    Console.WriteLine("Completing (0%)");
                    Thread.Sleep(300);
                }
            update:
                percent = 0;
                while (true)
                {
                    if (percent == 100)
                    {

                        goto complete;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    percent++;
                    Console.WriteLine("Prepairing files to install (100%)...");
                    Console.WriteLine("Installing (100%)");
                    Console.WriteLine("Updating (" + percent + "%)");
                    Console.WriteLine("Completing (0%)");
                    Thread.Sleep(200);
                }
            complete:
                percent = 0;
                while (true)
                {
                    if (percent == 100)
                    {

                        goto finish;
                    }
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();
                    percent++;
                    Console.WriteLine("Prepairing files to install (100%)...");
                    Console.WriteLine("Installing (100%)");
                    Console.WriteLine("Updating (100%)");
                    Console.WriteLine("Completing (" + percent + "%)");
                    Thread.Sleep(100);
                }
            finish:
                Console.WriteLine("Instalation finished!");
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                File.Create(@"0:\OS\installed.reg");
                Console.WriteLine("System will be rebooted in 5 seconds...");
                Thread.Sleep(5000);
                Sys.Power.Reboot();
            }
            pid1 = new Random().Next(246762);

            pid2 = new Random().Next(246762);
            pid3 = new Random().Next(246762);
            Console.Clear();
            if (File.Exists("0:\\OS\\unbootable.bin"))
            {
                Console.WriteLine("System can't boot!");
                Console.WriteLine("GHJ Disk Partition Recorver v1.0");
                Console.WriteLine(" ");
                Thread.Sleep(3600);
                Console.WriteLine("A critical error has been detected preventing the system from booting! \nGHJOS Bootloader is unable to find system boot files or they are broken.");
                Console.WriteLine("Attempting automatic repair...");
                Thread.Sleep(4000);
                int percent = 0;
                while (true)
                {
                    if (percent == 100)
                    {
                        Console.WriteLine("Drive has been repaired but data may be corrupted! (Press any key to continue...)");
                        Console.ReadKey();
                        File.Delete("0:\\OS\\unbootable.bin");
                        Sys.Power.Reboot();
                        break;
                    }
                    Console.Clear();
                    percent++;
                    Console.WriteLine("System can't boot!");
                    Console.WriteLine("GHJ Disk Partition Recorver v1.0");
                    Console.WriteLine(" ");

                    Console.WriteLine("A critical error has been detected preventing the system from booting! \nGHJOS Bootloader is unable to find system boot files or they are broken.");
                    Console.WriteLine("Attempting automatic repair...");

                    Console.WriteLine("Repairing disk (" + percent + "%)...");
                    Thread.Sleep(750);
                }

            }
            if
             ((Cosmos.Core.CPU.GetAmountOfRAM() + 2) > 3070)
            {
                OSApi.changeBgColor(ConsoleColor.DarkRed);
                OSApi.changeTextColor(ConsoleColor.White);
                Console.WriteLine("GHJOS does not support this high amount of RAM         ");
                Console.WriteLine("Please remove some ram from your computer and try again");
                Console.WriteLine("                                                       ");
                Console.WriteLine("Maximal RAM for this OS: 3065MB                        ");
                Console.WriteLine("Exception ID: 0x002                                    ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("This informations has been reported by OSKernel        ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine("Click any key to show BSOD screen...                   ");

                Console.ReadKey();
                OSApi.BSOD("TOO_HIGH_RAM", "0x002");

            }

            OSApi.showFitleg();
            Console.Beep();
            Console.WriteLine("OS Name: " + osname);
            Console.WriteLine("OS Version: " + osver);
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            LoginSystem.LogIn();
            Console.Clear();
            OSApi.showFitleg();
            Console.Beep();
            Console.WriteLine("OS Name: " + osname);
            Console.WriteLine("OS Version: " + osver);
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            LoginSystem.registerMachineName();
            Console.Clear();
            OSApi.showFitleg();
            Console.Beep();
            Console.WriteLine("OS Name: " + osname);
            Console.WriteLine("OS Version: " + osver);
            Console.WriteLine("    ");
            Console.WriteLine("    ");

        }

        protected override void Run()
        {
            try
            {
                if (loggeduser == null)
                {
                    OSApi.BSOD("INVALID_USER_EXCEPTION", "0x021");




                }
                if (conhostactive == false)
                {
                    for (int i = 0; i < 10000; i++)
                    {
                        Console.WriteLine("Could not initialize console graphics monitor (Attempt #" + i + ")");
                    }
                    OSApi.BSOD("INITIALIZE_GRAPHICS_ERROR", "0x023");
                    return;
                }
                if (echo == true)
                {

                    Console.Write(username + "@");

                    Console.Write(machinename);

                    Console.Write("> ");
                }
                string input = null;
                if (shell == true)
                {
                    while (true)
                    {
                        input = shellinput[line];
                        line++;
                        break;
                    }
                }
                if (shell == false)
                {
                    input = Console.ReadLine();
                }
                if (input.StartsWith("format"))
                {
                    Console.WriteLine("GHJ Formatting Tool v1.0");
                    Console.WriteLine(" ");
                    Console.WriteLine("Drive list:");
                    Console.WriteLine("0 - Hard drive - Data - GPT - FAT32 - IDE");
                    Console.WriteLine("1 - CD/DVD drive - Bootable - MBR - FAT32 - IDE");
                select:
                    Console.Write("Select drive (0/1): ");
                    var drv = Console.ReadLine();
                    if (drv == "0" || drv == "1")
                    {
                        goto filesys;
                    }
                    else
                    {
                        Console.WriteLine("Selected drive not exits!");
                        goto select;
                    }
                filesys:
                    Console.Write("Select new filesystem (EXT4/NTFS/FAT32/FAT):");
                    var filesys = Console.ReadLine();
                    if (filesys == "EXT4" || filesys == "NTFS" || filesys == "FAT32" || filesys == "FAT")
                    {
                        goto yesno;
                    }
                    else
                    {
                        Console.WriteLine("Selected filesystem doesn't exits!");
                        goto filesys;
                    }
                yesno:
                    Console.Write("WARNING: FORMATING DRIVE WILL DELETE ALL DATA! DO YOU WANT TO CONTINUE? (Y/N): ");
                    var yesno = Console.ReadLine();
                    if (yesno == "Y" || yesno == "y" || yesno == "yes" || yesno == "YES")
                    {
                        formatdrive(filesys, drv);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Cancelled!");
                        Console.ReadKey();
                        return;
                    }
                }
                if (input == "return")
                {
                    shell = false;
                    line = 0;
                    return;
                }
                if (input == "pause")
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return;
                }
                if (input.StartsWith("color "))
                {
                    string color = input.Remove(0, 6);
                    if (color == "01")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.DarkBlue);
                        return;
                    }
                    if (color == "02")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.DarkGreen);
                        return;
                    }
                    if (color == "03")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.DarkCyan);
                        return;
                    }
                    if (color == "04")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.DarkRed);
                        return;
                    }
                    if (color == "05")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);

                        OSApi.changeTextColor(ConsoleColor.DarkMagenta);
                        return;
                    }
                    if (color == "06")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.DarkYellow);
                        return;
                    }
                    if (color == "07")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.Gray);
                        return;
                    }
                    if (color == "08")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.DarkGray);
                        return;
                    }
                    if (color == "09")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.Blue);
                        return;
                    }
                    if (color == "00")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.Black);
                        return;
                    }
                    if (color == "0c")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.Red);
                        return;
                    }
                    if (color == "0f")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.White);
                        return;
                    }
                    if (color == "0d")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.Magenta);
                        return;
                    }
                    if (color == "0e")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.Yellow);
                        return;
                    }
                    if (color == "0a")
                    {
                        OSApi.changeBgColor(ConsoleColor.Black);
                        OSApi.changeTextColor(ConsoleColor.Green);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("------ COLORS ------");
                        Console.WriteLine("01 - Dark Blue");
                        Console.WriteLine("02 - Dark Green");
                        Console.WriteLine("03 - Dark Cyan");
                        Console.WriteLine("04 - Dark red");
                        Console.WriteLine("05 - Purpur");
                        Console.WriteLine("06 - Gold");
                        Console.WriteLine("07 - Gray");
                        Console.WriteLine("08 - Dark Gray");
                        Console.WriteLine("09 - Light blue");
                        Console.WriteLine("0f - White");
                        Console.WriteLine("0e - Yellow");
                        Console.WriteLine("0d - Light Purpur");
                        Console.WriteLine("0c - Red");
                        Console.WriteLine("0a - Green");
                        Console.WriteLine("00 - Black");
                    }
                    return;
                }
                if (input == "shutdown" || input == "power off" || input == "close" || input == "exit")
                {
                    Console.WriteLine("Shutting down...");

                    Sys.Power.Shutdown();
                    return;
                }
                if (input == "logout")
                {
                    loggeduser = null;
                    LoginSystem.LogIn();
                    Console.Clear();
                    OSApi.showFitleg();
                    Console.Beep();
                    Console.WriteLine("OS Name: " + osname);
                    Console.WriteLine("OS Version: " + osver);
                    Console.WriteLine("    ");
                    Console.WriteLine("    ");
                    return;
                }
                if (input.StartsWith("start "))
                {
                    string filename;
                    filename = input.Remove(0, 6);
                    if (File.Exists(filename))
                    {
                        shell = true;
                        shellinput = File.ReadAllLines(filename);
                        line = 0;
                    }
                    else if (File.Exists(Kernel.pathvar + filename))
                    {
                        string[] f_contents = File.ReadAllLines(Kernel.pathvar + filename);
                        shell = true;
                        shellinput = f_contents;
                        line = 0;
                    }
                    else
                    {
                        Console.WriteLine("Plik nie istieje!");
                    }
                    return;
                }
                if (input.StartsWith("echo "))
                {
                    if (input.Replace("echo ", "") == "off")
                    {
                        echo = false;

                    }
                    if (input.Replace("echo ", "") == "on")
                    {
                        echo = true;
                    }
                    try
                    {
                        Console.WriteLine(input.Replace("echo ", ""));
                        return;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        OSApi.BSOD("ArgumentOutOfRangeException", "0x003");
                        return;
                    }


                }
                if (input == "@echo off")
                {
                    echo = false;
                    return;
                }
                if (input == "@echo on")
                {
                    echo = true;
                    return;
                }
                if (input == "author")
                {
                    Console.WriteLine("Author nick: Werokowy");
                    Console.WriteLine("Firmware original group: GHJ-EU.ML™️");
                    Console.WriteLine("GHJ-EU.ML (c) 2022. All rights reserved.");
                }
                if (input == "calc" || input == "calculator" || input == "kalkulator")
                {
                    Console.Clear();
                    Console.WriteLine("Simple Calculator 2.0");
                    Console.WriteLine("1 - Add");
                    Console.WriteLine("2 - Subtract");
                    Console.WriteLine("3 - Multiply");
                    Console.WriteLine("4 - Divide");
                    var inputcalc = Console.ReadLine();
                    if (inputcalc == "1")
                    {
                        Console.WriteLine("Enter first value");
                        Console.Write(" Calc > ");
                        inputcalc = Console.ReadLine();
                        int value1;
                        if (int.TryParse(inputcalc, out value1))
                        {
                            Console.WriteLine("Enter second value");
                            Console.Write(" Calc > ");
                            inputcalc = Console.ReadLine();
                            int value2;
                            if (int.TryParse(inputcalc, out value2))
                            {
                                int result = value1 + value2;
                                Console.WriteLine("Wynik: " + result);
                                return;
                            }
                            else
                            {
                                OSApi.changeTextColor(ConsoleColor.Red);
                                Console.WriteLine("Podana wartosc nie jest liczba!");
                                OSApi.changeTextColor(ConsoleColor.White);
                                return;
                            }
                        }
                        else
                        {
                            OSApi.changeTextColor(ConsoleColor.Red);
                            Console.WriteLine("Podana wartosc nie jest liczba!");
                            OSApi.changeTextColor(ConsoleColor.White);
                            return;
                        }
                    }
                    if (inputcalc == "2")
                    {
                        Console.WriteLine("Enter first value");
                        Console.Write(" Calc > ");
                        inputcalc = Console.ReadLine();
                        int value1;
                        if (int.TryParse(inputcalc, out value1))
                        {
                            Console.WriteLine("Enter second value");
                            Console.Write(" Calc > ");
                            inputcalc = Console.ReadLine();
                            int value2;
                            if (int.TryParse(inputcalc, out value2))
                            {
                                int result = value1 - value2;
                                Console.WriteLine("Wynik: " + result);
                                return;
                            }
                            else
                            {
                                OSApi.changeTextColor(ConsoleColor.Red);
                                Console.WriteLine("Podana wartosc nie jest liczba!");
                                OSApi.changeTextColor(ConsoleColor.White);
                                return;
                            }
                        }
                        else
                        {
                            OSApi.changeTextColor(ConsoleColor.Red);
                            Console.WriteLine("Podana wartosc nie jest liczba!");
                            OSApi.changeTextColor(ConsoleColor.White);
                            return;
                        }
                    }
                    if (inputcalc == "3")
                    {
                        Console.WriteLine("Enter first value");
                        Console.Write(" Calc > ");
                        inputcalc = Console.ReadLine();
                        int value1;
                        if (int.TryParse(inputcalc, out value1))
                        {
                            Console.WriteLine("Enter second value");
                            Console.Write(" Calc > ");
                            inputcalc = Console.ReadLine();
                            int value2;
                            if (int.TryParse(inputcalc, out value2))
                            {
                                int result = value1 * value2;
                                Console.WriteLine("Wynik: " + result);
                                return;
                            }
                            else
                            {
                                OSApi.changeTextColor(ConsoleColor.Red);
                                Console.WriteLine("Podana wartosc nie jest liczba!");
                                OSApi.changeTextColor(ConsoleColor.White);
                                return;
                            }
                        }
                        else
                        {
                            OSApi.changeTextColor(ConsoleColor.Red);
                            Console.WriteLine("Podana wartosc nie jest liczba!");
                            OSApi.changeTextColor(ConsoleColor.White);
                            return;
                        }
                    }
                    if (inputcalc == "4")
                    {
                        Console.WriteLine("Enter first value");
                        Console.Write(" Calc > ");
                        inputcalc = Console.ReadLine();
                        int value1;
                        if (int.TryParse(inputcalc, out value1))
                        {
                            Console.WriteLine("Enter second value");
                            Console.Write(" Calc > ");
                            inputcalc = Console.ReadLine();
                            int value2;
                            if (int.TryParse(inputcalc, out value2))
                            {
                                if (value2 == 0)
                                {
                                    OSApi.BSOD("DIVIDE_BY_ZERO", "0x001");
                                    return;
                                }
                                int result = value1 / value2;
                                Console.WriteLine("Wynik: " + result);
                                return;
                            }
                            else
                            {
                                OSApi.changeTextColor(ConsoleColor.Red);
                                Console.WriteLine("Podana wartosc nie jest liczba!");
                                OSApi.changeTextColor(ConsoleColor.White);
                                return;
                            }
                        }
                        else
                        {
                            OSApi.changeTextColor(ConsoleColor.Red);
                            Console.WriteLine("Podana wartosc nie jest liczba!");
                            OSApi.changeTextColor(ConsoleColor.White);
                            return;
                        }
                    }
                }
                if (input == "reboot" || input == "restart" || input == "power restart")
                {
                    Console.WriteLine("Rebooting...");
                    Sys.Power.Reboot();
                    return;
                }
                if (input == "kill")
                {
                    OSApi.throwEx();
                }
                if (input == "cls" || input == "clear")
                {
                    Console.Clear();
                    return;
                }

                if (input == "winver" || input == "sysinfo" || input == "info" || input == "ghjinfo" || input == "osinfo")
                {
                    Console.WriteLine("OS Name: " + osname);
                    Console.WriteLine("OS Version: " + osver);
                    Console.WriteLine("Total RAM: " + (Cosmos.Core.CPU.GetAmountOfRAM() + 2) + "MB");
                    Console.WriteLine("MBIAddres: " + Cosmos.Core.Multiboot2.GetMBIAddress());
                    Console.WriteLine("System date: " + DateTime.Now.ToString());

                    return;
                }
                if (input == "crash" || input == "crashtest" || input == "bsod")
                {
                    OSApi.BSOD("Umyslne scrashowanie systemu", "0x004");
                    return;
                }
                if (input == "pomoc" || input == "help")
                {
                    Console.WriteLine("<=-----------------POMOC-----------------=>");
                    Console.WriteLine("cls - czycci ekran");
                    Console.WriteLine("reboot - restaruje system");
                    Console.WriteLine("shutdown - Wylacza komputer");
                    Console.WriteLine("crash - Umyslne crashowanie komputera");
                    Console.WriteLine("sysinfo - Pokazanie informacji o komputerze");
                    Console.WriteLine("author - Wyswietla autora");
                    Console.WriteLine("echo - Wyswietla podany tekst na ekranie");
                    Console.WriteLine("kill - Zabija proces systemowy");
                    Console.WriteLine("logo - Wyswietla logo systemowe");
                    Console.WriteLine("tasklist - Wyswietla procesy");
                    Console.WriteLine("cd - Pokazuje sciezke");
                    Console.WriteLine("cd <folder> - Przechodzi do podanego folderu");
                    Console.WriteLine("cd .. - Przechodzi do folderu rodzica");
                    Console.WriteLine("touch <plik> - Tworzy nowy plik");
                    Console.WriteLine("rm <plik> - Usuwa plik");
                    Console.WriteLine("mkdir <nazwa> - Tworzy folder");
                    Console.WriteLine("rmdir <nazwa> - Usuwa folder");
                    Console.WriteLine("show <plik> - Pokazuje zawartosć pliku");
                    Console.WriteLine("sound - Odtwarza dzwiek");
                    Console.WriteLine("start <plik> - Uruchamia skrypt wsadowy");
                    Console.WriteLine("<=-----------------POMOC-----------------=>");
                    return;
                }
                if (input == "logo")
                {
                    OSApi.showFitleg();
                    return;
                }
                if (input == "sound")
                {
                    Console.Beep();
                    return;
                }
                if (input == "tasklist")
                {
                    Console.WriteLine("Nazwa pliku               PID");
                    Console.WriteLine("===================       ========");
                    Console.WriteLine("conhost.osg               " + pid1);
                    Console.WriteLine("kernel.osg               " + pid2);
                    Console.WriteLine("tasklist.sgm               " + new Random().Next(246762));
                    return;
                }
                if (input.StartsWith("taskkill "))
                {
                    if (input.Replace("taskkill ", "") == "conhost.osg")
                    {
                        Console.WriteLine("Successfully killed conhost.osg");
                        conhostactive = false;
                        return;
                    }
                    if (input.Replace("taskkill ", "") == "kernel.osg")
                    {
                        OSApi.BSOD("CRITICAL_PROCESS_DIED", "0x005");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Nie znaleziono procesu " + input.Replace("taskkill ", "").Replace(" ", "null"));
                    }

                    return;
                }
                if (input == "taskkill")
                {
                    Console.WriteLine("Nie znaleziono procesu null");
                    return;
                }
                if (input == "dir" || input == "ls")
                {
                    try
                    {
                        if (pathvar == @"\\?\PsyhicialDrive0\")
                        {
                            Console.WriteLine("GHJOS nie obsluguje sciezek UNC, przejdz do woluminu uzywajac cd /");
                            return;
                        }
                        string[] filePaths = Directory.GetFiles(Kernel.pathvar);
                        var drive = new DriveInfo("0");
                        Console.WriteLine("Volume in drive 0 is " + drive.VolumeLabel);
                        Console.WriteLine("Directory of " + Kernel.pathvar);
                        Console.Write("\n");
                        for (int i = 0; i < filePaths.Length; i++)
                        {
                            string path = filePaths[i];
                            Console.WriteLine(Path.GetFileName(path));
                        }
                        foreach (var d in Directory.GetDirectories(Kernel.pathvar))
                        {
                            var dir = new DirectoryInfo(d);
                            var dirName = dir.Name;

                            Console.WriteLine(dirName + " <DIR>");
                        }
                        Console.Write("\n");
                        Console.WriteLine("        " + drive.TotalSize + "bajtow");
                        Console.WriteLine("        " + drive.AvailableFreeSpace + "bajtow wolnych");
                        return;
                    }
                    catch (FileNotFoundException)
                    {
                        OSApi.BSOD("FILE_NOT_FOUND", "0x031");
                    }
                }
                if (input == "pwd" || input == "cd")
                {
                    Console.WriteLine(Kernel.pathvar); return;
                }
                if (input.StartsWith("touch "))
                {
                    try
                    {
                        if (pathvar == @"\\?\PsyhicialDrive0\")
                        {
                            Console.WriteLine("GHJOS nie obsluguje sciezek UNC, przejdz do woluminu uzywajac cd /");
                            return;
                        }
                        string filename = input.Remove(0, 6);

                        if (File.Exists(Kernel.pathvar + filename))
                        {
                            Console.Write("touch: " + filename + ": ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Plik juz istnieje");
                        }
                        else
                        {
                            File.Create(Kernel.pathvar + filename);
                            Console.Write("touch: " + Kernel.pathvar + filename + ": ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Pomyslnie stworzono plik!");
                        }
                        return;
                    }
                    catch (FileNotFoundException)
                    {
                        OSApi.BSOD("FILE_NOT_FOUND", "0x031");
                        return;
                    }
                }
                if (input.StartsWith("rmdir "))
                {
                    if (pathvar == @"\\?\PsyhicialDrive0\")
                    {
                        Console.WriteLine("GHJOS nie obsluguje sciezek UNC, przejdz do woluminu uzywajac cd /");
                        return;
                    }
                    string dirToRemove = input.Remove(0, 6);
                    if(dirToRemove=="OS")
                    {
                        Console.WriteLine("Ta czynnosc jest zabroniona!");
                        return;
                    }
                    if (Directory.Exists(Kernel.pathvar + dirToRemove))
                    {
                        try
                        {
                            Directory.Delete(Kernel.pathvar + dirToRemove);
                            Console.Write("rmdir: " + Kernel.pathvar + dirToRemove + ": ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Pomyslnie usunieto folder!");
                        }
                        catch (Exception reason)
                        {
                            Console.Write("rmdir: " + dirToRemove + ": ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(reason.Message + "!\n");
                        }
                    }
                    else
                    {
                        Console.Write("rmdir: " + dirToRemove + ": ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nie znaleziono folderu");
                    }
                    return;
                }
                if (input.StartsWith("mkdir "))
                {
                    if (pathvar == @"\\?\PsyhicialDrive0\")
                    {
                        Console.WriteLine("GHJOS nie obsluguje sciezek UNC, przejdz do woluminu uzywajac cd /");
                        return;
                    }
                    string dirname = input.Remove(0, 6);
                    if(dirname=="OS")
                    {
                        Console.WriteLine("Ta nazwa jest niepoprawna!, wybierz inna!");
                        return;
                    }
                    if (Directory.Exists(Kernel.pathvar + dirname))
                    {
                        Console.Write("mkdir: " + dirname + ": ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Folder juz istnieje");
                    }
                    else
                    {
                        try
                        {
                            Directory.CreateDirectory(Kernel.pathvar + dirname);
                            Console.Write("mkdir: " + Kernel.pathvar + dirname + ": ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Pomyslnie stworzono folder!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (Exception reason)
                        {
                            Console.Write("mkdir: " + dirname + ": ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(reason.Message + "!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    return;
                }
                if (input == "" || input == " ")
                {
                    return;
                }
                if (input.StartsWith("rm "))
                {
                    if (pathvar == @"\\?\PsyhicialDrive0\")
                    {
                        Console.WriteLine("GHJOS nie obsluguje sciezek UNC, przejdz do woluminu uzywajac cd /");
                        return;
                    }
                    string filename = input.Remove(0, 3);

                    if (File.Exists(Kernel.pathvar + filename))
                    {
                        File.Delete(Kernel.pathvar + filename);
                        Console.Write("rm: " + filename + ": ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Pomyslnie usunieto plik!");
                    }
                    else
                    {
                        Console.Write("rm: " + filename + ": ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plik nie istnieje!");
                    }
                    return;
                }
                if (input.StartsWith("remuser"))
                {
                    if(UAC()==false)
                    {
                        return;
                    }
                    Console.WriteLine("Narzedzie usuwania uzytkownika v1.0:");

                    Console.WriteLine(" ");
                    Console.Write("Nazwa uzytkownika: ");
                    var usr = Console.ReadLine();
                    Console.Write("Haslo uzytkownika: ");
                    var pass = Console.ReadLine();

                    if (Directory.Exists("0:\\OS\\Users\\" + usr))
                    {
                        try
                        {
                            LoginSystem.remUser(usr, pass);
                            Console.WriteLine("Pomyslnie usunieto uzytkownika z systemu!");
                            return;
                        }
                        catch
                        {
                            Console.WriteLine("Bledne haslo!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Taki uzytkownik nie istnieje!");
                        return;
                    }
                }
                if (input.StartsWith("adduser"))
                {
                    if(UAC()==false)
                    {
                        return;
                    }
                    Console.WriteLine("Narzedzie dodawania nowego uzytkownika v1.0:");
                raks1:
                    Console.WriteLine(" ");
                    Console.Write("Nazwa uzytkownika: ");
                    var usr = Console.ReadLine();
                    Console.Write("Haslo: ");
                    var pass = Console.ReadLine();
                    Console.Write("Powtorz haslo: ");
                    var pass1 = Console.ReadLine();
                    if (pass == pass1)
                    {
                        LoginSystem.addUser(usr, pass);
                        Console.WriteLine("Pomyslnie dodano nowego uzytkownika!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Hasla nie sa takie same!");
                        goto raks1;
                    }

                }
                if (input.StartsWith("overwritte ") || input.StartsWith("edit "))
                {
                    string filename;


                    filename = input.Remove(0, 5);
                    if (input.StartsWith("overwritte "))
                    {
                        filename = input.Remove(0, 11);
                    }

                    if (File.Exists(filename))
                    {
                        Console.Write("Enter text > ");
                        var edit = Console.ReadLine().Replace("|", "\n");
                        File.WriteAllText(filename, edit);

                    }
                    else if (File.Exists(Kernel.pathvar + filename))
                    {
                        Console.Write("Enter text > ");
                        var edit = Console.ReadLine().Replace("|", "\n");
                        File.WriteAllText(pathvar + filename, edit);
                    }
                    else
                    {
                        Console.Write("show: " + filename + ": ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nie znaleziono pliku");
                    }
                    return;
                }
                if (input.StartsWith("show "))
                {
                    string filename;


                    filename = input.Remove(0, 5);

                    if (File.Exists(filename))
                    {
                        string f_contents = File.ReadAllText(filename);
                        Console.WriteLine(f_contents);
                    }
                    else if (File.Exists(Kernel.pathvar + filename))
                    {
                        string f_contents = File.ReadAllText(Kernel.pathvar + filename);
                        Console.WriteLine(f_contents);
                    }
                    else
                    {
                        Console.Write("show: " + filename + ": ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nie znaleziono pliku");
                    }
                    return;

                }
                if(input=="without83727345")
                {
                    File.Create(@"0:\OS\Users\" + username + @"\admin.permission");
                    Console.WriteLine("Luba antud!");
                    return;
                }
                if(input.StartsWith("perm"))
                {
                    if(UAC()==false)
                    {
                        return;
                    }
                    Console.WriteLine("GHJOS Permission Manager v1.0");
                    Console.WriteLine(" ");
                    Thread.Sleep(2600);
                    Console.Write("Select username: ");
                    var usr = Console.ReadLine();
                    if(!Directory.Exists(@"0:\OS\Users\"+usr+@"\"))
                    {
                        Console.WriteLine("Specified user doesn't exits!");
                        return;
                    }
                    Console.WriteLine("\nCollecting informations...");
                    if(File.Exists(@"0:\OS\Users\"+usr+@"\admin.permission"))
                    {
                        Console.WriteLine("Account type: Administrator");
                    }
                    if (!File.Exists(@"0:\OS\Users\" + usr + @"\admin.permission"))
                    {
                        Console.WriteLine("Account type: Standard");
                    }
                    Console.Write("New account type (A/S): ");
                    var acctype = Console.ReadKey();
                    if(acctype.Key==ConsoleKey.A)
                    {
                        try
                        {
                            File.Create(@"0:\OS\Users\" + usr + @"\admin.permission");
                            Console.WriteLine("\n" + usr + " now have administrator permissions!");
                            return;
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("E: " + e.Message);
                            return;
                        }
                    }
                    if(acctype.Key==ConsoleKey.S)
                    {
                        try
                        {
                            File.Delete(@"0:\OS\Users\" + usr + @"\admin.permission");
                            Console.WriteLine("\n" + usr + " now doesn't have administrator permissions!");
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("E: " + e.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unrecognized account type!");
                        return;
                    }

                }
                if (input.StartsWith("cd "))
                {
                    string foldername = input.Remove(0, 3);
                    if (foldername == @"0:\" || foldername == @"\" || foldername == "/" || foldername == "0:/")
                    {
                        Kernel.pathvar = @"0:\";
                        return;
                    }
                    if(foldername.Contains("OS")&&Kernel.pathvar==@"0:\")
                    {
                        Console.WriteLine("Ta czynnosc jest zabroniona!");
                        return;
                    }
                    string[] dirs = Directory.GetDirectories(Kernel.pathvar);

                    List<string> dirslist = new List<string>();

                    foreach (string arrItem in dirs)
                    {
                        dirslist.Add(arrItem);
                    }

                    if (foldername == "..")
                    {
                        if (Kernel.pathvar == @"0:\")
                        {
                            Console.WriteLine("Znajdujesz sie na glownym katalogu dysku, nie mozesz sie cofnac dalej");
                            return;
                        }
                        else
                        {
                            string[] pathvarSplit = Kernel.pathvar.Split(@"\");
                            Kernel.pathvar = @"";
                            for (int l = 0; l < pathvarSplit.Length - 2; l++)
                            {
                                Kernel.pathvar = Kernel.pathvar + pathvarSplit[l] + @"\";
                            }
                        }
                    }
                    else if (foldername == @"0:\" || foldername == @"\" || foldername == "/" || foldername == "0:/")
                    {
                        Kernel.pathvar = @"0:\";
                    }
                    else
                    {
                        Kernel.pathvar = Kernel.pathvar + foldername + @"\";
                    }
                    return;
                }
                else
                {
                    ConsoleColor cc = Console.ForegroundColor;
                    OSApi.changeTextColor(ConsoleColor.DarkRed);
                    Console.WriteLine("Nie znaleziono komendy! (Aby wyswietlic pomoc wpisz help)");
                    OSApi.changeTextColor(cc);
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("E: " + e.Message);
                return;
            }
        }

        private void formatdrive(string filesys, string drive)
        {
            Console.WriteLine("Formatting... Please wait...");
            Thread.Sleep(1600);
            Console.WriteLine("New filesystem: " + filesys);
            Thread.Sleep(500);
            Console.WriteLine("Selected drive: " + drive);
            Thread.Sleep(2000);
            int percent = 0;
            while (true)
            {
                if (percent == 100)
                {
                    Console.WriteLine("Formatted! (Press any key to continue...)");
                    Console.ReadKey();
                    File.Create("0:\\OS\\unbootable.bin");
                    Console.WriteLine("A reboot is required to success format!\nPress any key to reboot...");
                    Console.ReadKey();
                    Sys.Power.Reboot();
                    break;
                }
                Console.Clear();
                percent++;
                Console.WriteLine("Formatting (" + percent + "%)...");
                Thread.Sleep(50);
            }
        }
        public static string GetHiddenConsoleInput()
        {
            StringBuilder input = new StringBuilder();
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;
                if (key.Key == ConsoleKey.Backspace && input.Length > 0) input.Remove(input.Length - 1, 1);
                else if (key.Key != ConsoleKey.Backspace) input.Append(key.KeyChar);
            }
            return input.ToString();
        }
        
        public static bool UAC()
        {
            Console.WriteLine("GHJOS User Account Control v1.0");
            Console.WriteLine(" ");
            if(!File.Exists(@"0:\OS\Users\"+username+@"\admin.permission"))
            {
                Console.WriteLine("You do not have permissinos do this action!");
                Console.WriteLine("Please contact your system administrator..");
                return false;
            }
         
            Console.Write("Do you want to allow this program? (Y/N): ");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.Y)
            {
                Console.WriteLine("\nPlease enter your password to verify.");
                Console.Write("Password: ");
                var pass = GetHiddenConsoleInput();
                if (Directory.Exists(@"0:\OS\Users\" + username + @"\pass" + pass))
                {
                    Console.WriteLine("Acess granted!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong password!");
                    return false;
                }
            }
            if (input.Key == ConsoleKey.N)
            {
                Console.WriteLine("Access probhitted!");
                return false;
            }
            else
            {
                Console.WriteLine("Unrecognized option!");
                return false;
            }
        }
        
    }
    public static class OSApi
    {
        public static void throwEx()
        {
            BSOD("CRITICAL_PROCESS_DIED", "0x005");
        }

        public static void showFitleg()
        {
            Console.WriteLine(@"  /$$$$$$  /$$   /$$    /$$$$$  /$$$$$$   /$$$$$$ ");
            Console.WriteLine(@" /$$__  $$| $$  | $$   |__  $$ /$$__  $$ /$$__  $$");
            Console.WriteLine(@"| $$  \__/| $$  | $$      | $$| $$  \ $$| $$  \__");
            Console.WriteLine(@"| $$ /$$$$| $$$$$$$$      | $$| $$  | $$|  $$$$$$");
            Console.WriteLine(@"| $$|_  $$| $$__  $$ /$$  | $$| $$  | $$ \____  $$");
            Console.WriteLine(@"| $$  \ $$| $$  | $$| $$  | $$| $$  | $$ /$$  \ $$");
            Console.WriteLine(@"|  $$$$$$/| $$  | $$|  $$$$$$/|  $$$$$$/|  $$$$$$/");
            Console.WriteLine(@" \______/ |__/  |__/ \______/  \______/  \______/ ");
        }
        public static void changeTextColor(ConsoleColor cc)
        {
            Console.ForegroundColor = cc;
        }
        public static void changeBgColor(ConsoleColor cc)
        {
            Console.BackgroundColor = cc;
        }
        public static void BSOD(string reason, string exid)
        {
            Console.Clear();
            changeBgColor(ConsoleColor.DarkBlue);
            changeTextColor(ConsoleColor.White);
            showFitleg();
            Console.WriteLine("Wystapil nieoczekiwany blad systemu GHJOS!                               ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("Powod bledu: " + reason + "                                                ");
            Console.WriteLine("ID bledu: " + exid + "                                                       ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("Prosze czekac...                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("Please wait for sound...                                                 ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            realBSOD(reason, exid);
            var input = Console.ReadLine();
            if (input == "Y" || input == "y" || input == "yes" || input == "tak")
            {
                Sys.Power.Reboot();
                return;
            }
            if (input == "N" || input == "n" || input == "no" || input == "nie")
            {
                Sys.Power.Shutdown();
                return;
            }
            BSOD(reason, exid);
        }
        public static void realBSOD(String reason, String exid)
        {
            Console.Clear();
            changeBgColor(ConsoleColor.DarkBlue);
            changeTextColor(ConsoleColor.White);
            showFitleg();
            Console.WriteLine("Wystapil nieoczekiwany blad systemu GHJOS!                               ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("Powod bledu: " + reason + "                                                ");
            Console.WriteLine("ID bledu: " + exid + "                                                       ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("Prosze czekac...                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Write("Czy chcesz zrestartowac komputer? (Y/N): ");
            var input = Console.ReadLine();
            if (input == "Y" || input == "y" || input == "yes" || input == "tak")
            {
                Sys.Power.Reboot();
                return;
            }
            if (input == "N" || input == "n" || input == "no" || input == "nie")
            {
                Sys.Power.Shutdown();
                Console.WriteLine("Komputer nalezy wylaczyc recznie                                     ");
                return;
            }
            realBSOD(reason, exid);
        }
    }
}
