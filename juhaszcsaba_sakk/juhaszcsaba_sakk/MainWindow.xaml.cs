using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace juhaszcsaba_sakk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rectangle[,] mezok;

        public MainWindow()
        {
            InitializeComponent();
            FeluletLetrehozas();
        }

        private void FeluletLetrehozas()
        {
            for (int i = 0; i < 8; i++)
            {
                tabla.RowDefinitions.Add(new RowDefinition());
                tabla.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Rectangle uj = new Rectangle();
                    uj.Stroke = Brushes.Black;
                    if ((i+j) % 2 == 0)
                    {
                        uj.Fill = Brushes.White;
                    }
                    else
                    {
                        uj.Fill = Brushes.Black;
                    }
                    uj.MouseUp += Kattintas;
                    mezok[i, j] = uj;
                    tabla.Children.Add(mezok[i, j]);
                    Grid.SetRow(mezok[i, j], i);
                    Grid.SetColumn(mezok[i, j], j);

                }
            }
        }

        private void Kattintas(object sender, MouseButtonEventArgs e)
        {
            Rectangle kijelolt = sender as Rectangle;
            int x, y;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8 j++)
                {
                    if (mezok[i, j].Equals(kijelolt))
                    {
                       x = i;
                        y = j;
                    }
                }
            }
        }

    }
}
