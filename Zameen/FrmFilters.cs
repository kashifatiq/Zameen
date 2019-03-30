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


                SearchFilter isAlreadyExists = (from objResult in _db.SearchFilters where objResult.FilterText == txtFilterText.Text select objResult).FirstOrDefault();
                if (isAlreadyExists != null)
                {
                    Helpers.DisplayMessages.ShowDbOperation("Filter Already Exists. Filter ID = " + isAlreadyExists.SearchFilterID.ToString(), true);
                }
                else
                {
                    SearchFilter newSearchFilter = new SearchFilter();
                    newSearchFilter.Description = txtDescription.Text.Trim();
                    newSearchFilter.FilterText = txtFilterText.Text.Trim();
                    newSearchFilter.Title = txtTitle.Text.Trim();
                    _db.SearchFilters.AddObject(newSearchFilter);
                    _db.SaveChanges();
                    Helpers.DisplayMessages.ShowDbOperation("New Search Filter Saved", false);
                }
            }
            catch (Exception ex)
            {
                Helpers.DisplayMessages.ShowError(ex);
            }
        }

        private void LoadGrid()
        {
            try
            {
                List<SearchFilter> lstFilters = (from objResult in _db.SearchFilters select objResult).ToList();
                dgFilter.DataSource = lstFilters;
                
            }
            catch (Exception ex)
            {
                Helpers.DisplayMessages.ShowError(ex);
            }
        }

        private void FrmFilters_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
