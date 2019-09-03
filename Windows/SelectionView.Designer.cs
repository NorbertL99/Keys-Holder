namespace KeysHolder.Windows
{
    partial class SelectionView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionView));
            this.fromCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.whereCB = new System.Windows.Forms.ComboBox();
            this.whatTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.applayBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromCB
            // 
            this.fromCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromCB.FormattingEnabled = true;
            this.fromCB.Items.AddRange(new object[] {
            "PLATFORM",
            "LOGIN",
            "PASSWORD",
            "DESCRIPTION"});
            this.fromCB.Location = new System.Drawing.Point(88, 12);
            this.fromCB.Name = "fromCB";
            this.fromCB.Size = new System.Drawing.Size(130, 28);
            this.fromCB.TabIndex = 1;
            this.fromCB.Text = "PLATFORM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "WHERE";
            // 
            // whereCB
            // 
            this.whereCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.whereCB.FormattingEnabled = true;
            this.whereCB.Items.AddRange(new object[] {
            "CONTAIN",
            "EQUAL"});
            this.whereCB.Location = new System.Drawing.Point(88, 49);
            this.whereCB.Name = "whereCB";
            this.whereCB.Size = new System.Drawing.Size(130, 28);
            this.whereCB.TabIndex = 3;
            this.whereCB.Text = "CONTAIN";
            // 
            // whatTB
            // 
            this.whatTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.whatTB.Location = new System.Drawing.Point(16, 83);
            this.whatTB.Name = "whatTB";
            this.whatTB.Size = new System.Drawing.Size(202, 27);
            this.whatTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "FROM";
            // 
            // applayBT
            // 
            this.applayBT.Location = new System.Drawing.Point(16, 116);
            this.applayBT.Name = "applayBT";
            this.applayBT.Size = new System.Drawing.Size(202, 37);
            this.applayBT.TabIndex = 11;
            this.applayBT.Text = "Applay selection";
            this.applayBT.UseVisualStyleBackColor = true;
            this.applayBT.Click += new System.EventHandler(this.applayBT_Click);
            // 
            // SelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 168);
            this.Controls.Add(this.applayBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.whatTB);
            this.Controls.Add(this.whereCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectionView";
            this.Text = "Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox fromCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox whereCB;
        private System.Windows.Forms.TextBox whatTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button applayBT;
    }
}