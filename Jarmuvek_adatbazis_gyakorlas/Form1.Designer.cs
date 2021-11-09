
namespace Jarmuvek_adatbazis_gyakorlas
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
            this.listBox_Autok = new System.Windows.Forms.ListBox();
            this.listBox_Motorok = new System.Windows.Forms.ListBox();
            this.button_UjAuto = new System.Windows.Forms.Button();
            this.button_UjMotor = new System.Windows.Forms.Button();
            this.button_AutoModositas = new System.Windows.Forms.Button();
            this.button_AutoTorles = new System.Windows.Forms.Button();
            this.button_AutoMentes = new System.Windows.Forms.Button();
            this.button_MotorModositas = new System.Windows.Forms.Button();
            this.button_MotorTorles = new System.Windows.Forms.Button();
            this.button_MotorMentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Autok
            // 
            this.listBox_Autok.FormattingEnabled = true;
            this.listBox_Autok.ItemHeight = 15;
            this.listBox_Autok.Location = new System.Drawing.Point(13, 13);
            this.listBox_Autok.Name = "listBox_Autok";
            this.listBox_Autok.Size = new System.Drawing.Size(174, 109);
            this.listBox_Autok.TabIndex = 0;
            // 
            // listBox_Motorok
            // 
            this.listBox_Motorok.FormattingEnabled = true;
            this.listBox_Motorok.ItemHeight = 15;
            this.listBox_Motorok.Location = new System.Drawing.Point(248, 13);
            this.listBox_Motorok.Name = "listBox_Motorok";
            this.listBox_Motorok.Size = new System.Drawing.Size(175, 109);
            this.listBox_Motorok.TabIndex = 1;
            // 
            // button_UjAuto
            // 
            this.button_UjAuto.Location = new System.Drawing.Point(13, 129);
            this.button_UjAuto.Name = "button_UjAuto";
            this.button_UjAuto.Size = new System.Drawing.Size(174, 23);
            this.button_UjAuto.TabIndex = 2;
            this.button_UjAuto.Text = "Új Auto";
            this.button_UjAuto.UseVisualStyleBackColor = true;
            this.button_UjAuto.Click += new System.EventHandler(this.button_UjAuto_Click);
            // 
            // button_UjMotor
            // 
            this.button_UjMotor.Location = new System.Drawing.Point(248, 128);
            this.button_UjMotor.Name = "button_UjMotor";
            this.button_UjMotor.Size = new System.Drawing.Size(175, 23);
            this.button_UjMotor.TabIndex = 3;
            this.button_UjMotor.Text = "Új Motor";
            this.button_UjMotor.UseVisualStyleBackColor = true;
            // 
            // button_AutoModositas
            // 
            this.button_AutoModositas.Location = new System.Drawing.Point(13, 159);
            this.button_AutoModositas.Name = "button_AutoModositas";
            this.button_AutoModositas.Size = new System.Drawing.Size(174, 23);
            this.button_AutoModositas.TabIndex = 4;
            this.button_AutoModositas.Text = "Auto Módosítás";
            this.button_AutoModositas.UseVisualStyleBackColor = true;
            this.button_AutoModositas.Click += new System.EventHandler(this.button_AutoModositas_Click);
            // 
            // button_AutoTorles
            // 
            this.button_AutoTorles.Location = new System.Drawing.Point(13, 189);
            this.button_AutoTorles.Name = "button_AutoTorles";
            this.button_AutoTorles.Size = new System.Drawing.Size(174, 23);
            this.button_AutoTorles.TabIndex = 5;
            this.button_AutoTorles.Text = "Auto Törlés";
            this.button_AutoTorles.UseVisualStyleBackColor = true;
            this.button_AutoTorles.Click += new System.EventHandler(this.button_AutoTorles_Click);
            // 
            // button_AutoMentes
            // 
            this.button_AutoMentes.Location = new System.Drawing.Point(13, 219);
            this.button_AutoMentes.Name = "button_AutoMentes";
            this.button_AutoMentes.Size = new System.Drawing.Size(174, 23);
            this.button_AutoMentes.TabIndex = 6;
            this.button_AutoMentes.Text = "Auto Mentés";
            this.button_AutoMentes.UseVisualStyleBackColor = true;
            this.button_AutoMentes.Click += new System.EventHandler(this.button_AutoMentes_Click);
            // 
            // button_MotorModositas
            // 
            this.button_MotorModositas.Location = new System.Drawing.Point(248, 159);
            this.button_MotorModositas.Name = "button_MotorModositas";
            this.button_MotorModositas.Size = new System.Drawing.Size(175, 23);
            this.button_MotorModositas.TabIndex = 7;
            this.button_MotorModositas.Text = "Motor Módosítás";
            this.button_MotorModositas.UseVisualStyleBackColor = true;
            // 
            // button_MotorTorles
            // 
            this.button_MotorTorles.Location = new System.Drawing.Point(248, 189);
            this.button_MotorTorles.Name = "button_MotorTorles";
            this.button_MotorTorles.Size = new System.Drawing.Size(175, 23);
            this.button_MotorTorles.TabIndex = 8;
            this.button_MotorTorles.Text = "Motor Törlés";
            this.button_MotorTorles.UseVisualStyleBackColor = true;
            // 
            // button_MotorMentes
            // 
            this.button_MotorMentes.Location = new System.Drawing.Point(248, 219);
            this.button_MotorMentes.Name = "button_MotorMentes";
            this.button_MotorMentes.Size = new System.Drawing.Size(175, 23);
            this.button_MotorMentes.TabIndex = 9;
            this.button_MotorMentes.Text = "Motor Mentés";
            this.button_MotorMentes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 282);
            this.Controls.Add(this.button_MotorMentes);
            this.Controls.Add(this.button_MotorTorles);
            this.Controls.Add(this.button_MotorModositas);
            this.Controls.Add(this.button_AutoMentes);
            this.Controls.Add(this.button_AutoTorles);
            this.Controls.Add(this.button_AutoModositas);
            this.Controls.Add(this.button_UjMotor);
            this.Controls.Add(this.button_UjAuto);
            this.Controls.Add(this.listBox_Motorok);
            this.Controls.Add(this.listBox_Autok);
            this.Name = "Form1";
            this.Text = "JarmuvekForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Autok;
        private System.Windows.Forms.ListBox listBox_Motorok;
        private System.Windows.Forms.Button button_UjAuto;
        private System.Windows.Forms.Button button_UjMotor;
        private System.Windows.Forms.Button button_AutoModositas;
        private System.Windows.Forms.Button button_AutoTorles;
        private System.Windows.Forms.Button button_AutoMentes;
        private System.Windows.Forms.Button button_MotorModositas;
        private System.Windows.Forms.Button button_MotorTorles;
        private System.Windows.Forms.Button button_MotorMentes;
    }
}

