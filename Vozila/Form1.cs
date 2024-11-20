﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vozila
{
    public partial class Form1 : Form
    {

        private List<Vozila> listaVozila = new List<Vozila>();
        public Form1()
        {
            InitializeComponent();
            // Dodaj opcije za sortiranje direktno u ComboBox
            comboBox1.Items.AddRange(new string[] { "Marka", "Model", "Godina proizvodnje", "Kilometraža" });

            // Postavi podrazumevani izbor
            comboBox1.SelectedIndex = 0;

            

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarka.Text) || string.IsNullOrWhiteSpace(txtModel.Text) || !int.TryParse(txtGodinaProizvodnje.Text, out int godinaProizvodnje) || !int.TryParse(txtKilometraza.Text, out int kilometraza))
            {
                MessageBox.Show("Unesite ispravne podatke za vozilo!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kreiraj novo vozilo
            Vozila novoVozilo = new Vozila(
                txtMarka.Text,
                txtModel.Text,
                godinaProizvodnje,
                kilometraza
            );

            // Dodaj u listu
            listaVozila.Add(novoVozilo);

            // Prikaz u ListBox-u
            listbox.Items.Add(novoVozilo);

            // Očisti polja
            txtMarka.Clear();
            txtModel.Clear();
            txtGodinaProizvodnje.Clear();
            txtKilometraza.Clear();
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {

            var opcija = comboBox1.SelectedItem.ToString();
            IOrderedEnumerable<Vozila> sortiranaVozila = null;

            // Sortiranje prema odabranoj opciji
            switch (opcija)
            {
                case "Marka":
                    sortiranaVozila = listaVozila.OrderBy(v => v.Marka); // Sortiraj po marki uzlazno
                    break;

                case "Model":
                    sortiranaVozila = listaVozila.OrderBy(v => v.Model); // Sortiraj po modelu uzlazno
                    break;

                case "Godina proizvodnje":
                    sortiranaVozila = listaVozila.OrderBy(v => v.GodinaProizvodnje); // Sortiraj po godini proizvodnje uzlazno
                    break;

                case "Kilometraža":
                    sortiranaVozila = listaVozila.OrderBy(v => v.Kilometraza); // Sortiraj po kilometraži uzlazno
                    break;

                default:
                    MessageBox.Show("Nepoznata opcija za sortiranje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            // Prikaz sortirane liste u TextBox-u
            txtSortirano.Clear();
            foreach (var vozilo in sortiranaVozila)
            {
                txtSortirano.AppendText(vozilo.ToString() + Environment.NewLine);
            }

        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listbox.SelectedItem != null)
            {
                Vozila voziloZaBrisanje = (Vozila)listbox.SelectedItem;
                listaVozila.Remove(voziloZaBrisanje); // Uklanja vozilo iz liste vozila
                listbox.Items.Remove(voziloZaBrisanje); // Uklanja vozilo iz ListBox-a
            }
            else
            {
                MessageBox.Show("Nema odabranog vozila za brisanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
