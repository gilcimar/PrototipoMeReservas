namespace WindowsFormsApplication1
{
    partial class Tarifas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quartos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Single = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Double = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTerceiraPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarifas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Quartos,
            this.Noites,
            this.Pacote,
            this.Single,
            this.Double,
            this.ValorTerceiraPessoa,
            this.Reservas});
            this.dataGridView1.Location = new System.Drawing.Point(16, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 78);
            this.dataGridView1.TabIndex = 3;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Quartos
            // 
            this.Quartos.HeaderText = "Quartos";
            this.Quartos.Name = "Quartos";
            // 
            // Noites
            // 
            this.Noites.HeaderText = "Noites";
            this.Noites.Name = "Noites";
            // 
            // Pacote
            // 
            this.Pacote.HeaderText = "Pacote";
            this.Pacote.Name = "Pacote";
            // 
            // Single
            // 
            this.Single.HeaderText = "Valor Single";
            this.Single.Name = "Single";
            // 
            // Double
            // 
            this.Double.HeaderText = "Valor Double";
            this.Double.Name = "Double";
            // 
            // ValorTerceiraPessoa
            // 
            this.ValorTerceiraPessoa.HeaderText = "Valor 3º Pessoa";
            this.ValorTerceiraPessoa.Name = "ValorTerceiraPessoa";
            // 
            // Reservas
            // 
            this.Reservas.HeaderText = "Reservas";
            this.Reservas.Name = "Reservas";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Exibir tarifas desativadas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "+ Criar Tarifa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 196);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Tarifas";
            this.Text = "Tarifas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quartos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noites;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Single;
        private System.Windows.Forms.DataGridViewTextBoxColumn Double;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTerceiraPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}