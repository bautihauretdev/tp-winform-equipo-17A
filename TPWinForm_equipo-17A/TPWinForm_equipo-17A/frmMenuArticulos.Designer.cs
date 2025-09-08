namespace TPWinForm_equipo_17A
{
    partial class frmMenuArticulos
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
            this.btnListarArticulos = new System.Windows.Forms.Button();
            this.btnModificarArticulos = new System.Windows.Forms.Button();
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
            this.lblMenuArticulos = new System.Windows.Forms.Label();
            this.btnBuscarArticulos = new System.Windows.Forms.Button();
            this.btnEliminarArticulos = new System.Windows.Forms.Button();
            this.btnVerArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarArticulos
            // 
            this.btnListarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarArticulos.Location = new System.Drawing.Point(195, 92);
            this.btnListarArticulos.Name = "btnListarArticulos";
            this.btnListarArticulos.Size = new System.Drawing.Size(169, 45);
            this.btnListarArticulos.TabIndex = 20;
            this.btnListarArticulos.Text = "&Listar";
            this.btnListarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnModificarArticulos
            // 
            this.btnModificarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulos.Location = new System.Drawing.Point(195, 287);
            this.btnModificarArticulos.Name = "btnModificarArticulos";
            this.btnModificarArticulos.Size = new System.Drawing.Size(169, 47);
            this.btnModificarArticulos.TabIndex = 19;
            this.btnModificarArticulos.Text = "&Modificar";
            this.btnModificarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArticulos
            // 
            this.btnAgregarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulos.Location = new System.Drawing.Point(195, 219);
            this.btnAgregarArticulos.Name = "btnAgregarArticulos";
            this.btnAgregarArticulos.Size = new System.Drawing.Size(169, 47);
            this.btnAgregarArticulos.TabIndex = 18;
            this.btnAgregarArticulos.Text = "&Agregar";
            this.btnAgregarArticulos.UseVisualStyleBackColor = true;
            // 
            // lblMenuArticulos
            // 
            this.lblMenuArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuArticulos.AutoSize = true;
            this.lblMenuArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuArticulos.Location = new System.Drawing.Point(182, 47);
            this.lblMenuArticulos.Name = "lblMenuArticulos";
            this.lblMenuArticulos.Size = new System.Drawing.Size(181, 29);
            this.lblMenuArticulos.TabIndex = 17;
            this.lblMenuArticulos.Text = "Menú Artículos";
            this.lblMenuArticulos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscarArticulos
            // 
            this.btnBuscarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArticulos.Location = new System.Drawing.Point(195, 155);
            this.btnBuscarArticulos.Name = "btnBuscarArticulos";
            this.btnBuscarArticulos.Size = new System.Drawing.Size(169, 45);
            this.btnBuscarArticulos.TabIndex = 16;
            this.btnBuscarArticulos.Text = "&Buscar";
            this.btnBuscarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulos
            // 
            this.btnEliminarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulos.Location = new System.Drawing.Point(195, 353);
            this.btnEliminarArticulos.Name = "btnEliminarArticulos";
            this.btnEliminarArticulos.Size = new System.Drawing.Size(169, 47);
            this.btnEliminarArticulos.TabIndex = 21;
            this.btnEliminarArticulos.Text = "&Eliminar";
            this.btnEliminarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnVerArticulo
            // 
            this.btnVerArticulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVerArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerArticulo.Location = new System.Drawing.Point(195, 419);
            this.btnVerArticulo.Name = "btnVerArticulo";
            this.btnVerArticulo.Size = new System.Drawing.Size(169, 47);
            this.btnVerArticulo.TabIndex = 22;
            this.btnVerArticulo.Text = "&Ver Artículo";
            this.btnVerArticulo.UseVisualStyleBackColor = true;
            // 
            // frmMenuArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 530);
            this.Controls.Add(this.btnVerArticulo);
            this.Controls.Add(this.btnEliminarArticulos);
            this.Controls.Add(this.btnListarArticulos);
            this.Controls.Add(this.btnModificarArticulos);
            this.Controls.Add(this.btnAgregarArticulos);
            this.Controls.Add(this.lblMenuArticulos);
            this.Controls.Add(this.btnBuscarArticulos);
            this.MaximumSize = new System.Drawing.Size(587, 577);
            this.MinimumSize = new System.Drawing.Size(587, 577);
            this.Name = "frmMenuArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Artículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarArticulos;
        private System.Windows.Forms.Button btnModificarArticulos;
        private System.Windows.Forms.Button btnAgregarArticulos;
        private System.Windows.Forms.Label lblMenuArticulos;
        private System.Windows.Forms.Button btnBuscarArticulos;
        private System.Windows.Forms.Button btnEliminarArticulos;
        private System.Windows.Forms.Button btnVerArticulo;
    }
}