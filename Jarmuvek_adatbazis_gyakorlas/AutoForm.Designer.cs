
namespace Jarmuvek_adatbazis_gyakorlas
{
    partial class AutoForm
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
            this.button_AutoMegse = new System.Windows.Forms.Button();
            this.button_AutoOK = new System.Windows.Forms.Button();
            this.comboBox_AutoTipus = new System.Windows.Forms.ComboBox();
            this.label_Tipus = new System.Windows.Forms.Label();
            this.textBox_AutoSzin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_AutoKM = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_AutoMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AutoKM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_AutoMegse);
            this.groupBox1.Controls.Add(this.button_AutoOK);
            this.groupBox1.Controls.Add(this.comboBox_AutoTipus);
            this.groupBox1.Controls.Add(this.label_Tipus);
            this.groupBox1.Controls.Add(this.textBox_AutoSzin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.numericUpDown_AutoKM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_AutoMarka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új auto felvitele";
            // 
            // button_AutoMegse
            // 
            this.button_AutoMegse.Location = new System.Drawing.Point(89, 291);
            this.button_AutoMegse.Name = "button_AutoMegse";
            this.button_AutoMegse.Size = new System.Drawing.Size(75, 23);
            this.button_AutoMegse.TabIndex = 11;
            this.button_AutoMegse.Text = "Mégse";
            this.button_AutoMegse.UseVisualStyleBackColor = true;
            this.button_AutoMegse.Click += new System.EventHandler(this.button_AutoMegse_Click);
            // 
            // button_AutoOK
            // 
            this.button_AutoOK.Location = new System.Drawing.Point(7, 291);
            this.button_AutoOK.Name = "button_AutoOK";
            this.button_AutoOK.Size = new System.Drawing.Size(75, 23);
            this.button_AutoOK.TabIndex = 10;
            this.button_AutoOK.Text = "OK";
            this.button_AutoOK.UseVisualStyleBackColor = true;
            this.button_AutoOK.Click += new System.EventHandler(this.button_AutoOK_Click);
            // 
            // comboBox_AutoTipus
            // 
            this.comboBox_AutoTipus.FormattingEnabled = true;
            this.comboBox_AutoTipus.Location = new System.Drawing.Point(7, 237);
            this.comboBox_AutoTipus.Name = "comboBox_AutoTipus";
            this.comboBox_AutoTipus.Size = new System.Drawing.Size(147, 23);
            this.comboBox_AutoTipus.TabIndex = 9;
            // 
            // label_Tipus
            // 
            this.label_Tipus.AutoSize = true;
            this.label_Tipus.Location = new System.Drawing.Point(7, 218);
            this.label_Tipus.Name = "label_Tipus";
            this.label_Tipus.Size = new System.Drawing.Size(62, 15);
            this.label_Tipus.TabIndex = 8;
            this.label_Tipus.Text = "Autó típus";
            // 
            // textBox_AutoSzin
            // 
            this.textBox_AutoSzin.Location = new System.Drawing.Point(7, 188);
            this.textBox_AutoSzin.Name = "textBox_AutoSzin";
            this.textBox_AutoSzin.Size = new System.Drawing.Size(147, 23);
            this.textBox_AutoSzin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Szín";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gyártás idő";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // numericUpDown_AutoKM
            // 
            this.numericUpDown_AutoKM.Location = new System.Drawing.Point(7, 91);
            this.numericUpDown_AutoKM.Name = "numericUpDown_AutoKM";
            this.numericUpDown_AutoKM.Size = new System.Drawing.Size(147, 23);
            this.numericUpDown_AutoKM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Km óra állás";
            // 
            // textBox_AutoMarka
            // 
            this.textBox_AutoMarka.Location = new System.Drawing.Point(7, 42);
            this.textBox_AutoMarka.Name = "textBox_AutoMarka";
            this.textBox_AutoMarka.Size = new System.Drawing.Size(147, 23);
            this.textBox_AutoMarka.TabIndex = 1;
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
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 355);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutoForm";
            this.Text = "AutoForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AutoKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AutoMarka;
        private System.Windows.Forms.NumericUpDown numericUpDown_AutoKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_AutoMegse;
        private System.Windows.Forms.Button button_AutoOK;
        private System.Windows.Forms.ComboBox comboBox_AutoTipus;
        private System.Windows.Forms.Label label_Tipus;
        private System.Windows.Forms.TextBox textBox_AutoSzin;
        private System.Windows.Forms.Label label4;
    }
}