using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkManagementApp.Model
{
    public class Grup
    {
        public int? Id { get; set; }
        public string? Nume { get; set; }
        public List<Utilizator> Utilizatori { get; set; } = new List<Utilizator>();
        public List<Drept> Drepturi { get; set; } = new List<Drept>();


        public Grup(int id, string nume)
        {
            this.Id = id;
            this.Nume = nume;
        }

        public Grup() { }


        public void AdaugaUtilizator(Utilizator utilizator)
        {
            if (!Utilizatori.Contains(utilizator)) {
                Utilizatori.Add(utilizator);
            }
        }

        public void AdaugaDrept(Drept drept) {
            if (!Drepturi.Contains(drept)) {
                Drepturi.Add(drept);
            }
                }
    }
}