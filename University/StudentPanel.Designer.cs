namespace University
{
    partial class StudentPanel
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
            this.studentName = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.Label();
            this.btn_presentedLessons = new System.Windows.Forms.Button();
            this.btn_addRemove = new System.Windows.Forms.Button();
            this.btn_unitChoose = new System.Windows.Forms.Button();
            this.btn_editPassword = new System.Windows.Forms.Button();
            this.btn_getResult = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_passed_courses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.studentName.Location = new System.Drawing.Point(74, 9);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(59, 23);
            this.studentName.TabIndex = 10;
            this.studentName.Text = "علی نجفی";
            this.studentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentId
            // 
            this.studentId.AutoSize = true;
            this.studentId.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.studentId.Location = new System.Drawing.Point(74, 50);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(73, 23);
            this.studentId.TabIndex = 11;
            this.studentId.Text = "965361038";
            this.studentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_presentedLessons
            // 
            this.btn_presentedLessons.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_presentedLessons.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_presentedLessons.Location = new System.Drawing.Point(5, 96);
            this.btn_presentedLessons.Name = "btn_presentedLessons";
            this.btn_presentedLessons.Size = new System.Drawing.Size(221, 48);
            this.btn_presentedLessons.TabIndex = 7;
            this.btn_presentedLessons.Text = "دروس ترم";
            this.btn_presentedLessons.UseVisualStyleBackColor = false;
            this.btn_presentedLessons.Click += new System.EventHandler(this.btn_presentedLessons_Click);
            // 
            // btn_addRemove
            // 
            this.btn_addRemove.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_addRemove.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_addRemove.Location = new System.Drawing.Point(5, 314);
            this.btn_addRemove.Name = "btn_addRemove";
            this.btn_addRemove.Size = new System.Drawing.Size(221, 48);
            this.btn_addRemove.TabIndex = 9;
            this.btn_addRemove.Text = "حذف و اضافه";
            this.btn_addRemove.UseVisualStyleBackColor = false;
            this.btn_addRemove.Click += new System.EventHandler(this.btn_addRemove_Click);
            // 
            // btn_unitChoose
            // 
            this.btn_unitChoose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_unitChoose.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_unitChoose.Location = new System.Drawing.Point(5, 260);
            this.btn_unitChoose.Name = "btn_unitChoose";
            this.btn_unitChoose.Size = new System.Drawing.Size(221, 48);
            this.btn_unitChoose.TabIndex = 8;
            this.btn_unitChoose.Text = "انتخاب واحد";
            this.btn_unitChoose.UseVisualStyleBackColor = false;
            this.btn_unitChoose.Click += new System.EventHandler(this.btn_unitChoose_Click);
            // 
            // btn_editPassword
            // 
            this.btn_editPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_editPassword.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_editPassword.Location = new System.Drawing.Point(5, 370);
            this.btn_editPassword.Name = "btn_editPassword";
            this.btn_editPassword.Size = new System.Drawing.Size(221, 48);
            this.btn_editPassword.TabIndex = 12;
            this.btn_editPassword.Text = "تغییر رمز عبور";
            this.btn_editPassword.UseVisualStyleBackColor = false;
            this.btn_editPassword.Click += new System.EventHandler(this.btn_editPassword_Click);
            // 
            // btn_getResult
            // 
            this.btn_getResult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_getResult.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_getResult.Location = new System.Drawing.Point(5, 206);
            this.btn_getResult.Name = "btn_getResult";
            this.btn_getResult.Size = new System.Drawing.Size(221, 48);
            this.btn_getResult.TabIndex = 13;
            this.btn_getResult.Text = "کارنامه";
            this.btn_getResult.UseVisualStyleBackColor = false;
            this.btn_getResult.Click += new System.EventHandler(this.btn_getResult_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_back.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_back.Location = new System.Drawing.Point(5, 424);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(221, 48);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "برگشت";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_passed_courses
            // 
            this.btn_passed_courses.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_passed_courses.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_passed_courses.Location = new System.Drawing.Point(5, 151);
            this.btn_passed_courses.Name = "btn_passed_courses";
            this.btn_passed_courses.Size = new System.Drawing.Size(221, 48);
            this.btn_passed_courses.TabIndex = 15;
            this.btn_passed_courses.Text = "دروس گذرانده";
            this.btn_passed_courses.UseVisualStyleBackColor = false;
            this.btn_passed_courses.Click += new System.EventHandler(this.btn_passed_courses_Click);
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(233, 479);
            this.Controls.Add(this.btn_passed_courses);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.studentId);
            this.Controls.Add(this.btn_presentedLessons);
            this.Controls.Add(this.btn_addRemove);
            this.Controls.Add(this.btn_unitChoose);
            this.Controls.Add(this.btn_editPassword);
            this.Controls.Add(this.btn_getResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_passed_courses;
        private System.Windows.Forms.Button btn_getResult;
        private System.Windows.Forms.Button btn_editPassword;
        private System.Windows.Forms.Button btn_unitChoose;
        private System.Windows.Forms.Button btn_addRemove;
        private System.Windows.Forms.Button btn_presentedLessons;
        private System.Windows.Forms.Label studentId;
        private System.Windows.Forms.Label studentName;
    }
}