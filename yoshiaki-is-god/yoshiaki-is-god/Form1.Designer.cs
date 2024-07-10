namespace yoshiaki_is_god
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
            labelQuestion = new Label();
            labelChoices1 = new Label();
            labelChoices2 = new Label();
            labelChoices3 = new Label();
            labelChoices4 = new Label();
            buttonPrev = new Button();
            buttonNext = new Button();
            labelResult = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Location = new Point(317, 30);
            labelQuestion.Margin = new Padding(2, 0, 2, 0);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(105, 20);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = " labelQuestion";
            // 
            // labelChoices1
            // 
            labelChoices1.AutoSize = true;
            labelChoices1.Location = new Point(322, 57);
            labelChoices1.Margin = new Padding(2, 0, 2, 0);
            labelChoices1.Name = "labelChoices1";
            labelChoices1.Size = new Size(101, 20);
            labelChoices1.TabIndex = 1;
            labelChoices1.Text = "labelChoices1";
            labelChoices1.Click += labelChoices1_Click;
            // 
            // labelChoices2
            // 
            labelChoices2.AutoSize = true;
            labelChoices2.Location = new Point(322, 88);
            labelChoices2.Margin = new Padding(2, 0, 2, 0);
            labelChoices2.Name = "labelChoices2";
            labelChoices2.Size = new Size(101, 20);
            labelChoices2.TabIndex = 2;
            labelChoices2.Text = "labelChoices2";
            labelChoices2.Click += labelChoices2_Click;
            // 
            // labelChoices3
            // 
            labelChoices3.AutoSize = true;
            labelChoices3.Location = new Point(322, 118);
            labelChoices3.Margin = new Padding(2, 0, 2, 0);
            labelChoices3.Name = "labelChoices3";
            labelChoices3.Size = new Size(101, 20);
            labelChoices3.TabIndex = 3;
            labelChoices3.Text = "labelChoices3";
            labelChoices3.Click += labelChoices3_Click;
            // 
            // labelChoices4
            // 
            labelChoices4.AutoSize = true;
            labelChoices4.Location = new Point(322, 150);
            labelChoices4.Margin = new Padding(2, 0, 2, 0);
            labelChoices4.Name = "labelChoices4";
            labelChoices4.Size = new Size(101, 20);
            labelChoices4.TabIndex = 4;
            labelChoices4.Text = "labelChoices4";
            labelChoices4.Click += labelChoices4_Click;
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(251, 212);
            buttonPrev.Margin = new Padding(2);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(90, 27);
            buttonPrev.TabIndex = 5;
            buttonPrev.Text = "前へ";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(409, 212);
            buttonNext.Margin = new Padding(2);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(90, 27);
            buttonNext.TabIndex = 6;
            buttonNext.Text = "次へ";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click_1;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(322, 179);
            labelResult.Margin = new Padding(2, 0, 2, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(29, 20);
            labelResult.TabIndex = 7;
            labelResult.Text = "     ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(550, 179);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 8;
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(labelResult);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrev);
            Controls.Add(labelChoices4);
            Controls.Add(labelChoices3);
            Controls.Add(labelChoices2);
            Controls.Add(labelChoices1);
            Controls.Add(labelQuestion);
            Name = "Form1";
            Text = "問題";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQuestion;
        private Label labelChoices1;
        private Label labelChoices2;
        private Label labelChoices3;
        private Label labelChoices4;
        private Button buttonPrev;
        private Button buttonNext;
        private Label labelResult;
        private Label label5;
    }
}
