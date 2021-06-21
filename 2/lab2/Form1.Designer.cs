
namespace lab2zad2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxWielkosc = new System.Windows.Forms.GroupBox();
            this.rbtnBDuza = new System.Windows.Forms.RadioButton();
            this.rbtnDuza = new System.Windows.Forms.RadioButton();
            this.rbtnMaly = new System.Windows.Forms.RadioButton();
            this.groupBoxStyl = new System.Windows.Forms.GroupBox();
            this.groupBoxKolor = new System.Windows.Forms.GroupBox();
            this.rbtnGreen = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.cbLine = new System.Windows.Forms.CheckBox();
            this.groupBoxWielkosc.SuspendLayout();
            this.groupBoxStyl.SuspendLayout();
            this.groupBoxKolor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj tekst";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(509, 23);
            this.textBox1.TabIndex = 1;
            // 
            // groupBoxWielkosc
            // 
            this.groupBoxWielkosc.Controls.Add(this.rbtnBDuza);
            this.groupBoxWielkosc.Controls.Add(this.rbtnDuza);
            this.groupBoxWielkosc.Controls.Add(this.rbtnMaly);
            this.groupBoxWielkosc.Location = new System.Drawing.Point(41, 132);
            this.groupBoxWielkosc.Name = "groupBoxWielkosc";
            this.groupBoxWielkosc.Size = new System.Drawing.Size(200, 172);
            this.groupBoxWielkosc.TabIndex = 2;
            this.groupBoxWielkosc.TabStop = false;
            this.groupBoxWielkosc.Text = "Wielkość";
            // 
            // rbtnBDuza
            // 
            this.rbtnBDuza.AutoSize = true;
            this.rbtnBDuza.Location = new System.Drawing.Point(25, 126);
            this.rbtnBDuza.Name = "rbtnBDuza";
            this.rbtnBDuza.Size = new System.Drawing.Size(89, 19);
            this.rbtnBDuza.TabIndex = 2;
            this.rbtnBDuza.TabStop = true;
            this.rbtnBDuza.Text = "bardzo duża";
            this.rbtnBDuza.UseVisualStyleBackColor = true;
            // 
            // rbtnDuza
            // 
            this.rbtnDuza.AutoSize = true;
            this.rbtnDuza.Location = new System.Drawing.Point(25, 79);
            this.rbtnDuza.Name = "rbtnDuza";
            this.rbtnDuza.Size = new System.Drawing.Size(50, 19);
            this.rbtnDuza.TabIndex = 1;
            this.rbtnDuza.TabStop = true;
            this.rbtnDuza.Text = "duża";
            this.rbtnDuza.UseVisualStyleBackColor = true;
            // 
            // rbtnMaly
            // 
            this.rbtnMaly.AutoSize = true;
            this.rbtnMaly.Location = new System.Drawing.Point(25, 34);
            this.rbtnMaly.Name = "rbtnMaly";
            this.rbtnMaly.Size = new System.Drawing.Size(51, 19);
            this.rbtnMaly.TabIndex = 0;
            this.rbtnMaly.TabStop = true;
            this.rbtnMaly.Text = "mała";
            this.rbtnMaly.UseVisualStyleBackColor = true;
            // 
            // groupBoxStyl
            // 
            this.groupBoxStyl.Controls.Add(this.cbLine);
            this.groupBoxStyl.Controls.Add(this.cbItalic);
            this.groupBoxStyl.Controls.Add(this.cbBold);
            this.groupBoxStyl.Location = new System.Drawing.Point(301, 132);
            this.groupBoxStyl.Name = "groupBoxStyl";
            this.groupBoxStyl.Size = new System.Drawing.Size(200, 172);
            this.groupBoxStyl.TabIndex = 3;
            this.groupBoxStyl.TabStop = false;
            this.groupBoxStyl.Text = "Styl czcionki";
            // 
            // groupBoxKolor
            // 
            this.groupBoxKolor.Controls.Add(this.rbtnGreen);
            this.groupBoxKolor.Controls.Add(this.rbtnBlue);
            this.groupBoxKolor.Controls.Add(this.rbtnRed);
            this.groupBoxKolor.Location = new System.Drawing.Point(561, 132);
            this.groupBoxKolor.Name = "groupBoxKolor";
            this.groupBoxKolor.Size = new System.Drawing.Size(200, 172);
            this.groupBoxKolor.TabIndex = 4;
            this.groupBoxKolor.TabStop = false;
            this.groupBoxKolor.Text = "Kolor czcionki";
            // 
            // rbtnGreen
            // 
            this.rbtnGreen.AutoSize = true;
            this.rbtnGreen.Location = new System.Drawing.Point(28, 125);
            this.rbtnGreen.Name = "rbtnGreen";
            this.rbtnGreen.Size = new System.Drawing.Size(62, 19);
            this.rbtnGreen.TabIndex = 2;
            this.rbtnGreen.TabStop = true;
            this.rbtnGreen.Text = "zielony";
            this.rbtnGreen.UseVisualStyleBackColor = true;
            // 
            // rbtnBlue
            // 
            this.rbtnBlue.AutoSize = true;
            this.rbtnBlue.Location = new System.Drawing.Point(28, 78);
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.Size = new System.Drawing.Size(71, 19);
            this.rbtnBlue.TabIndex = 1;
            this.rbtnBlue.TabStop = true;
            this.rbtnBlue.Text = "niebieski";
            this.rbtnBlue.UseVisualStyleBackColor = true;
            // 
            // rbtnRed
            // 
            this.rbtnRed.AutoSize = true;
            this.rbtnRed.Location = new System.Drawing.Point(28, 33);
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.Size = new System.Drawing.Size(75, 19);
            this.rbtnRed.TabIndex = 0;
            this.rbtnRed.TabStop = true;
            this.rbtnRed.Text = "czerwony";
            this.rbtnRed.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(241, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aktualizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Location = new System.Drawing.Point(26, 33);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(90, 19);
            this.cbBold.TabIndex = 0;
            this.cbBold.Text = "Pogrubienie";
            this.cbBold.UseVisualStyleBackColor = true;
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Location = new System.Drawing.Point(26, 78);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(84, 19);
            this.cbItalic.TabIndex = 1;
            this.cbItalic.Text = "Pochylenie";
            this.cbItalic.UseVisualStyleBackColor = true;
            // 
            // cbLine
            // 
            this.cbLine.AutoSize = true;
            this.cbLine.Location = new System.Drawing.Point(26, 125);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(93, 19);
            this.cbLine.TabIndex = 2;
            this.cbLine.Text = "Podkreślenie";
            this.cbLine.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxKolor);
            this.Controls.Add(this.groupBoxStyl);
            this.Controls.Add(this.groupBoxWielkosc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formatowanie";
            this.groupBoxWielkosc.ResumeLayout(false);
            this.groupBoxWielkosc.PerformLayout();
            this.groupBoxStyl.ResumeLayout(false);
            this.groupBoxStyl.PerformLayout();
            this.groupBoxKolor.ResumeLayout(false);
            this.groupBoxKolor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxWielkosc;
        private System.Windows.Forms.GroupBox groupBoxStyl;
        private System.Windows.Forms.GroupBox groupBoxKolor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnBDuza;
        private System.Windows.Forms.RadioButton rbtnDuza;
        private System.Windows.Forms.RadioButton rbtnMaly;
        private System.Windows.Forms.RadioButton rbtnGreen;
        private System.Windows.Forms.RadioButton rbtnBlue;
        private System.Windows.Forms.RadioButton rbtnRed;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cbLine;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox cbBold;
    }
}

