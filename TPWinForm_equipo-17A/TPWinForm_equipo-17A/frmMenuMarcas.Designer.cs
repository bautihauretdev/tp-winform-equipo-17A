namespace TPWinForm_equipo_17A
{
    partial class frmMenuMarcas
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
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.lblMenuMarcas = new System.Windows.Forms.Label();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategorias
            // 
            this.btnCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Location = new System.Drawing.Point(201, 350);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(169, 48);
            this.btnCategorias.TabIndex = 9;
            this.btnCategorias.Text = "&Eliminar";
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnMarcas
            // 
            this.btnMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(201, 282);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(169, 48);
            this.btnMarcas.TabIndex = 8;
            this.btnMarcas.Text = "&Modificar";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // lblMenuMarcas
            // 
            this.lblMenuMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuMarcas.AutoSize = true;
            this.lblMenuMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuMarcas.Location = new System.Drawing.Point(209, 110);
            this.lblMenuMarcas.Name = "lblMenuMarcas";
            this.lblMenuMarcas.Size = new System.Drawing.Size(166, 29);
            this.lblMenuMarcas.TabIndex = 7;
            this.lblMenuMarcas.Text = "Menú Marcas";
            this.lblMenuMarcas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnArticulos
            // 
            this.btnArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Location = new System.Drawing.Point(201, 218);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(169, 46);
            this.btnArticulos.TabIndex = 6;
            this.btnArticulos.Text = "&Agregar";
            this.btnArticulos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(201, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Listar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMenuMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.lblMenuMarcas);
            this.Controls.Add(this.btnArticulos);
            this.MaximumSize = new System.Drawing.Size(587, 577);
            this.MinimumSize = new System.Drawing.Size(587, 577);
            this.Name = "frmMenuMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Marcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Label lblMenuMarcas;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button button1;
    }
}