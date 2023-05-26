using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursovaya2023;

namespace Kursovaya
{
    internal class MongoDB
    {
        public static void AddToDB(User user)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Dark_Star");
            var collection = database.GetCollection<User>("users");
            collection.InsertOne(user);

        }

        public static void FindAll()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Dark_Star");
            var collection = database.GetCollection<User>("users");
            var list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($" {item?.nickname} {item?.password} {item?.email}");
            }

        }

        public static void Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Dark_Star");
            var collection = database.GetCollection<User>("users");
            var one = collection.Find(x => x.nickname == name).FirstOrDefault();

            Console.WriteLine($" {one?.nickname} {one?.password} {one?.email}");


        }

        public static void ReplaceByName(string name, User user1)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Dark_Star");
            var collection = database.GetCollection<User>("users");
            collection.ReplaceOne(x => x.nickname == name, user1);
        }
    }
}
