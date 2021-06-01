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
            this.components = new System.ComponentModel.Container();
            this.Decks = new System.Windows.Forms.NumericUpDown();
            this.ParkplaetzePerDeck = new System.Windows.Forms.NumericUpDown();
            this.label_Decks = new System.Windows.Forms.Label();
            this.label_ParkplaetzePerDeck = new System.Windows.Forms.Label();
            this.Button_WeltGenerieren = new System.Windows.Forms.Button();
            this.panel_Konfiguration = new System.Windows.Forms.Panel();
            this.FahrzeugeInWelt = new System.Windows.Forms.NumericUpDown();
            this.label_FahrzeugeInWelt = new System.Windows.Forms.Label();
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
            this.label_arrow_left = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label_VergangeneZeit = new System.Windows.Forms.Label();
            this.Button_StartTime = new System.Windows.Forms.Button();
            this.Button_StopTime = new System.Windows.Forms.Button();
            this.TrackBar_Speed = new System.Windows.Forms.TrackBar();
            this.label_VergangeneZeitInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Decks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkplaetzePerDeck)).BeginInit();
            this.panel_Konfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FahrzeugeInWelt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // Decks
            // 
            this.Decks.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Decks.ForeColor = System.Drawing.SystemColors.Window;
            this.Decks.Location = new System.Drawing.Point(4, 20);
            this.Decks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.ParkplaetzePerDeck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.Button_WeltGenerieren.FlatAppearance.BorderSize = 0;
            this.Button_WeltGenerieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_WeltGenerieren.Location = new System.Drawing.Point(418, 11);
            this.Button_WeltGenerieren.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_WeltGenerieren.Name = "Button_WeltGenerieren";
            this.Button_WeltGenerieren.Size = new System.Drawing.Size(117, 35);
            this.Button_WeltGenerieren.TabIndex = 4;
            this.Button_WeltGenerieren.Text = "Welt Generieren";
            this.Button_WeltGenerieren.UseVisualStyleBackColor = false;
            this.Button_WeltGenerieren.Click += new System.EventHandler(this.Button_WeltGenerieren_Click);
            // 
            // panel_Konfiguration
            // 
            this.panel_Konfiguration.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Konfiguration.Controls.Add(this.FahrzeugeInWelt);
            this.panel_Konfiguration.Controls.Add(this.label_FahrzeugeInWelt);
            this.panel_Konfiguration.Controls.Add(this.label_PlaetzeInsgesamt);
            this.panel_Konfiguration.Controls.Add(this.Decks);
            this.panel_Konfiguration.Controls.Add(this.Button_WeltGenerieren);
            this.panel_Konfiguration.Controls.Add(this.label_Decks);
            this.panel_Konfiguration.Controls.Add(this.ParkplaetzePerDeck);
            this.panel_Konfiguration.Controls.Add(this.label_ParkplaetzePerDeck);
            this.panel_Konfiguration.Location = new System.Drawing.Point(12, 22);
            this.panel_Konfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Konfiguration.Name = "panel_Konfiguration";
            this.panel_Konfiguration.Size = new System.Drawing.Size(553, 60);
            this.panel_Konfiguration.TabIndex = 5;
            // 
            // FahrzeugeInWelt
            // 
            this.FahrzeugeInWelt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FahrzeugeInWelt.ForeColor = System.Drawing.SystemColors.Window;
            this.FahrzeugeInWelt.Location = new System.Drawing.Point(268, 20);
            this.FahrzeugeInWelt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            // label_FahrzeugeInWelt
            // 
            this.label_FahrzeugeInWelt.AutoSize = true;
            this.label_FahrzeugeInWelt.Location = new System.Drawing.Point(269, 4);
            this.label_FahrzeugeInWelt.Name = "label_FahrzeugeInWelt";
            this.label_FahrzeugeInWelt.Size = new System.Drawing.Size(57, 13);
            this.label_FahrzeugeInWelt.TabIndex = 6;
            this.label_FahrzeugeInWelt.Text = "Fahrzeuge";
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
            this.ProgressBar_Auslastung.Location = new System.Drawing.Point(15, 572);
            this.ProgressBar_Auslastung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProgressBar_Auslastung.Name = "ProgressBar_Auslastung";
            this.ProgressBar_Auslastung.Size = new System.Drawing.Size(547, 11);
            this.ProgressBar_Auslastung.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar_Auslastung.TabIndex = 7;
            // 
            // Auslastung
            // 
            this.Auslastung.AutoSize = true;
            this.Auslastung.Location = new System.Drawing.Point(25, 553);
            this.Auslastung.Name = "Auslastung";
            this.Auslastung.Size = new System.Drawing.Size(30, 13);
            this.Auslastung.TabIndex = 8;
            this.Auslastung.Text = "0 / 0";
            this.Auslastung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Auslastung
            // 
            this.label_Auslastung.AutoSize = true;
            this.label_Auslastung.Location = new System.Drawing.Point(13, 537);
            this.label_Auslastung.Name = "label_Auslastung";
            this.label_Auslastung.Size = new System.Drawing.Size(59, 13);
            this.label_Auslastung.TabIndex = 9;
            this.label_Auslastung.Text = "Auslastung";
            // 
            // Button_Befahren
            // 
            this.Button_Befahren.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button_Befahren.FlatAppearance.BorderSize = 0;
            this.Button_Befahren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Befahren.Location = new System.Drawing.Point(255, 118);
            this.Button_Befahren.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Befahren.Name = "Button_Befahren";
            this.Button_Befahren.Size = new System.Drawing.Size(75, 22);
            this.Button_Befahren.TabIndex = 10;
            this.Button_Befahren.Text = "BEFAHREN";
            this.Button_Befahren.UseVisualStyleBackColor = false;
            this.Button_Befahren.Click += new System.EventHandler(this.Button_Befahren_Click);
            // 
            // Button_Verlassen
            // 
            this.Button_Verlassen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button_Verlassen.FlatAppearance.BorderSize = 0;
            this.Button_Verlassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Verlassen.Location = new System.Drawing.Point(244, 450);
            this.Button_Verlassen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Verlassen.Name = "Button_Verlassen";
            this.Button_Verlassen.Size = new System.Drawing.Size(86, 22);
            this.Button_Verlassen.TabIndex = 11;
            this.Button_Verlassen.Text = "VERLASSEN";
            this.Button_Verlassen.UseVisualStyleBackColor = false;
            this.Button_Verlassen.Click += new System.EventHandler(this.Button_Verlassen_Click);
            // 
            // Geparkte_Fahrzeuge
            // 
            this.Geparkte_Fahrzeuge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Geparkte_Fahrzeuge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Geparkte_Fahrzeuge.ForeColor = System.Drawing.SystemColors.Window;
            this.Geparkte_Fahrzeuge.FormattingEnabled = true;
            this.Geparkte_Fahrzeuge.Location = new System.Drawing.Point(15, 118);
            this.Geparkte_Fahrzeuge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Geparkte_Fahrzeuge.Name = "Geparkte_Fahrzeuge";
            this.Geparkte_Fahrzeuge.Size = new System.Drawing.Size(161, 351);
            this.Geparkte_Fahrzeuge.TabIndex = 12;
            // 
            // Ungeparkte_Fahrzeuge
            // 
            this.Ungeparkte_Fahrzeuge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Ungeparkte_Fahrzeuge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ungeparkte_Fahrzeuge.ForeColor = System.Drawing.SystemColors.Window;
            this.Ungeparkte_Fahrzeuge.FormattingEnabled = true;
            this.Ungeparkte_Fahrzeuge.Location = new System.Drawing.Point(401, 118);
            this.Ungeparkte_Fahrzeuge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ungeparkte_Fahrzeuge.Name = "Ungeparkte_Fahrzeuge";
            this.Ungeparkte_Fahrzeuge.Size = new System.Drawing.Size(161, 351);
            this.Ungeparkte_Fahrzeuge.TabIndex = 13;
            // 
            // label_Info
            // 
            this.label_Info.Location = new System.Drawing.Point(187, 168);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(208, 102);
            this.label_Info.TabIndex = 14;
            // 
            // label_UngeparkteFahrzeuge
            // 
            this.label_UngeparkteFahrzeuge.AutoSize = true;
            this.label_UngeparkteFahrzeuge.Location = new System.Drawing.Point(425, 100);
            this.label_UngeparkteFahrzeuge.Name = "label_UngeparkteFahrzeuge";
            this.label_UngeparkteFahrzeuge.Size = new System.Drawing.Size(116, 13);
            this.label_UngeparkteFahrzeuge.TabIndex = 15;
            this.label_UngeparkteFahrzeuge.Text = "Ungeparkte Fahrzeuge";
            // 
            // label_GeparkteFahrzeuge
            // 
            this.label_GeparkteFahrzeuge.AutoSize = true;
            this.label_GeparkteFahrzeuge.Location = new System.Drawing.Point(38, 100);
            this.label_GeparkteFahrzeuge.Name = "label_GeparkteFahrzeuge";
            this.label_GeparkteFahrzeuge.Size = new System.Drawing.Size(104, 13);
            this.label_GeparkteFahrzeuge.TabIndex = 16;
            this.label_GeparkteFahrzeuge.Text = "Geparkte Fahrzeuge";
            // 
            // Button_CheckCar
            // 
            this.Button_CheckCar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button_CheckCar.FlatAppearance.BorderSize = 0;
            this.Button_CheckCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CheckCar.Location = new System.Drawing.Point(235, 274);
            this.Button_CheckCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_CheckCar.Name = "Button_CheckCar";
            this.Button_CheckCar.Size = new System.Drawing.Size(117, 40);
            this.Button_CheckCar.TabIndex = 17;
            this.Button_CheckCar.Text = "Wo ist das Fahrzeug?";
            this.Button_CheckCar.UseVisualStyleBackColor = false;
            this.Button_CheckCar.Click += new System.EventHandler(this.Button_CheckCar_Click);
            // 
            // label_arrow_left
            // 
            this.label_arrow_left.AutoSize = true;
            this.label_arrow_left.Location = new System.Drawing.Point(198, 144);
            this.label_arrow_left.Name = "label_arrow_left";
            this.label_arrow_left.Size = new System.Drawing.Size(133, 13);
            this.label_arrow_left.TabIndex = 18;
            this.label_arrow_left.Text = "<-<-<-<-<-<-------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "--------------------------->->->->->";
            // 
            // Button_Exit
            // 
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_Exit.ForeColor = System.Drawing.Color.Black;
            this.Button_Exit.Location = new System.Drawing.Point(558, 2);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(17, 17);
            this.Button_Exit.TabIndex = 20;
            this.Button_Exit.Text = "X";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label_VergangeneZeit
            // 
            this.label_VergangeneZeit.AutoSize = true;
            this.label_VergangeneZeit.Location = new System.Drawing.Point(265, 502);
            this.label_VergangeneZeit.Name = "label_VergangeneZeit";
            this.label_VergangeneZeit.Size = new System.Drawing.Size(49, 13);
            this.label_VergangeneZeit.TabIndex = 21;
            this.label_VergangeneZeit.Text = "00:00:00";
            this.label_VergangeneZeit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_StartTime
            // 
            this.Button_StartTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button_StartTime.FlatAppearance.BorderSize = 0;
            this.Button_StartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_StartTime.Location = new System.Drawing.Point(101, 492);
            this.Button_StartTime.Name = "Button_StartTime";
            this.Button_StartTime.Size = new System.Drawing.Size(75, 23);
            this.Button_StartTime.TabIndex = 22;
            this.Button_StartTime.Text = "START";
            this.Button_StartTime.UseVisualStyleBackColor = false;
            this.Button_StartTime.Click += new System.EventHandler(this.Button_StartTime_Click);
            // 
            // Button_StopTime
            // 
            this.Button_StopTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Button_StopTime.FlatAppearance.BorderSize = 0;
            this.Button_StopTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_StopTime.Location = new System.Drawing.Point(401, 492);
            this.Button_StopTime.Name = "Button_StopTime";
            this.Button_StopTime.Size = new System.Drawing.Size(75, 23);
            this.Button_StopTime.TabIndex = 23;
            this.Button_StopTime.Text = "STOP";
            this.Button_StopTime.UseVisualStyleBackColor = false;
            this.Button_StopTime.Click += new System.EventHandler(this.Button_StopTime_Click);
            // 
            // TrackBar_Speed
            // 
            this.TrackBar_Speed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TrackBar_Speed.Location = new System.Drawing.Point(187, 520);
            this.TrackBar_Speed.Maximum = 100;
            this.TrackBar_Speed.Minimum = 1;
            this.TrackBar_Speed.Name = "TrackBar_Speed";
            this.TrackBar_Speed.Size = new System.Drawing.Size(213, 45);
            this.TrackBar_Speed.TabIndex = 24;
            this.TrackBar_Speed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar_Speed.Value = 1;
            this.TrackBar_Speed.Scroll += new System.EventHandler(this.TrackBar_Speed_Scroll);
            // 
            // label_VergangeneZeitInfo
            // 
            this.label_VergangeneZeitInfo.AutoSize = true;
            this.label_VergangeneZeitInfo.Location = new System.Drawing.Point(248, 484);
            this.label_VergangeneZeitInfo.Name = "label_VergangeneZeitInfo";
            this.label_VergangeneZeitInfo.Size = new System.Drawing.Size(86, 13);
            this.label_VergangeneZeitInfo.TabIndex = 25;
            this.label_VergangeneZeitInfo.Text = "Vergangene Zeit";
            this.label_VergangeneZeitInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(577, 596);
            this.Controls.Add(this.label_VergangeneZeitInfo);
            this.Controls.Add(this.TrackBar_Speed);
            this.Controls.Add(this.Button_StopTime);
            this.Controls.Add(this.Button_StartTime);
            this.Controls.Add(this.label_VergangeneZeit);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_arrow_left);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Die Garage";
            ((System.ComponentModel.ISupportInitialize)(this.Decks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParkplaetzePerDeck)).EndInit();
            this.panel_Konfiguration.ResumeLayout(false);
            this.panel_Konfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FahrzeugeInWelt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Speed)).EndInit();
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
        private System.Windows.Forms.Label label_arrow_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label_VergangeneZeit;
        private System.Windows.Forms.Button Button_StartTime;
        private System.Windows.Forms.Button Button_StopTime;
        private System.Windows.Forms.TrackBar TrackBar_Speed;
        private System.Windows.Forms.Label label_VergangeneZeitInfo;
    }
}

