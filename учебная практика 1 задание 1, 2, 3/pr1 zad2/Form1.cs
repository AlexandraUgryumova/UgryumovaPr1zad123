﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1_zad2
{
    public partial class Form1 :Form
    {
        Shop monetka = new Shop();
        Product cola = new Product("Кола", 85);
        Product juice = new Product("Сок \"Добрый\"", 100);
        List<string> products = new List<string>();
        Product product;

        Playlist playlist;
        public Form1 ()
        {
            InitializeComponent();
            comboBox1.Items.Add("Кола");
            comboBox1.Items.Add("Сок \"Добрый\"");

            playlist = new Playlist();
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            listBox1.Items.Add(cola.GetInfo());
            listBox1.Items.Add(juice.GetInfo());
            monetka.AddProduct(cola, 9000);
            monetka.AddProduct(juice, 9000);
            monetka.WriteAllProducts(listBox1);
        }
        public bool checkSym (string text)
        {
            foreach (var ch in text)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Введи число");
                    return false;
                }
            }
            if (Convert.ToInt32(text) <= 0)
            {
                MessageBox.Show("Введи положительное число");
                return false;
            }
            return true;
        }

        private void button2_Click (object sender, EventArgs e)
        {
            if (checkSym(kol1_txt.Text) && checkSym(sale_txt.Text))
            {
                product = new Product(name_txt.Text, Convert.ToInt32(sale_txt.Text));
                products.Add(name_txt.Text);
                comboBox1.Items.Add(name_txt.Text);
                monetka.AddProduct(product, Convert.ToInt32(kol1_txt.Text));
                monetka.WriteAllProducts(listBox1);
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            int amount = 0;
            name_txt.Text = "";
            switch (comboBox1.Text)
            {
                case "Кола":
                    amount = 9000;
                    break;
                case "Сок \"Добрый\"":
                    amount = 9000;
                    break;
                case "":
                    amount = Convert.ToInt32(kol1_txt.Text);
                    break;
            }
            if (comboBox1.Text != "")
            {
                if (kol2_txt.Text != "")
                {
                    if (checkSym(kol2_txt.Text))
                    {
                        bool amountt = monetka.amountReturn();
                        if (amountt)
                        {
                            prib_lbl.Text = $"{int.Parse(prib_lbl.Text) + (product.Price * int.Parse(kol2_txt.Text))}";
                            amount -= int.Parse(kol2_txt.Text);
                        }
                        monetka.Sell(comboBox1.Text, int.Parse(kol2_txt.Text));
                        monetka.WriteAllProducts(listBox1);
                    }
                } 
                else
                    MessageBox.Show("Введи количество");
            } 
            else
                MessageBox.Show("Выбери товар");
        }

        private void listBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
        }

        private void button3_Click (object sender, EventArgs e)
        {
        }

        private void button3_Click_1 (object sender, EventArgs e)
        {
            playlist.currentIndex = 0;
            UpdateCurrentSongDisplay();
        }

        private void Back_btn_Click (object sender, EventArgs e)
        {
            playlist.Back();
            UpdateCurrentSongDisplay();
        }
        private void UpdateCurrentSongDisplay ()
        {
            Song currentSong = playlist.CurrentSong();
            label12.Text = currentSong.ToString();

            checkEnabled();
        }

        private void checkEnabled()
        {
            ClearPlaylist_btn.Enabled = playlist.list.Count > 1;
            StartPlaylist_btn.Enabled = playlist.list.Count > 1;
            Back_btn.Enabled = playlist.list.Count > 1;
            Next_btn.Enabled = playlist.list.Count > 1;
            DeleteSong_btn.Enabled = playlist.list.Count > 1;
        }

        private void Next_btn_Click (object sender, EventArgs e)
        {
            playlist.Next();
            UpdateCurrentSongDisplay();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void ClearPlaylist_btn_Click(object sender, EventArgs e)
        {
            playlist.Clear();
            listBox2.Items.Clear();
            MessageBox.Show("Плейлист успешно очищен!", "Сообщение");
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string author = textBox1.Text;
            string title = textBox2.Text;
            string filename = textBox3.Text;
            Song song = new Song(author, title, filename);
            playlist.Add(song);
            listBox2.Items.Add(song.ToString());

            MessageBox.Show("Песня успешно добавлена в плейлист!");
            checkEnabled();
        }

        private void DeleteSong_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listBox2.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < playlist.list.Count)
                {
                    playlist.list.RemoveAt(selectedIndex);
                    listBox2.Items.RemoveAt(selectedIndex);
                    UpdateCurrentSongDisplay();
                }
            }
            catch
            {
                MessageBox.Show("Песня успешно удалена из плейлиста!");
            }
        }
    }
}
