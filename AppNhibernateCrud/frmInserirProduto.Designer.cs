namespace AppNhibernateCrud
{
    partial class frmInserirProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQnatidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGravarProd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVoltarProd = new System.Windows.Forms.ToolStripButton();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade:";
            // 
            // textBoxQnatidade
            // 
            this.textBoxQnatidade.Location = new System.Drawing.Point(62, 132);
            this.textBoxQnatidade.Name = "textBoxQnatidade";
            this.textBoxQnatidade.Size = new System.Drawing.Size(142, 20);
            this.textBoxQnatidade.TabIndex = 1;
            this.textBoxQnatidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQnatidade_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Produto:";
            // 
            // textBoxNProduto
            // 
            this.textBoxNProduto.Location = new System.Drawing.Point(62, 93);
            this.textBoxNProduto.Name = "textBoxNProduto";
            this.textBoxNProduto.Size = new System.Drawing.Size(272, 20);
            this.textBoxNProduto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descrição:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(62, 216);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(272, 200);
            this.textBoxDescricao.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cadastrar Produto";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGravarProd,
            this.toolStripButtonVoltarProd});
            this.toolStrip1.Location = new System.Drawing.Point(62, 429);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(272, 37);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonGravarProd
            // 
            this.toolStripButtonGravarProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonGravarProd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGravarProd.Image")));
            this.toolStripButtonGravarProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGravarProd.Name = "toolStripButtonGravarProd";
            this.toolStripButtonGravarProd.Size = new System.Drawing.Size(65, 34);
            this.toolStripButtonGravarProd.Text = "Gravar";
            this.toolStripButtonGravarProd.Click += new System.EventHandler(this.toolStripButtonGravarProd_Click);
            // 
            // toolStripButtonVoltarProd
            // 
            this.toolStripButtonVoltarProd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonVoltarProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonVoltarProd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVoltarProd.Image")));
            this.toolStripButtonVoltarProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVoltarProd.Name = "toolStripButtonVoltarProd";
            this.toolStripButtonVoltarProd.Size = new System.Drawing.Size(60, 34);
            this.toolStripButtonVoltarProd.Text = "Voltar";
            this.toolStripButtonVoltarProd.Click += new System.EventHandler(this.toolStripButtonVoltarProd_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmInserirProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(407, 514);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQnatidade);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmInserirProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.frmInserirProduto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNProduto;
        private System.Windows.Forms.TextBox textBoxQnatidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton toolStripButtonGravarProd;
        private System.Windows.Forms.ToolStripButton toolStripButtonVoltarProd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}