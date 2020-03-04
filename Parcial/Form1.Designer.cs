namespace Parcial
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.Lblrespuesta2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnconvertir2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtcantidad2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convertir";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dólares",
            "Colones (SV)       ",
            "Yenes",
            " Rupia",
            "Peso (Chileno) ",
            "Peso (MX) ",
            "Peso (Argentino)   ",
            "Bitcoin  "});
            this.comboBox1.Location = new System.Drawing.Point(51, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Dólares",
            "Colones (SV)       ",
            "Yenes",
            " Rupia",
            "Peso (Chileno) ",
            "Peso (MX) ",
            "Peso (Argentino)   ",
            "Bitcoin  "});
            this.comboBox2.Location = new System.Drawing.Point(51, 154);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(72, 224);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "A";
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.Location = new System.Drawing.Point(96, 192);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(35, 13);
            this.LblRespuesta.TabIndex = 5;
            this.LblRespuesta.Text = "label3";
            // 
            // Lblrespuesta2
            // 
            this.Lblrespuesta2.AutoSize = true;
            this.Lblrespuesta2.Location = new System.Drawing.Point(483, 192);
            this.Lblrespuesta2.Name = "Lblrespuesta2";
            this.Lblrespuesta2.Size = new System.Drawing.Size(35, 13);
            this.Lblrespuesta2.TabIndex = 11;
            this.Lblrespuesta2.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "A";
            // 
            // btnconvertir2
            // 
            this.btnconvertir2.Location = new System.Drawing.Point(457, 224);
            this.btnconvertir2.Name = "btnconvertir2";
            this.btnconvertir2.Size = new System.Drawing.Size(75, 23);
            this.btnconvertir2.TabIndex = 9;
            this.btnconvertir2.Text = "Convertir";
            this.btnconvertir2.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Megabyte",
            "bit",
            "byte",
            "Kilobyte",
            "Gigabyte  ",
            "Terabyte"});
            this.comboBox3.Location = new System.Drawing.Point(438, 154);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            " Megabyte",
            "bit",
            "byte",
            "Kilobyte",
            "Gigabyte  ",
            "Terabyte"});
            this.comboBox4.Location = new System.Drawing.Point(438, 89);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Convertir";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(61, 53);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 12;
            // 
            // txtcantidad2
            // 
            this.txtcantidad2.Location = new System.Drawing.Point(449, 53);
            this.txtcantidad2.Name = "txtcantidad2";
            this.txtcantidad2.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 357);
            this.Controls.Add(this.txtcantidad2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.Lblrespuesta2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnconvertir2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.Label Lblrespuesta2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnconvertir2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtcantidad2;
    }
}

