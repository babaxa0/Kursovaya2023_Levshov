using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Kursovaya2023
{
    internal class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
