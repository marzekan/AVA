using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikaOdabiraPobjednika
{
    /// <summary>
    /// Klasa koja sadrzi metodu za odlučivanje pobjednika.
    /// </summary>
    public static class Voting
    {
        public static string OdabirPobjednika(List<string> listaOdabir1, List<string> listaOdabir2, List<string> listaOdabir3)
        {
            string pobjednik = "";
            string poslijednji = "";
            int brojGlasova = listaOdabir1.Count;
            /// Brojač. "Exhausted" su glasovi koji su nevažeći.
            int brExhausted = 0;
            int brojacNull = 0;

            /// Sadrži Id Kandidata.
            List<string> listaId = new List<string>();
            /// Sadrži brojeve glasova svakog Kandidata.
            List<int> listaBrojGlasova = new List<int>();

            while (true)
            {
                /// Kolekcija sadrži Kandidate grupirane prema Id-u, te broj glasova svakog Kandidata.
                var grupiraniGlasovi = listaOdabir1.GroupBy(i => i).Select(g => new { Id = g.Key, brGlasova = g.Count() });
                /// Kolekcija sadrži Kandidate sortirane prema broju glasova.
                var grupiraniGlasoviSortirano = grupiraniGlasovi.OrderByDescending(i => i.brGlasova);

                /// Pohranjivanje Id-a i broja glasova Kandidata u zasebne liste.
                foreach (var element in grupiraniGlasoviSortirano)
                {
                    listaId.Add(element.Id);
                    listaBrojGlasova.Add(element.brGlasova);
                }
                /// Ukoliko Kandidat sa najviše glasova ima više od 50% glasova, pobjednik je pronađen.
                if(((float)listaBrojGlasova.First() / (float)brojGlasova) > 0.5f && listaId.First() != null)
                {
                    pobjednik = listaId.First();
                    break;
                }
                /// Prebrjavanje ne-null elemenata liste.
                foreach (string clan in listaOdabir1)
                {
                    if(clan != null)
                    {
                        brojacNull++;
                    }
                }
                /// Ukoliko je ostao samo jedan ne-null Kandidat, on je pobjednik.
                if(brojacNull == 1)
                {
                    pobjednik = listaOdabir1[0];
                    break;
                }
                else
                {
                    foreach (string kandidat in listaId)
                    {
                        if(kandidat != null)
                        {
                            /// Kandidat s najmanjim brojem glasova u svakoj iteraciji.
                            poslijednji = kandidat.Last().ToString();
                        }
                    }

                    /// Mijenjanje Kandidata sa najmanjim brojem glasova, onim Kandidatima koji su drugi ili treći izbor.
                    for (int i = 0; i < brojGlasova; i++)
                    {
                        if(listaOdabir1[i] == poslijednji)
                        {
                            /// Ukoliko je Kandidat koji je drugi izbor već izbačen, tada se uzima treći odabir.
                            if(listaOdabir2[i] == null)
                            {
                                /// Ukoliko je i treći Kandidat već izbačen, tada glas postaje nevažeći (Exhausted).
                                if(listaOdabir3[i] == null)
                                {
                                    listaOdabir1[i] = null;
                                    brExhausted++;
                                }
                                else
                                {
                                    listaOdabir1[i] = listaOdabir3[i];
                                    listaOdabir3[i] = null;
                                }
                            }
                            else
                            {
                                listaOdabir1[i] = listaOdabir2[i];
                                listaOdabir2[i] = null;
                            }
                        }
                    }

                    /// Izbacivanje Kandidata s najmanjim brojem glasova iz liste drugih odabira.
                    for (int i = 0; i < listaOdabir2.Count; i++)
                    {
                        if(listaOdabir2[i] == poslijednji)
                        {
                            listaOdabir2[i] = null;
                        }
                    }

                    /// Izbacivanje Kandidata s najmanjim brojem glasova iz liste trećih odabira.
                    for (int i = 0; i < listaOdabir3.Count; i++)
                    {
                        if(listaOdabir3[i] == poslijednji)
                        {
                            listaOdabir3[i] = null;
                        }
                    }

                    /// Pripremanje lista za novu iteraciju.
                    listaId = new List<string>();
                    listaBrojGlasova = new List<int>();
                }
            }

            return pobjednik;
        }
    }
}
