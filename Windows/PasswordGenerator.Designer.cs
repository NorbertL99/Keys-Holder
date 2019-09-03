namespace KeysHolder.Windows
{
    partial class PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            this.lengthNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hasNumbers = new System.Windows.Forms.CheckBox();
            this.hasSmall = new System.Windows.Forms.CheckBox();
            this.hasBig = new System.Windows.Forms.CheckBox();
            this.hasSpecial = new System.Windows.Forms.CheckBox();
            this.generateBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // lengthNUD
            // 
            this.lengthNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lengthNUD.Location = new System.Drawing.Point(17, 36);
            this.lengthNUD.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.lengthNUD.Name = "lengthNUD";
            this.lengthNUD.Size = new System.Drawing.Size(266, 26);
            this.lengthNUD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // hasNumbers
            // 
            this.hasNumbers.AutoSize = true;
            this.hasNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasNumbers.Location = new System.Drawing.Point(17, 68);
            this.hasNumbers.Name = "hasNumbers";
            this.hasNumbers.Size = new System.Drawing.Size(193, 24);
            this.hasNumbers.TabIndex = 3;
            this.hasNumbers.Text = "Password has numbers";
            this.hasNumbers.UseVisualStyleBackColor = true;
            // 
            // hasSmall
            // 
            this.hasSmall.AutoSize = true;
            this.hasSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasSmall.Location = new System.Drawing.Point(17, 98);
            this.hasSmall.Name = "hasSmall";
            this.hasSmall.Size = new System.Drawing.Size(215, 24);
            this.hasSmall.TabIndex = 4;
            this.hasSmall.Text = "Password has small letters";
            this.hasSmall.UseVisualStyleBackColor = true;
            // 
            // hasBig
            // 
            this.hasBig.AutoSize = true;
            this.hasBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasBig.Location = new System.Drawing.Point(17, 128);
            this.hasBig.Name = "hasBig";
            this.hasBig.Size = new System.Drawing.Size(200, 24);
            this.hasBig.TabIndex = 5;
            this.hasBig.Text = "Password has big letters";
            this.hasBig.UseVisualStyleBackColor = true;
            // 
            // hasSpecial
            // 
            this.hasSpecial.AutoSize = true;
            this.hasSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasSpecial.Location = new System.Drawing.Point(17, 158);
            this.hasSpecial.Name = "hasSpecial";
            this.hasSpecial.Size = new System.Drawing.Size(221, 24);
            this.hasSpecial.TabIndex = 6;
            this.hasSpecial.Text = "Password has special signs";
            this.hasSpecial.UseVisualStyleBackColor = true;
            // 
            // generateBT
            // 
            this.generateBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateBT.Location = new System.Drawing.Point(17, 189);
            this.generateBT.Name = "generateBT";
            this.generateBT.Size = new System.Drawing.Size(266, 40);
            this.generateBT.TabIndex = 7;
            this.generateBT.Text = "Generate";
            this.generateBT.UseVisualStyleBackColor = true;
            this.generateBT.Click += new System.EventHandler(this.generateBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTB.Location = new System.Drawing.Point(17, 256);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.ReadOnly = true;
            this.passwordTB.Size = new System.Drawing.Size(266, 26);
            this.passwordTB.TabIndex = 9;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 297);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generateBT);
            this.Controls.Add(this.hasSpecial);
            this.Controls.Add(this.hasBig);
            this.Controls.Add(this.hasSmall);
            this.Controls.Add(this.hasNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lengthNUD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.lengthNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown lengthNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox hasNumbers;
        private System.Windows.Forms.CheckBox hasSmall;
        private System.Windows.Forms.CheckBox hasBig;
        private System.Windows.Forms.CheckBox hasSpecial;
        private System.Windows.Forms.Button generateBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTB;
    }
}