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
        public World welt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_WeltGenerieren_Click(object sender, EventArgs e)
        {
            welt = new World((int)Decks.Value, (int)ParkplaetzePerDeck.Value, (int)FahrzeugeInWelt.Value)
            {
                decks = (int)Decks.Value,
                placesPerDeck = (int)ParkplaetzePerDeck.Value,
                amountOfCars = (int)FahrzeugeInWelt.Value,
                parktime = TrackBar_Parkdauer.Value,
                timeBetweenParkingTries = 3600 / TrackBar_ParkversucheProStunde.Value
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
            if (welt.freeroamingCars.Count == 0)
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
            for (int i = 0; i < welt.garage.parkingPlaces.Count; i++)
            {
                if (welt.garage.parkingPlaces[i].vehicle != null)
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
            welt.freeroamingCars.Add(welt.garage.parkingPlaces[index].vehicle);
            welt.garage.parkingPlaces[index].vehicle = null;
            welt.garage.freePlaces++;
            welt.garage.occupiedPlaces--;

            UpdateGUI();
        }
        private void ParkCar()
        {
            if (welt.garage.freePlaces == 0)
            {
                label_Info.Text = "Kein freier Platz!";
                return;
            }

            for (int i = 0; i < welt.garage.capacity; i++)
            {
                if (welt.garage.parkingPlaces[i].vehicle == null)
                {
                    welt.garage.parkingPlaces[i].vehicle = welt.freeroamingCars[0];
                    welt.garage.parkingPlaces[i].vehicle.parkingEndTime = welt.time + welt.parktime;
 //                   label_Info.Text = "Endparkzeit gesetzt auf: "
 //                       + TimeSpan.FromSeconds(welt.garage.parkingPlaces[i].fahrzeug.parkingEndTime);
                    welt.freeroamingCars.RemoveAt(0);
                    break;
                }
            }
            welt.garage.freePlaces--;
            welt.garage.occupiedPlaces++;
            welt.lastTimeCarParked = welt.time;

            UpdateGUI();
        }
        private void UpdateGUI()
        {
            Ungeparkte_Fahrzeuge.Items.Clear();
            for (int i = 0; i < welt.freeroamingCars.Count; i++)
            {
                Ungeparkte_Fahrzeuge.Items.Add(welt.freeroamingCars[i].numberPlate);
            }
            Geparkte_Fahrzeuge.Items.Clear();
            for (int i = 0; i < welt.garage.parkingPlaces.Count; i++)
            {
                if (welt.garage.parkingPlaces[i].vehicle != null)
                {
                    Geparkte_Fahrzeuge.Items.Add(welt.garage.parkingPlaces[i].vehicle.numberPlate);
                }
            }
            Auslastung.Text = welt.garage.capacity - welt.garage.freePlaces + " / " + welt.garage.capacity;

            var percentage = (float)welt.garage.occupiedPlaces / (float)welt.garage.capacity * 100;
            ProgressBar_Auslastung.Value = (int)percentage;
        }

        private void Button_CheckCar_Click(object sender, EventArgs e)
        {
            var id = Geparkte_Fahrzeuge.SelectedIndex;            
            var searchedNumberPlate = TextBox_NumberPlate.Text;
            if (id == -1 && searchedNumberPlate == "")
            {
                label_Info.Text = "Kein geparktes Fahrzeug ausgewählt!";
                return;
            }
            if(searchedNumberPlate != string.Empty)
            {
                var searchId = -1;
                for (int i = 0; i < welt.garage.parkingPlaces.Count; i++)
                {
                    if(welt.garage.parkingPlaces[i].vehicle != null)
                    {
                        if(welt.garage.parkingPlaces[i].vehicle.numberPlate == searchedNumberPlate)
                        {
                            searchId = i;
                        }
                    }
                }
                if(searchId == -1)
                {
                    label_Info.Text = "Kennzeichen nicht in Parkhaus gefunden!";
                    return;
                }
                id = searchId;
            }

            var deck = welt.garage.parkingPlaces[id].deck;
            var type = welt.garage.parkingPlaces[id].vehicle.vehicleType;
            var numberPlate = welt.garage.parkingPlaces[id].vehicle.numberPlate;
            label_Info.Text = "Art: " + type + "\n\nKennzeichen: " + numberPlate + "\n\nEtage: " + deck + "\n\nPlatz: " + id;
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (welt is null) return;
            welt.time += 0.1d * welt.speed;
            label_VergangeneZeit.Text = TimeSpan.FromSeconds(Math.Round(welt.time, 0)).ToString();

            for (int i = 0; i < welt.garage.parkingPlaces.Count; i++)
            {
                if (welt.garage.parkingPlaces[i].vehicle != null)
                {
                    if (welt.garage.parkingPlaces[i].vehicle.parkingEndTime <= welt.time)
                    {
                        ExitCarFromGarage(i);
                    }
                }
            }

            if (welt.freeroamingCars.Count > 0)
            {
                if (welt.lastTimeCarParked + welt.timeBetweenParkingTries <= welt.time)
                {
                    ParkCar();
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
            label_Parkversuche.Text = TrackBar_ParkversucheProStunde.Value.ToString();
            if (welt is null) return;
            welt.timeBetweenParkingTries = 3600 / TrackBar_ParkversucheProStunde.Value;
        }

        private void TrackBar_Parkdauer_Scroll(object sender, EventArgs e)
        {
            label_Parkdauer.Text = TimeSpan.FromSeconds(welt.parktime).ToString();
            if (welt is null) return;
            welt.parktime = TrackBar_Parkdauer.Value;
        }
    }
}
