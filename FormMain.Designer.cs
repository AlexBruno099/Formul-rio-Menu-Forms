namespace Formulario
{
    partial class FormMain
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSegunda = new System.Windows.Forms.Button();
            this.btnSegundaFormThread = new System.Windows.Forms.Button();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mFileSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobreDes = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobreVersao = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboMenu = new System.Windows.Forms.ToolStripComboBox();
            this.mPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 172);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(784, 140);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Principal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSegunda
            // 
            this.btnSegunda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSegunda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegunda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSegunda.Location = new System.Drawing.Point(0, 24);
            this.btnSegunda.Name = "btnSegunda";
            this.btnSegunda.Size = new System.Drawing.Size(152, 70);
            this.btnSegunda.TabIndex = 1;
            this.btnSegunda.Text = "SegundaForm";
            this.btnSegunda.UseVisualStyleBackColor = false;
            this.btnSegunda.Click += new System.EventHandler(this.btnSegunda_Click);
            // 
            // btnSegundaFormThread
            // 
            this.btnSegundaFormThread.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSegundaFormThread.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSegundaFormThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundaFormThread.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSegundaFormThread.Location = new System.Drawing.Point(158, 24);
            this.btnSegundaFormThread.Name = "btnSegundaFormThread";
            this.btnSegundaFormThread.Size = new System.Drawing.Size(163, 70);
            this.btnSegundaFormThread.TabIndex = 2;
            this.btnSegundaFormThread.Text = "Segunda Form Thread";
            this.btnSegundaFormThread.UseVisualStyleBackColor = false;
            this.btnSegundaFormThread.Click += new System.EventHandler(this.btnSegundaFormThread_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.AutoSize = false;
            this.MenuBar.BackColor = System.Drawing.Color.DarkGray;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.ComboMenu,
            this.mPesquisar});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(813, 21);
            this.MenuBar.TabIndex = 3;
            this.MenuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.Color.DarkGray;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNovo,
            this.mFileAbrir,
            this.toolStripSeparator2,
            this.mFileSair});
            this.menuFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 17);
            this.menuFile.Text = "File";
            // 
            // mFileNovo
            // 
            this.mFileNovo.Name = "mFileNovo";
            this.mFileNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFileNovo.Size = new System.Drawing.Size(180, 22);
            this.mFileNovo.Text = "Novo";
            this.mFileNovo.Click += new System.EventHandler(this.mFileNovo_Click);
            // 
            // mFileAbrir
            // 
            this.mFileAbrir.Name = "mFileAbrir";
            this.mFileAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mFileAbrir.Size = new System.Drawing.Size(180, 22);
            this.mFileAbrir.Text = "Abrir";
            this.mFileAbrir.Click += new System.EventHandler(this.mFileAbrir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mFileSair
            // 
            this.mFileSair.Name = "mFileSair";
            this.mFileSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.mFileSair.Size = new System.Drawing.Size(180, 22);
            this.mFileSair.Text = "Sair";
            this.mFileSair.Click += new System.EventHandler(this.mFileSair_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobre});
            this.menuHelp.ForeColor = System.Drawing.Color.White;
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 17);
            this.menuHelp.Text = "Help";
            // 
            // mHelpSobre
            // 
            this.mHelpSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobreDes,
            this.mHelpSobreVersao});
            this.mHelpSobre.Name = "mHelpSobre";
            this.mHelpSobre.Size = new System.Drawing.Size(180, 22);
            this.mHelpSobre.Text = "Sobre";
            // 
            // mHelpSobreDes
            // 
            this.mHelpSobreDes.Name = "mHelpSobreDes";
            this.mHelpSobreDes.Size = new System.Drawing.Size(152, 22);
            this.mHelpSobreDes.Text = "Desenvolvedor";
            this.mHelpSobreDes.Click += new System.EventHandler(this.mHelpSobreDes_Click);
            // 
            // mHelpSobreVersao
            // 
            this.mHelpSobreVersao.Name = "mHelpSobreVersao";
            this.mHelpSobreVersao.Size = new System.Drawing.Size(152, 22);
            this.mHelpSobreVersao.Text = "Versão";
            this.mHelpSobreVersao.Click += new System.EventHandler(this.mHelpSobreVersao_Click);
            // 
            // ComboMenu
            // 
            this.ComboMenu.BackColor = System.Drawing.Color.Silver;
            this.ComboMenu.ForeColor = System.Drawing.Color.White;
            this.ComboMenu.Items.AddRange(new object[] {
            "Inglês\t",
            "Português"});
            this.ComboMenu.MergeIndex = 0;
            this.ComboMenu.Name = "ComboMenu";
            this.ComboMenu.Size = new System.Drawing.Size(121, 17);
            this.ComboMenu.Sorted = true;
            this.ComboMenu.SelectedIndexChanged += new System.EventHandler(this.ComboMenu_SelectedIndexChanged);
            this.ComboMenu.Click += new System.EventHandler(this.ComboMenu_Click);
            // 
            // mPesquisar
            // 
            this.mPesquisar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mPesquisar.ForeColor = System.Drawing.Color.White;
            this.mPesquisar.Name = "mPesquisar";
            this.mPesquisar.Size = new System.Drawing.Size(200, 17);
            this.mPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mPesquisar_KeyUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.btnSegundaFormThread);
            this.Controls.Add(this.btnSegunda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.MenuBar;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSegunda;
        private System.Windows.Forms.Button btnSegundaFormThread;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem mFileNovo;
        private System.Windows.Forms.ToolStripMenuItem mFileAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mFileSair;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobre;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobreDes;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobreVersao;
        private System.Windows.Forms.ToolStripComboBox ComboMenu;
        private System.Windows.Forms.ToolStripTextBox mPesquisar;
    }
}

