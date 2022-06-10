
namespace _931903.gorbatyuk.anastasiya.lab12
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btStop = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbYasno = new System.Windows.Forms.Label();
            this.lbPas = new System.Windows.Forms.Label();
            this.lbDojd = new System.Windows.Forms.Label();
            this.lbPogoda = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 100);
            this.panel1.TabIndex = 0;
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(620, 37);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(167, 43);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Стоп";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(116, 37);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(175, 43);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Старт";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Погода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Аналитика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ясно, ожидаемое 40%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "пасмурно, ожидаемое 30%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "дождь, ожидаемое 30%";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Location = new System.Drawing.Point(95, 129);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(16, 17);
            this.lbDay.TabIndex = 7;
            this.lbDay.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "дней";
            // 
            // lbYasno
            // 
            this.lbYasno.AutoSize = true;
            this.lbYasno.Location = new System.Drawing.Point(53, 256);
            this.lbYasno.Name = "lbYasno";
            this.lbYasno.Size = new System.Drawing.Size(16, 17);
            this.lbYasno.TabIndex = 9;
            this.lbYasno.Text = "0";
            // 
            // lbPas
            // 
            this.lbPas.AutoSize = true;
            this.lbPas.Location = new System.Drawing.Point(53, 301);
            this.lbPas.Name = "lbPas";
            this.lbPas.Size = new System.Drawing.Size(16, 17);
            this.lbPas.TabIndex = 10;
            this.lbPas.Text = "0";
            // 
            // lbDojd
            // 
            this.lbDojd.AutoSize = true;
            this.lbDojd.Location = new System.Drawing.Point(53, 349);
            this.lbDojd.Name = "lbDojd";
            this.lbDojd.Size = new System.Drawing.Size(16, 17);
            this.lbDojd.TabIndex = 11;
            this.lbDojd.Text = "0";
            // 
            // lbPogoda
            // 
            this.lbPogoda.AutoSize = true;
            this.lbPogoda.Location = new System.Drawing.Point(113, 171);
            this.lbPogoda.Name = "lbPogoda";
            this.lbPogoda.Size = new System.Drawing.Size(39, 17);
            this.lbPogoda.TabIndex = 12;
            this.lbPogoda.Text = "ясно";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 505);
            this.Controls.Add(this.lbPogoda);
            this.Controls.Add(this.lbDojd);
            this.Controls.Add(this.lbPas);
            this.Controls.Add(this.lbYasno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbYasno;
        private System.Windows.Forms.Label lbPas;
        private System.Windows.Forms.Label lbDojd;
        private System.Windows.Forms.Label lbPogoda;
        private System.Windows.Forms.Timer timer1;
    }
}

