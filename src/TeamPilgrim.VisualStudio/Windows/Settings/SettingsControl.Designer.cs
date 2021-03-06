﻿namespace JustAProgrammer.TeamPilgrim.VisualStudio.Windows.Settings
{
    partial class SettingsControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDefaultWorkItemAssociation = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEvaluatePolicies = new System.Windows.Forms.CheckBox();
            this.chkPreservePendingChangesLocally = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Work Item Association:";
            // 
            // cmbDefaultWorkItemAssociation
            // 
            this.cmbDefaultWorkItemAssociation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefaultWorkItemAssociation.FormattingEnabled = true;
            this.cmbDefaultWorkItemAssociation.Location = new System.Drawing.Point(162, 3);
            this.cmbDefaultWorkItemAssociation.Name = "cmbDefaultWorkItemAssociation";
            this.cmbDefaultWorkItemAssociation.Size = new System.Drawing.Size(183, 21);
            this.cmbDefaultWorkItemAssociation.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEvaluatePolicies);
            this.groupBox1.Controls.Add(this.chkPreservePendingChangesLocally);
            this.groupBox1.Location = new System.Drawing.Point(6, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shelving";
            // 
            // chkEvaluatePolicies
            // 
            this.chkEvaluatePolicies.AutoSize = true;
            this.chkEvaluatePolicies.Location = new System.Drawing.Point(6, 42);
            this.chkEvaluatePolicies.Name = "chkEvaluatePolicies";
            this.chkEvaluatePolicies.Size = new System.Drawing.Size(246, 17);
            this.chkEvaluatePolicies.TabIndex = 6;
            this.chkEvaluatePolicies.Text = "Evaluate policies and check-in before shelving";
            this.chkEvaluatePolicies.UseVisualStyleBackColor = true;
            // 
            // chkPreservePendingChangesLocally
            // 
            this.chkPreservePendingChangesLocally.AutoSize = true;
            this.chkPreservePendingChangesLocally.Location = new System.Drawing.Point(6, 19);
            this.chkPreservePendingChangesLocally.Name = "chkPreservePendingChangesLocally";
            this.chkPreservePendingChangesLocally.Size = new System.Drawing.Size(191, 17);
            this.chkPreservePendingChangesLocally.TabIndex = 5;
            this.chkPreservePendingChangesLocally.Text = "Preserve Pending Changes Locally";
            this.chkPreservePendingChangesLocally.UseVisualStyleBackColor = true;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDefaultWorkItemAssociation);
            this.Controls.Add(this.label1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(348, 110);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDefaultWorkItemAssociation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEvaluatePolicies;
        private System.Windows.Forms.CheckBox chkPreservePendingChangesLocally;

    }
}
