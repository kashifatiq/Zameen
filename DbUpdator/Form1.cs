using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
namespace DbUpdator
{
    public partial class Form1 : Form
    {
        private const string fldSchema = "\\Schema";
        private const string fldData = "\\Data";
        private const string fldFunctions = "\\Functions";
        private const string fldProcedures = "\\SPs";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestCon_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtConString.Text))
                    MessageBox.Show("Con String is empty");
                else
                {
                    using (SqlConnection connection = new SqlConnection(txtConString.Text.Trim()))
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open)
                        {
                            using (var command = new SqlCommand("select ISNULL(AppSettingValue,'') dbversion from AppSettings where AppSettingName = 'DbVersion'", connection))
                            {
                                command.CommandTimeout = 10000;
                                object dd = command.ExecuteScalar();
                                if (dd != null)
                                    lblDbVersion.Text = dd.ToString();
                                else
                                    lblDbVersion.Text = "0.0";
                            }
                            lblConStatus.Text = "OK";
                            lblConStatus.ForeColor = Color.Green;
                            MessageBox.Show("OK, Connection successful");
                        }
                        else
                        {
                            lblConStatus.Text = "Failed";
                            lblConStatus.ForeColor = Color.Red;
                            MessageBox.Show("Connection failed");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TEST CONNECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                txtConString.Text = ConfigurationManager.AppSettings["constr"];
                txtMainFolderPath.Text = Application.StartupPath;
                
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnBrowsFolders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Application.StartupPath;
            fbd.ShowDialog();
            txtMainFolderPath.Text = fbd.SelectedPath;
        }

        private void btnLoadSprints_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lstDirectories = Directory.GetDirectories(txtMainFolderPath.Text.Trim()).ToList();
                foreach (string directory in lstDirectories)
                {
                    chkSprintFolders.Items.Add(directory);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chkSprintFolders_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                chkSqlFiles.Items.Clear();

                foreach (string item in chkSprintFolders.CheckedItems)
                {
                    if (Directory.Exists(item + fldSchema) == true)
                    {
                        ListFiles(item + fldSchema);
                    }
                    if (Directory.Exists(item + fldData) == true)
                    {
                        ListFiles(item + fldData);
                    }
                    if (Directory.Exists(item + fldFunctions) == true)
                    {
                        ListFiles(item + fldData);
                    }
                    if (Directory.Exists(item + fldProcedures) == true)
                    {
                        ListFiles(item + fldData);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void ListFiles(string filesPath)
        {
            List<string> files = Directory.GetFiles(filesPath, "*.sql").ToList();
            foreach (string file in files)
            {
                chkSqlFiles.Items.Add(file, true);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                lstResults.Items.Clear();
                foreach (string item in chkSqlFiles.CheckedItems)
                {
                    string script = File.ReadAllText(item);
                    IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                    using (SqlConnection Connection = new SqlConnection(txtConString.Text.Trim()))
                    {
                        Connection.Open();
                        foreach (string commandString in commandStrings)
                        {
                            if (commandString.Trim() != "")
                            {
                                using (var command = new SqlCommand(commandString, Connection))
                                {
                                    try
                                    {
                                        command.CommandTimeout = 10000;
                                        command.ExecuteNonQuery();
                                        lstResults.Items.Add("DONE: "+ item);
                                    }
                                    catch (Exception ex)
                                    {
                                        lstResults.Items.Add(item + " : " + ex.Message);
                                    }
                                }
                            }
                        }
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
