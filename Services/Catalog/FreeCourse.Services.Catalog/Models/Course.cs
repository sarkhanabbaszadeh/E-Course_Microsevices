using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourse.Services.Catalog.Models
{
	public class Course
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public int Id { get; set; }

        public int Name { get; set; }

		[BsonRepresentation(BsonType.Decimal128)]
		public decimal Price { get; set; }

        public string UserId { get; set; }

        public string Picture { get; set; }

		[BsonRepresentation(BsonType.DateTime)]
		public DateTime CreatedTime { get; set; }


    }
}
