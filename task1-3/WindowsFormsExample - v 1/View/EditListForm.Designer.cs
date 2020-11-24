using System.ComponentModel;

namespace WindowsFormsExample.View
{
    partial class EditListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.tbId = new System.Windows.Forms.NumericUpDown();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrevios = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.tbId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.imgPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(245, 198);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(224, 20);
            this.tbName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Birthday";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(338, 18);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 14;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(245, 225);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(224, 20);
            this.tbId.TabIndex = 13;
            // 
            // imgPhoto
            // 
            this.imgPhoto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imgPhoto.Location = new System.Drawing.Point(167, 12);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(159, 161);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPhoto.TabIndex = 9;
            this.imgPhoto.TabStop = false;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNext.Location = new System.Drawing.Point(577, 70);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(127, 53);
            this.btNext.TabIndex = 17;
            this.btNext.Text = ">>";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrevios
            // 
            this.btPrevios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btPrevios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btPrevios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPrevios.Location = new System.Drawing.Point(34, 70);
            this.btPrevios.Name = "btPrevios";
            this.btPrevios.Size = new System.Drawing.Size(127, 53);
            this.btPrevios.TabIndex = 16;
            this.btPrevios.Text = "<<";
            this.btPrevios.UseVisualStyleBackColor = false;
            this.btPrevios.Click += new System.EventHandler(this.btPrevios_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 268);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(794, 508);
            this.table.TabIndex = 18;
            // 
            // EditListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 788);
            this.Controls.Add(this.table);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrevios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.imgPhoto);
            this.Name = "EditListForm";
            this.Text = "EditListForm";
            ((System.ComponentModel.ISupportInitialize) (this.tbId)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.imgPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrevios;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.NumericUpDown tbId;
        private System.Windows.Forms.TextBox tbName;

        #endregion
    }
}