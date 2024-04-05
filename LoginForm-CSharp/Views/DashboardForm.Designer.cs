namespace LoginForm_CSharp.Views
{
    partial class DashboardForm
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
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.DFirstName = new System.Windows.Forms.Label();
            this.DLastName = new System.Windows.Forms.Label();
            this.DOccupation = new System.Windows.Forms.Label();
            this.DUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePic
            // 
            this.ProfilePic.Location = new System.Drawing.Point(106, 80);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(100, 100);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 0;
            this.ProfilePic.TabStop = false;
            // 
            // DFirstName
            // 
            this.DFirstName.AutoSize = true;
            this.DFirstName.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFirstName.Location = new System.Drawing.Point(233, 212);
            this.DFirstName.Name = "DFirstName";
            this.DFirstName.Size = new System.Drawing.Size(52, 26);
            this.DFirstName.TabIndex = 1;
            this.DFirstName.Text = "fnam";
            // 
            // DLastName
            // 
            this.DLastName.AutoSize = true;
            this.DLastName.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLastName.Location = new System.Drawing.Point(233, 259);
            this.DLastName.Name = "DLastName";
            this.DLastName.Size = new System.Drawing.Size(60, 26);
            this.DLastName.TabIndex = 2;
            this.DLastName.Text = "lname";
            // 
            // DOccupation
            // 
            this.DOccupation.AutoSize = true;
            this.DOccupation.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOccupation.Location = new System.Drawing.Point(233, 353);
            this.DOccupation.Name = "DOccupation";
            this.DOccupation.Size = new System.Drawing.Size(50, 26);
            this.DOccupation.TabIndex = 3;
            this.DOccupation.Text = "occu";
            // 
            // DUserName
            // 
            this.DUserName.AutoSize = true;
            this.DUserName.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DUserName.Location = new System.Drawing.Point(233, 306);
            this.DUserName.Name = "DUserName";
            this.DUserName.Size = new System.Drawing.Size(66, 26);
            this.DUserName.TabIndex = 4;
            this.DUserName.Text = "uname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Occupation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name :";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(106, 399);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(102, 32);
            this.LogoutButton.TabIndex = 9;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 537);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DUserName);
            this.Controls.Add(this.DOccupation);
            this.Controls.Add(this.DLastName);
            this.Controls.Add(this.DFirstName);
            this.Controls.Add(this.ProfilePic);
            this.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfilePic;
        private System.Windows.Forms.Label DFirstName;
        private System.Windows.Forms.Label DLastName;
        private System.Windows.Forms.Label DOccupation;
        private System.Windows.Forms.Label DUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LogoutButton;
    }
}