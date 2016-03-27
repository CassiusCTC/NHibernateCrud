namespace AppNhibernateCrud
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.btnrefresh = new System.Windows.Forms.Button();
            this.listuser = new System.Windows.Forms.ListView();
            this.cd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.est = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddUsuario = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnrefresh
            // 
            this.btnrefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnrefresh.BackColor = System.Drawing.Color.LightGray;
            this.btnrefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrefresh.BackgroundImage")));
            this.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrefresh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnrefresh.Location = new System.Drawing.Point(37, 422);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(45, 43);
            this.btnrefresh.TabIndex = 15;
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // listuser
            // 
            this.listuser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cd,
            this.email,
            this.user,
            this.pass,
            this.nome,
            this.est});
            this.listuser.GridLines = true;
            this.listuser.Location = new System.Drawing.Point(37, 131);
            this.listuser.Name = "listuser";
            this.listuser.Size = new System.Drawing.Size(724, 285);
            this.listuser.TabIndex = 14;
            this.listuser.UseCompatibleStateImageBehavior = false;
            this.listuser.View = System.Windows.Forms.View.Details;
            // 
            // cd
            // 
            this.cd.Text = "Codigo";
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 168;
            // 
            // user
            // 
            this.user.Text = "Username";
            // 
            // pass
            // 
            this.pass.Text = "Password";
            this.pass.Width = 128;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 221;
            // 
            // est
            // 
            this.est.Text = "UF";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButtonAddUsuario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 64);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripButtonAddUsuario
            // 
            this.toolStripButtonAddUsuario.AutoSize = false;
            this.toolStripButtonAddUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddUsuario.BackgroundImage")));
            this.toolStripButtonAddUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonAddUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUsuario.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonAddUsuario.ForeColor = System.Drawing.Color.LimeGreen;
            this.toolStripButtonAddUsuario.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddUsuario.Image")));
            this.toolStripButtonAddUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUsuario.Margin = new System.Windows.Forms.Padding(10, 2, 4, 2);
            this.toolStripButtonAddUsuario.Name = "toolStripButtonAddUsuario";
            this.toolStripButtonAddUsuario.Size = new System.Drawing.Size(90, 60);
            this.toolStripButtonAddUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tabela Usuarios";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(792, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.listuser);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.ListView listuser;
        private System.Windows.Forms.ColumnHeader cd;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader user;
        private System.Windows.Forms.ColumnHeader pass;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader est;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUsuario;
        private System.Windows.Forms.Label label2;
    }
}