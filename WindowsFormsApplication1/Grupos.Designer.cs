namespace WindowsFormsApplication1
{
    partial class Grupos
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
            this.components = new System.ComponentModel.Container();
            this.meReservasDsvDataSet = new WindowsFormsApplication1.MeReservasDsvDataSet();
            this.meReservasDsvDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoTableAdapter = new WindowsFormsApplication1.MeReservasDsvDataSetTableAdapters.GrupoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.MeReservasDsvDataSetTableAdapters.TableAdapterManager();
            this.grupoUsuarioTableAdapter = new WindowsFormsApplication1.MeReservasDsvDataSetTableAdapters.GrupoUsuarioTableAdapter();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.meReservasDsvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meReservasDsvDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // meReservasDsvDataSet
            // 
            this.meReservasDsvDataSet.DataSetName = "MeReservasDsvDataSet";
            this.meReservasDsvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meReservasDsvDataSetBindingSource
            // 
            this.meReservasDsvDataSetBindingSource.DataSource = this.meReservasDsvDataSet;
            this.meReservasDsvDataSetBindingSource.Position = 0;
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.meReservasDsvDataSet;
            // 
            // grupoTableAdapter
            // 
            this.grupoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArquivoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BandeiraFormaPagamentoTableAdapter = null;
            this.tableAdapterManager.BandeiraOperadoraTableAdapter = null;
            this.tableAdapterManager.BandeiraSistemaTableAdapter = null;
            this.tableAdapterManager.CategoriaQuartoTableAdapter = null;
            this.tableAdapterManager.ComodidadeCategoriaTableAdapter = null;
            this.tableAdapterManager.ComodidadeIdiomaTableAdapter = null;
            this.tableAdapterManager.ComodidadeTableAdapter = null;
            this.tableAdapterManager.CupomDescontoTableAdapter = null;
            this.tableAdapterManager.DescricaoCategoriaTableAdapter = null;
            this.tableAdapterManager.DetalhesPagamentoOperadoraTableAdapter = null;
            this.tableAdapterManager.DisponibCategoriaTableAdapter = null;
            this.tableAdapterManager.DisponibQuartoTableAdapter = null;
            this.tableAdapterManager.FormaPagamentoHotelTableAdapter = null;
            this.tableAdapterManager.FormaPagamentoTableAdapter = null;
            this.tableAdapterManager.FuncaoTableAdapter = null;
            this.tableAdapterManager.FuncaoUsuarioTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = this.grupoTableAdapter;
            this.tableAdapterManager.GrupoUsuarioTableAdapter = this.grupoUsuarioTableAdapter;
            this.tableAdapterManager.HistoricoPagamentoTableAdapter = null;
            this.tableAdapterManager.HospedeTableAdapter = null;
            this.tableAdapterManager.HotelFormaPagamentoBandeiraTableAdapter = null;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.IdiomaHotelTableAdapter = null;
            this.tableAdapterManager.IdiomaSistemaTableAdapter = null;
            this.tableAdapterManager.InfoReservaCategoTableAdapter = null;
            this.tableAdapterManager.InfoReservaCriancaTableAdapter = null;
            this.tableAdapterManager.NomeQuartoTableAdapter = null;
            this.tableAdapterManager.OperadoraPagamentoHotelTableAdapter = null;
            this.tableAdapterManager.OperadoraPagamentoSistemaTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.PortletTableAdapter = null;
            this.tableAdapterManager.QuartoReservadoTableAdapter = null;
            this.tableAdapterManager.QuartoTableAdapter = null;
            this.tableAdapterManager.ReservaServicoTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.SettingTableAdapter = null;
            this.tableAdapterManager.TarifaTableAdapter = null;
            this.tableAdapterManager.TextoGaleriaImagemTableAdapter = null;
            this.tableAdapterManager.TipoPessoaTableAdapter = null;
            this.tableAdapterManager.TrackingTableAdapter = null;
            this.tableAdapterManager.UnidadeTableAdapter = null;
            this.tableAdapterManager.UnidadeUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.MeReservasDsvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.ValorTarifaTableAdapter = null;
            // 
            // grupoUsuarioTableAdapter
            // 
            this.grupoUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataMember = "GrupoUsuario";
            this.grupoUsuarioBindingSource.DataSource = this.meReservasDsvDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+ Incluir Grupo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Editar});
            this.dataGridView1.Location = new System.Drawing.Point(26, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 84);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 214);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Grupos";
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.Grupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meReservasDsvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meReservasDsvDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource meReservasDsvDataSetBindingSource;
        private MeReservasDsvDataSet meReservasDsvDataSet;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private MeReservasDsvDataSetTableAdapters.GrupoTableAdapter grupoTableAdapter;
        private MeReservasDsvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MeReservasDsvDataSetTableAdapters.GrupoUsuarioTableAdapter grupoUsuarioTableAdapter;
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}