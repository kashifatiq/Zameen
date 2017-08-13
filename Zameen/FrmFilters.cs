using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HtmlReader
{
    public partial class FrmFilters : Form
    {
        ProjectEntities _db = new ProjectEntities();
        public FrmFilters()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SearchFilter newSearchFilter = new SearchFilter();
                newSearchFilter.Description = txtDescription.Text.Trim();
                newSearchFilter.FilterText = txtFilterText.Text.Trim();
                newSearchFilter.Title = txtTitle.Text.Trim();
                _db.SearchFilters.AddObject(newSearchFilter);
                _db.SaveChanges();
                MessageBox.Show("Data Saved", "Data base operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
