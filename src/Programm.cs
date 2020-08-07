using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ComponentModel.Design;

namespace Minecodes_Dev_Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Process shell = new Process())
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("              Minecodes Dev Shell v1");
                    Console.WriteLine("                 Author: Minecodes");
                    Console.WriteLine("         Github: https://github.com/Minecodes");
                    Console.WriteLine("-------------------------------------------------");
                    shell.StartInfo.UseShellExecute = false;
                    shell.StartInfo.FileName = "powershell.exe";
                    shell.StartInfo.Arguments = "-NoLogo";
                    shell.StartInfo.CreateNoWindow = false;
                    shell.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
