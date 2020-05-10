namespace KimMilyoner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5050 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelQuestionNo = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.tanidiaSor = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelQustion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(27, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(140, 29);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(27, 116);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(140, 29);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(27, 155);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(140, 29);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(133, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 214);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose one answer";
            // 
            // button5050
            // 
            this.button5050.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button5050.Location = new System.Drawing.Point(790, 285);
            this.button5050.Name = "button5050";
            this.button5050.Size = new System.Drawing.Size(132, 68);
            this.button5050.TabIndex = 13;
            this.button5050.Text = "50/50";
            this.button5050.UseVisualStyleBackColor = true;
            this.button5050.Click += new System.EventHandler(this.button5050_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(389, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 68);
            this.button2.TabIndex = 15;
            this.button2.Text = "My Final Aswer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelQuestionNo
            // 
            this.labelQuestionNo.AutoSize = true;
            this.labelQuestionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelQuestionNo.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelQuestionNo.Location = new System.Drawing.Point(12, 541);
            this.labelQuestionNo.Name = "labelQuestionNo";
            this.labelQuestionNo.Size = new System.Drawing.Size(70, 25);
            this.labelQuestionNo.TabIndex = 18;
            this.labelQuestionNo.Text = "label2";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelResult.Location = new System.Drawing.Point(223, 541);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(60, 25);
            this.labelResult.TabIndex = 19;
            this.labelResult.Text = "Time";
            // 
            // tanidiaSor
            // 
            this.tanidiaSor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tanidiaSor.Location = new System.Drawing.Point(790, 363);
            this.tanidiaSor.Name = "tanidiaSor";
            this.tanidiaSor.Size = new System.Drawing.Size(132, 68);
            this.tanidiaSor.TabIndex = 20;
            this.tanidiaSor.Text = "Ask A Friend";
            this.tanidiaSor.UseVisualStyleBackColor = true;
            this.tanidiaSor.Click += new System.EventHandler(this.tanidiaSor_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(307, 40);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(281, 90);
            this.webBrowser1.TabIndex = 16;
            this.webBrowser1.Visible = false;
            // 
            // labelQustion
            // 
            this.labelQustion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQustion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelQustion.Location = new System.Drawing.Point(0, 0);
            this.labelQustion.Name = "labelQustion";
            this.labelQustion.Size = new System.Drawing.Size(880, 197);
            this.labelQustion.TabIndex = 17;
            this.labelQustion.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelQustion);
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(42, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 197);
            this.panel1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tanidiaSor);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelQuestionNo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5050);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Who Wants To Be Millionare? Group B";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5050;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelQuestionNo;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button tanidiaSor;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label labelQustion;
        private System.Windows.Forms.Panel panel1;

    }
}

