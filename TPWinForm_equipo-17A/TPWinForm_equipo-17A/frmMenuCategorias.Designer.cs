namespace TPWinForm_equipo_17A
{
    partial class frmMenuCategorias
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
            this.btnListarCategorias = new System.Windows.Forms.Button();
            this.btnEliminarCategorias = new System.Windows.Forms.Button();
            this.btnModificarCategorias = new System.Windows.Forms.Button();
            this.lblMenuCategorias = new System.Windows.Forms.Label();
            this.btnAgregarCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarCategorias
            // 
            this.btnListarCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCategorias.Location = new System.Drawing.Point(201, 155);
            this.btnListarCategorias.Name = "btnListarCategorias";
            this.btnListarCategorias.Size = new System.Drawing.Size(169, 45);
            this.btnListarCategorias.TabIndex = 15;
            this.btnListarCategorias.Text = "&Listar";
            this.btnListarCategorias.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategorias
            // 
            this.btnEliminarCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategorias.Location = new System.Drawing.Point(201, 350);
            this.btnEliminarCategorias.Name = "btnEliminarCategorias";
            this.btnEliminarCategorias.Size = new System.Drawing.Size(169, 47);
            this.btnEliminarCategorias.TabIndex = 14;
            this.btnEliminarCategorias.Text = "&Eliminar";
            this.btnEliminarCategorias.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategorias
            // 
            this.btnModificarCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategorias.Location = new System.Drawing.Point(201, 282);
            this.btnModificarCategorias.Name = "btnModificarCategorias";
            this.btnModificarCategorias.Size = new System.Drawing.Size(169, 47);
            this.btnModificarCategorias.TabIndex = 13;
            this.btnModificarCategorias.Text = "&Modificar";
            this.btnModificarCategorias.UseVisualStyleBackColor = true;
            // 
            // lblMenuCategorias
            // 
            this.lblMenuCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuCategorias.AutoSize = true;
            this.lblMenuCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuCategorias.Location = new System.Drawing.Point(188, 110);
            this.lblMenuCategorias.Name = "lblMenuCategorias";
            this.lblMenuCategorias.Size = new System.Drawing.Size(205, 29);
            this.lblMenuCategorias.TabIndex = 12;
            this.lblMenuCategorias.Text = "Menú Categorías";
            this.lblMenuCategorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarCategorias
            // 
            this.btnAgregarCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategorias.Location = new System.Drawing.Point(201, 218);
            this.btnAgregarCategorias.Name = "btnAgregarCategorias";
            this.btnAgregarCategorias.Size = new System.Drawing.Size(169, 45);
            this.btnAgregarCategorias.TabIndex = 11;
            this.btnAgregarCategorias.Text = "&Agregar";
            this.btnAgregarCategorias.UseVisualStyleBackColor = true;
            // 
            // frmMenuCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 530);
            this.Controls.Add(this.btnListarCategorias);
            this.Controls.Add(this.btnEliminarCategorias);
            this.Controls.Add(this.btnModificarCategorias);
            this.Controls.Add(this.lblMenuCategorias);
            this.Controls.Add(this.btnAgregarCategorias);
            this.MaximumSize = new System.Drawing.Size(587, 577);
            this.MinimumSize = new System.Drawing.Size(587, 577);
            this.Name = "frmMenuCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Categorías";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarCategorias;
        private System.Windows.Forms.Button btnEliminarCategorias;
        private System.Windows.Forms.Button btnModificarCategorias;
        private System.Windows.Forms.Label lblMenuCategorias;
        private System.Windows.Forms.Button btnAgregarCategorias;
    }
}