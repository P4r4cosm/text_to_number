namespace text_to_number
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.answer1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.TextBox();
            this.right = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.TextBox();
            this.Ответ = new System.Windows.Forms.Label();
            this.answer2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число текстом: ";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(51, 117);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(244, 20);
            this.number.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(51, 156);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(244, 20);
            this.answer1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ответ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Задача 1 (русский язык)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(473, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Задача 2 (1-ый вариант)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Введите левую границу:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Введите правую границу:";
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(478, 156);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(246, 20);
            this.left.TabIndex = 9;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(478, 197);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(246, 20);
            this.right.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Ответ_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Введите текст:";
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(478, 117);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(246, 20);
            this.Text.TabIndex = 13;
            // 
            // Ответ
            // 
            this.Ответ.AutoSize = true;
            this.Ответ.Location = new System.Drawing.Point(476, 220);
            this.Ответ.Name = "Ответ";
            this.Ответ.Size = new System.Drawing.Size(37, 13);
            this.Ответ.TabIndex = 14;
            this.Ответ.Text = "Ответ";
            this.Ответ.Click += new System.EventHandler(this.Ответ_Click);
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(478, 236);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(243, 20);
            this.answer2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.Ответ);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox answer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox left;
        private System.Windows.Forms.TextBox right;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.Label Ответ;
        private System.Windows.Forms.TextBox answer2;
    }
}

