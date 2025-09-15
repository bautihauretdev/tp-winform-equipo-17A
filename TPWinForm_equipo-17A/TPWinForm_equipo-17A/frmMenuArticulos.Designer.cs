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
            this.btnEliminarArticulos = new System.Windows.Forms.Button();
            this.btnModificarArticulos = new System.Windows.Forms.Button();
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
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
            this.dgvArticulos.Location = new System.Drawing.Point(9, 9);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(761, 310);
            this.dgvArticulos.TabIndex = 23;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnEliminarArticulos
            // 
            this.btnEliminarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminarArticulos.Location = new System.Drawing.Point(463, 491);
            this.btnEliminarArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarArticulos.Name = "btnEliminarArticulos";
            this.btnEliminarArticulos.Size = new System.Drawing.Size(127, 37);
            this.btnEliminarArticulos.TabIndex = 21;
            this.btnEliminarArticulos.Text = "&Eliminar";
            this.btnEliminarArticulos.UseVisualStyleBackColor = true;
            this.btnEliminarArticulos.Click += new System.EventHandler(this.btnEliminarArticulos_Click);
            // 
            // btnModificarArticulos
            // 
            this.btnModificarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModificarArticulos.Location = new System.Drawing.Point(635, 491);
            this.btnModificarArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarArticulos.Name = "btnModificarArticulos";
            this.btnModificarArticulos.Size = new System.Drawing.Size(127, 37);
            this.btnModificarArticulos.TabIndex = 19;
            this.btnModificarArticulos.Text = "&Modificar";
            this.btnModificarArticulos.UseVisualStyleBackColor = true;
            this.btnModificarArticulos.Click += new System.EventHandler(this.btnModificarArticulos_Click);
            // 
            // btnAgregarArticulos
            // 
            this.btnAgregarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarArticulos.Location = new System.Drawing.Point(276, 491);
            this.btnAgregarArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarArticulos.Name = "btnAgregarArticulos";
            this.btnAgregarArticulos.Size = new System.Drawing.Size(127, 37);
            this.btnAgregarArticulos.TabIndex = 18;
            this.btnAgregarArticulos.Text = "&Agregar";
            this.btnAgregarArticulos.UseVisualStyleBackColor = true;
            this.btnAgregarArticulos.Click += new System.EventHandler(this.btnAgregarArticulos_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.pbxArticulo.Location = new System.Drawing.Point(779, 15);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxArticulo.MaximumSize = new System.Drawing.Size(1132, 297);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(249, 297);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 24;
            this.pbxArticulo.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(306, 328);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 29);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(9, 329);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(291, 27);
            this.txtBuscar.TabIndex = 27;
            // 
            // frmMenuArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 532);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnEliminarArticulos);
            this.Controls.Add(this.btnModificarArticulos);
            this.Controls.Add(this.btnAgregarArticulos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1059, 579);
            this.MinimumSize = new System.Drawing.Size(586, 574);
            this.Name = "frmMenuArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Artículos";
            this.Load += new System.EventHandler(this.frmMenuArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnEliminarArticulos;
        private System.Windows.Forms.Button btnModificarArticulos;
        private System.Windows.Forms.Button btnAgregarArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}