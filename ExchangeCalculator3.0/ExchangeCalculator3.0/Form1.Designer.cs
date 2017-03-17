namespace ExchangeCalculator3._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.General = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDivideAbokiTrackMas = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAbokiFXAvgResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDivideAvg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAbokiFXAvg2 = new System.Windows.Forms.TextBox();
            this.txtResipAbokiTrackMasResult = new System.Windows.Forms.TextBox();
            this.txtTrackMasRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDivideResipAbokiTrackMasResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAbokiFXAvg1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAbokiTrackMasResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecpirocal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.General.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // General
            // 
            this.General.Controls.Add(this.tabPage1);
            this.General.Location = new System.Drawing.Point(21, 12);
            this.General.Name = "General";
            this.General.SelectedIndex = 0;
            this.General.Size = new System.Drawing.Size(959, 616);
            this.General.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(951, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDivideAbokiTrackMas);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtAbokiFXAvgResult);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnDivideAvg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAbokiFXAvg2);
            this.groupBox1.Controls.Add(this.txtResipAbokiTrackMasResult);
            this.groupBox1.Controls.Add(this.txtTrackMasRate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDivideResipAbokiTrackMasResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAbokiFXAvg1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAbokiTrackMasResult);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRecpirocal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(27, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 355);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NGN Calculation";
            // 
            // btnDivideAbokiTrackMas
            // 
            this.btnDivideAbokiTrackMas.Location = new System.Drawing.Point(215, 171);
            this.btnDivideAbokiTrackMas.Name = "btnDivideAbokiTrackMas";
            this.btnDivideAbokiTrackMas.Size = new System.Drawing.Size(100, 23);
            this.btnDivideAbokiTrackMas.TabIndex = 5;
            this.btnDivideAbokiTrackMas.Text = "Divide";
            this.btnDivideAbokiTrackMas.UseVisualStyleBackColor = false;
            this.btnDivideAbokiTrackMas.Click += new System.EventHandler(this.btnDivideAbokiTrackMas_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Calculate Reciprocal";
            // 
            // txtAbokiFXAvgResult
            // 
            this.txtAbokiFXAvgResult.Location = new System.Drawing.Point(215, 119);
            this.txtAbokiFXAvgResult.Name = "txtAbokiFXAvgResult";
            this.txtAbokiFXAvgResult.Size = new System.Drawing.Size(100, 20);
            this.txtAbokiFXAvgResult.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Calculate Division";
            // 
            // btnDivideAvg
            // 
            this.btnDivideAvg.Location = new System.Drawing.Point(215, 90);
            this.btnDivideAvg.Name = "btnDivideAvg";
            this.btnDivideAvg.Size = new System.Drawing.Size(100, 23);
            this.btnDivideAvg.TabIndex = 3;
            this.btnDivideAvg.Text = "Divide";
            this.btnDivideAvg.UseVisualStyleBackColor = false;
            this.btnDivideAvg.Click += new System.EventHandler(this.btnDivideAvg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Calculate avg";
            // 
            // txtAbokiFXAvg2
            // 
            this.txtAbokiFXAvg2.Location = new System.Drawing.Point(215, 64);
            this.txtAbokiFXAvg2.Name = "txtAbokiFXAvg2";
            this.txtAbokiFXAvg2.Size = new System.Drawing.Size(100, 20);
            this.txtAbokiFXAvg2.TabIndex = 1;
            // 
            // txtResipAbokiTrackMasResult
            // 
            this.txtResipAbokiTrackMasResult.Location = new System.Drawing.Point(215, 281);
            this.txtResipAbokiTrackMasResult.Name = "txtResipAbokiTrackMasResult";
            this.txtResipAbokiTrackMasResult.Size = new System.Drawing.Size(100, 20);
            this.txtResipAbokiTrackMasResult.TabIndex = 10;
            // 
            // txtTrackMasRate
            // 
            this.txtTrackMasRate.Location = new System.Drawing.Point(215, 145);
            this.txtTrackMasRate.Name = "txtTrackMasRate";
            this.txtTrackMasRate.Size = new System.Drawing.Size(100, 20);
            this.txtTrackMasRate.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Final result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Aboki avg result";
            // 
            // btnDivideResipAbokiTrackMasResult
            // 
            this.btnDivideResipAbokiTrackMasResult.Location = new System.Drawing.Point(215, 252);
            this.btnDivideResipAbokiTrackMasResult.Name = "btnDivideResipAbokiTrackMasResult";
            this.btnDivideResipAbokiTrackMasResult.Size = new System.Drawing.Size(100, 23);
            this.btnDivideResipAbokiTrackMasResult.TabIndex = 21;
            this.btnDivideResipAbokiTrackMasResult.Text = "Divide";
            this.btnDivideResipAbokiTrackMasResult.UseVisualStyleBackColor = false;
            this.btnDivideResipAbokiTrackMasResult.Click += new System.EventHandler(this.btnDivideResipAbokiTrackMasResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Aboki\'s 2nd avg";
            // 
            // txtAbokiFXAvg1
            // 
            this.txtAbokiFXAvg1.Location = new System.Drawing.Point(215, 38);
            this.txtAbokiFXAvg1.Name = "txtAbokiFXAvg1";
            this.txtAbokiFXAvg1.Size = new System.Drawing.Size(100, 20);
            this.txtAbokiFXAvg1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "TrackMaster rate\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Reciprocal";
            // 
            // txtAbokiTrackMasResult
            // 
            this.txtAbokiTrackMasResult.Location = new System.Drawing.Point(215, 200);
            this.txtAbokiTrackMasResult.Name = "txtAbokiTrackMasResult";
            this.txtAbokiTrackMasResult.ReadOnly = true;
            this.txtAbokiTrackMasResult.Size = new System.Drawing.Size(100, 20);
            this.txtAbokiTrackMasResult.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aboki\'s 1st average";
            // 
            // txtRecpirocal
            // 
            this.txtRecpirocal.Location = new System.Drawing.Point(215, 226);
            this.txtRecpirocal.Name = "txtRecpirocal";
            this.txtRecpirocal.ReadOnly = true;
            this.txtRecpirocal.Size = new System.Drawing.Size(100, 20);
            this.txtRecpirocal.TabIndex = 7;
            this.txtRecpirocal.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Aboki TrackMaster result";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 131);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "If this pop-ups shows, just press Yes";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(404, 31);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(521, 507);
            this.webBrowser1.TabIndex = 19;
            this.webBrowser1.Url = new System.Uri("https://abokifx.com/", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 646);
            this.Controls.Add(this.General);
            this.Name = "Form1";
            this.Text = "Form1";
            this.General.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl General;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDivideAbokiTrackMas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAbokiFXAvgResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDivideAvg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAbokiFXAvg2;
        private System.Windows.Forms.TextBox txtResipAbokiTrackMasResult;
        private System.Windows.Forms.TextBox txtTrackMasRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDivideResipAbokiTrackMasResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAbokiFXAvg1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAbokiTrackMasResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecpirocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

