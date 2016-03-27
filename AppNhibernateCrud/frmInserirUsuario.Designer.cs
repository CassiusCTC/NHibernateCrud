namespace AppNhibernateCrud
{
    partial class frmInserirUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirUsuario));
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_usern = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_usern = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_est = new System.Windows.Forms.Label();
            this.errorv = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGravarProd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVoltarProd = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(37, 89);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(311, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(37, 211);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(135, 20);
            this.textBox_pass.TabIndex = 1;
            // 
            // textBox_usern
            // 
            this.textBox_usern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_usern.Location = new System.Drawing.Point(37, 170);
            this.textBox_usern.Name = "textBox_usern";
            this.textBox_usern.Size = new System.Drawing.Size(311, 20);
            this.textBox_usern.TabIndex = 2;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(37, 130);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(311, 20);
            this.textBox_email.TabIndex = 3;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(35, 71);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 15);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Nome";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(34, 112);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(44, 15);
            this.label_email.TabIndex = 5;
            this.label_email.Text = "Email";
            // 
            // label_usern
            // 
            this.label_usern.AutoSize = true;
            this.label_usern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usern.Location = new System.Drawing.Point(36, 152);
            this.label_usern.Name = "label_usern";
            this.label_usern.Size = new System.Drawing.Size(73, 15);
            this.label_usern.TabIndex = 6;
            this.label_usern.Text = "Username";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(34, 193);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(69, 15);
            this.label_pass.TabIndex = 7;
            this.label_pass.Text = "Password";
            // 
            // label_est
            // 
            this.label_est.AutoSize = true;
            this.label_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_est.Location = new System.Drawing.Point(34, 232);
            this.label_est.Name = "label_est";
            this.label_est.Size = new System.Drawing.Size(51, 15);
            this.label_est.TabIndex = 9;
            this.label_est.Text = "Estado";
            // 
            // errorv
            // 
            this.errorv.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastrar Usuario";
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
            this.toolStrip1.Location = new System.Drawing.Point(37, 290);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(311, 37);
            this.toolStrip1.TabIndex = 14;
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
            // 
            // frmInserirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(403, 352);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_est);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_usern);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_usern);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_name);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInserirUsuario";
            this.Text = "Cadastrar Usuarios";
            this.Load += new System.EventHandler(this.frmInserirUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_usern;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_usern;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_est;
        private System.Windows.Forms.ErrorProvider errorv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGravarProd;
        private System.Windows.Forms.ToolStripButton toolStripButtonVoltarProd;
    }
}

