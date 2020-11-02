namespace WindowsFormsExample
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
            this.lbxData = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxData
            // 
            this.lbxData.FormattingEnabled = true;
            this.lbxData.ItemHeight = 25;
            this.lbxData.Location = new System.Drawing.Point(12, 12);
            this.lbxData.Name = "lbxData";
            this.lbxData.Size = new System.Drawing.Size(615, 279);
            this.lbxData.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdd.Location = new System.Drawing.Point(12, 321);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(127, 53);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEdit.Location = new System.Drawing.Point(145, 321);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(127, 53);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.DodgerBlue;
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRemove.Location = new System.Drawing.Point(465, 321);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(162, 53);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 389);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbxData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListBox lbxData;

        #endregion
    }
}

