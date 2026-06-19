using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watcher.Properties;

namespace Watcher
{
    public partial class Opciones : Form
    {
        static Opciones opciones;
        public Opciones()
        {
            opciones = this;
            
            InitializeComponent();

            LoadOptions();


        }

        private void LoadOptions()
        {
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                cartaPrinterComboBox.Items.Add(PrinterSettings.InstalledPrinters[i]);
                oficioPrinterComboBox.Items.Add(PrinterSettings.InstalledPrinters[i]);
                colorPrinterComboBox.Items.Add(PrinterSettings.InstalledPrinters[i]);
                inePrinterComboBox.Items.Add(PrinterSettings.InstalledPrinters[i]);
            }
            cartaPrinterComboBox.SelectedItem = Settings.Default.CartaPrinter;
            oficioPrinterComboBox.SelectedItem = Settings.Default.OficioPrinter;
            colorPrinterComboBox.SelectedItem = Settings.Default.ColorPrinter;
            inePrinterComboBox.SelectedItem = Settings.Default.INEPrinter;

            cartaPrecio.Text = Settings.Default.CartaPrecio.ToString();
            cartaDuplexPrecio.Text = Settings.Default.CartaDuplexPrecio.ToString();
            cartaColorPrecio.Text = Settings.Default.CartaColorPrecio.ToString();
            oficioPrecio.Text = Settings.Default.OficioPrecio.ToString();
            oficioDuplexPrecio.Text = Settings.Default.OficioDuplexPrecio.ToString();
            oficioColorPrecio.Text = Settings.Default.OficioColorPrecio.ToString();
            inePrecio.Text = Settings.Default.INEPrecio.ToString();
            ineColorPrecio.Text = Settings.Default.INEColorPrecio.ToString();

            scannerDirectory.Text = Settings.Default.ScannerDirectory;
        }

        private void examinarButton_Click(object sender, EventArgs e)
        {
            string selectedPath = "";
            var t = new Thread((ThreadStart)(() => {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.Cancel)
                    return;

                selectedPath = fbd.SelectedPath;
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            Console.WriteLine(selectedPath);
            scannerDirectory.Text = selectedPath;
            Settings.Default.ScannerDirectory = scannerDirectory.Text;
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
             
            Close();
        }
        private void cartaPrinterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (cartaPrinterComboBox.SelectedIndex != -1)
            {
                Settings.Default.CartaPrinter = cartaPrinterComboBox.Text;
            }
        }
        private void oficioPrinterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (oficioPrinterComboBox.SelectedIndex != -1)
            {
                Settings.Default.OficioPrinter = oficioPrinterComboBox.Text;
            }
        }

        private void colorPrinterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colorPrinterComboBox.SelectedIndex != -1)
            {
                Settings.Default.ColorPrinter = colorPrinterComboBox.Text;
            }
        }

        private void inePrinterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inePrinterComboBox.SelectedIndex != -1)
            {
                Settings.Default.INEPrinter = inePrinterComboBox.Text;
            }
        }

        private void cartaPrecio_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.CartaPrecio = Convert.ToDecimal(cartaPrecio.Text);
        }

        private void cartaDuplexPrecio_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.CartaDuplexPrecio = Convert.ToDecimal(cartaDuplexPrecio.Text);
        }

        private void cartaColorPrecio_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.CartaColorPrecio = Convert.ToDecimal(cartaColorPrecio.Text);
        }

        private void oficioPrecio_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.OficioPrecio = Convert.ToDecimal(oficioPrecio.Text);
        }

        private void oficioDuplexPrecio_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.OficioDuplexPrecio = Convert.ToDecimal(oficioDuplexPrecio.Text);
        }

        private void oficioColorPrecio_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.OficioColorPrecio = Convert.ToDecimal(oficioColorPrecio.Text);
        }

        private void inePrecio_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.INEPrecio = Convert.ToDecimal(inePrecio.Text);
        }
        private void ineColorPrecio_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.INEColorPrecio = Convert.ToDecimal(ineColorPrecio.Text);
        }

        private void ineOptionsButton_Click(object sender, EventArgs e)
        {
            INEadvancedOptions ineAdvancedOptions = new INEadvancedOptions();
            ineAdvancedOptions.ShowDialog();
        }

        private void resetOptionsButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
        }
    }
}
