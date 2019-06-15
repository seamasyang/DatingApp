using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppApi
{
    public class AppConfig
    {
        public static byte[] JwtSecret{get;set;}
        public static string ConnectionString { get; set; }
    }
}
