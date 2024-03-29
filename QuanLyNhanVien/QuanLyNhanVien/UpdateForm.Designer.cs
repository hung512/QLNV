﻿namespace QuanLyNhanVien
{
    partial class UpdateForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtHomeTown = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(274, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 54);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 54);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(122, 202);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(274, 22);
            this.txtSalary.TabIndex = 39;
            // 
            // txtHomeTown
            // 
            this.txtHomeTown.Location = new System.Drawing.Point(122, 139);
            this.txtHomeTown.Name = "txtHomeTown";
            this.txtHomeTown.Size = new System.Drawing.Size(274, 22);
            this.txtHomeTown.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 22);
            this.txtName.TabIndex = 35;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(122, 32);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(274, 22);
            this.txtCode.TabIndex = 34;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(12, 203);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(48, 17);
            this.lblSalary.TabIndex = 33;
            this.lblSalary.Text = "Salary";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(12, 174);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(64, 17);
            this.lblRoom.TabIndex = 32;
            this.lblRoom.Text = "Room_Id";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(12, 142);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(79, 17);
            this.lblHome.TabIndex = 31;
            this.lblHome.Text = "HomeTown";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(12, 110);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(60, 17);
            this.lblBirth.TabIndex = 30;
            this.lblBirth.Text = "Birthday";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 32);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 17);
            this.lblCode.TabIndex = 28;
            this.lblCode.Text = "Code";
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(122, 105);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(274, 22);
            this.dtpDay.TabIndex = 42;
            // 
            // cbbRoom
            // 
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Location = new System.Drawing.Point(122, 171);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(274, 24);
            this.cbbRoom.TabIndex = 43;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 343);
            this.Controls.Add(this.cbbRoom);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtHomeTown);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtHomeTown;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.ComboBox cbbRoom;

    }
}