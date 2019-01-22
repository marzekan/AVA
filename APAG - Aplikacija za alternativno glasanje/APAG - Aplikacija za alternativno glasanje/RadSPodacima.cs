using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAG___Aplikacija_za_alternativno_glasanje
{
    /// <summary>
    /// Statička klasa koja sadrži metode za dohvaćanje podataka iz baze podataka.
    /// </summary>
    public static class RadSPodacima
    {
        /// <summary>
        /// Postavlja listu Glasanja kao izvor podataka binding source-a.
        /// </summary>
        /// <param name="bs"></param>
        public static void PrikazGlasanja(BindingSource bs)
        {
            BindingList<Glasanje> listaGlasanja = null;
            using (var db = new Entities2())
            {
                listaGlasanja = new BindingList<Glasanje>(db.Glasanje.ToList());
            }
            bs.DataSource = listaGlasanja;
        }

        /// <summary>
        /// Postavlja listu Kandidata kao izvor podataka binding source-a.
        /// </summary>
        /// <param name="bs"></param>
        public static void PrikazKandidata(BindingSource bs) 
        {
            BindingList<Kandidat> listaKandidata = null;
            using (var db = new Entities2())
            {
                listaKandidata = new BindingList<Kandidat>(db.Kandidat.ToList());
            }
            bs.DataSource = listaKandidata;
        }

        /// <summary>
        /// Postavlja listu Glasaca kao izbor podataka binding source-a.
        /// </summary>
        /// <param name="bs"></param>
        public static void PrikazGlasaca(BindingSource bs)
        {
            BindingList<Glasac> listaGlasaca = null;
            using (var db = new Entities2())
            {
                listaGlasaca = new BindingList<Glasac>(db.Glasac.ToList());
            }
            bs.DataSource = listaGlasaca;
        }
    }
}
