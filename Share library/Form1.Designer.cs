namespace Share_library
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4add = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6list = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5pages = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2lang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1383, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Push to login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1118, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1114, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter pass";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1383, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Push to remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1118, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 26);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1110, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID to remove";
            // 
            // button4add
            // 
            this.button4add.Location = new System.Drawing.Point(1383, 371);
            this.button4add.Name = "button4add";
            this.button4add.Size = new System.Drawing.Size(121, 36);
            this.button4add.TabIndex = 9;
            this.button4add.Text = "push to add";
            this.button4add.UseVisualStyleBackColor = true;
            this.button4add.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1118, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 26);
            this.textBox4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1114, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "add new author";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 882);
            this.dataGridView1.TabIndex = 14;
            // 
            // button6list
            // 
            this.button6list.Location = new System.Drawing.Point(1383, 640);
            this.button6list.Name = "button6list";
            this.button6list.Size = new System.Drawing.Size(121, 48);
            this.button6list.TabIndex = 15;
            this.button6list.Text = "datad grid";
            this.button6list.UseVisualStyleBackColor = true;
            this.button6list.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Drama",
            "Action",
            "Comedy",
            "Horror",
            "Adventure"});
            this.comboBox1.Location = new System.Drawing.Point(1118, 440);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 28);
            this.comboBox1.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1383, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 36);
            this.button5.TabIndex = 17;
            this.button5.Text = "push to sort";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1114, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Enter genre to sort";
            // 
            // textBox3title
            // 
            this.textBox3title.Location = new System.Drawing.Point(1118, 247);
            this.textBox3title.Name = "textBox3title";
            this.textBox3title.Size = new System.Drawing.Size(193, 26);
            this.textBox3title.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1114, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "add title";
            // 
            // textBox5pages
            // 
            this.textBox5pages.Location = new System.Drawing.Point(1118, 308);
            this.textBox5pages.Name = "textBox5pages";
            this.textBox5pages.Size = new System.Drawing.Size(193, 26);
            this.textBox5pages.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1114, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "add pages";
            // 
            // comboBox2lang
            // 
            this.comboBox2lang.FormattingEnabled = true;
            this.comboBox2lang.Items.AddRange(new object[] {
            "ENG",
            "RUS",
            "LAT"});
            this.comboBox2lang.Location = new System.Drawing.Point(1118, 376);
            this.comboBox2lang.Name = "comboBox2lang";
            this.comboBox2lang.Size = new System.Drawing.Size(193, 28);
            this.comboBox2lang.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1114, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "choose lang";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1100, 524);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 333);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 906);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2lang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5pages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3title);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6list);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4add;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6list;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5pages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2lang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

