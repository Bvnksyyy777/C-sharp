using System;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace LogInSystem
{
    class Program
    {
        static bool register(string usrName, string usrPwd)
        {
           if(logIn(usrName, usrPwd)==false)
            {
                 StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("C:\\DataBase.txt", true);
                sw.WriteLine(usrName+usrPwd);
                return true;
            }
            catch(Exception ex)
            {
                return  false;
            }
            finally
            {
                sw.Close();
            }
           
            }
            else
            {
                return false;
            }
        }
        static bool logIn(string usrName,  string usrPwd)
        {
            string line;
            string usrInput=usrName+usrPwd;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("C:\\DataBase.txt");
                line = sr.ReadLine();
                while(line!= null)
                {
                    if (line == usrInput)
                    {
                        return true;
                    }
                    line = sr.ReadLine();
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }
            return false;

        }
        public static string GetPassword()
        {
            //it just makes the password looks like *** instead of normal letters or numbers
            StringBuilder input = new StringBuilder();
            while (true)
            {
                int x = Console.CursorLeft;
                int y = Console.CursorTop;
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                    Console.SetCursorPosition(x - 1, y);
                    Console.Write(" ");
                    Console.SetCursorPosition(x - 1, y);
                }
                else if (key.KeyChar < 32 || key.KeyChar > 126)
                {
                    Trace.WriteLine("Output suppressed: no key char");
                }
                else if (key.Key != ConsoleKey.Backspace)
                {
                    input.Append(key.KeyChar);
                    Console.Write("*");
                }
            }
            return input.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to log in or press 2 to register: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                logIn:
                Console.WriteLine("Enter your username: ");
                string usrName= Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                string usrPasswd = GetPassword();
                if(logIn(usrName, usrPasswd) == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Welcome " + usrName);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("User not found, try again or register");
                    Console.Write("Press 1 to register or 2 to try again: ");
                    int usrChoice=int.Parse(Console.ReadLine());
                    if (usrChoice == 1)
                    {
                        if (register(usrName, usrPasswd) == true)
                        {
                            Console.WriteLine("Registration completed");
                        }
                    }
                    else
                    {
                        goto logIn;
                    }
                }
            }
            else
            {
                register:
                Console.Write("Enter desirable username: ");
                string usrName = Console.ReadLine();
                Console.Write("Enter password: ");
                string usrPwd = GetPassword();
                if(register(usrName,usrPwd) == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Registration completed");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("This user already exists, do you want to log in?");
                    Console.Write("Press 1 to log in or 2 to try again: ");
                    int usrChoice = int.Parse(Console.ReadLine());
                    if(usrChoice == 1)
                    {
                        Console.WriteLine("Enter your username: ");
                        string usrN = Console.ReadLine();
                        Console.WriteLine("Enter your password: ");
                        string usrPasswd = GetPassword();
                        if (logIn(usrN, usrPasswd) == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Welcome " + usrName);
                        }
                    }
                    else
                    {
                        goto register;
                    }
                }

            }
        }
    }
}
