﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GnossTestView.Areas.GnossTestView.Model
{
    public class ConfigurationModel
    {
        public string urlApiIntegracionEntornos { get; set; }

        public UserPaswordModel usuarioRootRepositorio { get; set; }

        public SerferFtpModel serverFtpUpload { get; set; }

        public List<AutorizationModel> autorizacion { get; set; }

        public List<ProyectoRamaModel> proyectos { get; set; }

        public class UserPaswordModel
        {
            public string user { get; set; }
            public string password { get; set; }
        }

        public class SerferFtpModel
        {
            public string server { get; set; }
            public string port { get; set; }
        }

        public class AutorizationModel
        {
            public string url { get; set; }
            public string user { get; set; }
            public string password { get; set; }
        }

        public class ProyectoRamaModel
        {
            public string nombreCortoProyecto { get; set; }
            public string rama { get; set; }
            public string userFTP { get; set; }
            public string passwordFTP { get; set; }
        }
    }
}