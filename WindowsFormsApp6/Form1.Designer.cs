namespace WindowsFormsApp6
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
            this.OupN = new System.Windows.Forms.TextBox();
            this.OupM = new System.Windows.Forms.TextBox();
            this.Cout = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(92, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Output";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OupN
            // 
            this.OupN.Location = new System.Drawing.Point(92, 68);
            this.OupN.Name = "OupN";
            this.OupN.Size = new System.Drawing.Size(95, 20);
            this.OupN.TabIndex = 1;

            // 
            // OupM
            // 
            this.OupM.Location = new System.Drawing.Point(92, 156);
            this.OupM.Name = "OupM";
            this.OupM.Size = new System.Drawing.Size(95, 20);
            this.OupM.TabIndex = 2;

            // 
            // Cout
            // 
            this.Cout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cout.Location = new System.Drawing.Point(338, 12);
            this.Cout.Name = "Cout";
            this.Cout.Size = new System.Drawing.Size(450, 426);
            this.Cout.TabIndex = 3;
            this.Cout.TabStop = false;
            this.Cout.Text = "";

            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(14, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Enter amount\r\n  \r\nof Triangles\r\n";

            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(14, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 24);
            this.textBox2.TabIndex = 5;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Enter amount\r\n  \r\nof Right Pyramids";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cout);
            this.Controls.Add(this.OupM);
            this.Controls.Add(this.OupN);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OupN;
        private System.Windows.Forms.TextBox OupM;
        private System.Windows.Forms.RichTextBox Cout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

