namespace WindowsFormsExample
{
    partial class PersonForm
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
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.NumericUpDown();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.imgPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.tbId)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPhoto
            // 
            this.imgPhoto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imgPhoto.Location = new System.Drawing.Point(41, 54);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(159, 161);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPhoto.TabIndex = 0;
            this.imgPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(328, 54);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(224, 30);
            this.tbName.TabIndex = 3;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(328, 103);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(224, 30);
            this.tbId.TabIndex = 4;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(360, 164);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birthday";
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancel.Location = new System.Drawing.Point(424, 412);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(127, 53);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btApply
            // 
            this.btApply.BackColor = System.Drawing.Color.DodgerBlue;
            this.btApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btApply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btApply.Location = new System.Drawing.Point(291, 412);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(127, 53);
            this.btApply.TabIndex = 7;
            this.btApply.Text = "Apply";
            this.btApply.UseVisualStyleBackColor = false;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 487);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgPhoto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            ((System.ComponentModel.ISupportInitialize) (this.imgPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.tbId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbId;
        private System.Windows.Forms.TextBox tbName;

        #endregion
    }
}