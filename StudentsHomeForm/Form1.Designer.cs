namespace StudentsHomeForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblStudentName = new Label();
            btnSearchFacility = new Button();
            btnBookFacility = new Button();
            btnSubmitReview = new Button();
            btnSubmitProfile = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 64);
            label1.Name = "label1";
            label1.Size = new Size(609, 40);
            label1.TabIndex = 0;
            label1.Text = "Inter-University Facility System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 173);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Welcome,";
            label2.Click += label2_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.BorderStyle = BorderStyle.Fixed3D;
            lblStudentName.Location = new Point(232, 173);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(350, 25);
            lblStudentName.TabIndex = 2;
            // 
            // btnSearchFacility
            // 
            btnSearchFacility.Location = new Point(191, 259);
            btnSearchFacility.Name = "btnSearchFacility";
            btnSearchFacility.Size = new Size(167, 29);
            btnSearchFacility.TabIndex = 3;
            btnSearchFacility.Text = "Search Facility";
            btnSearchFacility.UseVisualStyleBackColor = true;
            // 
            // btnBookFacility
            // 
            btnBookFacility.Location = new Point(191, 306);
            btnBookFacility.Name = "btnBookFacility";
            btnBookFacility.Size = new Size(167, 29);
            btnBookFacility.TabIndex = 4;
            btnBookFacility.Text = "Book Facility";
            btnBookFacility.UseVisualStyleBackColor = true;
            // 
            // btnSubmitReview
            // 
            btnSubmitReview.Location = new Point(389, 259);
            btnSubmitReview.Name = "btnSubmitReview";
            btnSubmitReview.Size = new Size(168, 29);
            btnSubmitReview.TabIndex = 5;
            btnSubmitReview.Text = "Submit Review";
            btnSubmitReview.UseVisualStyleBackColor = true;
            // 
            // btnSubmitProfile
            // 
            btnSubmitProfile.Location = new Point(389, 306);
            btnSubmitProfile.Name = "btnSubmitProfile";
            btnSubmitProfile.Size = new Size(167, 29);
            btnSubmitProfile.TabIndex = 6;
            btnSubmitProfile.Text = "My Profile";
            btnSubmitProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = SystemColors.ActiveCaption;
            btnLogOut.Location = new Point(191, 362);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 453);
            Controls.Add(btnLogOut);
            Controls.Add(btnSubmitProfile);
            Controls.Add(btnSubmitReview);
            Controls.Add(btnBookFacility);
            Controls.Add(btnSearchFacility);
            Controls.Add(lblStudentName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "StudentsHomeForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblStudentName;
        private Button btnSearchFacility;
        private Button btnBookFacility;
        private Button btnSubmitReview;
        private Button btnSubmitProfile;
        private Button btnLogOut;
    }
}
