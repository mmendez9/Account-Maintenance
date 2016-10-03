namespace Account
{
    partial class Form1
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btmAdd = new System.Windows.Forms.Button();
            this.btmVer = new System.Windows.Forms.Button();
            this.btmDel = new System.Windows.Forms.Button();
            this.btmClear = new System.Windows.Forms.Button();
            this.btmExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(13, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(97, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Account List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 186);
            this.listBox1.TabIndex = 1;
            // 
            // btmAdd
            // 
            this.btmAdd.Location = new System.Drawing.Point(184, 37);
            this.btmAdd.Name = "btmAdd";
            this.btmAdd.Size = new System.Drawing.Size(75, 35);
            this.btmAdd.TabIndex = 2;
            this.btmAdd.Text = "Add Account";
            this.btmAdd.UseVisualStyleBackColor = true;
            this.btmAdd.Click += new System.EventHandler(this.btmAdd_Click);
            // 
            // btmVer
            // 
            this.btmVer.Location = new System.Drawing.Point(184, 78);
            this.btmVer.Name = "btmVer";
            this.btmVer.Size = new System.Drawing.Size(75, 36);
            this.btmVer.TabIndex = 3;
            this.btmVer.Text = "Verify Account";
            this.btmVer.UseVisualStyleBackColor = true;
            // 
            // btmDel
            // 
            this.btmDel.Location = new System.Drawing.Point(184, 120);
            this.btmDel.Name = "btmDel";
            this.btmDel.Size = new System.Drawing.Size(75, 36);
            this.btmDel.TabIndex = 4;
            this.btmDel.Text = "Delete Account";
            this.btmDel.UseVisualStyleBackColor = true;
            // 
            // btmClear
            // 
            this.btmClear.Location = new System.Drawing.Point(184, 162);
            this.btmClear.Name = "btmClear";
            this.btmClear.Size = new System.Drawing.Size(75, 23);
            this.btmClear.TabIndex = 5;
            this.btmClear.Text = "Clear List";
            this.btmClear.UseVisualStyleBackColor = true;
            // 
            // btmExit
            // 
            this.btmExit.Location = new System.Drawing.Point(184, 191);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(75, 23);
            this.btmExit.TabIndex = 6;
            this.btmExit.Text = "Exit";
            this.btmExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 238);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.btmClear);
            this.Controls.Add(this.btmDel);
            this.Controls.Add(this.btmVer);
            this.Controls.Add(this.btmAdd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Account Maintenance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btmAdd;
        private System.Windows.Forms.Button btmVer;
        private System.Windows.Forms.Button btmDel;
        private System.Windows.Forms.Button btmClear;
        private System.Windows.Forms.Button btmExit;
    }
}

