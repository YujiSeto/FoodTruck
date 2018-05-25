namespace FoodTruck.Grafico
{
    partial class TelaListaPedidos
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
            this.dgListaPedidos = new System.Windows.Forms.DataGridView();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaPedidos
            // 
            this.dgListaPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NomeCliente,
            this.DataCompra,
            this.Valor});
            this.dgListaPedidos.Location = new System.Drawing.Point(11, 49);
            this.dgListaPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgListaPedidos.Name = "dgListaPedidos";
            this.dgListaPedidos.RowTemplate.Height = 24;
            this.dgListaPedidos.Size = new System.Drawing.Size(778, 392);
            this.dgListaPedidos.TabIndex = 14;
            this.dgListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaPedidos_CellContentClick);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(153, 9);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(67, 35);
            this.btAlterar.TabIndex = 13;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(81, 9);
            this.btRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(67, 35);
            this.btRemover.TabIndex = 12;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "NomeCliente";
            this.NomeCliente.HeaderText = "Cliente";
            this.NomeCliente.Name = "NomeCliente";
            // 
            // DataCompra
            // 
            this.DataCompra.DataPropertyName = "DataCompra";
            this.DataCompra.HeaderText = "Data da Compra";
            this.DataCompra.Name = "DataCompra";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "ValorTotal";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // TelaListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgListaPedidos);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btRemover);
            this.Name = "TelaListaPedidos";
            this.Text = "TelaListaPedidos";
            this.Load += new System.EventHandler(this.TelaListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaPedidos;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}