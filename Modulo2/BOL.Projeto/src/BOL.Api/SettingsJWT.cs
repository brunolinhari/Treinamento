using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOL.Api
{
    public class SettingsJWT
    {
        public string Secret { get; set; }
        public int ExpiracaoHoras { get; set; }
        public string Emissor { get; set; }
        public string ValidoEm { get; set; }
    }
}
