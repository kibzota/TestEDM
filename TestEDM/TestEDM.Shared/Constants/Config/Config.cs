using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestEDM.Shared.Constants
{
    public static class Config
    {
        public const string DefaultConnection = "DefaultConnection";

        public static IConfigurationRoot ConfiguracaoAppSettings;

        public static void Load(IConfigurationRoot configuracao)
        {
            ConfiguracaoAppSettings = configuracao;
        }

        public static string BuscarStringDeConexao()
        {
            return ConfiguracaoAppSettings.GetConnectionString(DefaultConnection);
        }
    }
}
