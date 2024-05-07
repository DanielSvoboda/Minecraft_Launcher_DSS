using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static MinecraftLauncherDSS.modelJson;
using System.Net.Http;


namespace MinecraftLauncherDSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //bool operatingSystem64bit = Environment.Is64BitOperatingSystem;

        string gameDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft2";
        string username;        // Nick
        string uuid;            // Skin/Capa
        string gameVersion;     // Version 
        string accessToken;     // Authenticator Token
        string javaRuntime;     // Pasta java

        // revisar o tamanha das variaveis...  ¯\_(ツ)_/¯ 
        string[,] conteudoCompleto = new string[1000, 4];    // linhas,colunas
        string[,] arrayLibraries = new string[200, 2];       // linhas,colunas
        string[,] arrayAssets = new string[5000, 2];         // linhas,colunas
        string[,] arrayArquivosJava = new string[1000,1];    // linhas,colunas

        bool verificarVersao = false;

        //links: https://gist.github.com/skyrising/95a8e6a7287634e097ecafa2f21c240f
        string url_version_manifest = "https://piston-meta.mojang.com/mc/game/version_manifest.json";
        string url_java = "https://launchermeta.mojang.com/v1/products/java-runtime/2ec0cc96c44e5a76b9c8b7c39df7210883d12871/all.json";
        string url_assets = "https://resources.download.minecraft.net";


        // Move o Form inteiro ao clicar no panel_Barra modificado
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_Barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_TypeDownload.Items.Add("Versão");
            comboBox_TypeDownload.SelectedIndex = 0;

            baixarImagemBackgroud();
            verificarVersoesBaixadas();
            pegarNick_uuid_checkBox();
        }



        private void baixarImagemBackgroud()
        {
            try
            {
                string baseUrl = "https://launchercontent.mojang.com";
                string jsonUrl = baseUrl + "/games.json";
                string imageUrl = "";

                using (WebClient webClient = new WebClient())
                {
                    string jsonString = webClient.DownloadString(jsonUrl);
                    JObject jsonObj = JObject.Parse(jsonString);

                    foreach (var entry in jsonObj["entries"])
                    {
                        if (entry["heroImage"] != null)
                        {
                            imageUrl = (string)entry["heroImage"]["url"];
                            break;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(imageUrl))
                {
                    using (WebClient webClient = new WebClient())
                    {
                        using (Stream stream = webClient.OpenRead(baseUrl + imageUrl))
                        {
                            panel_Principal.BackgroundImage = Image.FromStream(stream);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao baixar a imagem de fundo.\n\n" + ex);
            }
        }


        // Procura por todos os arquivos .jar dentro da pasta versions, e add no ComboBox
        private void verificarVersoesBaixadas()
        {
            comboBox_gameVersion.Items.Clear();
            try
            {
                string[] arquivosJAR = Directory.GetFiles(gameDir + "/versions", "*.jar", SearchOption.AllDirectories);

                // Ordena o array de forma decrescente
                Array.Sort(arquivosJAR, (a, b) => String.Compare(b, a));

                foreach (var item in arquivosJAR)
                {
                    string arquivo = item.Substring(item.LastIndexOf("\\") + 1);        // Corta na última "\" e apaga o que tem antes
                    string versao = arquivo.Substring(0, arquivo.Length - 4);           // Apaga o .JAR
                    comboBox_gameVersion.Items.Add(versao);                             // 1.19.4
                }
                comboBox_gameVersion.SelectedIndex = 0;
            }
            catch (Exception)
            {
                // Nada :)
            }
        }


        private void pegarNick_uuid_checkBox()
        {
            string usernameFilePath = Path.Combine(gameDir, "nick.txt");
            if (File.Exists(usernameFilePath))
            {
                textBox_username.Text = File.ReadAllText(usernameFilePath);
            }

            string uuidFilePath = Path.Combine(gameDir, "uuid.txt");
            if (File.Exists(uuidFilePath))
            {
                textBox_uuid.Text = File.ReadAllText(uuidFilePath);
            }

            string checkBox_FecharAoIniciarFilePath = Path.Combine(gameDir, "checkBox_FecharAoIniciar.txt");
            if (File.Exists(checkBox_FecharAoIniciarFilePath))
            {
                string checkBoxState = File.ReadAllText(checkBox_FecharAoIniciarFilePath);
                checkBox_FecharAoIniciar.Checked = bool.Parse(checkBoxState);
            }
        }


        private void button_iniciar_Click(object sender, EventArgs e)
        {
            if (comboBox_gameVersion.Text == "") return;

            string url = gameDir + @"\versions\"+ comboBox_gameVersion.Text +@"\"+ comboBox_gameVersion.Text + ".json";
            username = textBox_username.Text;
            if (username.Length < 3 || username.Length > 16)
            {
                MessageBox.Show("O Nick deve ter entre 3 e 16 caracteres.");
            }
            else if (!username.All(c => char.IsLetterOrDigit(c) || c == '_' || c == '.'))
            {
                MessageBox.Show("O Nick só pode conter letras, números, sublinhados e pontos.");
            }
            else
            {
                if (textBox_username.Text != "")
                {
                    string usernameFilePath = Path.Combine(gameDir, "nick.txt");
                    File.WriteAllText(usernameFilePath, textBox_username.Text);
                }

                if (textBox_uuid.Text != "")
                {
                    string uuidFilePath = Path.Combine(gameDir, "uuid.txt");
                    File.WriteAllText(uuidFilePath, textBox_uuid.Text);
                }

                string checkBox_FecharAoIniciarFilePath = Path.Combine(gameDir, "checkBox_FecharAoIniciar.txt");
                File.WriteAllText(checkBox_FecharAoIniciarFilePath, checkBox_FecharAoIniciar.Checked.ToString());

                if (textBox_uuid.Text == "")
                {
                    uuid = "dab2e2bbd58247ce8404516910f54d74";
                }
                else
                {
                    uuid = textBox_uuid.Text;
                }
                
                gameVersion = comboBox_gameVersion.Text;
                accessToken = textBox_accessToken.Text;

                WebRequest solicitacao = HttpWebRequest.Create(url);
                WebResponse resposta = solicitacao.GetResponse();
                StreamReader ler_get = new StreamReader(resposta.GetResponseStream());
                JObject jsonObj_filesGame = JObject.Parse(ler_get.ReadToEnd());


                json_iniciar json_iniciar = new json_iniciar
                {
                    javaVersion = (string)jsonObj_filesGame["javaVersion"]["component"],        //java-runtime-gamma
                    versionType = (string)jsonObj_filesGame["type"],                            //release
                    assetIndex = (string)jsonObj_filesGame["assetIndex"]["id"],                 //release
                    arguments = jsonObj_filesGame["arguments"]["game"],                         //
                    Dlog4j = (string)jsonObj_filesGame["logging"]["client"]["file"]["id"],

                    //HeapDumpPath = (string)jsonObj_filesGame["jvm"]["XX:HeapDumpPath"],       //MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -deve ser desnecessario, 
                    //OsName = (string)jsonObj_filesGame["jvm"]["Dos.name"],                    //Windows 10
                    //OsVersion = (string)jsonObj_filesGame["jvm"]["Dos.version"],              //10.0

                    LibraryPaths = new List<string>()
                };


                // refatorar e usar o sistema atual...
                foreach (var library in jsonObj_filesGame["libraries"])
                {
                    bool includeLibrary = true;

                    if (library["rules"] != null)
                    {
                        foreach (var rule in library["rules"])
                        {
                            if (rule["os"] != null && (rule["os"]["name"].ToString() == "linux" || rule["os"]["name"].ToString() == "osx"))
                            {
                                includeLibrary = false;
                                break;
                            }
                        }
                    }

                    if (includeLibrary)
                    {
                        //deveria rodar com os arm64, mas não inicia ¯\_(ツ)_/¯
                        string path = (string)library["downloads"]["artifact"]["path"];
                        if (!path.EndsWith("natives-windows-arm64.jar"))
                        {
                            json_iniciar.LibraryPaths.Add(gameDir + @"\libraries\" + path.Replace('/', '\\'));
                        }
                    }
                }

                javaRuntime = gameDir + @"\javas\" + json_iniciar.javaVersion + @"\bin\javaw.exe";

                //string comandoAzul = javaRuntime + " -Xss1M -cp "; //cmd
                string comandoAzul = " -Xss1M -cp ";
                string classpath = string.Join(";", json_iniciar.LibraryPaths);
                comandoAzul += classpath + ";" + gameDir + @"\versions\" + comboBox_gameVersion.Text + @"\" + comboBox_gameVersion.Text + @".jar" + @" -Xmx4G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M -Dlog4j.configurationFile=" + gameDir + @"\assets\log_configs\" + json_iniciar.Dlog4j + " net.minecraft.client.main.Main ";


                foreach (var item in json_iniciar.arguments)
                {
                    comandoAzul += item.ToString() + " ";

                    if (item.ToString() == "${version_type}")
                    {
                        comandoAzul = comandoAzul.Substring(0, comandoAzul.Length - 1);
                        break;
                    }
                }

                string versionType = json_iniciar.versionType;
                string assetIndex = json_iniciar.assetIndex;

                comandoAzul = comandoAzul.Replace("${auth_player_name}", username);          // --username ${ auth_player_name}
                comandoAzul = comandoAzul.Replace("${version_name}", gameVersion);           // --version ${version_name}
                comandoAzul = comandoAzul.Replace("${game_directory}", gameDir);             // --gameDir ${game_directory}
                comandoAzul = comandoAzul.Replace("${assets_root}", gameDir + @"\assets");   // --assetsDir ${assets_root}
                comandoAzul = comandoAzul.Replace("${assets_index_name}", assetIndex);       // --assetIndex ${assets_index_name} 
                comandoAzul = comandoAzul.Replace("${auth_uuid}", uuid);                     // --uuid ${auth_uuid} 
                comandoAzul = comandoAzul.Replace("${auth_access_token}", accessToken);      // --accessToken ${auth_access_token}   //////////////////  verificar esses
                comandoAzul = comandoAzul.Replace("${clientid}", "");                        // --clientId ${clientid}               //////////////////  verificar esses
                comandoAzul = comandoAzul.Replace("${auth_xuid}", "");                       // --xuid ${auth_xuid}                  //////////////////  verificar esses
                comandoAzul = comandoAzul.Replace("${user_type}", "msa");                    // --userType ${user_type}              //////////////////  verificar esses
                comandoAzul = comandoAzul.Replace("${version_type}", versionType);           // --versionType ${version_type} 

                if (checkBox_Demo.Checked)
                {
                    comandoAzul += " -demo";
                }

                // abrir pelo CMD
                //System.Diagnostics.Process Minecraft = new System.Diagnostics.Process();
                //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                ////startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden; // Esconde o CMD
                //startInfo.FileName = "cmd.exe";
                //startInfo.Arguments = "/C " + comandoAzul;
                //Minecraft.StartInfo = startInfo;
                //Minecraft.Start();

                // abrir direto pelo JAVAW
                ProcessStartInfo startInfo = new ProcessStartInfo(javaRuntime, comandoAzul);
                Process javaProcess = new Process();
                javaProcess.StartInfo = startInfo;
                javaProcess.Start();


                if (checkBox_FecharAoIniciar.Checked == true)
                {
                    Environment.Exit(1);
                }

                // Um dialog para ver os argumentos (comandoAzul)
                if (false)
                {
                    var dialogTipo = typeof(Form).Assembly.GetType("System.Windows.Forms.PropertyGridInternal.GridErrorDlg");
                    var dialog = (Form)Activator.CreateInstance(dialogTipo, new PropertyGrid());
                    dialog.Text = "Observações - Importantes!";
                    dialogTipo.GetProperty("Message").SetValue(dialog, "Argumentos:", null);
                    dialogTipo.GetProperty("Details").SetValue(dialog, comandoAzul, null);
                    var botao_cancelar = dialog.Controls.Find("cancelBtn", true);   // Remove o botão cancelar
                    botao_cancelar[0].Visible = false;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        dialog.Close();
                    }
                }
            }
        }


        JObject jsonObj;

        private void Verificar_VersionManifest(object sender, EventArgs e)
        {
            int quantidadeVersoes = 0;
            int contadeiro = 0;

            // Baixa só uma vez a lista de versões na sessão atual, se sair uma nova versão após clicar tem que reabrir o programa
            if (verificarVersao == false)
            {
                WebRequest solicitacao = HttpWebRequest.Create(url_version_manifest);
                WebResponse resposta = solicitacao.GetResponse();
                StreamReader ler_get = new StreamReader(resposta.GetResponseStream());
                jsonObj = JObject.Parse(ler_get.ReadToEnd());
                verificarVersao = true;
            }

            json_version_manifest json_version_manifest = new json_version_manifest
            {
                release = (string)jsonObj["latest"]["release"],     // apenas a release  mais recente   exemplo "release:1.19.4"   em 24/04/2023
                snapshot = (string)jsonObj["latest"]["snapshot"],   // apenas a snapshot mais recente   exemplo "snapshot:23w16a"  em 24/04/2023

                id = from p in jsonObj["versions"] select (string)p["id"],                  //1.19.4
                type = from p in jsonObj["versions"] select (string)p["type"],              //release
                url = from p in jsonObj["versions"] select (string)p["url"],                //https://piston-meta.mojang.com/v1/packages/f42c5f3f354ab3fef44088fe61e9c1cdbc25a8cc/1.19.4.json
                releaseTime = from p in jsonObj["versions"] select (string)p["releaseTime"] //2023-03-14T12:56:18+00:00
            };

            //quantidade de itens/versões , mais de 687 
            foreach (var conteudo in json_version_manifest.id)
            {
                if (conteudo != null)
                {
                    quantidadeVersoes++;
                }
            }


            foreach (var conteudo in json_version_manifest.id)
            {
                if (conteudo != null & contadeiro < quantidadeVersoes)
                {
                    addArray_version_manifest(contadeiro, conteudo.ToString(), "id");
                    contadeiro++;
                }
            }

            contadeiro = 0;
            foreach (var conteudo in json_version_manifest.type)
            {
                if (conteudo != null & contadeiro < quantidadeVersoes)
                {
                    addArray_version_manifest(contadeiro, conteudo.ToString(), "type");
                    contadeiro++;
                }
            }

            contadeiro = 0;
            foreach (var conteudo in json_version_manifest.url)
            {
                if (conteudo != null & contadeiro < quantidadeVersoes)
                {
                    addArray_version_manifest(contadeiro, conteudo.ToString(), "url");
                    contadeiro++;
                }
            }

            contadeiro = 0;
            foreach (var conteudo in json_version_manifest.releaseTime)
            {
                if (conteudo != null & contadeiro < quantidadeVersoes)
                {
                    addArray_version_manifest(contadeiro, conteudo.ToString(), "releaseTime");
                    contadeiro++;
                }
            }


            comboBox_VersionsDownload.Items.Clear();

            // Inclui as versões no comboBox
            for (int i = 0; i < quantidadeVersoes; i++)
            {
                if (comboBox_TypeDownload.Text == "release")
                {
                    if (conteudoCompleto[i, 1] == "release")
                    {
                        comboBox_VersionsDownload.Items.Add(conteudoCompleto[i, 0]);
                    }
                }
                if (comboBox_TypeDownload.Text == "snapshot")
                {
                    if (conteudoCompleto[i, 1] == "snapshot")
                    {
                        comboBox_VersionsDownload.Items.Add(conteudoCompleto[i, 0]);
                    }
                }
                if (comboBox_TypeDownload.Text == "old_beta")
                {
                    if (conteudoCompleto[i, 1] == "old_beta")
                    {
                        comboBox_VersionsDownload.Items.Add(conteudoCompleto[i, 0]);
                    }
                }
                if (comboBox_TypeDownload.Text == "old_alpha")
                {
                    if (conteudoCompleto[i, 1] == "old_alpha")
                    {
                        comboBox_VersionsDownload.Items.Add(conteudoCompleto[i, 0]);
                    }
                }
            }

            comboBox_VersionsDownload.Focus();
            comboBox_VersionsDownload.DroppedDown = true;
        }




        private void addArray_version_manifest(int linha, string conteudo, string tipo)
        {
            if (tipo == "id")
            {
                conteudoCompleto[linha, 0] = conteudo;
            }
            if (tipo == "type")
            {
                conteudoCompleto[linha, 1] = conteudo;
            }
            if (tipo == "url")
            {
                conteudoCompleto[linha, 2] = conteudo;
            }
            if (tipo == "releaseTime")
            {
                conteudoCompleto[linha, 3] = conteudo;
            }
        }


        private void addArray2(int linha, string conteudo, string tipo)
        {
            if (tipo == "path_libraries")
            {
                arrayLibraries[linha, 0] = conteudo;
            }
            if (tipo == "url_libraries")
            {
                arrayLibraries[linha, 1] = conteudo;
            }
        }



        private async void button_Baixar_Click(object sender, EventArgs e)
        {
            this.Enabled = false; 
            criarPastas(comboBox_VersionsDownload.Text);
            
            string url = ""; // Pega o url da versão selecionada no comboBox

            for (var i = 0; i < conteudoCompleto.Length; i++)
            {
                if (conteudoCompleto[i,0] == comboBox_VersionsDownload.Text)
                {
                    url = conteudoCompleto[i, 2];
                    break;
                }
            }


            WebRequest solicitacao = HttpWebRequest.Create(url);
            WebResponse resposta = solicitacao.GetResponse();
            StreamReader ler_get = new StreamReader(resposta.GetResponseStream());
            JObject jsonObj_filesGame = JObject.Parse(ler_get.ReadToEnd());

            json_filesGame json_filesGame = new json_filesGame
            {
                url_client = (string)jsonObj_filesGame["downloads"]["client"]["url"],
                assetIndex  = (string)jsonObj_filesGame["assetIndex"]["url"],
                log_configs = (string)jsonObj_filesGame["logging"]["client"]["file"]["url"],

                path_libraries = from p in jsonObj_filesGame["libraries"] select (string)p["downloads"]["artifact"]["path"],
                url_libraries  = from p in jsonObj_filesGame["libraries"] select (string)p["downloads"]["artifact"]["url"],

                java = (string)jsonObj_filesGame["javaVersion"]["component"], //java-runtime-gamma

                //os_libraries = from p in json["libraries"] select (string)p["rules"]["os"]["name"],
            };

            label_Titulo.Location = new Point(9, 11);

            download_javao(json_filesGame.java);                                                                                        // JAVA             todos os arquivos do java 
            download(url, "versions/" + comboBox_VersionsDownload.Text, "");                                                            //1.19.4.json       contem os argumentos..
            download(json_filesGame.url_client, "versions/" + comboBox_VersionsDownload.Text, comboBox_VersionsDownload.Text + ".jar"); //1.19.4.jar        jar
            download(json_filesGame.assetIndex, "assets/indexes", "");                                                                 //3.json            (hash dos arquivos)
            download(json_filesGame.log_configs, "assets/log_configs", "");                                                             //client-1.12.xml   (nada importante)

            
            // Armazena no arrayLibraries 1,0=path_libraries | 1,1=url_libraries   - caminho/url
            int contadeiro = 0;
            foreach (var conteudo in json_filesGame.path_libraries)
            {
                if (conteudo != null)
                {
                    string filename = conteudo.ToString().Substring(0, conteudo.ToString().LastIndexOf("/"));
                    addArray2(contadeiro, filename, "path_libraries");
                    contadeiro++;
                }
            }

            contadeiro = 0;
            foreach (var conteudo in json_filesGame.url_libraries)
            {
                if (conteudo != null)
                {
                    addArray2(contadeiro, conteudo.ToString(), "url_libraries");
                    contadeiro++;
                }
            }


            // Baixa as Bibliotecas/Libraries da arrayLibraries
            for (var i = 0; i < contadeiro; i++)
            {
                if (arrayLibraries[i, 1] != null )
                {
                    if (!Directory.Exists(gameDir + "/libraries/" + arrayLibraries[i, 1]))
                    {
                        Directory.CreateDirectory(gameDir + "/libraries/" + arrayLibraries[i, 0]);
                    }
                    download(arrayLibraries[i, 1], "libraries/" + arrayLibraries[i, 0], "");
                }      
            }


            // Baixa as assets   imagens/sons/lingua...            \.minecraft2\assets\indexes\3.json            
            string assets_indexes_Json = json_filesGame.assetIndex.Substring(json_filesGame.assetIndex.LastIndexOf("/") + 1);
            var json_assets = File.ReadAllText(gameDir + @"\assets\indexes\"+ assets_indexes_Json);
            var result = JsonConvert.DeserializeObject<Json_assets>(json_assets);


            foreach (KeyValuePair<string, Objects_assets> pair in result.objects)
            {
                string path_Assets = pair.Key;
                string hash = pair.Value.hash;
                string hash_2 = hash.Substring(0, 2);
                string urlDownload = url_assets + "/" + hash_2 + "/"+ hash;
                
                if (!Directory.Exists(gameDir + "/assets/objects/"+ hash_2))
                {
                    Directory.CreateDirectory(gameDir + "/assets/objects/"+ hash_2);
                }

                download(urlDownload, "assets/objects/"+hash_2, hash);
            }

            await Task.Delay(2000);

            label_Titulo.Text = "MINECRAFT LAUCHER DSS";
            label_Titulo.Location = new Point(336, 11);

            verificarVersoesBaixadas();

            MessageBox.Show("Versão " + comboBox_VersionsDownload.Text + " baixada com sucesso!");
            this.Enabled = true;
        }



        private void criarPastas(string versao)
        {
            // Verifica se existe os diretorios, se não, cria eles
            if (!Directory.Exists(gameDir + "/assets/indexes"))
            {
                Directory.CreateDirectory(gameDir + "/assets/indexes");
            }

            if (!Directory.Exists(gameDir + "/assets/log_configs"))
            {
                Directory.CreateDirectory(gameDir + "/assets/log_configs");
            }

            if (!Directory.Exists(gameDir + "/versions/" + versao))
            {
                Directory.CreateDirectory(gameDir + "/versions/" + versao);
            }

            //if (!Directory.Exists(gameDir + "/assets/objects"))
            //{
            //    Directory.CreateDirectory(gameDir + "/assets/objects");
            //}

            //if (!Directory.Exists(gameDir + "/libraries"))
            //{
            //    Directory.CreateDirectory(gameDir + "/libraries");
            //}

            //if (!Directory.Exists(gameDir + "/versions"))
            //{
            //    Directory.CreateDirectory(gameDir + "/versions");
            //}
        }





        private void download_javao(string javaVersion)
        {
            string dirJava = gameDir + "/javas/" + javaVersion;
            if (!Directory.Exists(dirJava))
            {
                Directory.CreateDirectory(dirJava);
            }

            string url_Javao = "";

            WebRequest solicitacao = HttpWebRequest.Create(url_java);
            WebResponse resposta = solicitacao.GetResponse();
            StreamReader ler_get = new StreamReader(resposta.GetResponseStream());
            JObject jsonObj_filesGame = JObject.Parse(ler_get.ReadToEnd());


            json_java json_java = new json_java
            {
                java64 = from p in jsonObj_filesGame["windows-x64"][javaVersion] select (string)p["manifest"]["url"],       //https://piston-meta.mojang.com/v1/packages/74f9ec828e19df89c6bc7366d1048c5a315119e8/manifest.json
                java86 = from p in jsonObj_filesGame["windows-x86"][javaVersion] select (string)p["manifest"]["url"],
            };


            if (Environment.Is64BitOperatingSystem)
            {
                foreach (var conteudo in json_java.java64)
                {
                    if (conteudo != null)
                    {
                        url_Javao = conteudo.ToString();
                    }
                }
            }
            else
            {
                foreach (var conteudo in json_java.java86)
                {
                    if (conteudo != null)
                    {
                        url_Javao = conteudo.ToString();
                    }
                }
            }


            download(url_Javao, "javas/" + javaVersion, javaVersion + ".json");
            // https://piston-meta.mojang.com/v1/packages/74f9ec828e19df89c6bc7366d1048c5a315119e8/manifest.json


            System.Threading.Thread.Sleep(1200);
            var json_assets = File.ReadAllText(dirJava + "/" + javaVersion + ".json");
            var result = JsonConvert.DeserializeObject<Json_assets_seila>(json_assets);
            //var result = JsonConvert.DeserializeObject<Json_assets_seila>(ler_get2.ToString());

            int linha = 0;
            foreach (KeyValuePair<string, Objects_assets_seila> pair in result.files)
            {
                string path = pair.Key;
                string type = pair.Value.type;
                // MessageBox.Show("path_Assets:" + path + "\n" + "type:" + type);

                if (type == "directory")
                {
                    if (!Directory.Exists(gameDir + "/javas/" + javaVersion + "/" + path))
                    {
                        Directory.CreateDirectory(gameDir + "/javas/" + javaVersion + "/" + path);
                    }
                }
                else
                {
                    arrayArquivosJava[linha, 0] = path;
                    linha++;
                }
            }


            WebRequest solicitacao2 = HttpWebRequest.Create(url_Javao);
            WebResponse resposta2 = solicitacao2.GetResponse();
            StreamReader ler_get2 = new StreamReader(resposta2.GetResponseStream());
            JObject jsonObj_filesGame2 = JObject.Parse(ler_get2.ReadToEnd());

            foreach (var item in arrayArquivosJava)
            {
                if (item != null & item != "")
                {
                    json_java_files json_java_files = new json_java_files
                    {
                        //url = from p in jsonObj_filesGame2["files"][item] select (string)p["downloads"]["raw"]["url"],
                        url = (string)jsonObj_filesGame2["files"][item]["downloads"]["raw"]["url"],
                        // trocar raw por lzma, e descompactar
                    };

                    if (item != "release")
                    {
                        string arquivo = item.Substring(item.LastIndexOf("/") + 1);     // Corta na ultima  \  apaga oque tem antes
                        string diretorio = item.Substring(0, item.LastIndexOf("/"));    // Corta na ultima  \  apaga oque tem depois

                        download(json_java_files.url, "javas/" + javaVersion + "/" + diretorio, arquivo);
                    }
                    else
                    {
                        download(json_java_files.url, "javas/" + javaVersion, item);
                    }

                    label_Titulo.Text = "Baixando: " + item;
                }
            }
        }



        // Exemplo:   download( "https://www.google.com/robots.txt", "assets/objects" , "robots.txt" );
        private void download(string url, string diretorio, string nome)
        {
            using (WebClient wc = new WebClient())
            {
                // Se o parametro 'nome' estiver em branco, vai usar o nome 'original'
                nome = (nome == "") ? url.Substring(url.LastIndexOf("/") + 1) : nome;

                // Download do arquivo de forma síncrona
                wc.DownloadFile(url, gameDir + "/" + diretorio + "/" + nome);

                // Atualizar a interface do usuário após o download / NÃO FUNCIONA DIREITO :/
                label_Titulo.Invoke((Action)(() => {
                    label_Titulo.Text = "Baixando: " + diretorio + "/" + nome;
                }));
            }
        }



        // Ao clicar no comboBox escrito 'versões', o conteudo é "substituido"
        private void comboBox_TypeDownload_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (verificarVersao == false)
            {
                comboBox_TypeDownload.Items.Clear();
                comboBox_TypeDownload.Items.Add("release");
                comboBox_TypeDownload.Items.Add("snapshot");
                comboBox_TypeDownload.Items.Add("old_beta");
                comboBox_TypeDownload.Items.Add("old_alpha");            
            }
        }


        private void button_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void button_FecharTUDO_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void textBox_uuid_TextChanged(object sender, EventArgs e)
        {
            if (textBox_uuid.Text.Length == 32)
            {
                try
                {
                    string url = "https://api.mineatar.io/body/full/";
                        using (WebClient webClient = new WebClient())
                        {
                            using (Stream stream = webClient.OpenRead(url + textBox_uuid.Text + "?scale=10"))
                            {
                            pictureBox_UUID.Image = Image.FromStream(stream);
                            }
                        }
                }
                catch (Exception)
                {
                    pictureBox_UUID.Image = null;
                    throw;
                }
            }
        }
    }
}
