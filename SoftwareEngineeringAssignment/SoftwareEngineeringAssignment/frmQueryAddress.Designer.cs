namespace SoftwareEngineeringAssignment
{
    partial class frmQueryAddress
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPOBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(238, 146);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPOBox
            // 
            this.txtPOBox.Location = new System.Drawing.Point(103, 198);
            this.txtPOBox.Name = "txtPOBox";
            this.txtPOBox.Size = new System.Drawing.Size(100, 20);
            this.txtPOBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "POBox (Optional)";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(103, 172);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 14;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(11, 175);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "City";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(103, 146);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostCode.TabIndex = 12;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(11, 149);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(56, 13);
            this.lblPostCode.TabIndex = 11;
            this.lblPostCode.Text = "Post Code";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(11, 46);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(103, 43);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(210, 96);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Text = "";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(103, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 19;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(11, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 13);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "AddressID";
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBack.Location = new System.Drawing.Point(227, 181);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 37);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Enabled = false;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnForward.Location = new System.Drawing.Point(273, 181);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(40, 37);
            this.btnForward.TabIndex = 46;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // frmQueryAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 338);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPOBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Name = "frmQueryAddress";
            this.Text = "frmQueryAddress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQueryAddress_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPOBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
    }
}