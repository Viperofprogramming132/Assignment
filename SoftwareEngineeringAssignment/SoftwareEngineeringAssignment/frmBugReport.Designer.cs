namespace SoftwareEngineeringAssignment
{
    partial class frmBugReport
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
            this.lblBug = new System.Windows.Forms.Label();
            this.txtBug = new System.Windows.Forms.RichTextBox();
            this.btnBug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBug
            // 
            this.lblBug.AutoSize = true;
            this.lblBug.Location = new System.Drawing.Point(13, 13);
            this.lblBug.Name = "lblBug";
            this.lblBug.Size = new System.Drawing.Size(172, 13);
            this.lblBug.TabIndex = 0;
            this.lblBug.Text = "Got a bug write it here and hit save";
            // 
            // txtBug
            // 
            this.txtBug.Location = new System.Drawing.Point(16, 43);
            this.txtBug.Name = "txtBug";
            this.txtBug.Size = new System.Drawing.Size(361, 187);
            this.txtBug.TabIndex = 1;
            this.txtBug.Text = "";
            // 
            // btnBug
            // 
            this.btnBug.Location = new System.Drawing.Point(12, 236);
            this.btnBug.Name = "btnBug";
            this.btnBug.Size = new System.Drawing.Size(75, 23);
            this.btnBug.TabIndex = 2;
            this.btnBug.Text = "Save";
            this.btnBug.UseVisualStyleBackColor = true;
            this.btnBug.Click += new System.EventHandler(this.btnBug_Click);
            // 
            // frmBugReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 313);
            this.Controls.Add(this.btnBug);
            this.Controls.Add(this.txtBug);
            this.Controls.Add(this.lblBug);
            this.Name = "frmBugReport";
            this.Text = "frmBugReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBug;
        private System.Windows.Forms.RichTextBox txtBug;
        private System.Windows.Forms.Button btnBug;
    }
}