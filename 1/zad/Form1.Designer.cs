
namespace zad1lab2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIdealna = new System.Windows.Forms.CheckBox();
            this.checkBoxStandard = new System.Windows.Forms.CheckBox();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.rbtnKobieta = new System.Windows.Forms.RadioButton();
            this.rbtnMezczyzna = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj wzrost [cm]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj płeć";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wynik";
            
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 23);
            this.textBox1.TabIndex = 3;
            
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIdealna);
            this.groupBox1.Controls.Add(this.checkBoxStandard);
            this.groupBox1.Location = new System.Drawing.Point(579, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waga";
            // 
            // checkBoxIdealna
            // 
            this.checkBoxIdealna.AutoSize = true;
            this.checkBoxIdealna.Location = new System.Drawing.Point(6, 57);
            this.checkBoxIdealna.Name = "checkBoxIdealna";
            this.checkBoxIdealna.Size = new System.Drawing.Size(70, 19);
            this.checkBoxIdealna.TabIndex = 1;
            this.checkBoxIdealna.Text = "Idealana";
            this.checkBoxIdealna.UseVisualStyleBackColor = true;
            // 
            // checkBoxStandard
            // 
            this.checkBoxStandard.AutoSize = true;
            this.checkBoxStandard.Location = new System.Drawing.Point(7, 23);
            this.checkBoxStandard.Name = "checkBoxStandard";
            this.checkBoxStandard.Size = new System.Drawing.Size(95, 19);
            this.checkBoxStandard.TabIndex = 0;
            this.checkBoxStandard.Text = "Standardowa";
            this.checkBoxStandard.UseVisualStyleBackColor = true;
            
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOblicz.Location = new System.Drawing.Point(314, 266);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(136, 42);
            this.buttonOblicz.TabIndex = 5;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // rbtnKobieta
            // 
            this.rbtnKobieta.AutoSize = true;
            this.rbtnKobieta.Location = new System.Drawing.Point(314, 172);
            this.rbtnKobieta.Name = "rbtnKobieta";
            this.rbtnKobieta.Size = new System.Drawing.Size(65, 19);
            this.rbtnKobieta.TabIndex = 6;
            this.rbtnKobieta.TabStop = true;
            this.rbtnKobieta.Text = "Kobieta";
            this.rbtnKobieta.UseVisualStyleBackColor = true;
            // 
            // rbtnMezczyzna
            // 
            this.rbtnMezczyzna.AutoSize = true;
            this.rbtnMezczyzna.Location = new System.Drawing.Point(414, 172);
            this.rbtnMezczyzna.Name = "rbtnMezczyzna";
            this.rbtnMezczyzna.Size = new System.Drawing.Size(82, 19);
            this.rbtnMezczyzna.TabIndex = 7;
            this.rbtnMezczyzna.TabStop = true;
            this.rbtnMezczyzna.Text = "Mężczyzna";
            this.rbtnMezczyzna.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnMezczyzna);
            this.Controls.Add(this.rbtnKobieta);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Waga";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxIdealna;
        private System.Windows.Forms.CheckBox checkBoxStandard;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.RadioButton rbtnKobieta;
        private System.Windows.Forms.RadioButton rbtnMezczyzna;
    }
}

