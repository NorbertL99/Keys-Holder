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
    public partial class SelectionView : Form
    {
        /// <summary>
        /// This method run when window open
        /// </summary>
        public SelectionView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run when applay selection clicked
        /// </summary>
        private void applayBT_Click(object sender, EventArgs e)
        {
            if(GetSelection() != null)
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

        /// <summary>
        /// This method is used to get selection
        /// </summary>
        /// <returns></returns>
        public string[] GetSelection()
        {
            string[] selectionArray = new string[3];
            if(whatTB.Text != "")
            {
                selectionArray[0] = fromCB.Text;
                selectionArray[1] = whereCB.Text;
                selectionArray[2] = whatTB.Text;
                return selectionArray;
            }
            else
            {
                MessageBox.Show("Some gap is empty !", "Error status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
