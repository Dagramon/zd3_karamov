
namespace zd3_karamov
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.numericUpDownBelok = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUglevod = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCalorie = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBelok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUglevod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(635, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(664, 115);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Название";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(664, 144);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.PlaceholderText = "Описание";
            this.textBoxDesc.Size = new System.Drawing.Size(100, 23);
            this.textBoxDesc.TabIndex = 3;
            // 
            // numericUpDownBelok
            // 
            this.numericUpDownBelok.DecimalPlaces = 1;
            this.numericUpDownBelok.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownBelok.Location = new System.Drawing.Point(664, 189);
            this.numericUpDownBelok.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBelok.Name = "numericUpDownBelok";
            this.numericUpDownBelok.Size = new System.Drawing.Size(100, 23);
            this.numericUpDownBelok.TabIndex = 4;
            // 
            // numericUpDownUglevod
            // 
            this.numericUpDownUglevod.DecimalPlaces = 1;
            this.numericUpDownUglevod.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownUglevod.Location = new System.Drawing.Point(664, 239);
            this.numericUpDownUglevod.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownUglevod.Name = "numericUpDownUglevod";
            this.numericUpDownUglevod.Size = new System.Drawing.Size(100, 23);
            this.numericUpDownUglevod.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Белок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Углевод";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество";
            // 
            // numericUpDownCalorie
            // 
            this.numericUpDownCalorie.DecimalPlaces = 1;
            this.numericUpDownCalorie.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownCalorie.Location = new System.Drawing.Point(664, 339);
            this.numericUpDownCalorie.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCalorie.Name = "numericUpDownCalorie";
            this.numericUpDownCalorie.Size = new System.Drawing.Size(100, 23);
            this.numericUpDownCalorie.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Калорийность";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Обычная",
            "Молочная"});
            this.comboBox1.Location = new System.Drawing.Point(653, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(664, 288);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.PlaceholderText = "Количество";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmount.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Удалить выбранную";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(653, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Удалить по имени";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(669, 426);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Имя для удаления";
            this.textBox1.Size = new System.Drawing.Size(105, 23);
            this.textBox1.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(683, 485);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 23);
            this.numericUpDown1.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(653, 514);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Удалить по индексу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(183, 489);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(255, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Посчитать качество выбранного";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(183, 518);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(255, 23);
            this.button7.TabIndex = 24;
            this.button7.Text = "Вывести информацию о выбранном";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownCalorie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownUglevod);
            this.Controls.Add(this.numericUpDownBelok);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBelok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUglevod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.NumericUpDown numericUpDownUglevod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.NumericUpDown numericUpDownBelok;
        private System.Windows.Forms.NumericUpDown numericUpDownCalorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
    }
}

