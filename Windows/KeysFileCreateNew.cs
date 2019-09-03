using KeysHolder.Classes;
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

namespace KeysHolder.Windows
{
    public partial class KeysFileCreateNew : Form
    {
        /// <summary>
        /// Variables
        /// </summary>
        DESControler desControler = new DESControler();

        /// <summary>
        /// Class constructor
        /// </summary>
        public KeysFileCreateNew()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run when create button clicked
        /// </summary>
        private void createBT_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" && passwordTB.Text != "" && pathTB.Text != "")
            {
                try
                {
                    if (!File.Exists(pathTB.Text + nameTB.Text + ".keys"))
                    {
                        var myCreate = File.CreateText(pathTB.Text + nameTB.Text + ".keys");
                        myCreate.Close();
                    }
                    StreamWriter streamWriter = new StreamWriter(pathTB.Text + nameTB.Text + ".keys");
                    streamWriter.WriteLine(desControler.DESEncryption(passwordTB.Text));
                    streamWriter.Close();
                    MessageBox.Show("File created properly ! Window will be close !", "Operation status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some error while creating new keys file. \n Error Code: " + ex.ToString(), "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Some gap is empty !", "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
