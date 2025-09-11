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
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarMarcas
            // 
            this.btnEliminarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarcas.Location = new System.Drawing.Point(151, 284);
            this.btnEliminarMarcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarMarcas.Name = "btnEliminarMarcas";
            this.btnEliminarMarcas.Size = new System.Drawing.Size(127, 39);
            this.btnEliminarMarcas.TabIndex = 9;
            this.btnEliminarMarcas.Text = "&Eliminar";
            this.btnEliminarMarcas.UseVisualStyleBackColor = true;
            // 
            // btnModificarMarcas
            // 
            this.btnModificarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMarcas.Location = new System.Drawing.Point(151, 229);
            this.btnModificarMarcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarMarcas.Name = "btnModificarMarcas";
            this.btnModificarMarcas.Size = new System.Drawing.Size(127, 39);
            this.btnModificarMarcas.TabIndex = 8;
            this.btnModificarMarcas.Text = "&Modificar";
            this.btnModificarMarcas.UseVisualStyleBackColor = true;
            // 
            // lblMenuMarcas
            // 
            this.lblMenuMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuMarcas.AutoSize = true;
            this.lblMenuMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuMarcas.Location = new System.Drawing.Point(157, 89);
            this.lblMenuMarcas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuMarcas.Name = "lblMenuMarcas";
            this.lblMenuMarcas.Size = new System.Drawing.Size(132, 25);
            this.lblMenuMarcas.TabIndex = 7;
            this.lblMenuMarcas.Text = "Menú Marcas";
            this.lblMenuMarcas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarMarcas
            // 
            this.btnAgregarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarcas.Location = new System.Drawing.Point(151, 177);
            this.btnAgregarMarcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarMarcas.Name = "btnAgregarMarcas";
            this.btnAgregarMarcas.Size = new System.Drawing.Size(127, 37);
            this.btnAgregarMarcas.TabIndex = 6;
            this.btnAgregarMarcas.Text = "&Agregar";
            this.btnAgregarMarcas.UseVisualStyleBackColor = true;
            // 
            // btnListarMarcas
            // 
            this.btnListarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarMarcas.Location = new System.Drawing.Point(151, 126);
            this.btnListarMarcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarMarcas.Name = "btnListarMarcas";
            this.btnListarMarcas.Size = new System.Drawing.Size(127, 37);
            this.btnListarMarcas.TabIndex = 10;
            this.btnListarMarcas.Text = "&Listar";
            this.btnListarMarcas.UseVisualStyleBackColor = true;
            this.btnListarMarcas.Click += new System.EventHandler(this.btnListarMarcas_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(79, 328);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(266, 97);
            this.dgvMarca.TabIndex = 11;
            // 
            // frmMenuMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 437);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.btnListarMarcas);
            this.Controls.Add(this.btnEliminarMarcas);
            this.Controls.Add(this.btnModificarMarcas);
            this.Controls.Add(this.lblMenuMarcas);
            this.Controls.Add(this.btnAgregarMarcas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(444, 476);
            this.MinimumSize = new System.Drawing.Size(444, 476);
            this.Name = "frmMenuMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarMarcas;
        private System.Windows.Forms.Button btnModificarMarcas;
        private System.Windows.Forms.Label lblMenuMarcas;
        private System.Windows.Forms.Button btnAgregarMarcas;
        private System.Windows.Forms.Button btnListarMarcas;
        private System.Windows.Forms.DataGridView dgvMarca;
    }
}