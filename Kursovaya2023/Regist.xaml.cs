using Kursovaya2023;
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
using System.Windows.Shapes;
using MongoDB.Bson.Serialization;
using System.Text.RegularExpressions;

namespace Kursovaya2023
{
    /// <summary>
    /// Логика взаимодействия для Regist.xaml
    /// </summary>
    public partial class Regist : Window
    {
        public Regist()
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
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var nickname = tb1.Text;
            var email = tb2.Text;
            var password = tb3.Text;
            var reppas = tb4.Text;

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Dark_Star");
            var collection = database.GetCollection<BsonDocument>("users");
            string input = tb2.Text;
            bool containsAtSymbol = input.Contains("@");


            if (tb1.Text != "" && tb2.Text != "" && tb3.Text != "" && tb4.Text != "")
            {
                var filter = Builders<BsonDocument>.Filter.Eq("nickname", nickname);
                var existingNickname = collection.Find(filter).FirstOrDefault();
                if (existingNickname != null)
                {
                    tb1.BorderBrush = new SolidColorBrush(Colors.Red);
                    MessageNick messageNick = new MessageNick();
                    messageNick.Show();
                }
                else
                {
                    tb1.BorderBrush = new SolidColorBrush(Colors.LimeGreen);
                    if (containsAtSymbol)
                    {
                        var filter1 = Builders<BsonDocument>.Filter.Eq("email", email);
                        var existingEmail = collection.Find(filter1).FirstOrDefault();
                        if (existingEmail != null)
                        {
                            tb2.BorderBrush = new SolidColorBrush(Colors.Red);
                            MessageEmail messageEmail = new MessageEmail();
                            messageEmail.Show();
                        }
                        else
                        {
                            tb2.BorderBrush = new SolidColorBrush(Colors.LimeGreen);
                            if (tb3.Text != tb4.Text)
                            {
                                tb3.BorderBrush = new SolidColorBrush(Colors.Red);
                                tb4.BorderBrush = new SolidColorBrush(Colors.Red);
                                MessagePass messagePass = new MessagePass();
                                messagePass.Show();
                            }
                            else
                            {
                                var user = new BsonDocument
                                {
                                    { "nickname", nickname },
                                    { "password", password },
                                    { "email", email }
                                };
                                collection.InsertOne(user);
                                MainWindow mainWindow = new MainWindow();
                                mainWindow.Show();
                                this.Close();
                            }
                            
                        }
                    }
                    else
                    {
                        tb2.BorderBrush = new SolidColorBrush(Colors.Red);
                        EmailMessage emailMessage = new EmailMessage();
                        emailMessage.Show();
                    }
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
