using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkManagementApp.Model
{
    public class Utilizator
    {
        public int? Id { get; set; }
        public string? Nume { get; set; }
        public List<Grup> Grupuri { get; set;  } = new List<Grup>();


        public Utilizator(int id, string nume)
        {
            this.Id = id;
            this.Nume = nume;
        }

        public Utilizator() { }

        public Utilizator(int id, string nume) : this(nume)
        {
            this.Id = id;
        }
        public void AdaugaGrup(Grup grup)
        {
            if (!Grupuri.Contains(grup))
            {
                Grupuri.Add(grup);
            }
        }
        public void StergeGrup(Grup grup)
        {
            if (Grupuri.Contains(grup))
            {
                Grupuri.Remove(grup);
            }
        }

        public void AdaugaDrept(Drept drept)
        {
            if (!Grupuri.Any(g => g.Drepturi.Contains(drept)))
            {
                foreach (var grup in Grupuri)
                {
                    grup.AdaugaDrept(drept);
                }
            }
        }
        public void StergeDrept(Drept drept)
        {
            foreach (var grup in Grupuri)
            {
                if (grup.Drepturi.Contains(drept))
                {
                    grup.Drepturi.Remove(drept);
                }
            }
        }

        public LIst<Drept> GetDrepturi() {
            HashSet<Drept> drepturi = new();
            foreach (var grup in Grupuri) {
                foreach (var drept in grup.Drepturi) { 
                    drepturi.Add(drept);
                }
            }
            return new List<Drept>(drepturi);
        }

    }
}