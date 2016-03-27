namespace AppNhibernateCrud
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.listViewprod = new System.Windows.Forms.ListView();
            this.cd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.np = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddProd = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewprod
            // 
            this.listViewprod.BackColor = System.Drawing.Color.Honeydew;
            this.listViewprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewprod.CheckBoxes = true;
            this.listViewprod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cd,
            this.np,
            this.tipo,
            this.desc,
            this.qtn,
            this.resp,
            this.data});
            this.listViewprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewprod.GridLines = true;
            this.listViewprod.Location = new System.Drawing.Point(31, 134);
            this.listViewprod.Name = "listViewprod";
            this.listViewprod.Size = new System.Drawing.Size(736, 258);
            this.listViewprod.TabIndex = 0;
            this.listViewprod.UseCompatibleStateImageBehavior = false;
            this.listViewprod.View = System.Windows.Forms.View.Details;
            // 
            // cd
            // 
            this.cd.Text = "Codigo";
            // 
            // np
            // 
            this.np.Text = "Produto";
            this.np.Width = 99;
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo";
            this.tipo.Width = 69;
            // 
            // desc
            // 
            this.desc.Text = "Descrição";
            this.desc.Width = 233;
            // 
            // qtn
            // 
            this.qtn.Text = "Quant.";
            this.qtn.Width = 86;
            // 
            // resp
            // 
            this.resp.Text = "Responsavel";
            this.resp.Width = 103;
            // 
            // data
            // 
            this.data.Text = "Data Cadastro";
            this.data.Width = 149;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(31, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 43);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButtonAddProd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 65);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.BackgroundImage")));
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton1.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(10, 2, 4, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(90, 60);
            this.toolStripButton1.Text = "Add Categoria";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.BackgroundImage")));
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton2.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.LimeGreen;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(10, 2, 4, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(90, 60);
            this.toolStripButton2.Text = "Voltar";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonAddProd
            // 
            this.toolStripButtonAddProd.AutoSize = false;
            this.toolStripButtonAddProd.AutoToolTip = false;
            this.toolStripButtonAddProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddProd.BackgroundImage")));
            this.toolStripButtonAddProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonAddProd.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonAddProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButtonAddProd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddProd.Image")));
            this.toolStripButtonAddProd.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolStripButtonAddProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddProd.Margin = new System.Windows.Forms.Padding(10, 2, 4, 2);
            this.toolStripButtonAddProd.Name = "toolStripButtonAddProd";
            this.toolStripButtonAddProd.Size = new System.Drawing.Size(90, 61);
            this.toolStripButtonAddProd.Text = "Produtos";
            this.toolStripButtonAddProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonAddProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButtonAddProd.Click += new System.EventHandler(this.toolStripButtonAddProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tabela Produtos";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewprod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewprod;
        private System.Windows.Forms.ColumnHeader cd;
        private System.Windows.Forms.ColumnHeader np;
        private System.Windows.Forms.ColumnHeader desc;
        private System.Windows.Forms.ColumnHeader qtn;
        private System.Windows.Forms.ColumnHeader resp;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddProd;
        private System.Windows.Forms.Label label1;
    }
}