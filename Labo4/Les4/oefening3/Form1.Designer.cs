
namespace oefening3
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
            this.Numeric = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoven = new System.Windows.Forms.TextBox();
            this.txtOnder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rBevat = new System.Windows.Forms.RadioButton();
            this.rEinde = new System.Windows.Forms.RadioButton();
            this.rBegin = new System.Windows.Forms.RadioButton();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.txtReeks = new System.Windows.Forms.TextBox();
            this.txtTeken = new System.Windows.Forms.TextBox();
            this.Numeric.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Numeric
            // 
            this.Numeric.Controls.Add(this.tabPage1);
            this.Numeric.Controls.Add(this.tabPage2);
            this.Numeric.Location = new System.Drawing.Point(0, 1);
            this.Numeric.Name = "Numeric";
            this.Numeric.SelectedIndex = 0;
            this.Numeric.Size = new System.Drawing.Size(481, 513);
            this.Numeric.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtBoven);
            this.tabPage1.Controls.Add(this.txtOnder);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Numeric-based";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Even getallen binnen de opgegeven grenzen:";
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(30, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 259);
            this.listBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Go!...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoven
            // 
            this.txtBoven.Location = new System.Drawing.Point(278, 32);
            this.txtBoven.Name = "txtBoven";
            this.txtBoven.Size = new System.Drawing.Size(100, 23);
            this.txtBoven.TabIndex = 3;
            // 
            // txtOnder
            // 
            this.txtOnder.Location = new System.Drawing.Point(95, 35);
            this.txtOnder.Name = "txtOnder";
            this.txtOnder.Size = new System.Drawing.Size(100, 23);
            this.txtOnder.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bovengrens";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ondergrens";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtRes);
            this.tabPage2.Controls.Add(this.txtReeks);
            this.tabPage2.Controls.Add(this.txtTeken);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "String-Based";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.rBevat);
            this.groupBox1.Controls.Add(this.rEinde);
            this.groupBox1.Controls.Add(this.rBegin);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Location = new System.Drawing.Point(29, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 145);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter criteria";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Go!...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rBevat
            // 
            this.rBevat.AutoSize = true;
            this.rBevat.Location = new System.Drawing.Point(220, 21);
            this.rBevat.Name = "rBevat";
            this.rBevat.Size = new System.Drawing.Size(54, 19);
            this.rBevat.TabIndex = 5;
            this.rBevat.TabStop = true;
            this.rBevat.Text = "Bevat";
            this.rBevat.UseVisualStyleBackColor = true;
            // 
            // rEinde
            // 
            this.rEinde.AutoSize = true;
            this.rEinde.Location = new System.Drawing.Point(119, 22);
            this.rEinde.Name = "rEinde";
            this.rEinde.Size = new System.Drawing.Size(86, 19);
            this.rEinde.TabIndex = 4;
            this.rEinde.TabStop = true;
            this.rEinde.Text = "Eindigt met";
            this.rEinde.UseVisualStyleBackColor = true;
            // 
            // rBegin
            // 
            this.rBegin.AutoSize = true;
            this.rBegin.Location = new System.Drawing.Point(7, 23);
            this.rBegin.Name = "rBegin";
            this.rBegin.Size = new System.Drawing.Size(79, 19);
            this.rBegin.TabIndex = 3;
            this.rBegin.TabStop = true;
            this.rBegin.Text = "Begin met";
            this.rBegin.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(6, 67);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(312, 23);
            this.txtFilter.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Resultaat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Namen reeks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Scheidingsteken:";
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(29, 334);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(357, 145);
            this.txtRes.TabIndex = 3;
            // 
            // txtReeks
            // 
            this.txtReeks.Location = new System.Drawing.Point(124, 111);
            this.txtReeks.Name = "txtReeks";
            this.txtReeks.Size = new System.Drawing.Size(246, 23);
            this.txtReeks.TabIndex = 1;
            // 
            // txtTeken
            // 
            this.txtTeken.Location = new System.Drawing.Point(131, 63);
            this.txtTeken.Name = "txtTeken";
            this.txtTeken.Size = new System.Drawing.Size(38, 23);
            this.txtTeken.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 514);
            this.Controls.Add(this.Numeric);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Numeric.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Numeric;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoven;
        private System.Windows.Forms.TextBox txtOnder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rBevat;
        private System.Windows.Forms.RadioButton rEinde;
        private System.Windows.Forms.RadioButton rBegin;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.TextBox txtReeks;
        private System.Windows.Forms.TextBox txtTeken;
    }
}

