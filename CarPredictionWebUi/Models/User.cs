﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarPredictionWebUi.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}