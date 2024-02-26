namespace Sem2
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
            this.startBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PBA = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.PBB = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStopA = new System.Windows.Forms.Button();
            this.btnStopB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(523, 286);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(98, 71);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 324);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 114);
            this.textBox1.TabIndex = 1;
            // 
            // PBA
            // 
            this.PBA.Location = new System.Drawing.Point(12, 37);
            this.PBA.Name = "PBA";
            this.PBA.Size = new System.Drawing.Size(776, 23);
            this.PBA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thread A";
            // 
            // PBB
            // 
            this.PBB.Location = new System.Drawing.Point(12, 93);
            this.PBB.Name = "PBB";
            this.PBB.Size = new System.Drawing.Size(776, 23);
            this.PBB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thread B";
            // 
            // btnStopA
            // 
            this.btnStopA.Location = new System.Drawing.Point(12, 148);
            this.btnStopA.Name = "btnStopA";
            this.btnStopA.Size = new System.Drawing.Size(98, 71);
            this.btnStopA.TabIndex = 6;
            this.btnStopA.Text = "Stop A";
            this.btnStopA.UseVisualStyleBackColor = true;
            this.btnStopA.Click += new System.EventHandler(this.btnStopA_Click);
            // 
            // btnStopB
            // 
            this.btnStopB.Location = new System.Drawing.Point(205, 148);
            this.btnStopB.Name = "btnStopB";
            this.btnStopB.Size = new System.Drawing.Size(98, 71);
            this.btnStopB.TabIndex = 7;
            this.btnStopB.Text = "Stop B";
            this.btnStopB.UseVisualStyleBackColor = true;
            this.btnStopB.Click += new System.EventHandler(this.btnStopB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStopB);
            this.Controls.Add(this.btnStopA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PBB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar PBA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PBB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStopA;
        private System.Windows.Forms.Button btnStopB;
    }
}

