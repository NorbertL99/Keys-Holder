using KeysHolder.Classes;
using KeysHolder.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysHolder
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Variables
        /// </summary>
        DESControler desControler = new DESControler();
        List<KeysObjects> keysObjects = new List<KeysObjects>();
        string filePath = string.Empty;

        /// <summary>
        /// This method start when program run
        /// </summary>
        public MainWindow()
        {
            // Clearing daya view
            keysObjects.Clear();
            InitializeComponent();
        }

        /// <summary>
        /// This method run when load button clicked, this method loading keys file
        /// </summary>
        private void loadBT_Click(object sender, EventArgs e)
        {
            // If dialog from password is ok
            if(fileLoad.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath = fileLoad.FileName;
                    var fileStream = fileLoad.OpenFile();
                    StreamReader streamReader = new StreamReader(fileStream);
                    var password = desControler.DESDecryption(streamReader.ReadLine());
                    KeysFileLoader loader = new KeysFileLoader(password);
                    if (loader.ShowDialog() == DialogResult.OK)
                    {
                        streamReader.Close();
                        MessageBox.Show("File loaded properly !", "Operation status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Text = "KeysHolder - Current Load File [ " + filePath + " ] - Created by Norbert Lubaszka - Version 0.1";
                        KeysReader keysReader = new KeysReader(filePath);
                        keysObjects = keysReader.GetKeys();
                        RefreshView();
                    }
                    else if(loader.ShowDialog() == DialogResult.Abort)
                    {
                        streamReader.Close();
                        MessageBox.Show("Wrong password !", "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        filePath = string.Empty;
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some error while loading keys. \n Error code: " + ex.ToString(), "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// This method ryn when new button clicked
        /// </summary>
        private void newBT_Click(object sender, EventArgs e)
        {
            KeysFileCreateNew createNew = new KeysFileCreateNew();
            createNew.ShowDialog();
        }

        /// <summary>
        /// This method run when add button cliecked
        /// </summary>
        private void addBT_Click(object sender, EventArgs e)
        {
            if(filePath != string.Empty)
            {
                AddKey addKey = new AddKey(filePath);
                addKey.Show();
            }
            else
            {
                MessageBox.Show("First load or create keys file !", "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method is used to refresh keys data view
        /// </summary>
        private void RefreshView()
        {
            try
            {
                dataDGV.Rows.Clear();
                foreach (var keyObject in keysObjects)
                {
                    int RowIndex = dataDGV.Rows.Add();
                    dataDGV.Rows[RowIndex].Cells[0].Value = keyObject.platform;
                    dataDGV.Rows[RowIndex].Cells[1].Value = keyObject.login;
                    dataDGV.Rows[RowIndex].Cells[2].Value = keyObject.password;
                    dataDGV.Rows[RowIndex].Cells[3].Value = keyObject.description;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while refreshing view. \n Error code: " + ex.ToString(), "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method run when refresh button clicked
        /// </summary>

        private void refreshBT_Click(object sender, EventArgs e)
        {
            if(filePath != string.Empty)
            {
                KeysReader keysReader = new KeysReader(filePath);
                keysObjects = keysReader.GetKeys();
                RefreshView();
            }
            else
            {
                MessageBox.Show("First load or create keys file !", "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method run when generate button clicked
        /// </summary>
        private void generatorBT_Click(object sender, EventArgs e)
        {
            PasswordGenerator passwordGenerator = new PasswordGenerator();
            passwordGenerator.Show();
        }

        /// <summary>
        /// This method run when close button clicked
        /// </summary>
        private void closeBT_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = "KeysHolder - Current Load File[ none ] -Created by Norbert Lubaszka - Version 0.1";
                filePath = string.Empty;
                dataDGV.Rows.Clear();
                dataDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while clear view. \n Error code: " + ex.ToString(), "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method run when Show passwords button clicked
        /// </summary>
        private void showPassBT_Click(object sender, EventArgs e)
        {
            if (filePath != string.Empty)
            {
                StreamReader streamReader = new StreamReader(filePath);
                var password = desControler.DESDecryption(streamReader.ReadLine());
                streamReader.Close();
                KeysFileLoader loader = new KeysFileLoader(password);
                if (loader.ShowDialog() == DialogResult.OK)
                {
                    dataDGV.Columns[2].Visible = true;
                }
                else
                {
                    MessageBox.Show("Wrong password !", "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("First load or create keys file !", "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method run when Hide passwords button clicked
        /// </summary>
        private void hidePassBT_Click(object sender, EventArgs e)
        {
            if(filePath != string.Empty)
            {
                dataDGV.Columns[2].Visible = false;
            }
            else
            {
                MessageBox.Show("First load or create keys file !", "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method run when Selection button clicked
        /// </summary>
        private void selectionBT_Click(object sender, EventArgs e)
        {
            if(filePath != string.Empty)
            {
                string[] selectionArray = new string[3];
                SelectionView selectionView = new SelectionView();
                selectionView.ShowDialog();
                if (selectionView.DialogResult == DialogResult.OK)
                {
                    List<KeysObjects> keysObjects = new List<KeysObjects>();
                    selectionArray = selectionView.GetSelection();
                    int cell = 0;
                    string type = selectionArray[1];
                    string withCell = selectionArray[0];
                    switch (withCell)
                    {
                        case "PLATFORM":
                            cell = 0;
                            break;
                        case "LOGIN":
                            cell = 1;
                            break;
                        case "PASSWORD":
                            cell = 2;
                            break;
                        case "DESCRIPTION":
                            cell = 3;
                            break;
                    }
                    for (int i = 0; i < dataDGV.RowCount; i++)
                    {
                        string value = dataDGV.Rows[i].Cells[cell].Value.ToString();
                        if (type == "CONTAIN")
                        {
                            if (value.Contains(selectionArray[2]))
                            {
                                keysObjects.Add(new KeysObjects(dataDGV.Rows[i].Cells[0].Value.ToString(), dataDGV.Rows[i].Cells[1].Value.ToString(), dataDGV.Rows[i].Cells[2].Value.ToString(), dataDGV.Rows[i].Cells[3].Value.ToString()));
                            }
                        }
                        else if (type == "EQUAL")
                        {
                            if (value == selectionArray[2])
                            {
                                keysObjects.Add(new KeysObjects(dataDGV.Rows[i].Cells[0].Value.ToString(), dataDGV.Rows[i].Cells[1].Value.ToString(), dataDGV.Rows[i].Cells[2].Value.ToString(), dataDGV.Rows[i].Cells[3].Value.ToString()));
                            }
                        }
                    }
                    dataDGV.Rows.Clear();
                    dataDGV.Refresh();
                    foreach (var keyObject in keysObjects)
                    {
                        int RowIndex = dataDGV.Rows.Add();
                        dataDGV.Rows[RowIndex].Cells[0].Value = keyObject.platform;
                        dataDGV.Rows[RowIndex].Cells[1].Value = keyObject.login;
                        dataDGV.Rows[RowIndex].Cells[2].Value = keyObject.password;
                        dataDGV.Rows[RowIndex].Cells[3].Value = keyObject.description;
                    }
                }
            }
            else
            {
                MessageBox.Show("First load or create keys file !", "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
    }
}
