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
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Location = new Point(396, 37);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(126, 25);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = " labelQuestion";
            // 
            // labelChoices1
            // 
            labelChoices1.AutoSize = true;
            labelChoices1.Location = new Point(402, 71);
            labelChoices1.Name = "labelChoices1";
            labelChoices1.Size = new Size(120, 25);
            labelChoices1.TabIndex = 1;
            labelChoices1.Text = "labelChoices1";
            // 
            // labelChoices2
            // 
            labelChoices2.AutoSize = true;
            labelChoices2.Location = new Point(402, 110);
            labelChoices2.Name = "labelChoices2";
            labelChoices2.Size = new Size(120, 25);
            labelChoices2.TabIndex = 2;
            labelChoices2.Text = "labelChoices2";
            // 
            // labelChoices3
            // 
            labelChoices3.AutoSize = true;
            labelChoices3.Location = new Point(402, 148);
            labelChoices3.Name = "labelChoices3";
            labelChoices3.Size = new Size(120, 25);
            labelChoices3.TabIndex = 3;
            labelChoices3.Text = "labelChoices3";
            // 
            // labelChoices4
            // 
            labelChoices4.AutoSize = true;
            labelChoices4.Location = new Point(402, 187);
            labelChoices4.Name = "labelChoices4";
            labelChoices4.Size = new Size(120, 25);
            labelChoices4.TabIndex = 4;
            labelChoices4.Text = "labelChoices4";
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(314, 265);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(112, 34);
            buttonPrev.TabIndex = 5;
            buttonPrev.Text = "前へ";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(511, 265);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(112, 34);
            buttonNext.TabIndex = 6;
            buttonNext.Text = "次へ";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click_1;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(402, 224);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(97, 25);
            labelResult.TabIndex = 7;
            labelResult.Text = "labelResult";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(labelResult);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrev);
            Controls.Add(labelChoices4);
            Controls.Add(labelChoices3);
            Controls.Add(labelChoices2);
            Controls.Add(labelChoices1);
            Controls.Add(labelQuestion);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
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
    }
}
