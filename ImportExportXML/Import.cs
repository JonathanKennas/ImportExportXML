using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
// Lägg till referens Microsoft Excel Object Library
//using Microsoft.Office.Interop.Excel;

namespace ImportExportXML
{
    public class Import
    {
        public void imoprtFile()
        {
            try
            {
                DialogResult drResult = OFD.ShowDialog();
                if (drResult == System.Windows.Forms.DialogResult.OK)
                    txtXmlFilePath.Text = OFD.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filen gick inte att importera. " + ex.Message);
            }
        }
    }
}
