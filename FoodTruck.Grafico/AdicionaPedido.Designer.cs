using System;

namespace FoodTruck.Grafico
{
    partial class AdicionaPedido
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.cbBebidas = new System.Windows.Forms.ComboBox();
            this.cbLanches = new System.Windows.Forms.ComboBox();
            this.btAdicionaBebida = new System.Windows.Forms.Button();
            this.btAdicionaLanche = new System.Windows.Forms.Button();
            this.dgPedidoBebidas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPedidoLanches = new System.Windows.Forms.DataGridView();
            this.NomeLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLanche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btRemoverBebidaSelecionada = new System.Windows.Forms.Button();
            this.btRemoverLanche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoLanches)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bebidas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lanches:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente:";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(63, 20);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(496, 21);
            this.cbClientes.TabIndex = 5;
            // 
            // cbBebidas
            // 
            this.cbBebidas.FormattingEnabled = true;
            this.cbBebidas.Location = new System.Drawing.Point(63, 51);
            this.cbBebidas.Margin = new System.Windows.Forms.Padding(2);
            this.cbBebidas.Name = "cbBebidas";
            this.cbBebidas.Size = new System.Drawing.Size(213, 21);
            this.cbBebidas.TabIndex = 6;
            // 
            // cbLanches
            // 
            this.cbLanches.FormattingEnabled = true;
            this.cbLanches.Location = new System.Drawing.Point(346, 51);
            this.cbLanches.Margin = new System.Windows.Forms.Padding(2);
            this.cbLanches.Name = "cbLanches";
            this.cbLanches.Size = new System.Drawing.Size(213, 21);
            this.cbLanches.TabIndex = 7;
            // 
            // btAdicionaBebida
            // 
            this.btAdicionaBebida.Location = new System.Drawing.Point(62, 75);
            this.btAdicionaBebida.Margin = new System.Windows.Forms.Padding(2);
            this.btAdicionaBebida.Name = "btAdicionaBebida";
            this.btAdicionaBebida.Size = new System.Drawing.Size(83, 19);
            this.btAdicionaBebida.TabIndex = 8;
            this.btAdicionaBebida.Text = "Adicionar";
            this.btAdicionaBebida.UseVisualStyleBackColor = true;
            this.btAdicionaBebida.Click += new System.EventHandler(this.btAdicionaBebida_Click);
            // 
            // btAdicionaLanche
            // 
            this.btAdicionaLanche.Location = new System.Drawing.Point(346, 74);
            this.btAdicionaLanche.Margin = new System.Windows.Forms.Padding(2);
            this.btAdicionaLanche.Name = "btAdicionaLanche";
            this.btAdicionaLanche.Size = new System.Drawing.Size(87, 19);
            this.btAdicionaLanche.TabIndex = 9;
            this.btAdicionaLanche.Text = "Adicionar";
            this.btAdicionaLanche.UseVisualStyleBackColor = true;
            this.btAdicionaLanche.Click += new System.EventHandler(this.btAdicionaLanche_Click);
            // 
            // dgPedidoBebidas
            // 
            this.dgPedidoBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidoBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Tamanho,
            this.Valor});
            this.dgPedidoBebidas.Location = new System.Drawing.Point(14, 99);
            this.dgPedidoBebidas.Margin = new System.Windows.Forms.Padding(2);
            this.dgPedidoBebidas.Name = "dgPedidoBebidas";
            this.dgPedidoBebidas.RowTemplate.Height = 24;
            this.dgPedidoBebidas.Size = new System.Drawing.Size(262, 215);
            this.dgPedidoBebidas.TabIndex = 10;
            this.dgPedidoBebidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBebidas_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Tamanho
            // 
            this.Tamanho.DataPropertyName = "Tamanho";
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // dgPedidoLanches
            // 
            this.dgPedidoLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidoLanches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeLanche,
            this.ValorLanche});
            this.dgPedidoLanches.Location = new System.Drawing.Point(300, 99);
            this.dgPedidoLanches.Margin = new System.Windows.Forms.Padding(2);
            this.dgPedidoLanches.Name = "dgPedidoLanches";
            this.dgPedidoLanches.RowTemplate.Height = 24;
            this.dgPedidoLanches.Size = new System.Drawing.Size(260, 215);
            this.dgPedidoLanches.TabIndex = 11;
            // 
            // NomeLanche
            // 
            this.NomeLanche.DataPropertyName = "Nome";
            this.NomeLanche.HeaderText = "Nome";
            this.NomeLanche.Name = "NomeLanche";
            this.NomeLanche.ReadOnly = true;
            // 
            // ValorLanche
            // 
            this.ValorLanche.DataPropertyName = "Valor";
            this.ValorLanche.HeaderText = "Valor";
            this.ValorLanche.Name = "ValorLanche";
            this.ValorLanche.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(498, 328);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor total:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(76, 328);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 14;
            // 
            // btRemoverBebidaSelecionada
            // 
            this.btRemoverBebidaSelecionada.Location = new System.Drawing.Point(200, 75);
            this.btRemoverBebidaSelecionada.Margin = new System.Windows.Forms.Padding(2);
            this.btRemoverBebidaSelecionada.Name = "btRemoverBebidaSelecionada";
            this.btRemoverBebidaSelecionada.Size = new System.Drawing.Size(77, 19);
            this.btRemoverBebidaSelecionada.TabIndex = 15;
            this.btRemoverBebidaSelecionada.Text = "Remover";
            this.btRemoverBebidaSelecionada.UseVisualStyleBackColor = true;
            this.btRemoverBebidaSelecionada.Click += new System.EventHandler(this.btRemoverBebidaSelecionada_Click);
            // 
            // btRemoverLanche
            // 
            this.btRemoverLanche.Location = new System.Drawing.Point(475, 75);
            this.btRemoverLanche.Margin = new System.Windows.Forms.Padding(2);
            this.btRemoverLanche.Name = "btRemoverLanche";
            this.btRemoverLanche.Size = new System.Drawing.Size(85, 19);
            this.btRemoverLanche.TabIndex = 16;
            this.btRemoverLanche.Text = "Remover";
            this.btRemoverLanche.UseVisualStyleBackColor = true;
            this.btRemoverLanche.Click += new System.EventHandler(this.btRemoverLanche_Click);
            // 
            // AdicionaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 368);
            this.Controls.Add(this.btRemoverLanche);
            this.Controls.Add(this.btRemoverBebidaSelecionada);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgPedidoLanches);
            this.Controls.Add(this.dgPedidoBebidas);
            this.Controls.Add(this.btAdicionaLanche);
            this.Controls.Add(this.btAdicionaBebida);
            this.Controls.Add(this.cbLanches);
            this.Controls.Add(this.cbBebidas);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdicionaPedido";
            this.Text = "AdicionaPedido";
            this.Load += new System.EventHandler(this.AdicionaPedido_Load);
            this.Shown += new System.EventHandler(this.AdicionaPedido_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidoLanches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.ComboBox cbBebidas;
        private System.Windows.Forms.ComboBox cbLanches;
        private System.Windows.Forms.Button btAdicionaBebida;
        private System.Windows.Forms.Button btAdicionaLanche;
        private System.Windows.Forms.DataGridView dgPedidoBebidas;
        private System.Windows.Forms.DataGridView dgPedidoLanches;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLanche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btRemoverBebidaSelecionada;
        private System.Windows.Forms.Button btRemoverLanche;
    }
}