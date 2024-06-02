
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
            this.groupBox_config = new System.Windows.Forms.GroupBox();
            this.checkBox_imagens_fundo = new System.Windows.Forms.CheckBox();
            this.button_load_comands = new System.Windows.Forms.Button();
            this.label_comandos = new System.Windows.Forms.Label();
            this.textBox_Comandos = new System.Windows.Forms.TextBox();
            this.button_save_config = new System.Windows.Forms.Button();
            this.checkBox_ADM = new System.Windows.Forms.CheckBox();
            this.button_config_X = new System.Windows.Forms.Button();
            this.checkBox_FecharAoIniciar = new System.Windows.Forms.CheckBox();
            this.checkBox_Demo = new System.Windows.Forms.CheckBox();
            this.comboBox_gameVersion = new System.Windows.Forms.ComboBox();
            this.groupBox_Download = new System.Windows.Forms.GroupBox();
            this.button_configs = new System.Windows.Forms.Button();
            this.panel_Barra.SuspendLayout();
            this.panel_Principal.SuspendLayout();
            this.groupBox_config.SuspendLayout();
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
            this.textBox_username.Location = new System.Drawing.Point(244, 344);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(98, 20);
            this.textBox_username.TabIndex = 1;
            // 
            // textBox_uuid
            // 
            this.textBox_uuid.Location = new System.Drawing.Point(82, 185);
            this.textBox_uuid.Name = "textBox_uuid";
            this.textBox_uuid.Size = new System.Drawing.Size(200, 20);
            this.textBox_uuid.TabIndex = 2;
            // 
            // textBox_accessToken
            // 
            this.textBox_accessToken.Location = new System.Drawing.Point(82, 211);
            this.textBox_accessToken.Name = "textBox_accessToken";
            this.textBox_accessToken.Size = new System.Drawing.Size(200, 20);
            this.textBox_accessToken.TabIndex = 4;
            // 
            // label_nick
            // 
            this.label_nick.AutoSize = true;
            this.label_nick.Location = new System.Drawing.Point(171, 347);
            this.label_nick.Name = "label_nick";
            this.label_nick.Size = new System.Drawing.Size(67, 13);
            this.label_nick.TabIndex = 5;
            this.label_nick.Text = "Nick (nome):";
            // 
            // label_uuid
            // 
            this.label_uuid.AutoSize = true;
            this.label_uuid.Location = new System.Drawing.Point(18, 188);
            this.label_uuid.Name = "label_uuid";
            this.label_uuid.Size = new System.Drawing.Size(58, 13);
            this.label_uuid.TabIndex = 6;
            this.label_uuid.Text = "uuid (skin):";
            // 
            // label_token
            // 
            this.label_token.AutoSize = true;
            this.label_token.Location = new System.Drawing.Point(4, 214);
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
            this.panel_Principal.Controls.Add(this.groupBox_config);
            this.panel_Principal.Controls.Add(this.comboBox_gameVersion);
            this.panel_Principal.Controls.Add(this.groupBox_Download);
            this.panel_Principal.Controls.Add(this.button_Jogar);
            this.panel_Principal.Controls.Add(this.textBox_username);
            this.panel_Principal.Controls.Add(this.label_nick);
            this.panel_Principal.Controls.Add(this.button_configs);
            this.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Principal.Location = new System.Drawing.Point(0, 35);
            this.panel_Principal.Name = "panel_Principal";
            this.panel_Principal.Size = new System.Drawing.Size(820, 379);
            this.panel_Principal.TabIndex = 17;
            // 
            // groupBox_config
            // 
            this.groupBox_config.Controls.Add(this.checkBox_imagens_fundo);
            this.groupBox_config.Controls.Add(this.button_load_comands);
            this.groupBox_config.Controls.Add(this.label_comandos);
            this.groupBox_config.Controls.Add(this.textBox_Comandos);
            this.groupBox_config.Controls.Add(this.button_save_config);
            this.groupBox_config.Controls.Add(this.checkBox_ADM);
            this.groupBox_config.Controls.Add(this.button_config_X);
            this.groupBox_config.Controls.Add(this.checkBox_FecharAoIniciar);
            this.groupBox_config.Controls.Add(this.textBox_uuid);
            this.groupBox_config.Controls.Add(this.textBox_accessToken);
            this.groupBox_config.Controls.Add(this.checkBox_Demo);
            this.groupBox_config.Controls.Add(this.label_token);
            this.groupBox_config.Controls.Add(this.label_uuid);
            this.groupBox_config.Location = new System.Drawing.Point(3, 139);
            this.groupBox_config.Name = "groupBox_config";
            this.groupBox_config.Size = new System.Drawing.Size(520, 237);
            this.groupBox_config.TabIndex = 21;
            this.groupBox_config.TabStop = false;
            this.groupBox_config.Text = "                                                                           Config" +
    "urações";
            this.groupBox_config.Visible = false;
            // 
            // checkBox_imagens_fundo
            // 
            this.checkBox_imagens_fundo.AutoSize = true;
            this.checkBox_imagens_fundo.Checked = true;
            this.checkBox_imagens_fundo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_imagens_fundo.Location = new System.Drawing.Point(313, 42);
            this.checkBox_imagens_fundo.Name = "checkBox_imagens_fundo";
            this.checkBox_imagens_fundo.Size = new System.Drawing.Size(111, 17);
            this.checkBox_imagens_fundo.TabIndex = 25;
            this.checkBox_imagens_fundo.Text = "Imagens ao fundo";
            this.checkBox_imagens_fundo.UseVisualStyleBackColor = true;
            // 
            // button_load_comands
            // 
            this.button_load_comands.Location = new System.Drawing.Point(360, 167);
            this.button_load_comands.Name = "button_load_comands";
            this.button_load_comands.Size = new System.Drawing.Size(154, 23);
            this.button_load_comands.TabIndex = 24;
            this.button_load_comands.Text = "Restaurar comandos padrão";
            this.button_load_comands.UseVisualStyleBackColor = true;
            this.button_load_comands.Click += new System.EventHandler(this.button_load_comands_Click);
            // 
            // label_comandos
            // 
            this.label_comandos.AutoSize = true;
            this.label_comandos.Location = new System.Drawing.Point(5, 73);
            this.label_comandos.Name = "label_comandos";
            this.label_comandos.Size = new System.Drawing.Size(60, 13);
            this.label_comandos.TabIndex = 22;
            this.label_comandos.Text = "Comandos:";
            // 
            // textBox_Comandos
            // 
            this.textBox_Comandos.Location = new System.Drawing.Point(71, 70);
            this.textBox_Comandos.Multiline = true;
            this.textBox_Comandos.Name = "textBox_Comandos";
            this.textBox_Comandos.Size = new System.Drawing.Size(443, 68);
            this.textBox_Comandos.TabIndex = 22;
            this.textBox_Comandos.Text = "-Xmx4G -Xms4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=" +
    "20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M";
            // 
            // button_save_config
            // 
            this.button_save_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save_config.Location = new System.Drawing.Point(458, 208);
            this.button_save_config.Name = "button_save_config";
            this.button_save_config.Size = new System.Drawing.Size(56, 23);
            this.button_save_config.TabIndex = 22;
            this.button_save_config.Text = "Salvar";
            this.button_save_config.UseVisualStyleBackColor = true;
            this.button_save_config.Click += new System.EventHandler(this.button_save_config_Click);
            // 
            // checkBox_ADM
            // 
            this.checkBox_ADM.AutoSize = true;
            this.checkBox_ADM.Location = new System.Drawing.Point(6, 19);
            this.checkBox_ADM.Name = "checkBox_ADM";
            this.checkBox_ADM.Size = new System.Drawing.Size(149, 17);
            this.checkBox_ADM.TabIndex = 23;
            this.checkBox_ADM.Text = "Iniciar como Administrador";
            this.checkBox_ADM.UseVisualStyleBackColor = true;
            // 
            // button_config_X
            // 
            this.button_config_X.Location = new System.Drawing.Point(500, 5);
            this.button_config_X.Name = "button_config_X";
            this.button_config_X.Size = new System.Drawing.Size(20, 20);
            this.button_config_X.TabIndex = 22;
            this.button_config_X.Text = "X";
            this.button_config_X.UseVisualStyleBackColor = true;
            this.button_config_X.Click += new System.EventHandler(this.button_config_X_Click);
            // 
            // checkBox_FecharAoIniciar
            // 
            this.checkBox_FecharAoIniciar.AutoSize = true;
            this.checkBox_FecharAoIniciar.Checked = true;
            this.checkBox_FecharAoIniciar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_FecharAoIniciar.Location = new System.Drawing.Point(313, 19);
            this.checkBox_FecharAoIniciar.Name = "checkBox_FecharAoIniciar";
            this.checkBox_FecharAoIniciar.Size = new System.Drawing.Size(181, 17);
            this.checkBox_FecharAoIniciar.TabIndex = 18;
            this.checkBox_FecharAoIniciar.Text = "Fechar essa tela ao iniciar o jogo";
            this.checkBox_FecharAoIniciar.UseVisualStyleBackColor = true;
            // 
            // checkBox_Demo
            // 
            this.checkBox_Demo.AutoSize = true;
            this.checkBox_Demo.Location = new System.Drawing.Point(6, 42);
            this.checkBox_Demo.Name = "checkBox_Demo";
            this.checkBox_Demo.Size = new System.Drawing.Size(54, 17);
            this.checkBox_Demo.TabIndex = 19;
            this.checkBox_Demo.Text = "Demo";
            this.checkBox_Demo.UseVisualStyleBackColor = true;
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
            // button_configs
            // 
            this.button_configs.Location = new System.Drawing.Point(12, 344);
            this.button_configs.Name = "button_configs";
            this.button_configs.Size = new System.Drawing.Size(90, 23);
            this.button_configs.TabIndex = 14;
            this.button_configs.Text = "Configurações";
            this.button_configs.UseVisualStyleBackColor = true;
            this.button_configs.Click += new System.EventHandler(this.button_configs_Click);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Launcher DSS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Barra.ResumeLayout(false);
            this.panel_Barra.PerformLayout();
            this.panel_Principal.ResumeLayout(false);
            this.panel_Principal.PerformLayout();
            this.groupBox_config.ResumeLayout(false);
            this.groupBox_config.PerformLayout();
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
        private System.Windows.Forms.Button button_configs;
        private System.Windows.Forms.GroupBox groupBox_config;
        private System.Windows.Forms.Button button_config_X;
        private System.Windows.Forms.CheckBox checkBox_ADM;
        private System.Windows.Forms.Button button_save_config;
        private System.Windows.Forms.Button button_load_comands;
        private System.Windows.Forms.Label label_comandos;
        private System.Windows.Forms.TextBox textBox_Comandos;
        private System.Windows.Forms.CheckBox checkBox_imagens_fundo;
    }
}

