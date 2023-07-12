using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftLauncherDSS
{
    class modelJson
    {
        public class json_version_manifest
        {
            public string release { get; set; }
            public string snapshot { get; set; }


            public IEnumerable id { get; set; }
            public IEnumerable type { get; set; }
            public IEnumerable url { get; set; }
            public IEnumerable releaseTime { get; set; }
        }


        public class json_filesGame
        {
            public string java { get; set; }
            public string url_client { get; set; }
            public string assetIndex { get; set; }
            public string log_configs { get; set; }

            public IEnumerable path_libraries { get; set; }
            public IEnumerable url_libraries { get; set; }

            //public IEnumerable os_libraries { get; set; }     // dividir entre os sistemas operacional...
        }



        public class json_iniciar
        {
            public string javaVersion { get; set; }
            public string versionType { get; set; }

            public string assetIndex { get; set; }

            public string Dlog4j { get; set; }

            public IEnumerable arguments { get; set; }

            // não usado...
            public string HeapDumpPath { get; set; }
            public string OsName { get; set; }
            public string OsVersion { get; set; }
            public string JavaLibraryPath { get; set; }
            public string MinecraftLauncherBrand { get; set; }
            public string MinecraftLauncherVersion { get; set; }


            public List<string> LibraryPaths { get; set; }

        }


        public class json_java
        {
            public IEnumerable java64 { get; set; }
            public IEnumerable java86 { get; set; }
        }



        public class Json_assets_seila
        {
            public IDictionary<string, Objects_assets_seila> files { get; set; }
        }

        public class Objects_assets_seila
        {
            public string type { get; set; }
        }



        public class json_java_files
        {
            public string url { get; set; }
        }




        public class Json_assets
        {
            public IDictionary<string, Objects_assets> objects { get; set; }
        }

        public class Objects_assets
        {
            public string hash { get; set; }
        }



    }
}
