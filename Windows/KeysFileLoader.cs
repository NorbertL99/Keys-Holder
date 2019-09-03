using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysHolder.Windows
{
    public partial class KeysFileLoader : Form
    {
        /// <summary>
        /// Variables
        /// </summary>
        public string password { get; private set; }

        /// <summary>
        /// Class construcotr
        /// </summary>
        /// <param name="password">Password to file</param>
        public KeysFileLoader(string password)
        {
            this.password = password;
            InitializeComponent();
        }

        /// <summary>
        /// This method run when load button clicked
        /// </summary>
        private void loadBT_Click(object sender, EventArgs e)
        {
            if(passwordTB.Text != "")
            {
                if (passwordTB.Text == password)
                {
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Some gap is empty !", "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
