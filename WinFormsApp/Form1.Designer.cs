namespace WinFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.quick = new System.Windows.Forms.Button();
            this.merge = new System.Windows.Forms.Button();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сортировка строк и чисел";
            // 
            // textBoxSort
            // 
            this.textBoxSort.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxSort.Location = new System.Drawing.Point(31, 55);
            this.textBoxSort.Multiline = true;
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSort.Size = new System.Drawing.Size(445, 181);
            this.textBoxSort.TabIndex = 1;
            this.textBoxSort.TextChanged += new System.EventHandler(this.textBoxSort_TextChanged);
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxTime.Location = new System.Drawing.Point(536, 55);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(179, 23);
            this.textBoxTime.TabIndex = 2;
            this.textBoxTime.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(523, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время сортировки";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(529, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bubble sort";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.LightCoral;
            this.insert.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insert.Location = new System.Drawing.Point(661, 116);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(92, 47);
            this.insert.TabIndex = 5;
            this.insert.Text = "Insertion sort";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // quick
            // 
            this.quick.BackColor = System.Drawing.Color.LightCoral;
            this.quick.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quick.Location = new System.Drawing.Point(529, 189);
            this.quick.Name = "quick";
            this.quick.Size = new System.Drawing.Size(92, 47);
            this.quick.TabIndex = 6;
            this.quick.Text = "Qiuck sort";
            this.quick.UseVisualStyleBackColor = false;
            this.quick.Click += new System.EventHandler(this.quick_Click);
            // 
            // merge
            // 
            this.merge.BackColor = System.Drawing.Color.LightCoral;
            this.merge.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.merge.Location = new System.Drawing.Point(661, 189);
            this.merge.Name = "merge";
            this.merge.Size = new System.Drawing.Size(92, 47);
            this.merge.TabIndex = 7;
            this.merge.Text = "Merge sort";
            this.merge.UseVisualStyleBackColor = false;
            this.merge.Click += new System.EventHandler(this.merge_Click);
            // 
            // textBoxRes
            // 
            this.textBoxRes.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxRes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxRes.Location = new System.Drawing.Point(31, 257);
            this.textBoxRes.Multiline = true;
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes.Size = new System.Drawing.Size(445, 181);
            this.textBoxRes.TabIndex = 8;
            // 
            // Plus
            // 
            this.Plus.AutoSize = true;
            this.Plus.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plus.Location = new System.Drawing.Point(529, 257);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(168, 32);
            this.Plus.TabIndex = 10;
            this.Plus.Text = "По возрастанию";
            this.Plus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.merge);
            this.Controls.Add(this.quick);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxSort);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button quick;
        private System.Windows.Forms.Button merge;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.CheckBox Plus;
    }
}
