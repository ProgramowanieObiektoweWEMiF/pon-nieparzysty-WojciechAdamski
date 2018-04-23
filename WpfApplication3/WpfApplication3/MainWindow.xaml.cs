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

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox8.Text = Convert.ToString(kasa);
        }



        int[,] id = new int[400, 400];
        string[] nazwa = new string[200];
        int i;
        int z;
        int zz;
        int x;
        int kasa = 100000;
        int nr = 1;
        double s;


        void update_texboxow ()
        {
            textBox2.Text = Convert.ToString(id[x, i]); // krzesla
            textBox1.Text = Convert.ToString(id[x, i + 1]); // sklepy
            textBox7.Text = Convert.ToString((id[x, i + 1] * 200) + (id[x, i] * 20)); // zysk
            textBox8.Text = Convert.ToString(kasa); // kasa
            textBox6.Text = nazwa[i]; // nazwa
            textBox3.Text = Convert.ToString(stadion.siedzenia_max);
            textBox4.Text = Convert.ToString(stadion.sklepy_max);
        }


        void wybor_tablicy()
        {
            i = listBox1.SelectedIndex * 2;
            x = listBox1.SelectedIndex;
        }





        private void button1_Click(object sender, RoutedEventArgs e) // tworzenie stadionu
        {
            if (kasa >= 10000)
            {
                x = zz;
                i = z;

                stadion stadion1 = new stadion(textBox5.Text, 10, 10);

                id[x, i] = stadion1.siedzenia_kupione;
                id[x, i + 1] = stadion1.sklepy_kupione;
                nazwa[i] = Convert.ToString(nr) + ". " + stadion1.nazwa_stadionu;

                listBox1.Items.Add(nazwa[i]);
                kasa = kasa - 10000;

                update_texboxow();

                nr++;
                x++;
                i++;
                i++;

                z = i;
                zz = x;
            }
            else
            {
                MessageBox.Show("Nie masz kasy");
            }

        }










        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e) //list box
        {
            wybor_tablicy();
            update_texboxow();
        }





        private void button6_Click(object sender, RoutedEventArgs e) // kup
        {

            int s2 = Convert.ToInt32(s);
            wybor_tablicy();



            if (kasa >= Convert.ToInt32(textBox11.Text))
            {
                
                if (radioButton1.IsChecked == true & stadion.sklepy_max >= id[x, i + 1] + s2)  // sklepy
                {
                    id[x, i+1] = id[x, i+1] + s2;
                    kasa = kasa - Convert.ToInt32(textBox11.Text);
                    update_texboxow();
                }

                if (radioButton2.IsChecked == true & stadion.siedzenia_max >= id[x, i] + s2)  // krzesla
                {
                    id[x, i] = id[x, i] + s2;
                    kasa = kasa - Convert.ToInt32(textBox11.Text);
                    update_texboxow();
                }
                


            }
            else
            {
                MessageBox.Show("Nie masz kasy.");
            }
        }








        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            s = Math.Round(slider1.Value);
            textBox10.Text = s.ToString();

            
            if (radioButton1.IsChecked == true)  {textBox11.Text = Convert.ToString(s * 2000);}
            if (radioButton2.IsChecked == true)  {textBox11.Text = Convert.ToString(s * 50);}


        }


        private void radioButton2_Click(object sender, RoutedEventArgs e)
        {
            textBox11.Text = Convert.ToString(s * 50);
        }


        private void radioButton1_Click(object sender, RoutedEventArgs e)
        {
            textBox11.Text = Convert.ToString(s * 2000);
        }









        private void button2_Click(object sender, RoutedEventArgs e) // tworzenie hotelu
        {
        }
        private void listBox1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {

        }





    }
}
