using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public class DesignForm//THIS CLASS IS FOR DESIGNS
    {
        public void TITLESCREEN()
        {
            Console.Clear();
            string head = @"

                                                    ──────╔═══════╗──────
                                                    ▒▓▒▓▒▒║░░░║░░░║▒▒▓▒▓▒
                                                    ▒▓▒▓▒▒║░░░╬═░░║▒▒▓▒▓▒
                                                    ▒▓▒▓▒▒║░░░░░░░║▒▒▓▒▓▒
                                                    ──────╚═══════╝──────";
            string header1 = @"
                               
                                ░██╗░░░░░░░██╗███████╗██╗░░░░░░█████╗░░█████╗░███╗░░░███╗███████╗  
                                ░██║░░██╗░░██║██╔════╝██║░░░░░██╔══██╗██╔══██╗████╗░████║██╔════╝  
                                ░╚██╗████╗██╔╝█████╗░░██║░░░░░██║░░╚═╝██║░░██║██╔████╔██║█████╗░░  
                                ░░████╔═████║░██╔══╝░░██║░░░░░██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░  
                                ░░╚██╔╝░╚██╔╝░███████╗███████╗╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗  
                                ░░░╚═╝░░░╚═╝░░╚══════╝╚══════╝░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝  

                                                        ████████╗░█████╗░
                                                        ╚══██╔══╝██╔══██╗
                                                        ░░░██║░░░██║░░██║
                                                        ░░░██║░░░██║░░██║
                                                        ░░░██║░░░╚█████╔╝
                                                        ░░░╚═╝░░░░╚════╝░

                                                ████████╗░█████╗░░██████╗██╗░░██╗  
                                                ╚══██╔══╝██╔══██╗██╔════╝██║░██╔╝  
                                                ░░░██║░░░███████║╚█████╗░█████═╝░  
                                                ░░░██║░░░██╔══██║░╚═══██╗██╔═██╗░  
                                                ░░░██║░░░██║░░██║██████╔╝██║░╚██╗  
                                                ░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝  

                       ███╗░░░███╗░█████╗░███╗░░██╗░█████╗░░██████╗░███████╗███╗░░░███╗███████╗███╗░░██╗████████╗
                       ████╗░████║██╔══██╗████╗░██║██╔══██╗██╔════╝░██╔════╝████╗░████║██╔════╝████╗░██║╚══██╔══╝
                       ██╔████╔██║███████║██╔██╗██║███████║██║░░██╗░█████╗░░██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░
                       ██║╚██╔╝██║██╔══██║██║╚████║██╔══██║██║░░╚██╗██╔══╝░░██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░
                       ██║░╚═╝░██║██║░░██║██║░╚███║██║░░██║╚██████╔╝███████╗██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░
                       ╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░

                                        ░██████╗██╗░░░██╗░██████╗████████╗███████╗███╗░░░███╗
                                        ██╔════╝╚██╗░██╔╝██╔════╝╚══██╔══╝██╔════╝████╗░████║
                                        ╚█████╗░░╚████╔╝░╚█████╗░░░░██║░░░█████╗░░██╔████╔██║
                                        ░╚═══██╗░░╚██╔╝░░░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║
                                        ██████╔╝░░░██║░░░██████╔╝░░░██║░░░███████╗██║░╚═╝░██║
                                        ╚═════╝░░░░╚═╝░░░╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝ ";

            String header3 = @"

                █▀█ █▀█ █▀▀ █▀ █▀   ▄▀█ █▄░█ █▄█   █▄▀ █▀▀ █▄█   ▀█▀ █▀█   █▀▀ █▀█ █▄░█ ▀█▀ █ █▄░█ █░█ █▀▀ ░ ░ ░
                █▀▀ █▀▄ ██▄ ▄█ ▄█   █▀█ █░▀█ ░█░   █░█ ██▄ ░█░   ░█░ █▄█   █▄▄ █▄█ █░▀█ ░█░ █ █░▀█ █▄█ ██▄ ▄ ▄ ▄";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(header1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(head);
            Console.ResetColor();
            Console.WriteLine(header3);
            Console.ReadKey();
        }
        public void Header()
        {
            Console.Clear();
            string header = @"      

                                 ████████╗███╗   ███╗███████╗
                                 ╚══██╔══╝████╗ ████║██╔════╝
                                    ██║   ██╔████╔██║███████╗
                                    ██║   ██║╚██╔╝██║╚════██║
                                    ██║   ██║ ╚═╝ ██║███████║
                                    ╚═╝   ╚═╝     ╚═╝╚══════╝
                            ";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(header);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                    Task Management System                                       ");
            Console.ResetColor();
        }
        public void Menu()
        {
            Console.WriteLine("+===============================================================================================+");
            Console.WriteLine("|                                                                                               |");
            Console.WriteLine("|                                 [1] Add Task                                                  |");
            Console.WriteLine("|                                 [2] Delete Task                                               |");
            Console.WriteLine("|                                 [3] Display Tasks                                             |");
            Console.WriteLine("|                                 [4] Exit                                                      |");
            Console.WriteLine("|                                                                                               |");
            Console.WriteLine("+===============================================================================================+");
        }
        public void AddDesign()
        {
            string header = @"
                     ▀█▀ ▄▀█ █▀ █▄▀   ▄▀█ █▀▄ █▀▄ █ █▄░█ █▀▀   █▀▀ █▀█ █▀█ █▀▄▀█
                     ░█░ █▀█ ▄█ █░█   █▀█ █▄▀ █▄▀ █ █░▀█ █▄█   █▀░ █▄█ █▀▄ █░▀░█";
            Console.WriteLine("");
            Console.Write(header);
            Console.WriteLine("");
        }
        public void DelDesign()
        {
            string header = @"
                     
                    ▀█▀ ▄▀█ █▀ █▄▀   █▀▄ █▀▀ █░░ █▀▀ ▀█▀ █ █▀█ █▄░█   █▀▀ █▀█ █▀█ █▀▄▀█
                    ░█░ █▀█ ▄█ █░█   █▄▀ ██▄ █▄▄ ██▄ ░█░ █ █▄█ █░▀█   █▀░ █▄█ █▀▄ █░▀░█";
            Console.WriteLine("");
            Console.Write(header);
            Console.WriteLine("");
        }
        public void SearchDesign()
        {
            string header = @"
                     
                    
                    ▀█▀ ▄▀█ █▀ █▄▀   █▀ █▀▀ ▄▀█ █▀█ █▀▀ █░█   █▀▀ █▀█ █▀█ █▀▄▀█
                    ░█░ █▀█ ▄█ █░█   ▄█ ██▄ █▀█ █▀▄ █▄▄ █▀█   █▀░ █▄█ █▀▄ █░▀░█";
            Console.WriteLine("");
            Console.Write(header);
            Console.WriteLine("");
        }
        
        public void TaskManager()
        {
            string taskhead = @"
                            █▀▄▀█ ▄▀█ █▄░█ ▄▀█ █▀▀ █▀▀   ▀█▀ ▄▀█ █▀ █▄▀ █▀
                            █░▀░█ █▀█ █░▀█ █▀█ █▄█ ██▄   ░█░ █▀█ ▄█ █░█ ▄█";
            Console.WriteLine("\n" + taskhead);
            Console.WriteLine("+===============================================================================================+");
            Console.WriteLine("|                                 [1] Search Task                                               |");
            Console.WriteLine("|                                 [2] Sort Tasks                                                |");
            Console.WriteLine("|                                 [3] Enqueue Task                                              |");
            Console.WriteLine("|                                 [4] Dequeue Task                                              |");
            Console.WriteLine("|                                 [5] Return                                                    |");
            Console.WriteLine("+===============================================================================================+");
        }

        public void EnqueueHeader()
        {
            string eqhead = @"
          ▀█▀ ▄▀█ █▀ █▄▀   █▀▀ █▄░█ █▀█ █░█ █▀▀ █░█ █▀▀ █ █▄░█ █▀▀   █▀ █▄█ █▀ ▀█▀ █▀▀ █▀▄▀█
          ░█░ █▀█ ▄█ █░█   ██▄ █░▀█ ▀▀█ █▄█ ██▄ █▄█ ██▄ █ █░▀█ █▄█   ▄█ ░█░ ▄█ ░█░ ██▄ █░▀░█";

            Console.WriteLine("");
            Console.Write(eqhead);
            Console.WriteLine("");
        }
        public void Enqueue()
        {
            Console.WriteLine("+===============================================================================================+");
            Console.WriteLine("|                                                                                               |");
            Console.WriteLine("|                                   [1] Enqueue All                                             |");
            Console.WriteLine("|                                   [2] Enqueue One                                             |");
            Console.WriteLine("|                                   [3] Return                                                  |");
            Console.WriteLine("|                                                                                               |");
            Console.WriteLine("+===============================================================================================+");
        }
        public void TILH()
        {
            string til = @"                 
                              ▀█▀ ▄▀█ █▀ █▄▀   █ █▄░█   █░░ █ █▀ ▀█▀
                              ░█░ █▀█ ▄█ █░█   █ █░▀█   █▄▄ █ ▄█ ░█░";
            Console.WriteLine("");
            Console.WriteLine(til);
        }
        public void TIQH()
        {
            string tin = @"
                            ▀█▀ ▄▀█ █▀ █▄▀   █ █▄░█   █▀█ █░█ █▀▀ █░█ █▀▀
                            ░█░ █▀█ ▄█ █░█   █ █░▀█   ▀▀█ █▄█ ██▄ █▄█ ██▄";
            Console.WriteLine("");
            Console.WriteLine(tin);
        }
        public void ColumnHeader()
        {
            Console.WriteLine("+===============================================================================================+");
            Console.WriteLine("\u001b[34m|\u001b[0m\u001b[33m Name:\t\t\t\t\u001b[34m|\u001b[0m\u001b[33m Priority:\t\u001b[34m|\u001b[0m\u001b[31m Deadline:\t\t\t\u001b[34m|\u001b[0m\u001b[32m Status:\t\u001b[34m|\u001b[0m");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------+");
        }
    }
}
