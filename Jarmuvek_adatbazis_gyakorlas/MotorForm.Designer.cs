
namespace Jarmuvek_adatbazis_gyakorlas
{
    partial class MotorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AutoMegse = new System.Windows.Forms.Button();
            this.button_AutoOK = new System.Windows.Forms.Button();
            this.comboBox_MotorTipus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_Motor = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_MotorKM = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MotorMarka = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MotorKM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_AutoMegse);
            this.groupBox1.Controls.Add(this.button_AutoOK);
            this.groupBox1.Controls.Add(this.comboBox_MotorTipus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker_Motor);
            this.groupBox1.Controls.Add(this.numericUpDown_MotorKM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_MotorMarka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új Motor felvitele";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Márka";
            // 
            // button_AutoMegse
            // 
            this.button_AutoMegse.Location = new System.Drawing.Point(86, 215);
            this.button_AutoMegse.Name = "button_AutoMegse";
            this.button_AutoMegse.Size = new System.Drawing.Size(75, 23);
            this.button_AutoMegse.TabIndex = 22;
            this.button_AutoMegse.Text = "Mégse";
            this.button_AutoMegse.UseVisualStyleBackColor = true;
            // 
            // button_AutoOK
            // 
            this.button_AutoOK.Location = new System.Drawing.Point(5, 215);
            this.button_AutoOK.Name = "button_AutoOK";
            this.button_AutoOK.Size = new System.Drawing.Size(75, 23);
            this.button_AutoOK.TabIndex = 21;
            this.button_AutoOK.Text = "OK";
            this.button_AutoOK.UseVisualStyleBackColor = true;
            // 
            // comboBox_MotorTipus
            // 
            this.comboBox_MotorTipus.FormattingEnabled = true;
            this.comboBox_MotorTipus.Location = new System.Drawing.Point(6, 186);
            this.comboBox_MotorTipus.Name = "comboBox_MotorTipus";
            this.comboBox_MotorTipus.Size = new System.Drawing.Size(147, 23);
            this.comboBox_MotorTipus.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Motor Típus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gyártás idő";
            // 
            // dateTimePicker_Motor
            // 
            this.dateTimePicker_Motor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Motor.Location = new System.Drawing.Point(5, 138);
            this.dateTimePicker_Motor.Name = "dateTimePicker_Motor";
            this.dateTimePicker_Motor.Size = new System.Drawing.Size(148, 23);
            this.dateTimePicker_Motor.TabIndex = 15;
            // 
            // numericUpDown_MotorKM
            // 
            this.numericUpDown_MotorKM.Location = new System.Drawing.Point(6, 90);
            this.numericUpDown_MotorKM.Name = "numericUpDown_MotorKM";
            this.numericUpDown_MotorKM.Size = new System.Drawing.Size(147, 23);
            this.numericUpDown_MotorKM.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Km óra állás";
            // 
            // textBox_MotorMarka
            // 
            this.textBox_MotorMarka.Location = new System.Drawing.Point(6, 41);
            this.textBox_MotorMarka.Name = "textBox_MotorMarka";
            this.textBox_MotorMarka.Size = new System.Drawing.Size(147, 23);
            this.textBox_MotorMarka.TabIndex = 12;
            // 
            // MotorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 285);
            this.Controls.Add(this.groupBox1);
            this.Name = "MotorForm";
            this.Text = "MotorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MotorKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AutoMegse;
        private System.Windows.Forms.Button button_AutoOK;
        private System.Windows.Forms.ComboBox comboBox_MotorTipus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Motor;
        private System.Windows.Forms.NumericUpDown numericUpDown_MotorKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MotorMarka;
    }
}