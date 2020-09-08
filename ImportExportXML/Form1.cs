using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
// Referens Microsoft Excel Object Library
using Microsoft.Office.Interop.Excel;

// Länk till exempel: https://www.c-sharpcorner.com/article/convert-xml-file-to-excel-file/

namespace ImportExportXML
{
    public partial class Form1 : Form      
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult drResult = OFD.ShowDialog();
                if (drResult == System.Windows.Forms.DialogResult.OK)
                    txtbExcelFileName.Text = OFD.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filen gick inte att importera. " + ex.Message);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            progressBarConvert.Value = 0;
            if (chBoxName.Checked && txtbExcelFileName.Text != "" && txtbFilePath.Text != "") // Använder samma sökväg som importerade filen
            {
                if (File.Exists(txtbFilePath.Text))
                {
                    string CustXmlFilePath = Path.Combine(new FileInfo(txtbFilePath.Text).DirectoryName, txtbExcelFileName.Text); // Skapar sökvägen för XML-filen
                    System.Data.DataTable dt = CreateDataTableFromXml(txtbFilePath.Text);
                    ExportDataTableToExcel(dt, CustXmlFilePath);

                    MessageBox.Show("Konverteringen är klar.");
                }

            }
            else if (!chBoxName.Checked || txtbFilePath.Text != "") // Använder samma sökväg som importerade filen
            {
                if (File.Exists(txtbFilePath.Text))
                {
                    FileInfo fi = new FileInfo(txtbFilePath.Text);
                    string XlFile = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, ".xlsx");
                    System.Data.DataTable dt = CreateDataTableFromXml(txtbFilePath.Text);
                    ExportDataTableToExcel(dt, XlFile);

                    MessageBox.Show("Filen är konverterad.");
                }
            }
            else
            {
                MessageBox.Show("Fyll i alla fält!");
            }
        }
        public System.Data.DataTable CreateDataTableFromXml(string XmlFile)
        {

            System.Data.DataTable Dt = new System.Data.DataTable();
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(XmlFile);
                Dt.Load(ds.CreateDataReader());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Dt;
        }

        private void ExportDataTableToExcel(System.Data.DataTable table, string Xlfile)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook book = excel.Application.Workbooks.Add(Type.Missing);
            excel.Visible = false;
            excel.DisplayAlerts = false;
            Worksheet excelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
            excelWorkSheet.Name = table.TableName;

            progressBarConvert.Maximum = table.Columns.Count;
            for (int i = 1; i < table.Columns.Count + 1; i++) //Skapar huvudkollumner i Excel
            {
                excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                if (progressBarConvert.Value < progressBarConvert.Maximum)
                {
                    progressBarConvert.Value++;
                    int percent = (int)(((double)progressBarConvert.Value / (double)progressBarConvert.Maximum) * 100);
                    progressBarConvert.CreateGraphics().DrawString(percent.ToString() + "%", new System.Drawing.Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBarConvert.Width / 2 - 10, progressBarConvert.Height / 2 - 7));
                    System.Windows.Forms.Application.DoEvents();
                }
            }
            progressBarConvert.Maximum = table.Rows.Count;
            for (int j = 0; j < table.Rows.Count; j++) //Exporterar rader till excel
            {
                for (int k = 0; k < table.Columns.Count; k++)
                {
                    excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                }

                if (progressBarConvert.Value < progressBarConvert.Maximum)
                {
                    progressBarConvert.Value++;
                    int percent = (int)(((double)progressBarConvert.Value / (double)progressBarConvert.Maximum) * 100);
                    progressBarConvert.CreateGraphics().DrawString(percent.ToString() + "%", new System.Drawing.Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBarConvert.Width / 2 - 10, progressBarConvert.Height / 2 - 7));
                    System.Windows.Forms.Application.DoEvents();
                }
            }

            book.SaveAs(Xlfile);
            book.Close(true);
            excel.Quit();
            Marshal.ReleaseComObject(book);
            Marshal.ReleaseComObject(book);
            Marshal.ReleaseComObject(excel);
        }
    }
}
