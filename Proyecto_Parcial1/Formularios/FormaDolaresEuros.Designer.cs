﻿
namespace Proyecto_Parcial1.Formularios
{
    partial class FormaDolaresEuros
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
            this.textBoxIngresar = new System.Windows.Forms.TextBox();
            this.textBoxResEu = new System.Windows.Forms.TextBox();
            this.textBoxResDol = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIngresar
            // 
            this.textBoxIngresar.Location = new System.Drawing.Point(173, 103);
            this.textBoxIngresar.Name = "textBoxIngresar";
            this.textBoxIngresar.Size = new System.Drawing.Size(135, 20);
            this.textBoxIngresar.TabIndex = 0;
            this.textBoxIngresar.TextChanged += new System.EventHandler(this.textBoxIngresar_TextChanged);
            // 
            // textBoxResEu
            // 
            this.textBoxResEu.Location = new System.Drawing.Point(284, 202);
            this.textBoxResEu.Name = "textBoxResEu";
            this.textBoxResEu.Size = new System.Drawing.Size(142, 20);
            this.textBoxResEu.TabIndex = 1;
            // 
            // textBoxResDol
            // 
            this.textBoxResDol.Location = new System.Drawing.Point(58, 202);
            this.textBoxResDol.Name = "textBoxResDol";
            this.textBoxResDol.Size = new System.Drawing.Size(142, 20);
            this.textBoxResDol.TabIndex = 2;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.White;
            this.buttonCalcular.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(188, 277);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(111, 38);
            this.buttonCalcular.TabIndex = 3;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(284, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Euros";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(89, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dolares";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(138, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ingrese Cantidad";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormaDolaresEuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Parcial1.Properties.Resources.BTS__3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxResDol);
            this.Controls.Add(this.textBoxResEu);
            this.Controls.Add(this.textBoxIngresar);
            this.Name = "FormaDolaresEuros";
            this.Text = "FormaDolaresEuros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIngresar;
        private System.Windows.Forms.TextBox textBoxResEu;
        private System.Windows.Forms.TextBox textBoxResDol;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}