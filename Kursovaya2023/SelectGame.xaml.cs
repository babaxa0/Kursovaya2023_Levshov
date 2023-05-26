using Kursovaya;
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
using System.Windows.Shapes;

namespace Kursovaya2023
{
    /// <summary>
    /// Логика взаимодействия для SelectGame.xaml
    /// </summary>
    public partial class SelectGame : Window
    {
        public SelectGame()
        {
            InitializeComponent();
        }
        private void ExitButt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinButt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectGame selectGame = new SelectGame();
            selectGame.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DOTA dOTA = new DOTA();
            dOTA.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CS cS = new CS();
            cS.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DIABLO dIABLO = new DIABLO();
            dIABLO.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            LOL lOL = new LOL();
            lOL.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            WARZONE wARZONE = new WARZONE();
            wARZONE.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            SelectGame selectGame = new SelectGame();
            selectGame.Show();
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            DOTA dOTA = new DOTA();
            dOTA.Show();
            this.Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            DOTA dOTA = new DOTA();
            dOTA.Show();
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            CS cS = new CS();
            cS.Show();
            this.Close();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            DIABLO dIABLO = new DIABLO();
            dIABLO.Show();
            this.Close();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            LOL lOL = new LOL();
            lOL.Show();
            this.Close();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            WARZONE wARZONE = new WARZONE();
            wARZONE.Show();
            this.Close();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            CS cS = new CS();
            cS.Show();
            this.Close();
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            WARZONE wARZONE = new WARZONE();
            wARZONE.Show();
            this.Close();
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            LOL lOL = new LOL();
            lOL.Show();
            this.Close();
        }

        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            DIABLO dIABLO = new DIABLO();
            dIABLO.Show();
            this.Close();
        }
    }
}
