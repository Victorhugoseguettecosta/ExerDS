namespace Exercicios
{
    partial class frmmenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.escolhaUmExercícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escolhaUmExercícioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // escolhaUmExercícioToolStripMenuItem
            // 
            this.escolhaUmExercícioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exer1ToolStripMenuItem,
            this.exer2ToolStripMenuItem});
            this.escolhaUmExercícioToolStripMenuItem.Name = "escolhaUmExercícioToolStripMenuItem";
            this.escolhaUmExercícioToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.escolhaUmExercícioToolStripMenuItem.Text = "Escolha um Exercício";
            // 
            // exer1ToolStripMenuItem
            // 
            this.exer1ToolStripMenuItem.Name = "exer1ToolStripMenuItem";
            this.exer1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exer1ToolStripMenuItem.Text = "Exer 1";
            this.exer1ToolStripMenuItem.Click += new System.EventHandler(this.exer1ToolStripMenuItem_Click);
            // 
            // exer2ToolStripMenuItem
            // 
            this.exer2ToolStripMenuItem.Name = "exer2ToolStripMenuItem";
            this.exer2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exer2ToolStripMenuItem.Text = "Exer 2";
            this.exer2ToolStripMenuItem.Click += new System.EventHandler(this.exer2ToolStripMenuItem_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem escolhaUmExercícioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exer1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exer2ToolStripMenuItem;
    }
}

