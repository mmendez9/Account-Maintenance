namespace Account
{
    partial class Form2
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
            this.tbxNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btmAddNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNew
            // 
            this.tbxNew.Location = new System.Drawing.Point(45, 32);
            this.tbxNew.Name = "tbxNew";
            this.tbxNew.Size = new System.Drawing.Size(146, 20);
            this.tbxNew.TabIndex = 0;
            this.tbxNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account ";
            // 
            // btmAddNew
            // 
            this.btmAddNew.Location = new System.Drawing.Point(84, 58);
            this.btmAddNew.Name = "btmAddNew";
            this.btmAddNew.Size = new System.Drawing.Size(63, 25);
            this.btmAddNew.TabIndex = 2;
            this.btmAddNew.Text = "Add";
            this.btmAddNew.UseVisualStyleBackColor = true;
            this.btmAddNew.Click += new System.EventHandler(this.btmAddNew_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 101);
            this.Controls.Add(this.btmAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNew);
            this.Name = "Form2";
            this.Text = "Add New Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmAddNew;
    }
}