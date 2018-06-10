using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimCity2000
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox_kasa.Text = Convert.ToString(kasa);
        }


        int kasa = 10000000;
        int[, ,] id = new int[400, 400, 400];
        string[,] nazwa = new string[200, 200];
        int[,] xyz = new int[400, 400];
        int[] bufor = new int[400];
        double s;


        void update_texboxow()
        {
            if (xyz[1, 3] == 1)
            {
                textBox_element2.Text = Convert.ToString(id[xyz[1, 1], xyz[1, 2], xyz[1, 3]]); // krzesla
                textBox_element1.Text = Convert.ToString(id[xyz[1, 1], xyz[1, 2] + 1, xyz[1, 3]]); // sklepy
                textBox_zysk.Text = Convert.ToString((id[xyz[1, 1], xyz[1, 2] + 1, xyz[1, 3]] * 200) + (id[xyz[1, 2], xyz[1, 2], xyz[1, 3]] * 20)); // zysk
                textBox_kasa.Text = Convert.ToString(kasa); // kasa
                textBox_nazwa_w.Text = nazwa[xyz[1, 2], xyz[1, 3]]; // nazwa
                textBox_element1max.Text = Convert.ToString(stadion.element1_max);
                textBox_element2max.Text = Convert.ToString(stadion.element2_max);
            }
            if (xyz[1, 3] == 2)
            {
                textBox_element2.Text = Convert.ToString(id[xyz[2, 1], xyz[2, 2], xyz[1, 3]]); // krzesla
                textBox_element1.Text = Convert.ToString(id[xyz[2, 1], xyz[2, 2] + 1, xyz[1, 3]]); // sklepy
                textBox_zysk.Text = Convert.ToString((id[xyz[2, 1], xyz[2, 2] + 1, xyz[1, 3]] * 200) + (id[xyz[2, 1], xyz[2, 2], xyz[1, 3]] * 20)); // zysk
                textBox_kasa.Text = Convert.ToString(kasa); // kasa
                textBox_nazwa_w.Text = nazwa[xyz[2, 2], xyz[1, 3]]; // nazwa
                textBox_element1max.Text = Convert.ToString(stadion.element1_max);
                textBox_element2max.Text = Convert.ToString(stadion.element2_max);
            }

        }


        void wybor_tablicy()
        {
            xyz[1, 2] = listBox_stadiony.SelectedIndex * 2;
            xyz[1, 1] = listBox_stadiony.SelectedIndex;
            xyz[2, 2] = listBox_hotele.SelectedIndex * 2;
            xyz[2, 1] = listBox_hotele.SelectedIndex;
        }



        private void button_hotele_Click(object sender, RoutedEventArgs e)
        {
            {
                xyz[1, 3] = 2;


                if (kasa >= 10000)
                {

                    hotel hotel1 = new hotel(textBox_nazwa.Text, 0, 0);



                    xyz[2, 1] = bufor[3];
                    xyz[2, 2] = bufor[4];


                    id[xyz[2, 1], xyz[2, 2], xyz[1, 3]] = hotel1.pokoje_kupione;
                    id[xyz[2, 1], xyz[2, 2] + 1, xyz[1, 3]] = hotel1.parkingi_kupione;
                    nazwa[xyz[2, 2], xyz[1, 3]] = "Hotel: " + hotel1.nazwa;

                    listBox_hotele.Items.Add(nazwa[xyz[2, 2], xyz[1, 3]]);
                    kasa = kasa - 10000;

                    update_texboxow();


                    xyz[2, 1]++;
                    xyz[2, 2]++;
                    xyz[2, 2]++;


                    bufor[4] = xyz[2, 2];
                    bufor[3] = xyz[2, 1];

                }
                else
                {
                    MessageBox.Show("Nie masz kasy");
                }

            }
        }



        private void button_stadiony_Click(object sender, RoutedEventArgs e)
        {
            xyz[1, 3] = 1;


            if (kasa >= 10000)
            {

                stadion stadion1 = new stadion(textBox_nazwa.Text, 0, 0);



                xyz[1, 1] = bufor[1];
                xyz[1, 2] = bufor[2];


                id[xyz[1, 1], xyz[1, 2], xyz[1, 3]] = stadion1.siedzenia_kupione;
                id[xyz[1, 1], xyz[1, 2] + 1, xyz[1, 3]] = stadion1.sklepy_kupione;
                nazwa[xyz[1, 2], xyz[1, 3]] = "Stadion: " + stadion1.nazwa;

                listBox_stadiony.Items.Add(nazwa[xyz[1, 2], xyz[1, 3]]);
                kasa = kasa - 10000;

                update_texboxow();


                xyz[1, 1]++;
                xyz[1, 2]++;
                xyz[1, 2]++;


                bufor[2] = xyz[1, 2];
                bufor[1] = xyz[1, 1];

            }
            else
            {
                MessageBox.Show("Nie masz kasy");
            }
        }





        private void button_centra_Click(object sender, RoutedEventArgs e)
        {

        }







        private void button_kup_Click(object sender, RoutedEventArgs e)
        {
            int s2 = Convert.ToInt32(s);
            wybor_tablicy();



            if (kasa >= Convert.ToInt32(textBox_kup_cena.Text))
            {

                if (xyz[1, 3] == 1)
                {

                    if (radioButton_element1.IsChecked == true & stadion.element1_max >= id[xyz[1, 1], xyz[1, 2] + 1, xyz[1, 3]] + s2)  // sklepy
                    {
                        id[xyz[1, 1], xyz[1, 2] + 1, xyz[1, 3]] = id[xyz[1, 1], xyz[1, 2] + 1, xyz[1, 3]] + s2;
                        kasa = kasa - Convert.ToInt32(textBox_kup_cena.Text);
                        update_texboxow();
                    }

                    if (radioButton_element2.IsChecked == true & stadion.element2_max >= id[xyz[1, 1], xyz[1, 2], xyz[1, 3]] + s2)  // krzesla
                    {
                        id[xyz[1, 1], xyz[1, 2], xyz[1, 3]] = id[xyz[1, 1], xyz[1, 2], xyz[1, 3]] + s2;
                        kasa = kasa - Convert.ToInt32(textBox_kup_cena.Text);
                        update_texboxow();
                    }
                }


                if (xyz[1, 3] == 2)
                {


                    if (radioButton_element1.IsChecked == true & hotel.element1_max >= id[xyz[2, 1], xyz[2, 2] + 1, xyz[1, 3]] + s2)  // sklepy
                    {
                        id[xyz[2, 1], xyz[2, 2] + 1, xyz[1, 3]] = id[xyz[2, 1], xyz[2, 2] + 1, xyz[1, 3]] + s2;
                        kasa = kasa - Convert.ToInt32(textBox_kup_cena.Text);
                        update_texboxow();
                    }

                    if (radioButton_element2.IsChecked == true & hotel.element2_max >= id[xyz[2, 1], xyz[2, 2], xyz[1, 3]] + s2)  // krzesla
                    {
                        id[xyz[2, 1], xyz[2, 2], xyz[1, 3]] = id[xyz[2, 1], xyz[2, 2], xyz[1, 3]] + s2;
                        kasa = kasa - Convert.ToInt32(textBox_kup_cena.Text);
                        update_texboxow();
                    }

                }

            }
            else
            {
                MessageBox.Show("Nie masz kasy.");
            }
        }



        private void slider_kup_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            s = Math.Round(slider_kup.Value);
            textBox_kup_ilosc.Text = s.ToString();


            if (radioButton_element1.IsChecked == true) { textBox_kup_cena.Text = Convert.ToString(s * 2000); }
            if (radioButton_element2.IsChecked == true) { textBox_kup_cena.Text = Convert.ToString(s * 50); }


        }

        private void radioButton_element1_Click(object sender, RoutedEventArgs e)
        {
            textBox_kup_cena.Text = Convert.ToString(s * 2000);
        }

        private void radioButton_element2_Click(object sender, RoutedEventArgs e)
        {
            textBox_kup_cena.Text = Convert.ToString(s * 50);
        }

        private void listBox_hotele_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            xyz[1, 3] = 2;
            wybor_tablicy();
            update_texboxow();
            textBox_element1w.Text = "Pokoje";
            textBox_element2w.Text = "Parking";
            textBox_element1rb.Text = "Pokoje";
            textBox_element2rb.Text = "Parking";
        }

        private void listBox_stadiony_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            xyz[1, 3] = 1;
            wybor_tablicy();
            update_texboxow();
            textBox_element1w.Text = "Sklep";
            textBox_element2w.Text = "Siedzenia";
            textBox_element1rb.Text = "Sklep";
            textBox_element2rb.Text = "Siedzenia";
        }
    }
}
