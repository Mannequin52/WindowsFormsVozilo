using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms15_2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        class Vozilo
        {
            string marka, model, vrsta, VoziPo;

            public string Vrsta { get => Vrsta1; set => Vrsta1 = value; }
            public string Vrsta1 { get => Vrsta2; set => Vrsta2 = value; }
            public string Vrsta2 { get => vrsta; set => vrsta = value; }
            public string VoziPo1 { get => VoziPo; set => VoziPo = value; }

            public Vozilo (string a, string b, string c) {
                model = b;
                marka = a;
                vrsta = c;
            }

            public override string ToString()
            {
                return "Marka: " + marka + "\nModel: " + model + "\nVrsta: " + vrsta + "\nVozi po: " + VoziPo1 + "\r\n";
            }
        }
        List<Vozilo> voziloLista = new List<Vozilo>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Vozilo brum = new Vozilo(marka.Text, model.Text, vrsta.Text);
                voziloLista.Add(brum);
                marka.Clear();
                model.Clear();
                
                
            }
            catch
            {

            }

        }


        private void ispis_Click(object sender, EventArgs e)
        {
            foreach (Vozilo brum in voziloLista)
            {
                rezultat.AppendText(brum.ToString());
            }
        }

        /*
        private void vrsta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        */

        private void obradatxt_Click(object sender, EventArgs e)
        {
            foreach (Vozilo brum in voziloLista)
            {
                if (brum.Vrsta == "Avion")
                {
                    brum.VoziPo = "Zrak";
                }
                if (brum.Vrsta == "Automobil")
                {
                    brum.VoziPo = "Cesta";
                }
                if (brum.Vrsta == "Brod")
                {
                    brum.VoziPo = "Voda";
                }

            }
        }
    }
}
