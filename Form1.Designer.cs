namespace WinFormsApp2
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
            textBox_a = new TextBox();
            a = new Label();
            b = new Label();
            textBox_b = new TextBox();
            c = new Label();
            textBox_c = new TextBox();
            Result = new Label();
            Start = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 138);
            label1.Name = "label1";
            label1.Size = new Size(289, 45);
            label1.TabIndex = 0;
            label1.Text = "ax^2 + bx + c = 0";
            // 
            // textBox_a
            // 
            textBox_a.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_a.Location = new Point(82, 196);
            textBox_a.Name = "textBox_a";
            textBox_a.Size = new Size(107, 43);
            textBox_a.TabIndex = 1;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            a.Location = new Point(18, 196);
            a.Name = "a";
            a.Size = new Size(58, 37);
            a.TabIndex = 4;
            a.Text = "a =";
            a.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // b
            // 
            b.AutoSize = true;
            b.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            b.Location = new Point(18, 245);
            b.Name = "b";
            b.Size = new Size(60, 37);
            b.TabIndex = 6;
            b.Text = "b =";
            b.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_b
            // 
            textBox_b.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_b.Location = new Point(82, 245);
            textBox_b.Name = "textBox_b";
            textBox_b.Size = new Size(107, 43);
            textBox_b.TabIndex = 5;
            // 
            // c
            // 
            c.AutoSize = true;
            c.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            c.Location = new Point(18, 294);
            c.Name = "c";
            c.Size = new Size(56, 37);
            c.TabIndex = 8;
            c.Text = "c =";
            c.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_c
            // 
            textBox_c.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_c.Location = new Point(82, 294);
            textBox_c.Name = "textBox_c";
            textBox_c.Size = new Size(107, 43);
            textBox_c.TabIndex = 7;
            // 
            // Result
            // 
            Result.Font = new Font("Segoe UI Semibold", 20.2F, FontStyle.Bold | FontStyle.Italic);
            Result.ForeColor = SystemColors.ButtonHighlight;
            Result.Location = new Point(12, 358);
            Result.Name = "Result";
            Result.Size = new Size(472, 190);
            Result.TabIndex = 9;
            Result.Text = "Result";
            // 
            // Start
            // 
            Start.BackColor = Color.Sienna;
            Start.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Start.ForeColor = SystemColors.Menu;
            Start.Location = new Point(321, 138);
            Start.Name = "Start";
            Start.Size = new Size(129, 57);
            Start.TabIndex = 10;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(486, 67);
            label2.TabIndex = 11;
            label2.Text = "Програма для рахування квадратних рівнянь методом використання дискримінанту.";
            // 
            // label3
            // 
            label3.BackColor = Color.Sienna;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(497, 48);
            label3.TabIndex = 12;
            label3.Text = "Героєв К.М. ІПЗ 21";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 590);
            label4.Name = "label4";
            label4.Size = new Size(501, 57);
            label4.TabIndex = 13;
            label4.Text = "Введіть відповідні параметри для виконання та нажміть на кнопку";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(496, 645);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Start);
            Controls.Add(Result);
            Controls.Add(c);
            Controls.Add(textBox_c);
            Controls.Add(b);
            Controls.Add(textBox_b);
            Controls.Add(a);
            Controls.Add(textBox_a);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_a;
        private Label a;
        private Label b;
        private TextBox textBox_b;
        private Label c;
        private TextBox textBox_c;
        private Label Result;
        private Button Start;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
