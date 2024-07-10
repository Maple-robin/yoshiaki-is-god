namespace yoshiaki_is_god
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            hitori = new Button();
            taisenn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 27);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 1;
            label1.Text = "都道府県文化財クイズ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(636, 73);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 2;
            // 
            // hitori
            // 
            hitori.Location = new Point(155, 136);
            hitori.Name = "hitori";
            hitori.Size = new Size(112, 34);
            hitori.TabIndex = 3;
            hitori.Text = "一人で";
            hitori.UseVisualStyleBackColor = true;
            hitori.Click += button2_Click;
            // 
            // taisenn
            // 
            taisenn.Location = new Point(462, 136);
            taisenn.Name = "taisenn";
            taisenn.Size = new Size(112, 34);
            taisenn.TabIndex = 4;
            taisenn.Text = "対戦";
            taisenn.UseVisualStyleBackColor = true;
            taisenn.Click += taisenn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(taisenn);
            Controls.Add(hitori);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "モード選択";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button hitori;
        private Button taisenn;
    }
}