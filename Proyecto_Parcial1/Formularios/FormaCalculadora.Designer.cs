
namespace Proyecto_Parcial1.Formularios
{
    partial class FormaCalculadora
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
            this.textBoxValor1 = new System.Windows.Forms.TextBox();
            this.textBoxValor2 = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplicacion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxValor1
            // 
            this.textBoxValor1.Location = new System.Drawing.Point(152, 61);
            this.textBoxValor1.Name = "textBoxValor1";
            this.textBoxValor1.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor1.TabIndex = 0;
            // 
            // textBoxValor2
            // 
            this.textBoxValor2.Location = new System.Drawing.Point(152, 99);
            this.textBoxValor2.Name = "textBoxValor2";
            this.textBoxValor2.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor2.TabIndex = 1;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(152, 186);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.textBoxResultado.TabIndex = 2;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.White;
            this.buttonCalcular.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(34, 154);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(83, 34);
            this.buttonCalcular.TabIndex = 3;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calculadora";
            // 
            // buttonResta
            // 
            this.buttonResta.BackColor = System.Drawing.Color.White;
            this.buttonResta.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResta.Location = new System.Drawing.Point(289, 71);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(49, 34);
            this.buttonResta.TabIndex = 8;
            this.buttonResta.Text = "-";
            this.buttonResta.UseVisualStyleBackColor = false;
            // 
            // buttonSuma
            // 
            this.buttonSuma.BackColor = System.Drawing.Color.White;
            this.buttonSuma.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuma.Location = new System.Drawing.Point(289, 31);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(49, 34);
            this.buttonSuma.TabIndex = 9;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = false;
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.White;
            this.buttonDivision.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(289, 154);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(49, 34);
            this.buttonDivision.TabIndex = 10;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            // 
            // buttonMultiplicacion
            // 
            this.buttonMultiplicacion.BackColor = System.Drawing.Color.White;
            this.buttonMultiplicacion.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicacion.Location = new System.Drawing.Point(289, 113);
            this.buttonMultiplicacion.Name = "buttonMultiplicacion";
            this.buttonMultiplicacion.Size = new System.Drawing.Size(49, 34);
            this.buttonMultiplicacion.TabIndex = 11;
            this.buttonMultiplicacion.Text = "*";
            this.buttonMultiplicacion.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 12;
            // 
            // FormaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::Proyecto_Parcial1.Properties.Resources._4a6156bb_8768_446c_8f7d_cc56040c5813;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMultiplicacion);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxValor2);
            this.Controls.Add(this.textBoxValor1);
            this.Name = "FormaCalculadora";
            this.Text = "FormaCalculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValor1;
        private System.Windows.Forms.TextBox textBoxValor2;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplicacion;
        private System.Windows.Forms.Label label5;
    }
}