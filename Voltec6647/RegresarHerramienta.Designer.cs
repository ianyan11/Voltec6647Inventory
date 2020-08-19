namespace Voltec6647
{
    partial class RegresarHeramienta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.herramientasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Voltec6647.DatabaseDataSet();
            this.herramientasTableAdapter = new Voltec6647.DatabaseDataSetTableAdapters.HerramientasTableAdapter();
            this.databaseDataSet1 = new Voltec6647.DatabaseDataSet1();
            this.prestadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestadasTableAdapter = new Voltec6647.DatabaseDataSet1TableAdapters.PrestadasTableAdapter();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.herramientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.páginaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.áreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(-36, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 80);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Voltec6647.Properties.Resources.VOOLTEC_LOGO_01__1_;
            this.pictureBox1.Location = new System.Drawing.Point(1197, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("NeueHaasGroteskDisp W02 Blk", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.button1.Location = new System.Drawing.Point(27, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "REGRESAR HERRAMIENTA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("NeueHaasGroteskDisp W02 Blk", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.button2.Location = new System.Drawing.Point(27, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "REGRESAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.herramientaDataGridViewTextBoxColumn,
            this.cantidadStockDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn,
            this.páginaDataGridViewTextBoxColumn,
            this.descripciónDataGridViewTextBoxColumn,
            this.áreaDataGridViewTextBoxColumn,
            this.cajónDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prestadasBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(285, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(995, 520);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // herramientasBindingSource
            // 
            this.herramientasBindingSource.DataMember = "Herramientas";
            this.herramientasBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // herramientasTableAdapter
            // 
            this.herramientasTableAdapter.ClearBeforeFill = true;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestadasBindingSource
            // 
            this.prestadasBindingSource.DataMember = "Prestadas";
            this.prestadasBindingSource.DataSource = this.databaseDataSet1;
            // 
            // prestadasTableAdapter
            // 
            this.prestadasTableAdapter.ClearBeforeFill = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // herramientaDataGridViewTextBoxColumn
            // 
            this.herramientaDataGridViewTextBoxColumn.DataPropertyName = "Herramienta";
            this.herramientaDataGridViewTextBoxColumn.HeaderText = "Herramienta";
            this.herramientaDataGridViewTextBoxColumn.Name = "herramientaDataGridViewTextBoxColumn";
            this.herramientaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadStockDataGridViewTextBoxColumn
            // 
            this.cantidadStockDataGridViewTextBoxColumn.DataPropertyName = "CantidadStock";
            this.cantidadStockDataGridViewTextBoxColumn.HeaderText = "CantidadStock";
            this.cantidadStockDataGridViewTextBoxColumn.Name = "cantidadStockDataGridViewTextBoxColumn";
            this.cantidadStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            this.imagenDataGridViewImageColumn.ReadOnly = true;
            // 
            // páginaDataGridViewTextBoxColumn
            // 
            this.páginaDataGridViewTextBoxColumn.DataPropertyName = "Página";
            this.páginaDataGridViewTextBoxColumn.HeaderText = "Página";
            this.páginaDataGridViewTextBoxColumn.Name = "páginaDataGridViewTextBoxColumn";
            this.páginaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripciónDataGridViewTextBoxColumn
            // 
            this.descripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción";
            this.descripciónDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripciónDataGridViewTextBoxColumn.Name = "descripciónDataGridViewTextBoxColumn";
            this.descripciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // áreaDataGridViewTextBoxColumn
            // 
            this.áreaDataGridViewTextBoxColumn.DataPropertyName = "Área";
            this.áreaDataGridViewTextBoxColumn.HeaderText = "Área";
            this.áreaDataGridViewTextBoxColumn.Name = "áreaDataGridViewTextBoxColumn";
            this.áreaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cajónDataGridViewTextBoxColumn
            // 
            this.cajónDataGridViewTextBoxColumn.DataPropertyName = "Cajón";
            this.cajónDataGridViewTextBoxColumn.HeaderText = "Cajón";
            this.cajónDataGridViewTextBoxColumn.Name = "cajónDataGridViewTextBoxColumn";
            this.cajónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RegresarHeramienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "RegresarHeramienta";
            this.Text = "Form1  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CopiarBase_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestadasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource herramientasBindingSource;
        private DatabaseDataSetTableAdapters.HerramientasTableAdapter herramientasTableAdapter;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource prestadasBindingSource;
        private DatabaseDataSet1TableAdapters.PrestadasTableAdapter prestadasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn herramientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn páginaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn áreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajónDataGridViewTextBoxColumn;
    }
}

