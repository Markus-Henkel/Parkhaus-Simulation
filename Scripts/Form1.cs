using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieGarage
{
    public partial class Form1 : Form
    {
        public Welt welt;
        public Einstellungen einstellungen;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_WeltGenerieren_Click(object sender, EventArgs e)
        {
            einstellungen = new Einstellungen((int)Decks.Value, (int)ParkplaetzePerDeck.Value,(int)FahrzeugeInWelt.Value);
            welt = new Welt(einstellungen);
            UpdateGUI();
            label_Info.Text = string.Empty;
        }

        private void Button_Befahren_Click(object sender, EventArgs e)
        {
            if(welt is null)
            {
                label_Info.Text = "Keine Simulation gestartet!";
                return;
            }
            label_Info.Text = string.Empty;
            if (welt.ungeparkteFahrzeuge.Count == 0)
            {
                label_Info.Text = "Keine Fahrzeuge zum parken!";
                return;
            }
            if (welt.garage.freiePlaetze == 0)
            {
                label_Info.Text = "Kein freier Platz!";
                return;
            }

            for (int i = 0; i < welt.garage.kapazität; i++)
            {
                if (welt.garage.parkstellen[i].fahrzeug == null)
                {
                    welt.garage.parkstellen[i].fahrzeug = welt.ungeparkteFahrzeuge[0];
                    welt.ungeparkteFahrzeuge.RemoveAt(0);
                    break;
                }
            }
            welt.garage.freiePlaetze--;
            welt.garage.vergebenePlaetze++;

            UpdateGUI();
        }

        private void Button_Verlassen_Click(object sender, EventArgs e)
        {
            if (welt is null)
            {
                label_Info.Text = "Keine Simulation gestartet!";
                return;
            }
            label_Info.Text = string.Empty;

            int chosenCar = -1;
            for (int i = 0; i < welt.garage.parkstellen.Count; i++)
            {
                if (welt.garage.parkstellen[i].fahrzeug != null)
                {
                    chosenCar = i;
                    break;
                }
            }

            if (chosenCar == -1)
            {
                label_Info.Text = "Kein Auto im Parkhaus!";
                return;
            }

            welt.ungeparkteFahrzeuge.Add(welt.garage.parkstellen[chosenCar].fahrzeug);
            welt.garage.parkstellen[chosenCar].fahrzeug = null;
            welt.garage.freiePlaetze++;
            welt.garage.vergebenePlaetze--;

            UpdateGUI();
        }
        private void UpdateGUI()
        {
            Ungeparkte_Fahrzeuge.Items.Clear();
            for (int i = 0; i < welt.ungeparkteFahrzeuge.Count; i++)
            {
                Ungeparkte_Fahrzeuge.Items.Add(welt.ungeparkteFahrzeuge[i].kennzeichen);
            }
            Geparkte_Fahrzeuge.Items.Clear();
            for (int i = 0; i < welt.garage.parkstellen.Count; i++)
            {
                if (welt.garage.parkstellen[i].fahrzeug != null)
                {
                    Geparkte_Fahrzeuge.Items.Add(welt.garage.parkstellen[i].fahrzeug.kennzeichen);
                }
            }
            Auslastung.Text = welt.garage.kapazität - welt.garage.freiePlaetze + " / " + welt.garage.kapazität;

            var percentage = (float)welt.garage.vergebenePlaetze / (float)welt.garage.kapazität * 100;
            ProgressBar_Auslastung.Value = (int)percentage;
        }

        private void Button_CheckCar_Click(object sender, EventArgs e)
        {
            var id = Geparkte_Fahrzeuge.SelectedIndex;
            if(id == -1)
            {
                label_Info.Text = "Kein geparktes Fahrzeug ausgewählt!";
                return;
            }

            var etage = welt.garage.parkstellen[id].etage;
            var art = welt.garage.parkstellen[id].fahrzeug.fahrzeugart;
            var kennzeichen = welt.garage.parkstellen[id].fahrzeug.kennzeichen;
            label_Info.Text = "Das " + art + " mit Kennzeichen: " + kennzeichen + " steht auf Etage: " + etage + " auf Platz: " + id;
        }
    }
}
