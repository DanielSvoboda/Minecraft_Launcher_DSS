
namespace MinecraftLauncherDSS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Jogar = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_uuid = new System.Windows.Forms.TextBox();
            this.textBox_accessToken = new System.Windows.Forms.TextBox();
            this.label_nick = new System.Windows.Forms.Label();
            this.label_uuid = new System.Windows.Forms.Label();
            this.label_token = new System.Windows.Forms.Label();
            this.comboBox_VersionsDownload = new System.Windows.Forms.ComboBox();
            this.comboBox_TypeDownload = new System.Windows.Forms.ComboBox();
            this.button_Baixar = new System.Windows.Forms.Button();
            this.button_FecharTUDO = new System.Windows.Forms.Button();
            this.panel_Barra = new System.Windows.Forms.Panel();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.button_Minimizar = new System.Windows.Forms.Button();
            this.panel_Principal = new System.Windows.Forms.Panel();
            this.checkBox_Demo = new System.Windows.Forms.CheckBox();
            this.checkBox_FecharAoIniciar = new System.Windows.Forms.CheckBox();
            this.comboBox_gameVersion = new System.Windows.Forms.ComboBox();
            this.groupBox_Download = new System.Windows.Forms.GroupBox();
            this.panel_Barra.SuspendLayout();
            this.panel_Principal.SuspendLayout();
            this.groupBox_Download.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Jogar
            // 
            this.button_Jogar.Location = new System.Drawing.Point(348, 344);
            this.button_Jogar.Name = "button_Jogar";
            this.button_Jogar.Size = new System.Drawing.Size(131, 23);
            this.button_Jogar.TabIndex = 0;
            this.button_Jogar.Text = "JOGAR";
            this.button_Jogar.UseVisualStyleBackColor = true;
            this.button_Jogar.Click += new System.EventHandler(this.button_iniciar_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(90, 292);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(98, 20);
            this.textBox_username.TabIndex = 1;
            // 
            // textBox_uuid
            // 
            this.textBox_uuid.Location = new System.Drawing.Point(90, 318);
            this.textBox_uuid.Name = "textBox_uuid";
            this.textBox_uuid.Size = new System.Drawing.Size(200, 20);
            this.textBox_uuid.TabIndex = 2;
            // 
            // textBox_accessToken
            // 
            this.textBox_accessToken.Location = new System.Drawing.Point(90, 344);
            this.textBox_accessToken.Name = "textBox_accessToken";
            this.textBox_accessToken.Size = new System.Drawing.Size(200, 20);
            this.textBox_accessToken.TabIndex = 4;
            // 
            // label_nick
            // 
            this.label_nick.AutoSize = true;
            this.label_nick.Location = new System.Drawing.Point(17, 295);
            this.label_nick.Name = "label_nick";
            this.label_nick.Size = new System.Drawing.Size(67, 13);
            this.label_nick.TabIndex = 5;
            this.label_nick.Text = "Nick (nome):";
            // 
            // label_uuid
            // 
            this.label_uuid.AutoSize = true;
            this.label_uuid.Location = new System.Drawing.Point(26, 321);
            this.label_uuid.Name = "label_uuid";
            this.label_uuid.Size = new System.Drawing.Size(58, 13);
            this.label_uuid.TabIndex = 6;
            this.label_uuid.Text = "uuid (skin):";
            // 
            // label_token
            // 
            this.label_token.AutoSize = true;
            this.label_token.Location = new System.Drawing.Point(12, 347);
            this.label_token.Name = "label_token";
            this.label_token.Size = new System.Drawing.Size(75, 13);
            this.label_token.TabIndex = 8;
            this.label_token.Text = "accessToken:";
            // 
            // comboBox_VersionsDownload
            // 
            this.comboBox_VersionsDownload.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VersionsDownload.FormattingEnabled = true;
            this.comboBox_VersionsDownload.Location = new System.Drawing.Point(87, 19);
            this.comboBox_VersionsDownload.Name = "comboBox_VersionsDownload";
            this.comboBox_VersionsDownload.Size = new System.Drawing.Size(132, 21);
            this.comboBox_VersionsDownload.TabIndex = 11;
            // 
            // comboBox_TypeDownload
            // 
            this.comboBox_TypeDownload.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TypeDownload.FormattingEnabled = true;
            this.comboBox_TypeDownload.Location = new System.Drawing.Point(6, 19);
            this.comboBox_TypeDownload.Name = "comboBox_TypeDownload";
            this.comboBox_TypeDownload.Size = new System.Drawing.Size(75, 21);
            this.comboBox_TypeDownload.TabIndex = 12;
            this.comboBox_TypeDownload.SelectionChangeCommitted += new System.EventHandler(this.Verificar_VersionManifest);
            this.comboBox_TypeDownload.Click += new System.EventHandler(this.comboBox_TypeDownload_SelectedIndexChanged);
            // 
            // button_Baixar
            // 
            this.button_Baixar.Location = new System.Drawing.Point(225, 19);
            this.button_Baixar.Name = "button_Baixar";
            this.button_Baixar.Size = new System.Drawing.Size(46, 23);
            this.button_Baixar.TabIndex = 13;
            this.button_Baixar.Text = "Baixar";
            this.button_Baixar.UseVisualStyleBackColor = true;
            this.button_Baixar.Click += new System.EventHandler(this.button_Baixar_Click);
            // 
            // button_FecharTUDO
            // 
            this.button_FecharTUDO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_FecharTUDO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_FecharTUDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FecharTUDO.Location = new System.Drawing.Point(789, 3);
            this.button_FecharTUDO.Name = "button_FecharTUDO";
            this.button_FecharTUDO.Size = new System.Drawing.Size(28, 28);
            this.button_FecharTUDO.TabIndex = 14;
            this.button_FecharTUDO.Text = "X";
            this.button_FecharTUDO.UseVisualStyleBackColor = true;
            this.button_FecharTUDO.Click += new System.EventHandler(this.button_FecharTUDO_Click);
            // 
            // panel_Barra
            // 
            this.panel_Barra.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Barra.Controls.Add(this.label_Titulo);
            this.panel_Barra.Controls.Add(this.button_Minimizar);
            this.panel_Barra.Controls.Add(this.button_FecharTUDO);
            this.panel_Barra.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel_Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Barra.Location = new System.Drawing.Point(0, 0);
            this.panel_Barra.Name = "panel_Barra";
            this.panel_Barra.Size = new System.Drawing.Size(820, 35);
            this.panel_Barra.TabIndex = 16;
            this.panel_Barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Barra_MouseDown);
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.label_Titulo.Location = new System.Drawing.Point(336, 11);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(148, 13);
            this.label_Titulo.TabIndex = 18;
            this.label_Titulo.Text = "MINECRAFT LAUCHER DSS";
            this.label_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Barra_MouseDown);
            // 
            // button_Minimizar
            // 
            this.button_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minimizar.Location = new System.Drawing.Point(755, 3);
            this.button_Minimizar.Name = "button_Minimizar";
            this.button_Minimizar.Size = new System.Drawing.Size(28, 28);
            this.button_Minimizar.TabIndex = 15;
            this.button_Minimizar.Text = "---";
            this.button_Minimizar.UseVisualStyleBackColor = true;
            this.button_Minimizar.Click += new System.EventHandler(this.button_Minimizar_Click);
            // 
            // panel_Principal
            // 
            this.panel_Principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Principal.Controls.Add(this.checkBox_Demo);
            this.panel_Principal.Controls.Add(this.checkBox_FecharAoIniciar);
            this.panel_Principal.Controls.Add(this.comboBox_gameVersion);
            this.panel_Principal.Controls.Add(this.groupBox_Download);
            this.panel_Principal.Controls.Add(this.button_Jogar);
            this.panel_Principal.Controls.Add(this.textBox_username);
            this.panel_Principal.Controls.Add(this.textBox_uuid);
            this.panel_Principal.Controls.Add(this.textBox_accessToken);
            this.panel_Principal.Controls.Add(this.label_nick);
            this.panel_Principal.Controls.Add(this.label_uuid);
            this.panel_Principal.Controls.Add(this.label_token);
            this.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Principal.Location = new System.Drawing.Point(0, 35);
            this.panel_Principal.Name = "panel_Principal";
            this.panel_Principal.Size = new System.Drawing.Size(820, 379);
            this.panel_Principal.TabIndex = 17;
            // 
            // checkBox_Demo
            // 
            this.checkBox_Demo.AutoSize = true;
            this.checkBox_Demo.Location = new System.Drawing.Point(194, 294);
            this.checkBox_Demo.Name = "checkBox_Demo";
            this.checkBox_Demo.Size = new System.Drawing.Size(54, 17);
            this.checkBox_Demo.TabIndex = 19;
            this.checkBox_Demo.Text = "Demo";
            this.checkBox_Demo.UseVisualStyleBackColor = true;
            // 
            // checkBox_FecharAoIniciar
            // 
            this.checkBox_FecharAoIniciar.AutoSize = true;
            this.checkBox_FecharAoIniciar.Location = new System.Drawing.Point(348, 298);
            this.checkBox_FecharAoIniciar.Name = "checkBox_FecharAoIniciar";
            this.checkBox_FecharAoIniciar.Size = new System.Drawing.Size(104, 17);
            this.checkBox_FecharAoIniciar.TabIndex = 18;
            this.checkBox_FecharAoIniciar.Text = "Fechar ao iniciar";
            this.checkBox_FecharAoIniciar.UseVisualStyleBackColor = true;
            // 
            // comboBox_gameVersion
            // 
            this.comboBox_gameVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gameVersion.FormattingEnabled = true;
            this.comboBox_gameVersion.Location = new System.Drawing.Point(348, 321);
            this.comboBox_gameVersion.Name = "comboBox_gameVersion";
            this.comboBox_gameVersion.Size = new System.Drawing.Size(131, 21);
            this.comboBox_gameVersion.TabIndex = 17;
            // 
            // groupBox_Download
            // 
            this.groupBox_Download.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Download.Controls.Add(this.comboBox_TypeDownload);
            this.groupBox_Download.Controls.Add(this.comboBox_VersionsDownload);
            this.groupBox_Download.Controls.Add(this.button_Baixar);
            this.groupBox_Download.Location = new System.Drawing.Point(541, 327);
            this.groupBox_Download.Name = "groupBox_Download";
            this.groupBox_Download.Size = new System.Drawing.Size(276, 49);
            this.groupBox_Download.TabIndex = 16;
            this.groupBox_Download.TabStop = false;
            this.groupBox_Download.Text = "Download";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 414);
            this.Controls.Add(this.panel_Principal);
            this.Controls.Add(this.panel_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Launcher DSS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Barra.ResumeLayout(false);
            this.panel_Barra.PerformLayout();
            this.panel_Principal.ResumeLayout(false);
            this.panel_Principal.PerformLayout();
            this.groupBox_Download.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Jogar;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_uuid;
        private System.Windows.Forms.TextBox textBox_accessToken;
        private System.Windows.Forms.Label label_nick;
        private System.Windows.Forms.Label label_uuid;
        private System.Windows.Forms.Label label_token;
        private System.Windows.Forms.ComboBox comboBox_VersionsDownload;
        private System.Windows.Forms.ComboBox comboBox_TypeDownload;
        private System.Windows.Forms.Button button_Baixar;
        private System.Windows.Forms.Button button_FecharTUDO;
        private System.Windows.Forms.Panel panel_Barra;
        private System.Windows.Forms.Button button_Minimizar;
        private System.Windows.Forms.Panel panel_Principal;
        private System.Windows.Forms.GroupBox groupBox_Download;
        private System.Windows.Forms.ComboBox comboBox_gameVersion;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.CheckBox checkBox_FecharAoIniciar;
        private System.Windows.Forms.CheckBox checkBox_Demo;
    }
}

