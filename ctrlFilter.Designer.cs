﻿namespace DVLD
{
    partial class ctrlFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtbFilter = new System.Windows.Forms.MaskedTextBox();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtbFilter
            // 
            this.mtbFilter.Location = new System.Drawing.Point(264, 10);
            this.mtbFilter.Name = "mtbFilter";
            this.mtbFilter.Size = new System.Drawing.Size(199, 20);
            this.mtbFilter.TabIndex = 20;
            // 
            // cbIsActive
            // 
            this.cbIsActive.Enabled = false;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(264, 10);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(121, 21);
            this.cbIsActive.TabIndex = 19;
            this.cbIsActive.Visible = false;
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "UserID",
            "PersonID",
            "UserName",
            "FullName",
            "IsActive"});
            this.cbFilters.Location = new System.Drawing.Point(59, 10);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(199, 21);
            this.cbFilters.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filter By:";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::DVLD.Properties.Resources.find;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Location = new System.Drawing.Point(469, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(39, 32);
            this.btnFind.TabIndex = 21;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::DVLD.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(514, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 32);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // ctrlFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.mtbFilter);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label1);
            this.Name = "ctrlFilter";
            this.Size = new System.Drawing.Size(558, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbFilter;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
    }
}
