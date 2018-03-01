namespace ArchivosdeTextoyArchivosBinarios
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
            this.txtFactName = new System.Windows.Forms.TextBox();
            this.txtFactPet = new System.Windows.Forms.TextBox();
            this.txtFactColor = new System.Windows.Forms.TextBox();
            this.txtFactAddress = new System.Windows.Forms.TextBox();
            this.txtFactNumber = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sfdWindowSave = new System.Windows.Forms.SaveFileDialog();
            this.txtResultadobmp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ofdBitmap = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtFactName
            // 
            this.txtFactName.Location = new System.Drawing.Point(122, 129);
            this.txtFactName.Name = "txtFactName";
            this.txtFactName.Size = new System.Drawing.Size(100, 20);
            this.txtFactName.TabIndex = 0;
            // 
            // txtFactPet
            // 
            this.txtFactPet.Location = new System.Drawing.Point(122, 240);
            this.txtFactPet.Name = "txtFactPet";
            this.txtFactPet.Size = new System.Drawing.Size(100, 20);
            this.txtFactPet.TabIndex = 1;
            // 
            // txtFactColor
            // 
            this.txtFactColor.Location = new System.Drawing.Point(122, 214);
            this.txtFactColor.Name = "txtFactColor";
            this.txtFactColor.Size = new System.Drawing.Size(100, 20);
            this.txtFactColor.TabIndex = 2;
            // 
            // txtFactAddress
            // 
            this.txtFactAddress.Location = new System.Drawing.Point(122, 188);
            this.txtFactAddress.Name = "txtFactAddress";
            this.txtFactAddress.Size = new System.Drawing.Size(100, 20);
            this.txtFactAddress.TabIndex = 3;
            // 
            // txtFactNumber
            // 
            this.txtFactNumber.Location = new System.Drawing.Point(122, 162);
            this.txtFactNumber.Name = "txtFactNumber";
            this.txtFactNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFactNumber.TabIndex = 4;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(260, 136);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear XML";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero de Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Color Favorito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mascota Favorita";
            // 
            // txtResultadobmp
            // 
            this.txtResultadobmp.Location = new System.Drawing.Point(149, 12);
            this.txtResultadobmp.Multiline = true;
            this.txtResultadobmp.Name = "txtResultadobmp";
            this.txtResultadobmp.Size = new System.Drawing.Size(244, 78);
            this.txtResultadobmp.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Abrir bit map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofdBitmap
            // 
            this.ofdBitmap.FileName = "ofdBitmap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultadobmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtFactNumber);
            this.Controls.Add(this.txtFactAddress);
            this.Controls.Add(this.txtFactColor);
            this.Controls.Add(this.txtFactPet);
            this.Controls.Add(this.txtFactName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFactName;
        private System.Windows.Forms.TextBox txtFactPet;
        private System.Windows.Forms.TextBox txtFactColor;
        private System.Windows.Forms.TextBox txtFactAddress;
        private System.Windows.Forms.TextBox txtFactNumber;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog sfdWindowSave;
        private System.Windows.Forms.TextBox txtResultadobmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofdBitmap;
    }
}

