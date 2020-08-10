namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDD = new System.Windows.Forms.TextBox();
            this.textBoxMM = new System.Windows.Forms.TextBox();
            this.textBoxYY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLAT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLONG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxWMM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "--.----";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Izračunaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(219, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "--.----";
            // 
            // textBoxDD
            // 
            this.textBoxDD.Location = new System.Drawing.Point(223, 34);
            this.textBoxDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDD.Name = "textBoxDD";
            this.textBoxDD.Size = new System.Drawing.Size(37, 22);
            this.textBoxDD.TabIndex = 3;
            this.textBoxDD.Text = "22";
            this.textBoxDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMM
            // 
            this.textBoxMM.Location = new System.Drawing.Point(269, 34);
            this.textBoxMM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMM.Name = "textBoxMM";
            this.textBoxMM.Size = new System.Drawing.Size(37, 22);
            this.textBoxMM.TabIndex = 4;
            this.textBoxMM.Text = "04";
            this.textBoxMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxYY
            // 
            this.textBoxYY.Location = new System.Drawing.Point(316, 34);
            this.textBoxYY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxYY.Name = "textBoxYY";
            this.textBoxYY.Size = new System.Drawing.Size(37, 22);
            this.textBoxYY.TabIndex = 5;
            this.textBoxYY.Text = "15";
            this.textBoxYY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum (dd mm yy): ";
            // 
            // textBoxLAT
            // 
            this.textBoxLAT.Location = new System.Drawing.Point(223, 85);
            this.textBoxLAT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLAT.Name = "textBoxLAT";
            this.textBoxLAT.Size = new System.Drawing.Size(131, 22);
            this.textBoxLAT.TabIndex = 7;
            this.textBoxLAT.Text = "44,7429";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Geo. širina (N>0, S<0):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Geo. dužina (E>0, W<0):";
            // 
            // textBoxLONG
            // 
            this.textBoxLONG.Location = new System.Drawing.Point(223, 121);
            this.textBoxLONG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLONG.Name = "textBoxLONG";
            this.textBoxLONG.Size = new System.Drawing.Size(131, 22);
            this.textBoxLONG.TabIndex = 10;
            this.textBoxLONG.Text = "20,4025";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nadmorska visina [m]:";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(223, 155);
            this.textBoxH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(84, 22);
            this.textBoxH.TabIndex = 12;
            this.textBoxH.Text = "150";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "WMM: ";
            // 
            // textBoxWMM
            // 
            this.textBoxWMM.Location = new System.Drawing.Point(223, 202);
            this.textBoxWMM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWMM.Name = "textBoxWMM";
            this.textBoxWMM.Size = new System.Drawing.Size(84, 22);
            this.textBoxWMM.TabIndex = 14;
            this.textBoxWMM.Text = "2015";
            this.textBoxWMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 257);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Magnetna deklinacija [rad]: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 304);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Magnetna deklinacija [deg]: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Danas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxWMM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLONG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLAT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYY);
            this.Controls.Add(this.textBoxMM);
            this.Controls.Add(this.textBoxDD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Magnetna deklinacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDD;
        private System.Windows.Forms.TextBox textBoxMM;
        private System.Windows.Forms.TextBox textBoxYY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLAT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLONG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxWMM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}

