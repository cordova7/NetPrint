using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watcher
{
    public class SumatraPrinter
    {
        private string Argument = "";
        public SumatraPrinter(string argument)
        {
            this.Argument = argument;
            
        }

        public void Print()
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.FileName = @"C:\Program Files\SumatraPDF\SumatraPDF.exe";

                proc.StartInfo.Arguments = Argument;

                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;

                proc.Start();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                if (proc.HasExited == false)
                {
                    proc.WaitForExit(10000);
                }

                proc.EnableRaisingEvents = true;

                proc.Close();
            }
            catch
            {
                Console.WriteLine("Error in Sumatra Printer");
            }
        }
    }
}
