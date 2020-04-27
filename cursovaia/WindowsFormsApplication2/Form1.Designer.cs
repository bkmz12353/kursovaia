namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel = new System.Windows.Forms.PictureBox();
            this.Растения = new System.Windows.Forms.Label();
            this.Хищники = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPlants = new System.Windows.Forms.Label();
            this.lbPredators = new System.Windows.Forms.Label();
            this.lbHerbirove = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.plantdata = new System.Windows.Forms.TextBox();
            this.predatordata = new System.Windows.Forms.TextBox();
            this.planteaterdata = new System.Windows.Forms.TextBox();
            this.timedata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plantborntext = new System.Windows.Forms.Label();
            this.predatorborntext = new System.Windows.Forms.Label();
            this.planteaterbornеуче = new System.Windows.Forms.Label();
            this.plantborn = new System.Windows.Forms.TextBox();
            this.predatorborn = new System.Windows.Forms.TextBox();
            this.planteaterborn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1312, 632);
            this.panel.TabIndex = 0;
            this.panel.TabStop = false;
            this.panel.Click += new System.EventHandler(this.panel_Click);
            // 
            // Растения
            // 
            this.Растения.AutoSize = true;
            this.Растения.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Растения.ForeColor = System.Drawing.Color.Lime;
            this.Растения.Location = new System.Drawing.Point(12, 19);
            this.Растения.Name = "Растения";
            this.Растения.Size = new System.Drawing.Size(89, 20);
            this.Растения.TabIndex = 1;
            this.Растения.Text = "Растения";
            // 
            // Хищники
            // 
            this.Хищники.AutoSize = true;
            this.Хищники.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Хищники.ForeColor = System.Drawing.Color.Red;
            this.Хищники.Location = new System.Drawing.Point(12, 48);
            this.Хищники.Name = "Хищники";
            this.Хищники.Size = new System.Drawing.Size(84, 20);
            this.Хищники.TabIndex = 2;
            this.Хищники.Text = "Хищники";
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Травоядные";
            // 
            // lbPlants
            // 
            this.lbPlants.AccessibleDescription = "IbHerbirove";
            this.lbPlants.AccessibleName = "IbHerbirove";
            this.lbPlants.AutoSize = true;
            this.lbPlants.Location = new System.Drawing.Point(166, 21);
            this.lbPlants.Name = "lbPlants";
            this.lbPlants.Size = new System.Drawing.Size(152, 17);
            this.lbPlants.TabIndex = 4;
            this.lbPlants.Tag = "lbPlants";
            this.lbPlants.Text = "Количество растений";
            // 
            // lbPredators
            // 
            this.lbPredators.AutoSize = true;
            this.lbPredators.Location = new System.Drawing.Point(166, 48);
            this.lbPredators.Name = "lbPredators";
            this.lbPredators.Size = new System.Drawing.Size(153, 17);
            this.lbPredators.TabIndex = 5;
            this.lbPredators.Text = "Количество хищников";
            // 
            // lbHerbirove
            // 
            this.lbHerbirove.AutoSize = true;
            this.lbHerbirove.Location = new System.Drawing.Point(166, 76);
            this.lbHerbirove.Name = "lbHerbirove";
            this.lbHerbirove.Size = new System.Drawing.Size(168, 17);
            this.lbHerbirove.TabIndex = 6;
            this.lbHerbirove.Text = "Количество травоядных";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(512, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Смоделировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 221);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1288, 399);
            this.chart1.TabIndex = 100;
            this.chart1.Text = "chart1";
            // 
            // plantdata
            // 
            this.plantdata.Location = new System.Drawing.Point(357, 15);
            this.plantdata.Name = "plantdata";
            this.plantdata.Size = new System.Drawing.Size(100, 22);
            this.plantdata.TabIndex = 101;
            // 
            // predatordata
            // 
            this.predatordata.Location = new System.Drawing.Point(357, 43);
            this.predatordata.Name = "predatordata";
            this.predatordata.Size = new System.Drawing.Size(100, 22);
            this.predatordata.TabIndex = 102;
            // 
            // planteaterdata
            // 
            this.planteaterdata.Location = new System.Drawing.Point(357, 71);
            this.planteaterdata.Name = "planteaterdata";
            this.planteaterdata.Size = new System.Drawing.Size(100, 22);
            this.planteaterdata.TabIndex = 103;
            // 
            // timedata
            // 
            this.timedata.Location = new System.Drawing.Point(1013, 163);
            this.timedata.Name = "timedata";
            this.timedata.Size = new System.Drawing.Size(100, 22);
            this.timedata.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Количество времени";
            // 
            // plantborntext
            // 
            this.plantborntext.AccessibleName = "";
            this.plantborntext.AutoSize = true;
            this.plantborntext.Location = new System.Drawing.Point(542, 15);
            this.plantborntext.Name = "plantborntext";
            this.plantborntext.Size = new System.Drawing.Size(162, 17);
            this.plantborntext.TabIndex = 106;
            this.plantborntext.Text = "Рождаемость растений";
            this.plantborntext.Click += new System.EventHandler(this.label2_Click);
            // 
            // predatorborntext
            // 
            this.predatorborntext.AccessibleName = "";
            this.predatorborntext.AutoSize = true;
            this.predatorborntext.Location = new System.Drawing.Point(542, 42);
            this.predatorborntext.Name = "predatorborntext";
            this.predatorborntext.Size = new System.Drawing.Size(163, 17);
            this.predatorborntext.TabIndex = 107;
            this.predatorborntext.Text = "Рождаемость хищников";
            // 
            // planteaterbornеуче
            // 
            this.planteaterbornеуче.AccessibleName = "";
            this.planteaterbornеуче.AutoSize = true;
            this.planteaterbornеуче.Location = new System.Drawing.Point(542, 70);
            this.planteaterbornеуче.Name = "planteaterbornеуче";
            this.planteaterbornеуче.Size = new System.Drawing.Size(178, 17);
            this.planteaterbornеуче.TabIndex = 108;
            this.planteaterbornеуче.Text = "Рождаемость травоядных";
            // 
            // plantborn
            // 
            this.plantborn.Location = new System.Drawing.Point(735, 8);
            this.plantborn.Name = "plantborn";
            this.plantborn.Size = new System.Drawing.Size(100, 22);
            this.plantborn.TabIndex = 109;
            // 
            // predatorborn
            // 
            this.predatorborn.Location = new System.Drawing.Point(735, 37);
            this.predatorborn.Name = "predatorborn";
            this.predatorborn.Size = new System.Drawing.Size(100, 22);
            this.predatorborn.TabIndex = 110;
            // 
            // planteaterborn
            // 
            this.planteaterborn.Location = new System.Drawing.Point(735, 65);
            this.planteaterborn.Name = "planteaterborn";
            this.planteaterborn.Size = new System.Drawing.Size(100, 22);
            this.planteaterborn.TabIndex = 111;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 632);
            this.Controls.Add(this.planteaterborn);
            this.Controls.Add(this.predatorborn);
            this.Controls.Add(this.plantborn);
            this.Controls.Add(this.planteaterbornеуче);
            this.Controls.Add(this.predatorborntext);
            this.Controls.Add(this.plantborntext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timedata);
            this.Controls.Add(this.planteaterdata);
            this.Controls.Add(this.predatordata);
            this.Controls.Add(this.plantdata);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbHerbirove);
            this.Controls.Add(this.lbPredators);
            this.Controls.Add(this.lbPlants);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Хищники);
            this.Controls.Add(this.Растения);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Моделирование системы Хищник-Жертва";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox panel;
        private System.Windows.Forms.Label Растения;
        private System.Windows.Forms.Label Хищники;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPlants;
        private System.Windows.Forms.Label lbPredators;
        private System.Windows.Forms.Label lbHerbirove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox plantdata;
        private System.Windows.Forms.TextBox predatordata;
        private System.Windows.Forms.TextBox planteaterdata;
        private System.Windows.Forms.TextBox timedata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plantborntext;
        private System.Windows.Forms.Label predatorborntext;
        private System.Windows.Forms.Label planteaterbornеуче;
        private System.Windows.Forms.TextBox plantborn;
        private System.Windows.Forms.TextBox predatorborn;
        private System.Windows.Forms.TextBox planteaterborn;
    }
}

