namespace WindowsFormsApp1
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
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.btnShowCustomDialog = new System.Windows.Forms.Button();
            this.lblTB = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(100, 159);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(75, 23);
            this.btnShowDialog.TabIndex = 0;
            this.btnShowDialog.Text = "Show Alert";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.BtnShowDialog_Click);
            // 
            // btnShowCustomDialog
            // 
            this.btnShowCustomDialog.Location = new System.Drawing.Point(100, 305);
            this.btnShowCustomDialog.Name = "btnShowCustomDialog";
            this.btnShowCustomDialog.Size = new System.Drawing.Size(144, 23);
            this.btnShowCustomDialog.TabIndex = 1;
            this.btnShowCustomDialog.Text = "Show custom dialog";
            this.btnShowCustomDialog.UseVisualStyleBackColor = true;
            this.btnShowCustomDialog.Click += new System.EventHandler(this.BtnShowCustomDialog_Click);
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Location = new System.Drawing.Point(111, 198);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(52, 13);
            this.lblTB.TabIndex = 2;
            this.lblTB.Text = "Enter text";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(100, 226);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(250, 20);
            this.tbText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.btnShowCustomDialog);
            this.Controls.Add(this.btnShowDialog);
            this.Name = "Form1";
            this.Text = "My first Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Button btnShowCustomDialog;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.TextBox tbText;
    }
}

