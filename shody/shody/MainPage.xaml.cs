using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace shody
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public player _player;
        public maps _maps;
        public int postacx = 20;
        public int postacy = 100;
        public int exp = 0;

        public void engine(int pozycjax, int pozycjay)
        {
            rtbtext.Text = pozycjax.ToString() + ' ' + pozycjay.ToString();
            if (pozycjax == 250 && pozycjay == 120)
            {
                rtbtext.Text = "Dotarles do zamku";

                exp += 10;

                lblexp.Text = exp.ToString();
            }

            if (pozycjax == 20 && pozycjay == 320)
            {
                rtbtext.Text = "Dotarles do kopalni";
            }
        }
        public MainPage()
        {
            this.InitializeComponent();
            rtbtext.Text = "Witaj w Rusty Old";
            _player = new player(0, 0, 0);

            _player.Inventory.Add(new InventoryItem("Text"));
            _maps = new maps();
            //  rtbworld.Visible = false;
            // dgvworld.SendToBack();
            int ilo = 0;


            foreach (wlr wlrs in _maps.Wlrs)
            {
                ilo++;
                if (wlrs.Obiekt == " ")
                {
                    var lab = new TextBlock
                    {

                        Name = "textblock" + ilo,
                        Size = new Size(20, 15),
                        ForeColor = Color.White,
                        BackColor = Color.Brown,
                        Location = new Point(wlrs.Pozycjax, wlrs.Pozycjay),

                        Text = wlrs.Obiekt,


                    };
                
                }
                else if (wlrs.Obiekt == "#")
                {

                    var lab = new TextBlock
                    {

                        Name = "textblock" + ilo,
                        Size = new Size(20, 15),
                        ForeColor = Color.White,
                        BackColor = Color.Black,
                        Location = new Point(wlrs.Pozycjax, wlrs.Pozycjay),

                        Text = wlrs.Obiekt,


                    };

                    
                }
                else if (wlrs.Obiekt == "$")
                {

                    var lab = new TextBlock
                    {

                        Name = "textblock" + ilo,
                        Size = new Size(20, 15),
                        ForeColor = Color.White,
                        BackColor = Color.Yellow,
                        Location = new Point(wlrs.Pozycjax, wlrs.Pozycjay),

                        Text = wlrs.Obiekt,


                    };

                   
                }
                else
                {

                    var lab = new TextBlock
                    {

                        Name = "textblock" + ilo, 
                        FontSize = new Size(20, 15),
                        Foreground = White,
                        Background = Color.DarkOliveGreen,
                        Location = new Point(wlrs.Pozycjax, wlrs.Pozycjay),

                        Text = wlrs.Obiekt,


                    };

                    
                }


                //   dgvworld. = wlrs.Obiekt.ToString();
                //lab.BringToFront();

                //    rtbtext.Text = ilo.ToString() + '-' + wlrs.Pozycjax.ToString() + '-' + wlrs.Pozycjay.ToString();
            }
            lblexp.Text = _player.Exp.ToString();
            lblGold.Text = _player.Gold.ToString();
            lbllevel.Text = _player.Level.ToString();
        }

        private void btngora_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnlewo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btndol_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnprawo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rtbtext_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void rtbtext1_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
