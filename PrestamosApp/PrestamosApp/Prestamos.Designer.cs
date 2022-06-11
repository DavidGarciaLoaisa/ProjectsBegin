namespace PrestamosApp
{
    partial class Prestamos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.Saludo = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonComfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatosPersonales = new System.Windows.Forms.Panel();
            this.estado = new System.Windows.Forms.ComboBox();
            this.lugares = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatosPrestamo = new System.Windows.Forms.Panel();
            this.monto = new System.Windows.Forms.TextBox();
            this.cuota = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DatosPersonales.SuspendLayout();
            this.DatosPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludo.ForeColor = System.Drawing.Color.Black;
            this.Saludo.Location = new System.Drawing.Point(78, 40);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(158, 29);
            this.Saludo.TabIndex = 0;
            this.Saludo.Text = "Bienvenido, ";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Orange;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(679, 384);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(91, 40);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "VOLVER";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonComfirmar
            // 
            this.buttonComfirmar.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonComfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComfirmar.ForeColor = System.Drawing.Color.White;
            this.buttonComfirmar.Location = new System.Drawing.Point(333, 365);
            this.buttonComfirmar.Name = "buttonComfirmar";
            this.buttonComfirmar.Size = new System.Drawing.Size(122, 59);
            this.buttonComfirmar.TabIndex = 2;
            this.buttonComfirmar.Text = "Comfirmar solicitud";
            this.buttonComfirmar.UseVisualStyleBackColor = false;
            this.buttonComfirmar.Click += new System.EventHandler(this.buttonComfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(57, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos personales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(536, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalles del préstamo:";
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.BackColor = System.Drawing.Color.Khaki;
            this.DatosPersonales.Controls.Add(this.estado);
            this.DatosPersonales.Controls.Add(this.lugares);
            this.DatosPersonales.Controls.Add(this.label4);
            this.DatosPersonales.Controls.Add(this.label3);
            this.DatosPersonales.Location = new System.Drawing.Point(61, 190);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(315, 132);
            this.DatosPersonales.TabIndex = 5;
            // 
            // estado
            // 
            this.estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estado.FormattingEnabled = true;
            this.estado.Location = new System.Drawing.Point(145, 11);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(163, 21);
            this.estado.TabIndex = 13;
            // 
            // lugares
            // 
            this.lugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lugares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lugares.FormattingEnabled = true;
            this.lugares.Location = new System.Drawing.Point(145, 78);
            this.lugares.Name = "lugares";
            this.lugares.Size = new System.Drawing.Size(163, 21);
            this.lugares.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lugar de origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado civil:";
            // 
            // DatosPrestamo
            // 
            this.DatosPrestamo.BackColor = System.Drawing.Color.Khaki;
            this.DatosPrestamo.Controls.Add(this.monto);
            this.DatosPrestamo.Controls.Add(this.cuota);
            this.DatosPrestamo.Controls.Add(this.label6);
            this.DatosPrestamo.Controls.Add(this.label5);
            this.DatosPrestamo.Location = new System.Drawing.Point(409, 190);
            this.DatosPrestamo.Name = "DatosPrestamo";
            this.DatosPrestamo.Size = new System.Drawing.Size(335, 132);
            this.DatosPrestamo.TabIndex = 6;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(168, 12);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(160, 20);
            this.monto.TabIndex = 14;
            // 
            // cuota
            // 
            this.cuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuota.FormattingEnabled = true;
            this.cuota.Location = new System.Drawing.Point(168, 78);
            this.cuota.Name = "cuota";
            this.cuota.Size = new System.Drawing.Size(160, 21);
            this.cuota.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cuotas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Monto del préstamo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.DatosPrestamo);
            this.Controls.Add(this.DatosPersonales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonComfirmar);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.Saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            this.DatosPrestamo.ResumeLayout(false);
            this.DatosPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonComfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DatosPersonales;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.ComboBox lugares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel DatosPrestamo;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.ComboBox cuota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}