namespace SoftwareEngineeringAssignment
{
    partial class frmViewTimetable
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lsvTimeTable = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 13);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lsvTimeTable
            // 
            this.lsvTimeTable.Location = new System.Drawing.Point(13, 188);
            this.lsvTimeTable.Name = "lsvTimeTable";
            this.lsvTimeTable.Size = new System.Drawing.Size(744, 97);
            this.lsvTimeTable.TabIndex = 1;
            this.lsvTimeTable.UseCompatibleStateImageBehavior = false;
            // 
            // frmViewTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 372);
            this.Controls.Add(this.lsvTimeTable);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "frmViewTimetable";
            this.Text = "frmViewTimetable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListView lsvTimeTable;
    }
}