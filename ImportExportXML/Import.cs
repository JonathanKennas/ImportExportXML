using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportExportXML
{
    public class Import
    {
        public void imoprtFile()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Filen gick inte att importera. " + ex.Message);
            }
        }
    }
}
