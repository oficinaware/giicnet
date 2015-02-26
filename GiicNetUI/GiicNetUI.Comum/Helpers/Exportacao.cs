using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiicNetUI.Comum.Helpers
{
    class Exportacao
    {
        public static DataTable formatosExportacao()
        {
            DataTable formatosExportacao = new DataTable();
            formatosExportacao.Columns.Add("Formato", typeof(string));

            formatosExportacao.Rows.Add("Csv");
            formatosExportacao.Rows.Add("Html");
            formatosExportacao.Rows.Add("Pdf");
            formatosExportacao.Rows.Add("Excel");
            formatosExportacao.Rows.Add("Rtf");
            formatosExportacao.Rows.Add("Text");

            return formatosExportacao;
        }

        public static string exportar(GridControl grid, string formato)
        {
            if (!Directory.Exists(@"Exports\")) Directory.CreateDirectory(@"Exports\");
            switch(formato)
            {
                case "Csv":
                    try
                    {
                        grid.ExportToCsv(@"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".csv");
                        return @"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".csv";
                    }
                    catch(Exception eX)
                    {
                        return "Erro - " + eX.Message;
                    }
                case "Html":
                    try
                    {
                        grid.ExportToHtml(@"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".html");
                        return @"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".html";
                    }
                    catch(Exception eX)
                    {
                        return "Erro - " + eX.Message;
                    }
                case "Pdf":
                    try
                    {
                        grid.ExportToPdf(@"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".pdf");
                        return @"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".pdf";
                    }
                    catch(Exception eX)
                    {
                        return "Erro - " + eX.Message;
                    }
                case "Excel":
                    try
                    {
                        grid.ExportToXls(@"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".xls");
                        return @"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".xls";
                    }
                    catch(Exception eX)
                    {
                        return "Erro - " + eX.Message; 
                    }
                case "Rtf":
                    try
                    {
                        grid.ExportToRtf(@"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".rtf");
                        return @"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".rtf";
                    }
                    catch(Exception eX)
                    {
                        return "Erro - " + eX.Message; 
                    }
                case "Text":
                    try
                    {
                        grid.ExportToText(@"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".txt");
                        return @"Exports\" + grid.Tag + "_" + System.DateTime.Now.ToShortDateString() + ".txt";
                    }
                    catch(Exception eX)
                    {
                        return "Erro - " + eX.Message;  
                    }
                default:
                    return "Erro - Formato inválido!";
            }
        }
    }
}