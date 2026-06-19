using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watcher.Properties;

namespace Watcher
{
    public partial class WatcherForm : Form
    {

        public static WatcherForm form;


        static bool printStatus = true;
        static int numberOfCopies = 1;
        static string paper = "letter"; 
        //static string printer = paper == "letter" ? "-print-to-default" : "-print-to \"Oficio\"";
        static string mode = "simplex";
        static bool INE_mode = false;
        static bool ActiveTasks = false;
        static decimal TotalVentas = 0M;

        static bool Color = false;
        
        static Parameters tarea1parameters = new Parameters();
        static Parameters tarea2parameters = new Parameters();
        static Parameters tarea3parameters = new Parameters();
        static Parameters tarea4parameters = new Parameters();
        static Parameters tarea5parameters = new Parameters();

        static int ActiveTaskCount = 1;



        public WatcherForm()
        {
            
            form = this;
            InitializeComponent();
            RunWatcher();
            
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public static void RunWatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();

            //watcher.Path = @"C:\Users\Marco\Desktop\scaner";
            //watcher.Path = @"D:\scaner";
            try
            {
                watcher.Path = Directory.CreateDirectory(Settings.Default.ScannerDirectory).ToString();
            } catch (System.Exception)
            {
                watcher.Path = Directory.CreateDirectory(Environment.SpecialFolder.Desktop.ToString()).ToString();
            }
            

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Filter = "*.pdf";

            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;

            Console.ReadLine();
        }

        private static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\nFile loading."); 
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
        private static void OnChanged(object source, FileSystemEventArgs e)
        {

            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);

            while (IsFileLocked(new FileInfo(e.FullPath)))
            {
                Console.WriteLine("File still loading.");
            }
            Thread.Sleep(2000);
            
            

            if (printStatus)
            {
                if (ActiveTasks)
                {
                    switch (ActiveTaskCount)
                    {
                        case 1:
                            tarea1parameters.FilePath = e.FullPath;
                            if (tarea1parameters.INEmode)
                            {
                                tarea1parameters.FilePath = GetINEpath(e.FullPath);
                            } 
                            PrintPDFs(tarea1parameters.FilePath);
                            break;
                        case 2:
                            tarea2parameters.FilePath = e.FullPath;
                            if (tarea2parameters.INEmode)
                            {
                                tarea2parameters.FilePath = GetINEpath(e.FullPath);
                            }
                            PrintPDFs(tarea2parameters.FilePath);
                            break;
                        case 3:
                            tarea3parameters.FilePath = e.FullPath;
                            if (tarea3parameters.INEmode)
                            {
                                tarea3parameters.FilePath = GetINEpath(e.FullPath);
                            }
                            PrintPDFs(tarea3parameters.FilePath);
                            break;
                        case 4:
                            tarea4parameters.FilePath = e.FullPath;
                            if (tarea4parameters.INEmode)
                            {
                                tarea4parameters.FilePath = GetINEpath(e.FullPath);
                            }
                            PrintPDFs(tarea4parameters.FilePath);
                            break;
                        case 5:
                            tarea5parameters.FilePath = e.FullPath;
                            if (tarea5parameters.INEmode)
                            {
                                tarea5parameters.FilePath = GetINEpath(e.FullPath);
                            }
                            PrintPDFs(tarea5parameters.FilePath);
                            break;
                        default:
                            break;
                    }
                    
                }
                else
                {
                    //default print
                    if (INE_mode)
                    {
                        Console.WriteLine("Sending MAIN TASK to INE print");
                        PrintPDFs(GetINEpath(e.FullPath));
                    }
                    else
                    {
                        Console.WriteLine("Sending MAIN TASK to print");
                        PrintPDFs(e.FullPath);
                    }
                }

            }
            else
            {
                Console.WriteLine("Command Not Created, Copies are turned off");
            }


        }

        

        public static void PrintPDFs(string pdfFileName)
        {
            //string arguments = $"{printer} -print-settings \"{numberOfCopies}x, noscale, {mode}, paper={paper}\" -exit-when-done ";
            string arguments = "";

            if (form.CheckForActiveTasks())
            {
                bool tareaExecuted = false;
                switch (ActiveTaskCount)
                {
                    case 1:
                        arguments = tarea1parameters.GetParameters();

                        form.ventasTextBox.Invoke(new Action(()
                            => form.ventasTextBox.AppendText(Environment.NewLine + tarea1parameters.PrintVentas())));
                        TotalVentas += tarea1parameters.Total;

                        form.tarea1checkBox.Invoke(new Action(() => form.tarea1checkBox.Checked = false));
                        form.tarea1INE.Invoke(new Action(() => form.tarea1INE.Checked = false));
                        form.tarea1mode.Invoke(new Action(() => form.tarea1mode.Checked = false));
                        form.tarea1copies.Invoke(new Action(() => form.tarea1copies.Value = 1));

                        tarea1parameters.ResetParameters();
                        tareaExecuted = true;
                        break;
                    case 2:
                        arguments = tarea2parameters.GetParameters();

                        form.ventasTextBox.Invoke(new Action(()
                            => form.ventasTextBox.AppendText(Environment.NewLine + tarea2parameters.PrintVentas())));
                        TotalVentas += tarea2parameters.Total;

                        form.tarea2checkBox.Invoke(new Action(() => form.tarea2checkBox.Checked = false));
                        form.tarea2INE.Invoke(new Action(() => form.tarea2INE.Checked = false));
                        form.tarea2mode.Invoke(new Action(() => form.tarea2mode.Checked = false));
                        form.tarea2copies.Invoke(new Action(() => form.tarea2copies.Value = 1));

                        tarea2parameters.ResetParameters();
                        tareaExecuted = true;
                        break;
                    case 3:
                        arguments = tarea3parameters.GetParameters();
                        Console.WriteLine("Printing Tarea #3\n" + arguments + pdfFileName);
                        Console.WriteLine($"Paper: {tarea3parameters.Paper}, Mode: {tarea3parameters.Mode}, " +
                            $"# of copies: {tarea3parameters.NumberOfCopies}, INE Mode: {tarea3parameters.INEmode}");

                        form.ventasTextBox.Invoke(new Action(()
                            => form.ventasTextBox.AppendText(Environment.NewLine + tarea3parameters.PrintVentas())));
                        TotalVentas += tarea3parameters.Total;

                        form.tarea3checkBox.Invoke(new Action(() => form.tarea3checkBox.Checked = false));
                        form.tarea3INE.Invoke(new Action(() => form.tarea3INE.Checked = false));
                        form.tarea3mode.Invoke(new Action(() => form.tarea3mode.Checked = false));
                        form.tarea3copies.Invoke(new Action(() => form.tarea3copies.Value = 1));

                        tarea3parameters.ResetParameters();
                        tareaExecuted = true;
                        break;
                    case 4:
                        arguments = tarea4parameters.GetParameters();
                        Console.WriteLine("Printing Tarea #4\n" + arguments + pdfFileName);
                        Console.WriteLine($"Paper: {tarea4parameters.Paper}, Mode: {tarea4parameters.Mode}, " +
                            $"# of copies: {tarea4parameters.NumberOfCopies}, INE Mode: {tarea4parameters.INEmode}");

                        form.ventasTextBox.Invoke(new Action(()
                            => form.ventasTextBox.AppendText(Environment.NewLine + tarea4parameters.PrintVentas())));
                        TotalVentas += tarea4parameters.Total;
                        form.tarea4checkBox.Invoke(new Action(() => form.tarea4checkBox.Checked = false));
                        form.tarea4INE.Invoke(new Action(() => form.tarea4INE.Checked = false));
                        form.tarea4mode.Invoke(new Action(() => form.tarea4mode.Checked = false));
                        form.tarea4copies.Invoke(new Action(() => form.tarea4copies.Value = 1));

                        tarea4parameters.ResetParameters();
                        tareaExecuted = true;
                        break;
                    case 5:
                        arguments = tarea5parameters.GetParameters();
                        Console.WriteLine("Printing Tarea #5\n" + arguments + pdfFileName);
                        Console.WriteLine($"Paper: {tarea5parameters.Paper}, Mode: {tarea5parameters.Mode}, " +
                            $"# of copies: {tarea5parameters.NumberOfCopies}, INE Mode: {tarea5parameters.INEmode}");

                        form.ventasTextBox.Invoke(new Action(()
                            => form.ventasTextBox.AppendText(Environment.NewLine + tarea5parameters.PrintVentas())));
                        TotalVentas += tarea5parameters.Total;

                        form.tarea5checkBox.Invoke(new Action(() => form.tarea5checkBox.Checked = false));
                        form.tarea5INE.Invoke(new Action(() => form.tarea5INE.Checked = false));
                        form.tarea5mode.Invoke(new Action(() => form.tarea5mode.Checked = false));
                        form.tarea5copies.Invoke(new Action(() => form.tarea5copies.Value = 1));

                        tarea5parameters.ResetParameters();
                        tareaExecuted = true;
                        break;
                    default:
                        tarea1parameters.ResetParameters();
                        form.tarea1checkBox.Checked = false;
                        tarea2parameters.ResetParameters();
                        form.tarea2checkBox.Checked = false;
                        tarea3parameters.ResetParameters();
                        form.tarea3checkBox.Checked = false;
                        tarea4parameters.ResetParameters();
                        form.tarea4checkBox.Checked = false;
                        tarea5parameters.ResetParameters();
                        form.tarea5checkBox.Checked = false;
                        break;
                }

                if (form.CheckForActiveTasks())
                {
                    ActiveTaskCount++;
                    if (ActiveTaskCount > 5) ActiveTaskCount = 1;
                    if (!tareaExecuted) PrintPDFs(pdfFileName);
                }
                else
                {
                    form.ventasTextBox.Invoke(new Action(()
                        => form.ventasTextBox.AppendText(Environment.NewLine + "\tTOTAL\t$" + TotalVentas.ToString("0.00"))));

                    form.numericUpDown1.Invoke(new Action(() => form.numericUpDown1.Select(0, 1)));
                }
            }
            else
            {
                ActiveTaskCount = 1;

                Parameters mainParameter = new Parameters
                {
                    Paper = paper,
                    NumberOfCopies = numberOfCopies,
                    INEmode = INE_mode,
                    Mode = mode,
                    FilePath = pdfFileName,
                    Color = Color
                };
                Console.WriteLine("Printing MAIN TASK:\n" + mainParameter.GetParameters() + pdfFileName);

                arguments = mainParameter.GetParameters();

                form.ventasTextBox.Invoke(new Action(()
                        => form.ventasTextBox.AppendText(Environment.NewLine + mainParameter.PrintVentas())));
                TotalVentas += mainParameter.Total;
                form.ventasTextBox.Invoke(new Action(()
                        => form.ventasTextBox.AppendText(Environment.NewLine + "\tTOTAL\t$" + TotalVentas.ToString("0.00"))));

                form.numericUpDown1.Invoke(new Action(() => form.numericUpDown1.Select(0, 1)));
            }

            SumatraPrinter sumatraPrinter = new SumatraPrinter(arguments + pdfFileName);
            sumatraPrinter.Print();

        }

        public static string GetINEpath(string INEpath)
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\INEs\";
            string path = @"D:\INEs\";

            Directory.CreateDirectory(path);

            XPdfForm form = XPdfForm.FromFile(INEpath);

            if (form.PageCount < 2)
            {
                return INEpath;
            }

            PdfDocument document = new PdfDocument();
            // loop genera INEs
            for (int i = 1; i < form.PageCount; i += 2)
            {
                PdfPage page = document.AddPage();
                page.Size = PdfSharp.PageSize.Letter;
                XGraphics gfx = XGraphics.FromPdfPage(page);

                //form.PageNumber = 1;
                form.PageNumber = i;
                gfx.DrawImage(form, Settings.Default.X1, Settings.Default.Y1, form.PixelWidth, form.PixelHeight);
                //gfx.DrawImage(form, -180, 0, form.PixelWidth, form.PixelHeight);

                //form.PageNumber = 2;
                form.PageNumber = i + 1;
                gfx.DrawImage(form, Settings.Default.X2, Settings.Default.Y2, form.PixelWidth, form.PixelHeight);
                //gfx.DrawImage(form, -180, 396, form.PixelWidth, form.PixelHeight);

                XPen horizontalTopPen = new XPen(XColors.White, 4);
                XPen horizontalMidPen = new XPen(XColors.White, 8);
                XPen verticalPen = new XPen(XColors.White, 6);

                gfx.DrawLine(horizontalTopPen, 0, 0, 612, 0);
                gfx.DrawLine(horizontalMidPen, 0, 396, 612, 396);
                gfx.DrawLine(verticalPen, 612, 0, 612, 800);
            }
 

            string filename = $"INE-{Path.GetFileName(INEpath)}";
            document.Save(path + filename);

            form.Dispose();

            return (path + filename);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (INEcheckBox.Checked)
            {
                INE_mode = true;
                INEcheckBox.Checked = true;
                duplexCheckBox.Checked = false;
            } 
            else if (!INEcheckBox.Checked)
            {
                INE_mode = false;
            }
            
        }
        private void duplexCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (duplexCheckBox.Checked)
            {
                mode = "duplex";

                INEcheckBox.Checked = false;
                duplexCheckBox.Checked = true;
            }
            else if (!duplexCheckBox.Checked)
            {
                mode = "simplex";
            }
            
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numberOfCopies = (int) numericUpDown1.Value;
        }
        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            numberOfCopies = (int)numericUpDown1.Value;
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberOfCopies = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Stop!")
            {
                button1.Text = "Start!";
                button1.BackColor = System.Drawing.Color.Green;
                printStatus = false;
            }
            else if (button1.Text == "Start!")
            {
                button1.Text = "Stop!";
                button1.BackColor = System.Drawing.Color.Red;
                printStatus = true;
            }

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            INEcheckBox.Checked = false;
            duplexCheckBox.Checked = false;
            numericUpDown1.Value = 1;
            numericUpDown1.Focus();
            numericUpDown1.Select(0, 1);

            tarea1checkBox.Checked = false;
            tarea1INE.Checked = false;
            tarea1mode.Checked = false;
            tarea1copies.Value = 1;

            tarea2checkBox.Checked = false;
            tarea2INE.Checked = false;
            tarea2mode.Checked = false;
            tarea2copies.Value = 1;

            tarea3checkBox.Checked = false;
            tarea3INE.Checked = false;
            tarea3mode.Checked = false;
            tarea3copies.Value = 1;
            
            tarea4checkBox.Checked = false;
            tarea4INE.Checked = false;
            tarea4mode.Checked = false;
            tarea4copies.Value = 1;

            tarea5checkBox.Checked = false;
            tarea5INE.Checked = false;
            tarea5mode.Checked = false;
            tarea5copies.Value = 1;

            ActiveTasks = false;
            ActiveTaskCount = 1;
            tarea1parameters.ResetParameters();
            tarea2parameters.ResetParameters();
            tarea3parameters.ResetParameters();
            tarea4parameters.ResetParameters();
            tarea5parameters.ResetParameters();

            colorCheckBox.Checked = false;



        }

        private bool CheckForActiveTasks()
        {
            return ((tarea1checkBox.Checked 
                || tarea2checkBox.Checked
                || tarea3checkBox.Checked 
                || tarea4checkBox.Checked
                || tarea5checkBox.Checked) ||
                (tarea1parameters.Active 
                || tarea2parameters.Active 
                || tarea3parameters.Active 
                || tarea4parameters.Active 
                || tarea5parameters.Active));
        }

        //
        //  TAREA 1
        //
        private void tarea1checkBox_CheckedChanged(object sender, EventArgs e)
        {
            
            //string arguments = $"{printer} -print-settings \"{numberOfCopies}x, noscale, {mode}, paper={paper}\" -exit-when-done ";
            if (tarea1checkBox.Checked)
            {
                ActiveTasks = true;
                ActiveTaskCount = 1;
                tarea1parameters.Active = true;
                tarea1parameters.INEmode = tarea1INE.Checked ? true : false;
                tarea1parameters.NumberOfCopies = 
                    (int)tarea1copies.Value > 1 ? (int)tarea1copies.Value : 1;
                tarea1parameters.Mode = 
                    tarea1mode.Checked ? "duplex" : "simplex";
               
            } else 
            {
                tarea1INE.Checked = false;
                tarea1mode.Checked = false;
                tarea1copies.Value = 1;
                tarea1parameters.ResetParameters();
                ActiveTasks = CheckForActiveTasks();   
            }
        }
        private void tarea1mode_CheckedChanged(object sender, EventArgs e)
        {
            if(tarea1mode.Checked)
            {
                tarea1parameters.Mode = "duplex";
                tarea1checkBox.Checked = true;
                tarea1mode.Checked = true;
                tarea1INE.Checked = false;
            } else
            {
                tarea1parameters.Mode = "simplex";
            }
            
        }
        private void tarea1INE_CheckedChanged(object sender, EventArgs e)
        {
            if (tarea1INE.Checked)
            {
                tarea1parameters.INEmode = true;
                tarea1checkBox.Checked = true;
                tarea1mode.Checked = false;
                tarea1INE.Checked = true;
            } else
            {
                tarea1parameters.INEmode = false;
            }
            
        }
        private void tarea1copies_ValueChanged(object sender, EventArgs e)
        {
            tarea1parameters.NumberOfCopies = (int)tarea1copies.Value;
        }
        //
        //  TAREA 2
        //
        private void tarea2checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tarea2checkBox.Checked)
            {
                ActiveTasks = true;
                tarea2parameters.Active = true;
                tarea2parameters.INEmode = tarea2INE.Checked ? true : false;
                tarea2parameters.NumberOfCopies =
                    (int)tarea2copies.Value > 1 ? (int)tarea2copies.Value : 1;
                tarea2parameters.Mode =
                    tarea2mode.Checked ? "duplex" : "simplex";
            }
            else
            {
                tarea2INE.Checked = false;
                tarea2mode.Checked = false;
                tarea2copies.Value = 1;
                tarea2parameters.ResetParameters();
                ActiveTasks = CheckForActiveTasks();
            }
        }
        
        private void tarea2mode_CheckedChanged(object sender, EventArgs e)
        {
            if (tarea2mode.Checked)
            {
                tarea2parameters.Mode = "duplex";
                tarea2checkBox.Checked = true;
                tarea2mode.Checked = true;
                tarea2INE.Checked = false;
            } else
            {
                tarea2parameters.Mode = "simplex";
            }

        }
        private void tarea2INE_CheckedChanged(object sender, EventArgs e)
        {
            if (tarea2INE.Checked)
            {
                tarea1parameters.INEmode = true;
                tarea2checkBox.Checked = true;
                tarea2mode.Checked = false;
                tarea2INE.Checked = true;
            } else
            {
                tarea1parameters.INEmode = false;
            }
        }
        private void tarea2copies_ValueChanged(object sender, EventArgs e)
        {
            tarea2parameters.NumberOfCopies = (int)tarea2copies.Value;
        }

        //
        //  TAREA 3
        //
        private void tarea3checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tarea3checkBox.Checked)
            {
                ActiveTasks = true;
                tarea3parameters.Active = true;
                tarea3parameters.INEmode = tarea3INE.Checked ? true : false;
                tarea3parameters.NumberOfCopies =
                    (int)tarea3copies.Value > 1 ? (int)tarea3copies.Value : 1;
                tarea3parameters.Mode =
                    tarea3mode.Checked ? "duplex" : "simplex";
            }
            else
            {
                tarea3INE.Checked = false;
                tarea3mode.Checked = false;
                tarea3copies.Value = 1;
                tarea3parameters.ResetParameters();
                ActiveTasks = CheckForActiveTasks();
            }
        }
        private void tarea3INE_CheckedChanged(object sender, EventArgs e)
        {
            if (tarea3INE.Checked)
            {
                tarea3parameters.INEmode = true;
                tarea3checkBox.Checked = true;
                tarea3mode.Checked = false;
                tarea3INE.Checked = true;
            } else
            {
                tarea3parameters.INEmode = false;
            }
        }
        private void tarea3mode_CheckedChanged(object sender, EventArgs e)
        {
            if (tarea3mode.Checked)
            {
                tarea3parameters.Mode = "duplex";
                tarea3checkBox.Checked = true;
                tarea3mode.Checked = true;
                tarea3INE.Checked = false;
            } else
            {
                tarea3parameters.Mode = "simplex";
            }
        }
        private void tarea3copies_ValueChanged(object sender, EventArgs e)
        {
            tarea3parameters.NumberOfCopies = (int)tarea3copies.Value;
        }
        //
        //  TAREA 4
        //
        private void tarea4checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tarea4checkBox.Checked)
            {
                ActiveTasks = true;
                tarea4parameters.Active = true;
                tarea4parameters.INEmode = tarea4INE.Checked ? true : false;
                tarea4parameters.NumberOfCopies =
                    (int)tarea4copies.Value > 1 ? (int)tarea4copies.Value : 1;
                tarea4parameters.Mode =
                    tarea4mode.Checked ? "duplex" : "simplex";
            }
            else
            {
                tarea4INE.Checked = false;
                tarea4mode.Checked = false;
                tarea4copies.Value = 1;
                tarea4parameters.ResetParameters();
                ActiveTasks = CheckForActiveTasks();
            }
        }

        private void tarea4INE_CheckedChanged(object sender, EventArgs e)
        {
            
            if (tarea4INE.Checked)
            {
                tarea4parameters.INEmode = true;
                tarea4checkBox.Checked = true;
                tarea4mode.Checked = false;
                tarea4INE.Checked = true;
            } else
            {
                tarea4parameters.INEmode = false;
            }
        }

        private void tarea4mode_CheckedChanged(object sender, EventArgs e)
        {
            if (tarea4mode.Checked)
            {
                tarea4parameters.Mode = "duplex";
                tarea4checkBox.Checked = true;
                tarea4mode.Checked = true;
                tarea4INE.Checked = false;
            } else
            {
                tarea4parameters.Mode = "simplex";
            }
        }

        private void tarea4copies_ValueChanged(object sender, EventArgs e)
        {
            tarea4parameters.NumberOfCopies = (int)tarea4copies.Value;
        }
        //
        //  TAREA 5
        //
        private void tarea5checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tarea5checkBox.Checked)
            {
                ActiveTasks = true;
                tarea5parameters.Active = true;
                tarea5parameters.INEmode = tarea5INE.Checked ? true : false;
                tarea5parameters.NumberOfCopies =
                    (int)tarea5copies.Value > 1 ? (int)tarea5copies.Value : 1;
                tarea5parameters.Mode =
                    tarea5mode.Checked ? "duplex" : "simplex";
            }
            else
            {
                tarea5INE.Checked = false;
                tarea5mode.Checked = false;
                tarea5copies.Value = 1;
                tarea5parameters.ResetParameters();
                ActiveTasks = CheckForActiveTasks();
            }
        }

        private void tarea5INE_CheckedChanged(object sender, EventArgs e)
        {
            
            if (tarea5INE.Checked)
            {
                tarea5parameters.INEmode = true;
                tarea5checkBox.Checked = true;
                tarea5mode.Checked = false;
                tarea5INE.Checked = true;
            } else
            {
                tarea5parameters.INEmode = false;
            }
        }

        private void tarea5mode_CheckedChanged(object sender, EventArgs e)
        {
            
            if (tarea5mode.Checked)
            {
                tarea5parameters.Mode = "duplex";
                tarea5checkBox.Checked = true;
                tarea5mode.Checked = true;
                tarea5INE.Checked = false;
            } else
            {
                tarea5parameters.Mode = "simplex";
            }
        }

        private void tarea5copies_ValueChanged(object sender, EventArgs e)
        {
            tarea5parameters.NumberOfCopies = (int)tarea5copies.Value;
        }
        private bool hide = false;
        private void buttonShowHide_Click(object sender, EventArgs e)
        {
            if (hide == false)
            {
                this.Width = 216;
                hide = true;
                buttonShowHide.Text = ">>";
            } else
            {
                this.Width = 380;
                hide = false;
                buttonShowHide.Text = "<<";
            }
            
        }

        private void clearTextBox_Click(object sender, EventArgs e)
        {
            //var venta = new Venta();
            ventasTextBox.Text = "\tVentas";
            //Venta.ClearTotal();
            numericUpDown1.Select(0, 1);

            TotalVentas = 0M;
        }

        private void colorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (colorCheckBox.Checked == true)
            {
                Color = true;
                tarea1parameters.Color = true;
                tarea2parameters.Color = true;
                tarea3parameters.Color = true;
                tarea4parameters.Color = true;
                tarea5parameters.Color = true;
            } else if (colorCheckBox.Checked == false)
            {
                Color = false;
                tarea1parameters.Color = false;
                tarea2parameters.Color = false;
                tarea3parameters.Color = false;
                tarea4parameters.Color = false;
                tarea5parameters.Color = false;
            }
        }

        private void opcionesButton_Click(object sender, EventArgs e)
        {
            Opciones OpcionesForm = new Opciones();
            OpcionesForm.ShowDialog();
        }

        private void WatcherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
