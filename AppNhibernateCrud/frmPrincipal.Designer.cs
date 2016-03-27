namespace AppNhibernateCrud
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsuarios = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonProdutos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCategorias = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSair,
            this.toolStripButtonUsuarios,
            this.toolStripButtonProdutos,
            this.toolStripButtonCategorias});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(835, 65);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSair
            // 
            this.toolStripButtonSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSair.AutoSize = false;
            this.toolStripButtonSair.AutoToolTip = false;
            this.toolStripButtonSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSair.BackgroundImage")));
            this.toolStripButtonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonSair.Checked = true;
            this.toolStripButtonSair.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonSair.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSair.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSair.Image")));
            this.toolStripButtonSair.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonSair.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonSair.Margin = new System.Windows.Forms.Padding(1, 2, 4, 2);
            this.toolStripButtonSair.Name = "toolStripButtonSair";
            this.toolStripButtonSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButtonSair.Size = new System.Drawing.Size(60, 60);
            this.toolStripButtonSair.Text = "Sair";
            this.toolStripButtonSair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolStripButtonSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSair.Click += new System.EventHandler(this.toolStripButtonSair_Click);
            // 
            // toolStripButtonUsuarios
            // 
            this.toolStripButtonUsuarios.AutoSize = false;
            this.toolStripButtonUsuarios.AutoToolTip = false;
            this.toolStripButtonUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsuarios.BackgroundImage")));
            this.toolStripButtonUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonUsuarios.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonUsuarios.ForeColor = System.Drawing.Color.Snow;
            this.toolStripButtonUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsuarios.Image")));
            this.toolStripButtonUsuarios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonUsuarios.ImageTransparentColor = System.Drawing.Color.Azure;
            this.toolStripButtonUsuarios.Margin = new System.Windows.Forms.Padding(1, 2, 4, 2);
            this.toolStripButtonUsuarios.Name = "toolStripButtonUsuarios";
            this.toolStripButtonUsuarios.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButtonUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButtonUsuarios.Size = new System.Drawing.Size(90, 60);
            this.toolStripButtonUsuarios.Text = "Usuarios";
            this.toolStripButtonUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolStripButtonUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonUsuarios.Click += new System.EventHandler(this.toolStripButtonUsuarios_Click);
            // 
            // toolStripButtonProdutos
            // 
            this.toolStripButtonProdutos.AutoSize = false;
            this.toolStripButtonProdutos.AutoToolTip = false;
            this.toolStripButtonProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonProdutos.BackgroundImage")));
            this.toolStripButtonProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonProdutos.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonProdutos.ForeColor = System.Drawing.Color.Snow;
            this.toolStripButtonProdutos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonProdutos.Image")));
            this.toolStripButtonProdutos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProdutos.Margin = new System.Windows.Forms.Padding(10, 2, 4, 2);
            this.toolStripButtonProdutos.Name = "toolStripButtonProdutos";
            this.toolStripButtonProdutos.Size = new System.Drawing.Size(90, 60);
            this.toolStripButtonProdutos.Text = "Produtos";
            this.toolStripButtonProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonProdutos.Click += new System.EventHandler(this.toolStripButtonProdutos_Click);
            // 
            // toolStripButtonCategorias
            // 
            this.toolStripButtonCategorias.AutoSize = false;
            this.toolStripButtonCategorias.AutoToolTip = false;
            this.toolStripButtonCategorias.BackColor = System.Drawing.Color.Black;
            this.toolStripButtonCategorias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCategorias.BackgroundImage")));
            this.toolStripButtonCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonCategorias.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonCategorias.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonCategorias.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCategorias.Image")));
            this.toolStripButtonCategorias.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCategorias.Margin = new System.Windows.Forms.Padding(10, 2, 4, 2);
            this.toolStripButtonCategorias.Name = "toolStripButtonCategorias";
            this.toolStripButtonCategorias.Size = new System.Drawing.Size(90, 61);
            this.toolStripButtonCategorias.Text = "Categorias ";
            this.toolStripButtonCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonCategorias.Click += new System.EventHandler(this.toolStripButtonCategorias_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 742);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        public System.Windows.Forms.ToolStripButton toolStripButtonUsuarios;
        private System.Windows.Forms.ToolStripButton toolStripButtonProdutos;
        private System.Windows.Forms.ToolStripButton toolStripButtonSair;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCategorias;
    }
}