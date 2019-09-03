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
    public partial class AddKey : Form
    {
        /// <summary>
        /// Variables
        /// </summary>
        DESControler desControler = new DESControler();
        public string filePath { get; private set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="filePath">Keys file path</param>
        public AddKey(string filePath)
        {
            this.filePath = filePath;
            InitializeComponent();
        }

        /// <summary>
        /// This method is used to add key to key file
        /// </summary>
        private void addBT_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader streamReader = new StreamReader(filePath);
                var content = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = new StreamWriter(filePath);
                streamWriter.WriteLine(content + desControler.DESEncryption(platformTB.Text + "{" + loginTB.Text + ";" + passwordTB.Text + ";" + descriptionTB.Text + "}"));
                streamWriter.Close();
                platformTB.Text = "";
                loginTB.Text = "";
                passwordTB.Text = "";
                descriptionTB.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding password. \n Error message: " + ex.ToString(), "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
