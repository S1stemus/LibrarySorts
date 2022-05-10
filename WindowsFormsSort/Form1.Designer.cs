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
            this.Merge = new System.Windows.Forms.Button();
            this.quick = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Merge
            // 
            this.Merge.BackColor = System.Drawing.Color.RosyBrown;
            this.Merge.Location = new System.Drawing.Point(195, 445);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(122, 60);
            this.Merge.TabIndex = 3;
            this.Merge.Text = "Merge Sort";
            this.Merge.UseVisualStyleBackColor = false;
            // 
            // quick
            // 
            this.quick.BackColor = System.Drawing.Color.RosyBrown;
            this.quick.Location = new System.Drawing.Point(195, 521);
            this.quick.Name = "quick";
            this.quick.Size = new System.Drawing.Size(122, 60);
            this.quick.TabIndex = 4;
            this.quick.Text = "Quick Sort";
            this.quick.UseVisualStyleBackColor = false;
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.RosyBrown;
            this.insert.Location = new System.Drawing.Point(39, 521);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(122, 60);
            this.insert.TabIndex = 5;
            this.insert.Text = "Insertion Sort";
            this.insert.UseVisualStyleBackColor = false;
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(738, 110);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(167, 32);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По возрастанию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1483, 647);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.quick);
            this.Controls.Add(this.Merge);
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
        private System.Windows.Forms.Button Merge;
        private System.Windows.Forms.Button quick;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

