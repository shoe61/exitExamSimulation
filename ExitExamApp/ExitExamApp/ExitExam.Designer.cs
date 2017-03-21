namespace ExitExamApp
{
    partial class ExitExam
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
            this.exitExamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitExamButton
            // 
            this.exitExamButton.Location = new System.Drawing.Point(421, 327);
            this.exitExamButton.Name = "exitExamButton";
            this.exitExamButton.Size = new System.Drawing.Size(75, 23);
            this.exitExamButton.TabIndex = 0;
            this.exitExamButton.Text = "Exit";
            this.exitExamButton.UseVisualStyleBackColor = true;
            this.exitExamButton.Click += new System.EventHandler(this.exitExamButton_Click);
            // 
            // ExitExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 378);
            this.Controls.Add(this.exitExamButton);
            this.Name = "ExitExam";
            this.Text = "CS - Exit Exam";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitExamButton;
    }
}

