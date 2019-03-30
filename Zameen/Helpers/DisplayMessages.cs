using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HtmlReader.Helpers
{
    public static class DisplayMessages
    {
        public static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowDbOperation(string message,bool isError)
        {
            if (isError == false)
                MessageBox.Show(message, "Data base operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(message, "Data base operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
