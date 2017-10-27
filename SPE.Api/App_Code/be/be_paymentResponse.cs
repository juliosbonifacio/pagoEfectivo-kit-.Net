using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPE.Api.App_Code.be
{
    public class BEpaymentResponse
    {
        public string NumeroCip { get; set; }
        public string IdComercio { get; set; }
        public string Token { get; set; }
        public string Estado { get; set; }
        public string Mensaje { get; set; }
        public string Xml { get; set; }
    }
}
