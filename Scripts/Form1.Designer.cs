﻿
namespace DieGarage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Decks = new System.Windows.Forms.NumericUpDown();
            this.ParkplaetzePerDeck = new System.Windows.Forms.NumericUpDown();
            this.label_Decks = new System.Windows.Forms.Label();
            this.label_ParkplaetzePerDeck = new System.Windows.Forms.Label();
            this.Button_WeltGenerieren = new System.Windows.Forms.Button();
            this.panel_Konfiguration = new System.Windows.Forms.Panel();
            this.label_PlaetzeInsgesamt = new System.Windows.Forms.Label();
            this.ProgressBar_Auslastung = new System.Windows.Forms.ProgressBar();
            this.Auslastung = new System.Windows.Forms.Label();
            this.label_Auslastung = new System.Windows.Forms.Label();
            this.Button_Befahren = new System.Windows.Forms.Button();
            this.Button_Verlassen = new System.Windows.Forms.Button();
            this.Geparkte_Fahrzeuge = new System.Windows.Forms.ListBox();
            this.Ungeparkte_Fahrzeuge = new System.Windows.Forms.ListBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.label_UngeparkteFahrzeuge = new System.Windows.Forms.Label();
            this.label_GeparkteFahrzeuge = new System.Windows.Forms.Label();
            this.Button_CheckCar = new System.Windows.Forms.Button();
            this.label_FahrzeugeInWelt = new System.Windows.Forms.Label();
            this.FahrzeugeInWelt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Decks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkplaetzePerDeck)).BeginInit();
            this.panel_Konfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FahrzeugeInWelt)).BeginInit();
            this.SuspendLayout();
            // 
            // Decks
            // 
            this.Decks.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Decks.ForeColor = System.Drawing.SystemColors.Window;
            this.Decks.Location = new System.Drawing.Point(4, 20);
            this.Decks.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Decks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Decks.Name = "Decks";
            this.Decks.Size = new System.Drawing.Size(120, 20);
            this.Decks.TabIndex = 0;
            this.Decks.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ParkplaetzePerDeck
            // 
            this.ParkplaetzePerDeck.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ParkplaetzePerDeck.ForeColor = System.Drawing.SystemColors.Window;
            this.ParkplaetzePerDeck.Location = new System.Drawing.Point(142, 20);
            this.ParkplaetzePerDeck.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ParkplaetzePerDeck.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParkplaetzePerDeck.Name = "ParkplaetzePerDeck";
            this.ParkplaetzePerDeck.Size = new System.Drawing.Size(120, 20);
            this.ParkplaetzePerDeck.TabIndex = 1;
            this.ParkplaetzePerDeck.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label_Decks
            // 
            this.label_Decks.AutoSize = true;
            this.label_Decks.Location = new System.Drawing.Point(4, 4);
            this.label_Decks.Name = "label_Decks";
            this.label_Decks.Size = new System.Drawing.Size(41, 13);
            this.label_Decks.TabIndex = 2;
            this.label_Decks.Text = "Etagen";
            // 
            // label_ParkplaetzePerDeck
            // 
            this.label_ParkplaetzePerDeck.AutoSize = true;
            this.label_ParkplaetzePerDeck.Location = new System.Drawing.Point(143, 4);
            this.label_ParkplaetzePerDeck.Name = "label_ParkplaetzePerDeck";
            this.label_ParkplaetzePerDeck.Size = new System.Drawing.Size(106, 13);
            this.label_ParkplaetzePerDeck.TabIndex = 3;
            this.label_ParkplaetzePerDeck.Text = "Parkplätze pro Etage";
            // 
            // Button_WeltGenerieren
            // 
            this.Button_WeltGenerieren.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button_WeltGenerieren.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_WeltGenerieren.Location = new System.Drawing.Point(418, 11);
            this.Button_WeltGenerieren.Name = "Button_WeltGenerieren";
            this.Button_WeltGenerieren.Size = new System.Drawing.Size(117, 35);
            this.Button_WeltGenerieren.TabIndex = 4;
            this.Button_WeltGenerieren.Text = "Welt Generieren";
            this.Button_WeltGenerieren.UseVisualStyleBackColor = false;
            this.Button_WeltGenerieren.Click += new System.EventHandler(this.Button_WeltGenerieren_Click);
            // 
            // panel_Konfiguration
            // 
            this.panel_Konfiguration.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_Konfiguration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Konfiguration.Controls.Add(this.FahrzeugeInWelt);
            this.panel_Konfiguration.Controls.Add(this.label_FahrzeugeInWelt);
            this.panel_Konfiguration.Controls.Add(this.label_PlaetzeInsgesamt);
            this.panel_Konfiguration.Controls.Add(this.Decks);
            this.panel_Konfiguration.Controls.Add(this.Button_WeltGenerieren);
            this.panel_Konfiguration.Controls.Add(this.label_Decks);
            this.panel_Konfiguration.Controls.Add(this.ParkplaetzePerDeck);
            this.panel_Konfiguration.Controls.Add(this.label_ParkplaetzePerDeck);
            this.panel_Konfiguration.Location = new System.Drawing.Point(12, 13);
            this.panel_Konfiguration.Name = "panel_Konfiguration";
            this.panel_Konfiguration.Size = new System.Drawing.Size(553, 60);
            this.panel_Konfiguration.TabIndex = 5;
            // 
            // label_PlaetzeInsgesamt
            // 
            this.label_PlaetzeInsgesamt.AutoSize = true;
            this.label_PlaetzeInsgesamt.Location = new System.Drawing.Point(0, 82);
            this.label_PlaetzeInsgesamt.Name = "label_PlaetzeInsgesamt";
            this.label_PlaetzeInsgesamt.Size = new System.Drawing.Size(0, 13);
            this.label_PlaetzeInsgesamt.TabIndex = 5;
            // 
            // ProgressBar_Auslastung
            // 
            this.ProgressBar_Auslastung.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProgressBar_Auslastung.Location = new System.Drawing.Point(15, 517);
            this.ProgressBar_Auslastung.Name = "ProgressBar_Auslastung";
            this.ProgressBar_Auslastung.Size = new System.Drawing.Size(523, 41);
            this.ProgressBar_Auslastung.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar_Auslastung.TabIndex = 7;
            // 
            // Auslastung
            // 
            this.Auslastung.AutoSize = true;
            this.Auslastung.Location = new System.Drawing.Point(25, 501);
            this.Auslastung.Name = "Auslastung";
            this.Auslastung.Size = new System.Drawing.Size(30, 13);
            this.Auslastung.TabIndex = 8;
            this.Auslastung.Text = "0 / 0";
            this.Auslastung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Auslastung
            // 
            this.label_Auslastung.AutoSize = true;
            this.label_Auslastung.Location = new System.Drawing.Point(13, 485);
            this.label_Auslastung.Name = "label_Auslastung";
            this.label_Auslastung.Size = new System.Drawing.Size(59, 13);
            this.label_Auslastung.TabIndex = 9;
            this.label_Auslastung.Text = "Auslastung";
            // 
            // Button_Befahren
            // 
            this.Button_Befahren.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button_Befahren.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Befahren.Location = new System.Drawing.Point(198, 416);
            this.Button_Befahren.Name = "Button_Befahren";
            this.Button_Befahren.Size = new System.Drawing.Size(75, 23);
            this.Button_Befahren.TabIndex = 10;
            this.Button_Befahren.Text = "BEFAHREN";
            this.Button_Befahren.UseVisualStyleBackColor = false;
            this.Button_Befahren.Click += new System.EventHandler(this.Button_Befahren_Click);
            // 
            // Button_Verlassen
            // 
            this.Button_Verlassen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button_Verlassen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Verlassen.Location = new System.Drawing.Point(415, 416);
            this.Button_Verlassen.Name = "Button_Verlassen";
            this.Button_Verlassen.Size = new System.Drawing.Size(86, 23);
            this.Button_Verlassen.TabIndex = 11;
            this.Button_Verlassen.Text = "VERLASSEN";
            this.Button_Verlassen.UseVisualStyleBackColor = false;
            this.Button_Verlassen.Click += new System.EventHandler(this.Button_Verlassen_Click);
            // 
            // Geparkte_Fahrzeuge
            // 
            this.Geparkte_Fahrzeuge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Geparkte_Fahrzeuge.ForeColor = System.Drawing.SystemColors.Window;
            this.Geparkte_Fahrzeuge.FormattingEnabled = true;
            this.Geparkte_Fahrzeuge.Location = new System.Drawing.Point(155, 157);
            this.Geparkte_Fahrzeuge.Name = "Geparkte_Fahrzeuge";
            this.Geparkte_Fahrzeuge.Size = new System.Drawing.Size(161, 251);
            this.Geparkte_Fahrzeuge.TabIndex = 12;
            // 
            // Ungeparkte_Fahrzeuge
            // 
            this.Ungeparkte_Fahrzeuge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Ungeparkte_Fahrzeuge.ForeColor = System.Drawing.SystemColors.Window;
            this.Ungeparkte_Fahrzeuge.FormattingEnabled = true;
            this.Ungeparkte_Fahrzeuge.Location = new System.Drawing.Point(374, 157);
            this.Ungeparkte_Fahrzeuge.Name = "Ungeparkte_Fahrzeuge";
            this.Ungeparkte_Fahrzeuge.Size = new System.Drawing.Size(161, 251);
            this.Ungeparkte_Fahrzeuge.TabIndex = 13;
            // 
            // label_Info
            // 
            this.label_Info.Location = new System.Drawing.Point(89, 485);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(435, 29);
            this.label_Info.TabIndex = 14;
            // 
            // label_UngeparkteFahrzeuge
            // 
            this.label_UngeparkteFahrzeuge.AutoSize = true;
            this.label_UngeparkteFahrzeuge.Location = new System.Drawing.Point(374, 141);
            this.label_UngeparkteFahrzeuge.Name = "label_UngeparkteFahrzeuge";
            this.label_UngeparkteFahrzeuge.Size = new System.Drawing.Size(113, 13);
            this.label_UngeparkteFahrzeuge.TabIndex = 15;
            this.label_UngeparkteFahrzeuge.Text = "UngeparkteFahrzeuge";
            // 
            // label_GeparkteFahrzeuge
            // 
            this.label_GeparkteFahrzeuge.AutoSize = true;
            this.label_GeparkteFahrzeuge.Location = new System.Drawing.Point(156, 141);
            this.label_GeparkteFahrzeuge.Name = "label_GeparkteFahrzeuge";
            this.label_GeparkteFahrzeuge.Size = new System.Drawing.Size(104, 13);
            this.label_GeparkteFahrzeuge.TabIndex = 16;
            this.label_GeparkteFahrzeuge.Text = "Geparkte Fahrzeuge";
            // 
            // Button_CheckCar
            // 
            this.Button_CheckCar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button_CheckCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_CheckCar.Location = new System.Drawing.Point(20, 157);
            this.Button_CheckCar.Name = "Button_CheckCar";
            this.Button_CheckCar.Size = new System.Drawing.Size(117, 40);
            this.Button_CheckCar.TabIndex = 17;
            this.Button_CheckCar.Text = "Wo ist das Fahrzeug?";
            this.Button_CheckCar.UseVisualStyleBackColor = false;
            this.Button_CheckCar.Click += new System.EventHandler(this.Button_CheckCar_Click);
            // 
            // label_FahrzeugeInWelt
            // 
            this.label_FahrzeugeInWelt.AutoSize = true;
            this.label_FahrzeugeInWelt.Location = new System.Drawing.Point(269, 4);
            this.label_FahrzeugeInWelt.Name = "label_FahrzeugeInWelt";
            this.label_FahrzeugeInWelt.Size = new System.Drawing.Size(57, 13);
            this.label_FahrzeugeInWelt.TabIndex = 6;
            this.label_FahrzeugeInWelt.Text = "Fahrzeuge";
            // 
            // FahrzeugeInWelt
            // 
            this.FahrzeugeInWelt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FahrzeugeInWelt.ForeColor = System.Drawing.SystemColors.Window;
            this.FahrzeugeInWelt.Location = new System.Drawing.Point(268, 20);
            this.FahrzeugeInWelt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FahrzeugeInWelt.Name = "FahrzeugeInWelt";
            this.FahrzeugeInWelt.Size = new System.Drawing.Size(120, 20);
            this.FahrzeugeInWelt.TabIndex = 7;
            this.FahrzeugeInWelt.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(577, 570);
            this.Controls.Add(this.Button_CheckCar);
            this.Controls.Add(this.label_GeparkteFahrzeuge);
            this.Controls.Add(this.label_UngeparkteFahrzeuge);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.Ungeparkte_Fahrzeuge);
            this.Controls.Add(this.Geparkte_Fahrzeuge);
            this.Controls.Add(this.Button_Verlassen);
            this.Controls.Add(this.Button_Befahren);
            this.Controls.Add(this.label_Auslastung);
            this.Controls.Add(this.Auslastung);
            this.Controls.Add(this.ProgressBar_Auslastung);
            this.Controls.Add(this.panel_Konfiguration);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Die Garage";
            ((System.ComponentModel.ISupportInitialize)(this.Decks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkplaetzePerDeck)).EndInit();
            this.panel_Konfiguration.ResumeLayout(false);
            this.panel_Konfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FahrzeugeInWelt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Decks;
        private System.Windows.Forms.NumericUpDown ParkplaetzePerDeck;
        private System.Windows.Forms.Label label_Decks;
        private System.Windows.Forms.Label label_ParkplaetzePerDeck;
        private System.Windows.Forms.Button Button_WeltGenerieren;
        private System.Windows.Forms.Panel panel_Konfiguration;
        private System.Windows.Forms.Label label_PlaetzeInsgesamt;
        private System.Windows.Forms.ProgressBar ProgressBar_Auslastung;
        private System.Windows.Forms.Label Auslastung;
        private System.Windows.Forms.Label label_Auslastung;
        private System.Windows.Forms.Button Button_Befahren;
        private System.Windows.Forms.Button Button_Verlassen;
        private System.Windows.Forms.ListBox Geparkte_Fahrzeuge;
        private System.Windows.Forms.ListBox Ungeparkte_Fahrzeuge;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Label label_UngeparkteFahrzeuge;
        private System.Windows.Forms.Label label_GeparkteFahrzeuge;
        private System.Windows.Forms.Button Button_CheckCar;
        private System.Windows.Forms.NumericUpDown FahrzeugeInWelt;
        private System.Windows.Forms.Label label_FahrzeugeInWelt;
    }
}

