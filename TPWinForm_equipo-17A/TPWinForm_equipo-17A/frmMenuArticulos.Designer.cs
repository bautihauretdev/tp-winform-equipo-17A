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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnVerArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulos = new System.Windows.Forms.Button();
            this.btnModificarArticulos = new System.Windows.Forms.Button();
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
            this.btnBuscarArticulos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(0, 1);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(541, 143);
            this.dgvArticulos.TabIndex = 23;
            // 
            // btnVerArticulo
            // 
            this.btnVerArticulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVerArticulo.Location = new System.Drawing.Point(222, 396);
            this.btnVerArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerArticulo.Name = "btnVerArticulo";
            this.btnVerArticulo.Size = new System.Drawing.Size(95, 30);
            this.btnVerArticulo.TabIndex = 22;
            this.btnVerArticulo.Text = "&Ver Artículo";
            this.btnVerArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulos
            // 
            this.btnEliminarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminarArticulos.Location = new System.Drawing.Point(321, 396);
            this.btnEliminarArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarArticulos.Name = "btnEliminarArticulos";
            this.btnEliminarArticulos.Size = new System.Drawing.Size(95, 30);
            this.btnEliminarArticulos.TabIndex = 21;
            this.btnEliminarArticulos.Text = "&Eliminar";
            this.btnEliminarArticulos.UseVisualStyleBackColor = true;
            this.btnEliminarArticulos.Click += new System.EventHandler(this.btnEliminarArticulos_Click);
            // 
            // btnModificarArticulos
            // 
            this.btnModificarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModificarArticulos.Location = new System.Drawing.Point(420, 396);
            this.btnModificarArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarArticulos.Name = "btnModificarArticulos";
            this.btnModificarArticulos.Size = new System.Drawing.Size(95, 30);
            this.btnModificarArticulos.TabIndex = 19;
            this.btnModificarArticulos.Text = "&Modificar";
            this.btnModificarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArticulos
            // 
            this.btnAgregarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarArticulos.Location = new System.Drawing.Point(123, 396);
            this.btnAgregarArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarArticulos.Name = "btnAgregarArticulos";
            this.btnAgregarArticulos.Size = new System.Drawing.Size(95, 30);
            this.btnAgregarArticulos.TabIndex = 18;
            this.btnAgregarArticulos.Text = "&Agregar";
            this.btnAgregarArticulos.UseVisualStyleBackColor = true;
            this.btnAgregarArticulos.Click += new System.EventHandler(this.btnAgregarArticulos_Click);
            // 
            // btnBuscarArticulos
            // 
            this.btnBuscarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBuscarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscarArticulos.Location = new System.Drawing.Point(24, 396);
            this.btnBuscarArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarArticulos.Name = "btnBuscarArticulos";
            this.btnBuscarArticulos.Size = new System.Drawing.Size(95, 30);
            this.btnBuscarArticulos.TabIndex = 16;
            this.btnBuscarArticulos.Text = "&Buscar";
            this.btnBuscarArticulos.UseVisualStyleBackColor = true;
            // 
            // frmMenuArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 437);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnVerArticulo);
            this.Controls.Add(this.btnEliminarArticulos);
            this.Controls.Add(this.btnModificarArticulos);
            this.Controls.Add(this.btnAgregarArticulos);
            this.Controls.Add(this.btnBuscarArticulos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(444, 476);
            this.Name = "frmMenuArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Artículos";
            this.Load += new System.EventHandler(this.frmMenuArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnVerArticulo;
        private System.Windows.Forms.Button btnEliminarArticulos;
        private System.Windows.Forms.Button btnModificarArticulos;
        private System.Windows.Forms.Button btnAgregarArticulos;
        private System.Windows.Forms.Button btnBuscarArticulos;

    }
}