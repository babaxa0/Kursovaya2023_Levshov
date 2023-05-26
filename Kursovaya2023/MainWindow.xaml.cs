using Microsoft.Win32;
using MongoDB.Bson;
using MongoDB.Driver;
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

namespace Kursovaya2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regist regist = new Regist();
            regist.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var nickname = tb1.Text;
            var password = tb2.Text;

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Dark_Star");

            var collection = database.GetCollection<User>("users");

            var filter = Builders<User>.Filter.Eq("nickname", nickname) & Builders<User>.Filter.Eq("password", password);
            var user = collection.Find(filter).FirstOrDefault();
            if(tb1.Text != "" && tb2.Text != "")
            {
                if (user == null)
                {
                    MessageLog messageLog = new MessageLog();
                    messageLog.Show();
                    return;
                }

                else
                {
                    Main main = new Main();
                    main.Show();
                    this.Close();
                }
            }
            else
            {
                AllMessage allMessage = new AllMessage();
                allMessage.Show();
            }
        }
    }
}
