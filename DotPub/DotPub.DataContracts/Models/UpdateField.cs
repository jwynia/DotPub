/*
 * GoToSocial Swagger documentation.
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: REPLACE_ME
 * Contact: admin@gotosocial.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace DotPub.DataContracts.Models
{
	/// <summary>
	/// By default, max 4 fields and 255 characters per property/value.
	/// </summary>
	[DataContract]
	public partial class UpdateField : IEquatable<UpdateField>
	{
		/// <summary>
		/// Name of the field
		/// </summary>
		/// <value>Name of the field</value>

		[DataMember(Name = "name")]
		public string Name { get; set; }

		/// <summary>
		/// Value of the field
		/// </summary>
		/// <value>Value of the field</value>

		[DataMember(Name = "value")]
		public string Value { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateField {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		/// Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonSerializer.Serialize(this, new JsonSerializerOptions() { WriteIndented = true });
		}

		/// <summary>
		/// Returns true if objects are equal
		/// </summary>
		/// <param name="obj">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return obj.GetType() == GetType() && Equals((UpdateField)obj);
		}

		/// <summary>
		/// Returns true if UpdateField instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateField to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateField other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;

			return
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name)
				) &&
				(
					Value == other.Value ||
					Value != null &&
					Value.Equals(other.Value)
				);
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				var hashCode = 41;
				// Suitable nullity checks etc, of course :)
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Value != null)
					hashCode = hashCode * 59 + Value.GetHashCode();
				return hashCode;
			}
		}

		#region Operators

#pragma warning disable 1591

		public static bool operator ==(UpdateField left, UpdateField right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(UpdateField left, UpdateField right)
		{
			return !Equals(left, right);
		}

#pragma warning restore 1591

		#endregion Operators
	}
}