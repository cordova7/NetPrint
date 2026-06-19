using PdfSharp.Drawing;
using System;
using NetPrint.Properties;

namespace NetPrint
{
    public class Parameters
    {
        //string arguments = $"{printer} -print-settings \"{numberOfCopies}x, noscale, {mode}, paper={paper}\" -exit-when-done ";
        //private string Printer = "-print-to-default";
        private string Printer = "-print-to \"" + Settings.Default.CartaPrinter + "\"";
        public int NumberOfCopies = 1;
        public string Mode = "simplex";
        public string Paper = "letter";
        public bool INEmode = false;
        public bool Active = false;
        public string FilePath = "";
        public decimal Total = 0M;
        public bool Color = false;
        

        public Parameters()
        {
            

        }

        public string PrintVentas()
        {
            Venta VentaMessage = new Venta();
            string ventas = VentaMessage.GetText(this);
            Total = VentaMessage.GetResult();
            return ventas;
        }
        public string GetParameters()
        {
            if (XPdfForm.FromFile(FilePath).PixelHeight > 900)
            {
                Paper = "legal";
                //Printer = "-print-to \"Oficio\"";
                Printer = "-print-to \"" + Settings.Default.OficioPrinter + "\"";
            } else if (Color)
            {
                //Printer = "-print-to \"Color\"";
                Printer = "-print-to \"" + Settings.Default.ColorPrinter + "\"";
            }
            
            return $"{Printer} -print-settings \"{NumberOfCopies}x, noscale, {Mode}, paper={Paper}\" -exit-when-done ";
        }

        public void ResetParameters()
        {
            Printer = "-print-to \"" + Settings.Default.CartaPrinter + "\"";
            NumberOfCopies = 1;
            Mode = "simplex";
            Paper = "letter";
            INEmode = false;
            Active = false;
            FilePath = "";
            Total = 0M;
        } 
    
    }
}
