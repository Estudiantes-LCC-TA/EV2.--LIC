
namespace Lenguaje_y_Alfabeto_2
{
	partial class LIC
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LIC));
            this.BotonValidar = new System.Windows.Forms.Button();
            this.Mat = new System.Windows.Forms.TextBox();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.L3 = new System.Windows.Forms.Label();
            this.CadenaValidar = new System.Windows.Forms.TextBox();
            this.CV = new System.Windows.Forms.Label();
            this.CVIn = new System.Windows.Forms.Label();
            this.LCV = new System.Windows.Forms.ListBox();
            this.LCVIn = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BotonValidar
            // 
            this.BotonValidar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BotonValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonValidar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonValidar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonValidar.Location = new System.Drawing.Point(141, 280);
            this.BotonValidar.Name = "BotonValidar";
            this.BotonValidar.Size = new System.Drawing.Size(142, 49);
            this.BotonValidar.TabIndex = 0;
            this.BotonValidar.Text = "Validar Cadena";
            this.BotonValidar.UseVisualStyleBackColor = false;
            this.BotonValidar.Click += new System.EventHandler(this.Boton_Click);
            // 
            // Mat
            // 
            this.Mat.Location = new System.Drawing.Point(118, 137);
            this.Mat.Name = "Mat";
            this.Mat.Size = new System.Drawing.Size(230, 20);
            this.Mat.TabIndex = 1;
            this.Mat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mat_KeyPress);
            // 
            // L1
            // 
            this.L1.AutoEllipsis = true;
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.L1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.L1.Location = new System.Drawing.Point(41, 65);
            this.L1.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.L1.MaximumSize = new System.Drawing.Size(600, 50);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(107, 16);
            this.L1.TabIndex = 2;
            this.L1.Text = "Nombre Completo:";
            this.L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L2
            // 
            this.L2.AutoEllipsis = true;
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.L2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.L2.Location = new System.Drawing.Point(41, 137);
            this.L2.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.L2.MaximumSize = new System.Drawing.Size(100, 100);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(63, 16);
            this.L2.TabIndex = 3;
            this.L2.Text = "Matricula:";
            this.L2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(44, 95);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(304, 20);
            this.Nom.TabIndex = 4;
            this.Nom.TextChanged += new System.EventHandler(this.Nom_TextChanged);
            this.Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nom_KeyPress);
            // 
            // L3
            // 
            this.L3.AutoEllipsis = true;
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.L3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.L3.Location = new System.Drawing.Point(41, 186);
            this.L3.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.L3.MaximumSize = new System.Drawing.Size(300, 100);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(116, 16);
            this.L3.TabIndex = 5;
            this.L3.Text = "Ingrese una cadena:";
            this.L3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L3.Click += new System.EventHandler(this.label2_Click);
            // 
            // CadenaValidar
            // 
            this.CadenaValidar.Location = new System.Drawing.Point(44, 216);
            this.CadenaValidar.Name = "CadenaValidar";
            this.CadenaValidar.Size = new System.Drawing.Size(304, 20);
            this.CadenaValidar.TabIndex = 6;
            this.CadenaValidar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadenaValidar_KeyPress);
            // 
            // CV
            // 
            this.CV.AutoEllipsis = true;
            this.CV.AutoSize = true;
            this.CV.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.CV.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CV.Location = new System.Drawing.Point(393, 80);
            this.CV.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CV.MaximumSize = new System.Drawing.Size(300, 100);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(90, 16);
            this.CV.TabIndex = 9;
            this.CV.Text = "Cadenas Válidas";
            this.CV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CVIn
            // 
            this.CVIn.AutoEllipsis = true;
            this.CVIn.AutoSize = true;
            this.CVIn.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.CVIn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CVIn.Location = new System.Drawing.Point(393, 264);
            this.CVIn.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CVIn.MaximumSize = new System.Drawing.Size(300, 100);
            this.CVIn.Name = "CVIn";
            this.CVIn.Size = new System.Drawing.Size(100, 16);
            this.CVIn.TabIndex = 10;
            this.CVIn.Text = "Cadenas Inválidas";
            this.CVIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LCV
            // 
            this.LCV.FormattingEnabled = true;
            this.LCV.Location = new System.Drawing.Point(506, 21);
            this.LCV.Name = "LCV";
            this.LCV.Size = new System.Drawing.Size(165, 147);
            this.LCV.TabIndex = 11;
            // 
            // LCVIn
            // 
            this.LCVIn.FormattingEnabled = true;
            this.LCVIn.Location = new System.Drawing.Point(506, 199);
            this.LCVIn.Name = "LCVIn";
            this.LCVIn.Size = new System.Drawing.Size(165, 147);
            this.LCVIn.TabIndex = 12;
            // 
            // LIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 372);
            this.Controls.Add(this.LCVIn);
            this.Controls.Add(this.LCV);
            this.Controls.Add(this.CVIn);
            this.Controls.Add(this.CV);
            this.Controls.Add(this.CadenaValidar);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.Mat);
            this.Controls.Add(this.BotonValidar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LIC";
            this.Text = "Lenguaje Independiente del Contexto";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button BotonValidar;
        private System.Windows.Forms.TextBox Mat;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.TextBox CadenaValidar;
        private System.Windows.Forms.Label CV;
        private System.Windows.Forms.Label CVIn;
        private System.Windows.Forms.ListBox LCV;
        private System.Windows.Forms.ListBox LCVIn;
    }
}

