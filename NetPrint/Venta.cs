using PdfSharp.Drawing;
using System;

namespace NetPrint
{
    public class Venta
    {

        private decimal precioINE = 2M;
        private decimal precioCarta = 1.50M;
        private decimal precioOficio = 2M;
        private decimal precioCartaDuplex = 2M;
        private decimal precioOficioDuplex = 3M;

        private string ventaMessage = "";
        private decimal total = 0; 
       

        public string GetText(Parameters parameters)
        {
            if (parameters.Color)
            {
                precioINE = 6M;
                precioCarta = 6M;
                precioOficio = 7M;
                precioCartaDuplex = 7M;
                precioOficioDuplex = 8M;
            }

            int pageCount = 1;
            string pageSize = parameters.Paper == "letter" ? "Carta" : "Oficio";
            decimal precioDuplex = pageSize == "Carta" ? precioCartaDuplex : precioOficioDuplex;
            decimal precioSize = pageSize == "Carta" ? precioCarta : precioOficio;

            if(parameters.FilePath != "")
            {
                XPdfForm xPdfForm = XPdfForm.FromFile(parameters.FilePath);
                pageCount = xPdfForm.PageCount <= 0 ? 1 : xPdfForm.PageCount;
                xPdfForm.Dispose();
            } else
            {
                if (parameters.INEmode) pageSize = "INE";
                return pageSize + " ERROR";
            }

            if (parameters.INEmode)
            {
                ventaMessage = $"INE ({pageCount * parameters.NumberOfCopies}): ${precioINE * ((decimal)pageCount) * parameters.NumberOfCopies}";
                total += (precioINE * ((decimal)pageCount) * parameters.NumberOfCopies);
                return ventaMessage;
            }

            switch (parameters.Mode)
            {
               case "simplex":
                    pageCount *= parameters.NumberOfCopies;
                    ventaMessage += $"{pageSize} ({pageCount}): ${precioSize * (decimal)pageCount}";
                    total += precioSize * pageCount;
                    break;

                case "duplex":
                    if (pageCount % 2 == 1) {
                        ventaMessage += $"{pageSize} ({parameters.NumberOfCopies}): ${precioSize * parameters.NumberOfCopies}\n";
                        total += precioSize * parameters.NumberOfCopies;
                        pageCount--; 
                    };
                    pageCount = (pageCount / 2) * parameters.NumberOfCopies;
                    ventaMessage += $"{pageSize} Duplex ({pageCount}): ${precioDuplex * (decimal)pageCount}";
                    total += precioDuplex * pageCount;
                    break;

                default:
                    break;
            }

            return ventaMessage;

        }

        public decimal GetResult()
        {
            return total;
        }
        public string GetTotal()
        {
            ventaMessage = "";
            return "\tTOTAL\t$" + total.ToString("0.00");
        }

        public void ClearTotal()
        {
            ventaMessage = "";
            total = 0;
        }

    }
}
