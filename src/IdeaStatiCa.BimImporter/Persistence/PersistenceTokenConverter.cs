﻿using IdeaStatiCa.BimApi;
using IdeaStatiCa.Plugin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace IdeaStatiCa.BimImporter.Persistence
{
	/// <summary>
	/// A converter for serialization and deserialization of <see cref="IIdeaPersistenceToken"/> objects.
	/// </summary>
	internal class PersistenceTokenConverter : JsonConverter
	{
		private const string DataName = "$data";
		private const string TypeName = "$type";
		private JsonSerializer jsonSerializer;

		private JsonSerializer GetJsonSerializer()
		{
			return jsonSerializer ??
					(
						jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings
						{
							TypeNameHandling = TypeNameHandling.All,
						}
					)
				);
		}

		public override bool CanConvert(Type objectType)
		{
			return typeof(IIdeaPersistenceToken).IsAssignableFrom(objectType);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			// load the json object
			JObject obj = JObject.Load(reader);

			// get the value of the "$type" property
			string typeStr = obj.GetValue(TypeName).Value<string>();

			// get the type
			Type type = Type.GetType(typeStr);

			// check that the type was successfully created from the loaded json object
			if (type is null)
			{
				throw new InvalidOperationException($"Type name '{typeStr}' loaded from json could not be converted to a type.");
			}

			// get the object "$data" in the type of "$type"
			return obj.GetValue(DataName).ToObject(type, GetJsonSerializer());
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteStartObject();

			writer.WritePropertyName(TypeName);
			writer.WriteValue(value.GetType().AssemblyQualifiedName);

			writer.WritePropertyName(DataName);
			JObject.FromObject(value, GetJsonSerializer()).WriteTo(
				writer, new JsonConverter[] { this });

			writer.WriteEndObject();
		}
	}
}