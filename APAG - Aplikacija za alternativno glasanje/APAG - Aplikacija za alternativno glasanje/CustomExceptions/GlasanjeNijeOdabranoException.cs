using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAG___Aplikacija_za_alternativno_glasanje.CustomExceptions
{
    public class GlasanjeNijeOdabranoException : Exception
    {
        public string DodatnaPoruka { get; set; }

        public GlasanjeNijeOdabranoException(string poruka)
        {
            DodatnaPoruka = poruka;
        }
    }
}
