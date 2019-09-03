namespace KeysHolder
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dataDGV = new System.Windows.Forms.DataGridView();
            this.platformC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.teToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBT = new System.Windows.Forms.ToolStripMenuItem();
            this.newBT = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBT = new System.Windows.Forms.ToolStripMenuItem();
            this.keysSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBT = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPassBT = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePassBT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatorBT = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshBT = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLoad = new System.Windows.Forms.OpenFileDialog();
            this.selectionBT = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataDGV)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDGV
            // 
            this.dataDGV.AllowUserToAddRows = false;
            this.dataDGV.AllowUserToDeleteRows = false;
            this.dataDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.platformC,
            this.loginC,
            this.passwordC,
            this.descriptionC});
            this.dataDGV.Location = new System.Drawing.Point(11, 27);
            this.dataDGV.MultiSelect = false;
            this.dataDGV.Name = "dataDGV";
            this.dataDGV.Size = new System.Drawing.Size(843, 277);
            this.dataDGV.TabIndex = 0;
            // 
            // platformC
            // 
            this.platformC.HeaderText = "Platform";
            this.platformC.Name = "platformC";
            this.platformC.ReadOnly = true;
            this.platformC.Width = 200;
            // 
            // loginC
            // 
            this.loginC.HeaderText = "Login";
            this.loginC.Name = "loginC";
            this.loginC.ReadOnly = true;
            this.loginC.Width = 200;
            // 
            // passwordC
            // 
            this.passwordC.HeaderText = "Password";
            this.passwordC.Name = "passwordC";
            this.passwordC.ReadOnly = true;
            this.passwordC.Width = 200;
            // 
            // descriptionC
            // 
            this.descriptionC.HeaderText = "Description";
            this.descriptionC.Name = "descriptionC";
            this.descriptionC.ReadOnly = true;
            this.descriptionC.Width = 200;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teToolStripMenuItem,
            this.keysSettingToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.refreshBT});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(866, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // teToolStripMenuItem
            // 
            this.teToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadBT,
            this.newBT,
            this.closeBT});
            this.teToolStripMenuItem.Name = "teToolStripMenuItem";
            this.teToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.teToolStripMenuItem.Text = "Keys Files";
            // 
            // loadBT
            // 
            this.loadBT.Name = "loadBT";
            this.loadBT.Size = new System.Drawing.Size(180, 22);
            this.loadBT.Text = "Load";
            this.loadBT.Click += new System.EventHandler(this.loadBT_Click);
            // 
            // newBT
            // 
            this.newBT.Name = "newBT";
            this.newBT.Size = new System.Drawing.Size(180, 22);
            this.newBT.Text = "New";
            this.newBT.Click += new System.EventHandler(this.newBT_Click);
            // 
            // closeBT
            // 
            this.closeBT.Name = "closeBT";
            this.closeBT.Size = new System.Drawing.Size(180, 22);
            this.closeBT.Text = "Close";
            this.closeBT.Click += new System.EventHandler(this.closeBT_Click);
            // 
            // keysSettingToolStripMenuItem
            // 
            this.keysSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBT});
            this.keysSettingToolStripMenuItem.Name = "keysSettingToolStripMenuItem";
            this.keysSettingToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.keysSettingToolStripMenuItem.Text = "Keys Setting";
            // 
            // addBT
            // 
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(96, 22);
            this.addBT.Text = "Add";
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPassBT,
            this.hidePassBT,
            this.selectionBT});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showPassBT
            // 
            this.showPassBT.Name = "showPassBT";
            this.showPassBT.Size = new System.Drawing.Size(180, 22);
            this.showPassBT.Text = "Show passwords";
            this.showPassBT.Click += new System.EventHandler(this.showPassBT_Click);
            // 
            // hidePassBT
            // 
            this.hidePassBT.Name = "hidePassBT";
            this.hidePassBT.Size = new System.Drawing.Size(180, 22);
            this.hidePassBT.Text = "Hide passwords";
            this.hidePassBT.Click += new System.EventHandler(this.hidePassBT_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatorBT});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // generatorBT
            // 
            this.generatorBT.Name = "generatorBT";
            this.generatorBT.Size = new System.Drawing.Size(180, 22);
            this.generatorBT.Text = "Password Generator";
            this.generatorBT.Click += new System.EventHandler(this.generatorBT_Click);
            // 
            // refreshBT
            // 
            this.refreshBT.Name = "refreshBT";
            this.refreshBT.Size = new System.Drawing.Size(58, 20);
            this.refreshBT.Text = "Refresh";
            this.refreshBT.Click += new System.EventHandler(this.refreshBT_Click);
            // 
            // fileLoad
            // 
            this.fileLoad.FileName = "openFileDialog1";
            this.fileLoad.Filter = "keys files (*.keys)|*.keys";
            // 
            // selectionBT
            // 
            this.selectionBT.Name = "selectionBT";
            this.selectionBT.Size = new System.Drawing.Size(180, 22);
            this.selectionBT.Text = "Selection";
            this.selectionBT.Click += new System.EventHandler(this.selectionBT_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 316);
            this.Controls.Add(this.dataDGV);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "KeysHolder - Current Load File [  none  ] - Created by Norbert Lubaszka - Version" +
    " 0.1";
            ((System.ComponentModel.ISupportInitialize)(this.dataDGV)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformC;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginC;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordC;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionC;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem teToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBT;
        private System.Windows.Forms.ToolStripMenuItem newBT;
        private System.Windows.Forms.ToolStripMenuItem keysSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBT;
        private System.Windows.Forms.OpenFileDialog fileLoad;
        private System.Windows.Forms.ToolStripMenuItem refreshBT;
        private System.Windows.Forms.ToolStripMenuItem closeBT;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatorBT;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPassBT;
        private System.Windows.Forms.ToolStripMenuItem hidePassBT;
        private System.Windows.Forms.ToolStripMenuItem selectionBT;
    }
}

