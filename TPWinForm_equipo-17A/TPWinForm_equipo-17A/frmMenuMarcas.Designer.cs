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
            this.btnEliminarMarcas = new System.Windows.Forms.Button();
            this.btnModificarMarcas = new System.Windows.Forms.Button();
            this.lblMenuMarcas = new System.Windows.Forms.Label();
            this.btnAgregarMarcas = new System.Windows.Forms.Button();
            this.btnListarMarcas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminarMarcas
            // 
            this.btnEliminarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarcas.Location = new System.Drawing.Point(201, 350);
            this.btnEliminarMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarMarcas.Name = "btnEliminarMarcas";
            this.btnEliminarMarcas.Size = new System.Drawing.Size(169, 48);
            this.btnEliminarMarcas.TabIndex = 9;
            this.btnEliminarMarcas.Text = "&Eliminar";
            this.btnEliminarMarcas.UseVisualStyleBackColor = true;
            // 
            // btnModificarMarcas
            // 
            this.btnModificarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMarcas.Location = new System.Drawing.Point(201, 282);
            this.btnModificarMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarMarcas.Name = "btnModificarMarcas";
            this.btnModificarMarcas.Size = new System.Drawing.Size(169, 48);
            this.btnModificarMarcas.TabIndex = 8;
            this.btnModificarMarcas.Text = "&Modificar";
            this.btnModificarMarcas.UseVisualStyleBackColor = true;
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
            // btnAgregarMarcas
            // 
            this.btnAgregarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarcas.Location = new System.Drawing.Point(201, 218);
            this.btnAgregarMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarMarcas.Name = "btnAgregarMarcas";
            this.btnAgregarMarcas.Size = new System.Drawing.Size(169, 46);
            this.btnAgregarMarcas.TabIndex = 6;
            this.btnAgregarMarcas.Text = "&Agregar";
            this.btnAgregarMarcas.UseVisualStyleBackColor = true;
            // 
            // btnListarMarcas
            // 
            this.btnListarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarMarcas.Location = new System.Drawing.Point(201, 155);
            this.btnListarMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarMarcas.Name = "btnListarMarcas";
            this.btnListarMarcas.Size = new System.Drawing.Size(169, 46);
            this.btnListarMarcas.TabIndex = 10;
            this.btnListarMarcas.Text = "&Listar";
            this.btnListarMarcas.UseVisualStyleBackColor = true;
            this.btnListarMarcas.Click += new System.EventHandler(this.btnListarMarcas_Click);
            // 
            // frmMenuMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 528);
            this.Controls.Add(this.btnListarMarcas);
            this.Controls.Add(this.btnEliminarMarcas);
            this.Controls.Add(this.btnModificarMarcas);
            this.Controls.Add(this.lblMenuMarcas);
            this.Controls.Add(this.btnAgregarMarcas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(586, 575);
            this.MinimumSize = new System.Drawing.Size(586, 575);
            this.Name = "frmMenuMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Marcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarMarcas;
        private System.Windows.Forms.Button btnModificarMarcas;
        private System.Windows.Forms.Label lblMenuMarcas;
        private System.Windows.Forms.Button btnAgregarMarcas;
        private System.Windows.Forms.Button btnListarMarcas;
    }
}