namespace WindowsFormsSort
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Texts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texts
            // 
            this.Texts.BackColor = System.Drawing.Color.LightCoral;
            this.Texts.Location = new System.Drawing.Point(39, 47);
            this.Texts.Multiline = true;
            this.Texts.Name = "Texts";
            this.Texts.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Texts.Size = new System.Drawing.Size(646, 290);
            this.Texts.TabIndex = 0;
            this.Texts.TextChanged += new System.EventHandler(this.Texts_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сортировка строк и чисел\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(39, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bubble Sort";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Location = new System.Drawing.Point(195, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Merge Sort";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RosyBrown;
            this.button3.Location = new System.Drawing.Point(195, 521);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Quick Sort";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RosyBrown;
            this.button4.Location = new System.Drawing.Point(39, 521);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 60);
            this.button4.TabIndex = 5;
            this.button4.Text = "Insertion Sort";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сортировать";
            // 
            // Timer
            // 
            this.Timer.BackColor = System.Drawing.Color.LightCoral;
            this.Timer.Location = new System.Drawing.Point(734, 47);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(134, 20);
            this.Timer.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(729, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Время сортировки\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1483, 647);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Texts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Texts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Timer;
        private System.Windows.Forms.Label label3;
    }
}

