namespace Lab9
{
    partial class fMain
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
            this.tbx1min = new System.Windows.Forms.TextBox();
            this.tbx2min = new System.Windows.Forms.TextBox();
            this.tbx1max = new System.Windows.Forms.TextBox();
            this.tbx2max = new System.Windows.Forms.TextBox();
            this.tbdx1 = new System.Windows.Forms.TextBox();
            this.tbdx2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gv = new System.Windows.Forms.DataGridView();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx1min
            // 
            this.tbx1min.Location = new System.Drawing.Point(72, 7);
            this.tbx1min.Margin = new System.Windows.Forms.Padding(4);
            this.tbx1min.Name = "tbx1min";
            this.tbx1min.Size = new System.Drawing.Size(132, 22);
            this.tbx1min.TabIndex = 0;
            this.tbx1min.TextChanged += new System.EventHandler(this.tbx1min_TextChanged);
            // 
            // tbx2min
            // 
            this.tbx2min.Location = new System.Drawing.Point(72, 64);
            this.tbx2min.Margin = new System.Windows.Forms.Padding(4);
            this.tbx2min.Name = "tbx2min";
            this.tbx2min.Size = new System.Drawing.Size(132, 22);
            this.tbx2min.TabIndex = 1;
            this.tbx2min.TextChanged += new System.EventHandler(this.tbx2min_TextChanged);
            // 
            // tbx1max
            // 
            this.tbx1max.Location = new System.Drawing.Point(285, 7);
            this.tbx1max.Margin = new System.Windows.Forms.Padding(4);
            this.tbx1max.Name = "tbx1max";
            this.tbx1max.Size = new System.Drawing.Size(132, 22);
            this.tbx1max.TabIndex = 2;
            this.tbx1max.TextChanged += new System.EventHandler(this.tbx1max_TextChanged);
            // 
            // tbx2max
            // 
            this.tbx2max.Location = new System.Drawing.Point(285, 64);
            this.tbx2max.Margin = new System.Windows.Forms.Padding(4);
            this.tbx2max.Name = "tbx2max";
            this.tbx2max.Size = new System.Drawing.Size(132, 22);
            this.tbx2max.TabIndex = 3;
            this.tbx2max.TextChanged += new System.EventHandler(this.tbx2max_TextChanged);
            // 
            // tbdx1
            // 
            this.tbdx1.Location = new System.Drawing.Point(484, 7);
            this.tbdx1.Margin = new System.Windows.Forms.Padding(4);
            this.tbdx1.Name = "tbdx1";
            this.tbdx1.Size = new System.Drawing.Size(132, 22);
            this.tbdx1.TabIndex = 4;
            this.tbdx1.TextChanged += new System.EventHandler(this.tbdx1_TextChanged);
            // 
            // tbdx2
            // 
            this.tbdx2.Location = new System.Drawing.Point(484, 64);
            this.tbdx2.Margin = new System.Windows.Forms.Padding(4);
            this.tbdx2.Name = "tbdx2";
            this.tbdx2.Size = new System.Drawing.Size(132, 22);
            this.tbdx2.TabIndex = 5;
            this.tbdx2.TextChanged += new System.EventHandler(this.tbdx2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "X1min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "X2min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "X1max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "X2max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "dX1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "dX2";
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(20, 96);
            this.gv.Margin = new System.Windows.Forms.Padding(4);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.Size = new System.Drawing.Size(597, 236);
            this.gv.TabIndex = 12;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(625, 96);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(164, 28);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Розрахувати";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(625, 145);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 28);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(625, 304);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 28);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Квадрати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbdx2);
            this.Controls.Add(this.tbdx1);
            this.Controls.Add(this.tbx2max);
            this.Controls.Add(this.tbx1max);
            this.Controls.Add(this.tbx2min);
            this.Controls.Add(this.tbx1min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMain";
            this.Text = "Лабораторна робота №9";
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx1min;
        private System.Windows.Forms.TextBox tbx2min;
        private System.Windows.Forms.TextBox tbx1max;
        private System.Windows.Forms.TextBox tbx2max;
        private System.Windows.Forms.TextBox tbdx1;
        private System.Windows.Forms.TextBox tbdx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}

