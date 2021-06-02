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
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_WeltGenerieren_Click(object sender, EventArgs e)
        {
            welt = new Welt((int)Decks.Value, (int)ParkplaetzePerDeck.Value, (int)FahrzeugeInWelt.Value)
            {
                etagen = (int)Decks.Value,
                parkstellenProEtage = (int)ParkplaetzePerDeck.Value,
                fahrzeugeInWelt = (int)FahrzeugeInWelt.Value,
                parkdauer = TrackBar_Parkdauer.Value,
                parkversucheProStunde = TrackBar_ParkversucheProStunde.Value
            };
            TrackBar_Speed.Value = 1;
            UpdateGUI();
            label_Info.Text = string.Empty;
            Timer.Start();
        }

        private void Button_Befahren_Click(object sender, EventArgs e)
        {
            if (welt is null)
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
            ParkCar();
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
            ExitCarFromGarage(chosenCar);

        }
        private void ExitCarFromGarage(int index)
        {
            welt.ungeparkteFahrzeuge.Add(welt.garage.parkstellen[index].fahrzeug);
            welt.garage.parkstellen[index].fahrzeug = null;
            welt.garage.freiePlaetze++;
            welt.garage.vergebenePlaetze--;

            UpdateGUI();
        }
        private void ParkCar()
        {
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
                    welt.garage.parkstellen[i].fahrzeug.parkEndZeit = welt.time + welt.parkdauer;
                    label_Info.Text = "Endparkzeit gesetzt auf: "
                        + TimeSpan.FromSeconds(welt.garage.parkstellen[i].fahrzeug.parkEndZeit);
                    welt.ungeparkteFahrzeuge.RemoveAt(0);
                    break;
                }
            }
            welt.garage.freiePlaetze--;
            welt.garage.vergebenePlaetze++;

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
            if (id == -1)
            {
                label_Info.Text = "Kein geparktes Fahrzeug ausgewählt!";
                return;
            }

            var etage = welt.garage.parkstellen[id].etage;
            var art = welt.garage.parkstellen[id].fahrzeug.fahrzeugart;
            var kennzeichen = welt.garage.parkstellen[id].fahrzeug.kennzeichen;
            label_Info.Text = "Art: " + art + "\n\nKennzeichen: " + kennzeichen + "\n\nEtage: " + etage + "\n\nPlatz: " + id;
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (welt is null) return;
            welt.time += 1 * welt.speed;
            welt.time = Math.Round(welt.time, 1);
            label_VergangeneZeit.Text = TimeSpan.FromSeconds(welt.time).ToString();

            for (int i = 0; i < welt.garage.parkstellen.Count; i++)
            {
                if (welt.garage.parkstellen[i].fahrzeug != null)
                {
                    if (welt.garage.parkstellen[i].fahrzeug.parkEndZeit <= welt.time)
                    {
                        ExitCarFromGarage(i);
                    }
                }
            }
        }

        private void Button_StartTime_Click(object sender, EventArgs e)
        {
            if (welt is null) return;
            Timer.Start();
        }

        private void Button_StopTime_Click(object sender, EventArgs e)
        {
            if (welt is null) return;
            Timer.Stop();
        }

        private void TrackBar_Speed_Scroll(object sender, EventArgs e)
        {
            if (welt is null) return;
            welt.speed = TrackBar_Speed.Value;
        }

        private void TrackBar_ParkversucheProStunde_Scroll(object sender, EventArgs e)
        {
            if (welt is null) return;
            welt.parkversucheProStunde = TrackBar_ParkversucheProStunde.Value;

        }

        private void TrackBar_Parkdauer_Scroll(object sender, EventArgs e)
        {
            if (welt is null) return;
            welt.parkdauer = TrackBar_Parkdauer.Value;
            label_Parkdauer.Text = TimeSpan.FromSeconds(welt.parkdauer).ToString();
        }
    }
}
