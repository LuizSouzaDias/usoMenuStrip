namespace AppExemploMenu
{
    partial class FrmAzul
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFormAmarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirMenu
            // 
            this.exibirMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFormVermelho,
            this.exibirFormAzul,
            this.exibirFormAmarelo});
            this.exibirMenu.Name = "exibirMenu";
            this.exibirMenu.Size = new System.Drawing.Size(47, 20);
            this.exibirMenu.Text = "Exibir";
            // 
            // exibirFormVermelho
            // 
            this.exibirFormVermelho.Name = "exibirFormVermelho";
            this.exibirFormVermelho.Size = new System.Drawing.Size(180, 22);
            this.exibirFormVermelho.Text = "FormVermelho";
            this.exibirFormVermelho.Click += new System.EventHandler(this.exibirFormVermelho_Click);
            // 
            // exibirFormAzul
            // 
            this.exibirFormAzul.Name = "exibirFormAzul";
            this.exibirFormAzul.Size = new System.Drawing.Size(180, 22);
            this.exibirFormAzul.Text = "FormAzul";
            // 
            // exibirFormAmarelo
            // 
            this.exibirFormAmarelo.Name = "exibirFormAmarelo";
            this.exibirFormAmarelo.Size = new System.Drawing.Size(180, 22);
            this.exibirFormAmarelo.Text = "FormAmarelo";
            this.exibirFormAmarelo.Click += new System.EventHandler(this.exibirFormAmarelo_Click);
            // 
            // FrmAzul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAzul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAzul";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirMenu;
        private System.Windows.Forms.ToolStripMenuItem exibirFormVermelho;
        private System.Windows.Forms.ToolStripMenuItem exibirFormAzul;
        private System.Windows.Forms.ToolStripMenuItem exibirFormAmarelo;
    }
}