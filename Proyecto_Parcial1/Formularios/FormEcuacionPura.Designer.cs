
namespace Proyecto_Parcial1.Formularios
{
    partial class FormEcuacionPura
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
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxValorA = new System.Windows.Forms.TextBox();
            this.textBoxValorC = new System.Windows.Forms.TextBox();
            this.textBoxRes1 = new System.Windows.Forms.TextBox();
            this.textBoxRes2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.White;
            this.buttonCalcular.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(38, 269);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(94, 46);
            this.buttonCalcular.TabIndex = 0;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textBoxValorA
            // 
            this.textBoxValorA.Location = new System.Drawing.Point(193, 107);
            this.textBoxValorA.Name = "textBoxValorA";
            this.textBoxValorA.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorA.TabIndex = 1;
            // 
            // textBoxValorC
            // 
            this.textBoxValorC.Location = new System.Drawing.Point(193, 153);
            this.textBoxValorC.Name = "textBoxValorC";
            this.textBoxValorC.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorC.TabIndex = 2;
            // 
            // textBoxRes1
            // 
            this.textBoxRes1.Location = new System.Drawing.Point(317, 202);
            this.textBoxRes1.Name = "textBoxRes1";
            this.textBoxRes1.Size = new System.Drawing.Size(100, 20);
            this.textBoxRes1.TabIndex = 3;
            // 
            // textBoxRes2
            // 
            this.textBoxRes2.Location = new System.Drawing.Point(317, 252);
            this.textBoxRes2.Name = "textBoxRes2";
            this.textBoxRes2.Size = new System.Drawing.Size(100, 20);
            this.textBoxRes2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Harrington", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ecuacion Cuadratica Pura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese Valor de ax2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingrese Valor de c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Resultado X1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Resultado X2:";
            // 
            // FormEcuacionPura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Parcial1.Properties.Resources.dd35926e_b50a_48d9_8f6f_2938e577a362;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRes2);
            this.Controls.Add(this.textBoxRes1);
            this.Controls.Add(this.textBoxValorC);
            this.Controls.Add(this.textBoxValorA);
            this.Controls.Add(this.buttonCalcular);
            this.Name = "FormEcuacionPura";
            this.Text = "FormEcuacionPura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textBoxValorA;
        private System.Windows.Forms.TextBox textBoxValorC;
        private System.Windows.Forms.TextBox textBoxRes1;
        private System.Windows.Forms.TextBox textBoxRes2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}