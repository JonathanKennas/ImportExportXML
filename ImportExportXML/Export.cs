using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportExportXML
{
    public class Export
    {
        public void exportFile()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Filen gick inte att exportera. " + ex.Message);
            }
        }
    }
}
