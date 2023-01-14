using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AWS.API.Gateway.Example.DynamoDB
{
    [DynamoDBTable("persons")]
    public class Person
    {
        [DynamoDBHashKey("id"), JsonPropertyName("id")]
        public int? Id { get; set; }
        [DynamoDBProperty("name"), JsonPropertyName("name")]
        public string? Name { get; set; }
        [DynamoDBProperty("surname"), JsonPropertyName("surname")]
        public string? Surname { get; set; }
    }
}
