namespace SoftwareEngineeringAssignment
{
    partial class frmAddPerscription
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
            this.cmbDrugID = new System.Windows.Forms.ComboBox();
            this.cmbDrugName = new System.Windows.Forms.ComboBox();
            this.txtDrugDescription = new System.Windows.Forms.RichTextBox();
            this.lblDrugID = new System.Windows.Forms.Label();
            this.lblDrugName = new System.Windows.Forms.Label();
            this.lblDrugDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDrugID
            // 
            this.cmbDrugID.FormattingEnabled = true;
            this.cmbDrugID.Location = new System.Drawing.Point(359, 27);
            this.cmbDrugID.Name = "cmbDrugID";
            this.cmbDrugID.Size = new System.Drawing.Size(121, 21);
            this.cmbDrugID.TabIndex = 0;
            this.cmbDrugID.SelectedValueChanged += new System.EventHandler(this.cmbDrugID_SelectedValueChanged);
            // 
            // cmbDrugName
            // 
            this.cmbDrugName.FormattingEnabled = true;
            this.cmbDrugName.Location = new System.Drawing.Point(359, 67);
            this.cmbDrugName.Name = "cmbDrugName";
            this.cmbDrugName.Size = new System.Drawing.Size(390, 21);
            this.cmbDrugName.TabIndex = 1;
            this.cmbDrugName.SelectedValueChanged += new System.EventHandler(this.cmbDrugName_SelectedValueChanged);
            // 
            // txtDrugDescription
            // 
            this.txtDrugDescription.Location = new System.Drawing.Point(359, 107);
            this.txtDrugDescription.Name = "txtDrugDescription";
            this.txtDrugDescription.Size = new System.Drawing.Size(390, 183);
            this.txtDrugDescription.TabIndex = 2;
            this.txtDrugDescription.Text = "";
            // 
            // lblDrugID
            // 
            this.lblDrugID.AutoSize = true;
            this.lblDrugID.Location = new System.Drawing.Point(356, 9);
            this.lblDrugID.Name = "lblDrugID";
            this.lblDrugID.Size = new System.Drawing.Size(44, 13);
            this.lblDrugID.TabIndex = 3;
            this.lblDrugID.Text = "Drug ID";
            // 
            // lblDrugName
            // 
            this.lblDrugName.AutoSize = true;
            this.lblDrugName.Location = new System.Drawing.Point(356, 51);
            this.lblDrugName.Name = "lblDrugName";
            this.lblDrugName.Size = new System.Drawing.Size(61, 13);
            this.lblDrugName.TabIndex = 4;
            this.lblDrugName.Text = "Drug Name";
            // 
            // lblDrugDescription
            // 
            this.lblDrugDescription.AutoSize = true;
            this.lblDrugDescription.Location = new System.Drawing.Point(356, 91);
            this.lblDrugDescription.Name = "lblDrugDescription";
            this.lblDrugDescription.Size = new System.Drawing.Size(86, 13);
            this.lblDrugDescription.TabIndex = 5;
            this.lblDrugDescription.Text = "Drug Description";
            // 
            // frmAddPerscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 334);
            this.Controls.Add(this.lblDrugDescription);
            this.Controls.Add(this.lblDrugName);
            this.Controls.Add(this.lblDrugID);
            this.Controls.Add(this.txtDrugDescription);
            this.Controls.Add(this.cmbDrugName);
            this.Controls.Add(this.cmbDrugID);
            this.Name = "frmAddPerscription";
            this.Text = "Add Perscription";
            this.Load += new System.EventHandler(this.frmAddPerscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrugID;
        private System.Windows.Forms.ComboBox cmbDrugName;
        private System.Windows.Forms.RichTextBox txtDrugDescription;
        private System.Windows.Forms.Label lblDrugID;
        private System.Windows.Forms.Label lblDrugName;
        private System.Windows.Forms.Label lblDrugDescription;
    }
}