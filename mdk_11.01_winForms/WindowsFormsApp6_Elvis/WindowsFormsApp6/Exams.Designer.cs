namespace WindowsFormsApp6
{
    partial class Exams
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
            this.groupBoxVariant = new System.Windows.Forms.GroupBox();
            this.checkedListBoxAns = new System.Windows.Forms.CheckedListBox();
            this.buttonExam = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.groupBoxVariant.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVariant
            // 
            this.groupBoxVariant.Controls.Add(this.checkedListBoxAns);
            this.groupBoxVariant.Location = new System.Drawing.Point(12, 50);
            this.groupBoxVariant.Name = "groupBoxVariant";
            this.groupBoxVariant.Size = new System.Drawing.Size(416, 292);
            this.groupBoxVariant.TabIndex = 0;
            this.groupBoxVariant.TabStop = false;
            this.groupBoxVariant.Text = "Варианты ответа";
            // 
            // checkedListBoxAns
            // 
            this.checkedListBoxAns.FormattingEnabled = true;
            this.checkedListBoxAns.Location = new System.Drawing.Point(15, 38);
            this.checkedListBoxAns.Name = "checkedListBoxAns";
            this.checkedListBoxAns.Size = new System.Drawing.Size(377, 225);
            this.checkedListBoxAns.TabIndex = 0;
            // 
            // buttonExam
            // 
            this.buttonExam.Location = new System.Drawing.Point(444, 50);
            this.buttonExam.Name = "buttonExam";
            this.buttonExam.Size = new System.Drawing.Size(182, 36);
            this.buttonExam.TabIndex = 1;
            this.buttonExam.Text = "Следующий вопрос";
            this.buttonExam.UseVisualStyleBackColor = true;
            this.buttonExam.Click += new System.EventHandler(this.buttonExam_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(434, 335);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(182, 36);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Завершить тест";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(14, 12);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(44, 16);
            this.labelQuestion.TabIndex = 3;
            this.labelQuestion.Text = "label1";
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(670, 12);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(44, 16);
            this.labelHello.TabIndex = 4;
            this.labelHello.Text = "label1";
            // 
            // Exams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExam);
            this.Controls.Add(this.groupBoxVariant);
            this.Name = "Exams";
            this.Text = "Exams";
            this.Load += new System.EventHandler(this.Exams_Load);
            this.groupBoxVariant.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVariant;
        private System.Windows.Forms.CheckedListBox checkedListBoxAns;
        private System.Windows.Forms.Button buttonExam;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelHello;
    }
}