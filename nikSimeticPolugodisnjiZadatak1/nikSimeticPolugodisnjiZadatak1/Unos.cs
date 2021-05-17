using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticPolugodisnjiZadatak1
{
    class Unos
    {
        string marka;
        string model;
        int godiste;
        string status;

        public Unos(string marka, string model, int godiste)
        {
            this.marka = marka;
            this.model = model;
            this.godiste = godiste;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Godiste { get => godiste; set => godiste = value; }
        public string Status { get => status; set => status = value; }

        public void Provjera()
        {
            if(this.marka == "Prusa")
            {
                this.status = "Odličan";
            }
            else if(this.marka=="Creality")
            {
                if(this.model=="CR10S")
                {
                    this.status = "Dobar";
                }
                else
                {
                    this.status = "tako tako";
                }
            }
        }
        public override string ToString()
        {
            string ispis = string.Format("{0, -20} {1, -20} {2, -20} {3, -20} ", this.marka, this.model, this.godiste, this.Status);
            return ispis;
        }
    }
}
