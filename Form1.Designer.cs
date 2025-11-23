namespace Lipatov_Matvey_24VP2_KR
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            groupBox4 = new GroupBox();
            label6 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 1;
            label2.Text = "Размерность массива";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 53);
            numericUpDown1.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1000000000, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(277, 659);
            button1.Name = "button1";
            button1.Size = new Size(172, 29);
            button1.TabIndex = 3;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 659);
            button2.Name = "button2";
            button2.Size = new Size(250, 29);
            button2.TabIndex = 4;
            button2.Text = "Сортировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(21, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 92);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод значений";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(21, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 98);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Используемые алгоритмы сортировок";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 73);
            label5.Name = "label5";
            label5.Size = new Size(186, 20);
            label5.TabIndex = 2;
            label5.Text = "3. Сортировка подсчетом";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 53);
            label4.Name = "label4";
            label4.Size = new Size(279, 20);
            label4.TabIndex = 1;
            label4.Text = "2. Сортировка Шелла (шаг - Седжвика)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(223, 20);
            label3.TabIndex = 0;
            label3.Text = "1. Пирамидальная сортировка";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(21, 214);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(372, 152);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Тип сортируемого массива";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 121);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(267, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Частично упорядоченный массив";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(347, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Упорядоченный в обратном порядке массив";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(199, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Упорядоченный массив";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(216, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Неупорядоченный массив";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(21, 404);
            numericUpDown2.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 381);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 9;
            label1.Text = "Процент упорядоченности";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(21, 444);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(428, 189);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Поле для вывода ошибок";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 33);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 0;
            label6.Text = "Исключения";
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chartArea1.AxisX.LabelStyle.Format = "#'%';#'%',0%";
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Номер сортировки";
            chartArea1.AxisX2.Maximum = 100D;
            chartArea1.AxisY.Title = "Время сортировки";
            chartArea1.AxisY2.Maximum = 160D;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(473, 12);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Пирамидальная сортировка";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Сортировка Шелла (шаг - Седжвика)";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Сортировка подсчетом";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(604, 426);
            chart1.TabIndex = 12;
            chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Анализ времени алгоритмов сортировок";
            chart1.Titles.Add(title1);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dataGridView1.Location = new Point(473, 444);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(604, 255);
            dataGridView1.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.FillWeight = 294.1176F;
            Column1.HeaderText = "Тип сортировки";
            Column1.MaxInputLength = 1000000000;
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 80.58824F;
            Column2.HeaderText = "10%";
            Column2.MaxInputLength = 1000000000;
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 80.58824F;
            Column3.HeaderText = "20%";
            Column3.MaxInputLength = 1000000000;
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 80.58824F;
            Column4.HeaderText = "30%";
            Column4.MaxInputLength = 1000000000;
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 80.58824F;
            Column5.HeaderText = "40%";
            Column5.MaxInputLength = 1000000000;
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.FillWeight = 80.58824F;
            Column6.HeaderText = "50%";
            Column6.MaxInputLength = 1000000000;
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.FillWeight = 80.58824F;
            Column7.HeaderText = "60%";
            Column7.MaxInputLength = 1000000000;
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.FillWeight = 80.58824F;
            Column8.HeaderText = "70%";
            Column8.MaxInputLength = 1000000000;
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 80.58824F;
            Column9.HeaderText = "80%";
            Column9.MaxInputLength = 1000000000;
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.FillWeight = 80.58824F;
            Column10.HeaderText = "90%";
            Column10.MaxInputLength = 1000000000;
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.FillWeight = 80.58824F;
            Column11.HeaderText = "100%";
            Column11.MaxInputLength = 1000000000;
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 700);
            Controls.Add(dataGridView1);
            Controls.Add(chart1);
            Controls.Add(groupBox4);
            Controls.Add(numericUpDown2);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Lipatov_Matvey_24VP2_Course_Project";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox3;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
    }
}
