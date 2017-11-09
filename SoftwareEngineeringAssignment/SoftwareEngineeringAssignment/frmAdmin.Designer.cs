namespace SoftwareEngineeringAssignment
{
    partial class frmAdmin
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
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnFindStaff = new System.Windows.Forms.Button();
            this.btnUI = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(12, 12);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(130, 40);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Add Staff Member";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnTimetable
            // 
            this.btnTimetable.Location = new System.Drawing.Point(148, 12);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(124, 40);
            this.btnTimetable.TabIndex = 1;
            this.btnTimetable.Text = "Timetable Staff Member";
            this.btnTimetable.UseVisualStyleBackColor = true;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // btnFindStaff
            // 
            this.btnFindStaff.Location = new System.Drawing.Point(12, 58);
            this.btnFindStaff.Name = "btnFindStaff";
            this.btnFindStaff.Size = new System.Drawing.Size(130, 40);
            this.btnFindStaff.TabIndex = 2;
            this.btnFindStaff.Text = "Find Staff Member";
            this.btnFindStaff.UseVisualStyleBackColor = true;
            this.btnFindStaff.Click += new System.EventHandler(this.btnFindStaff_Click);
            // 
            // btnUI
            // 
            this.btnUI.Location = new System.Drawing.Point(148, 58);
            this.btnUI.Name = "btnUI";
            this.btnUI.Size = new System.Drawing.Size(124, 40);
            this.btnUI.TabIndex = 3;
            this.btnUI.Text = "Change the User Interface";
            this.btnUI.UseVisualStyleBackColor = true;
            this.btnUI.Click += new System.EventHandler(this.btnUI_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(13, 226);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnUI);
            this.Controls.Add(this.btnFindStaff);
            this.Controls.Add(this.btnTimetable);
            this.Controls.Add(this.btnAddStaff);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnFindStaff;
        private System.Windows.Forms.Button btnUI;
        private System.Windows.Forms.Button btnMain;
    }
}