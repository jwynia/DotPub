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
	/// 
	/// </summary>
	[DataContract]
	public partial class InstanceConfigurationStatuses : IEquatable<InstanceConfigurationStatuses>
	{
		/// <summary>
		/// Amount of characters clients should assume a url takes up.
		/// </summary>
		/// <value>Amount of characters clients should assume a url takes up.</value>

		[DataMember(Name = "characters_reserved_per_url")]
		public long? CharactersReservedPerUrl { get; set; }

		/// <summary>
		/// Maximum allowed length of a post on this instance, in characters.
		/// </summary>
		/// <value>Maximum allowed length of a post on this instance, in characters.</value>

		[DataMember(Name = "max_characters")]
		public long? MaxCharacters { get; set; }

		/// <summary>
		/// Max number of attachments allowed on a status.
		/// </summary>
		/// <value>Max number of attachments allowed on a status.</value>

		[DataMember(Name = "max_media_attachments")]
		public long? MaxMediaAttachments { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InstanceConfigurationStatuses {\n");
			sb.Append("  CharactersReservedPerUrl: ").Append(CharactersReservedPerUrl).Append("\n");
			sb.Append("  MaxCharacters: ").Append(MaxCharacters).Append("\n");
			sb.Append("  MaxMediaAttachments: ").Append(MaxMediaAttachments).Append("\n");
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
			return obj.GetType() == GetType() && Equals((InstanceConfigurationStatuses)obj);
		}

		/// <summary>
		/// Returns true if InstanceConfigurationStatuses instances are equal
		/// </summary>
		/// <param name="other">Instance of InstanceConfigurationStatuses to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InstanceConfigurationStatuses other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;

			return
				(
					CharactersReservedPerUrl == other.CharactersReservedPerUrl ||
					CharactersReservedPerUrl != null &&
					CharactersReservedPerUrl.Equals(other.CharactersReservedPerUrl)
				) &&
				(
					MaxCharacters == other.MaxCharacters ||
					MaxCharacters != null &&
					MaxCharacters.Equals(other.MaxCharacters)
				) &&
				(
					MaxMediaAttachments == other.MaxMediaAttachments ||
					MaxMediaAttachments != null &&
					MaxMediaAttachments.Equals(other.MaxMediaAttachments)
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
				if (CharactersReservedPerUrl != null)
					hashCode = hashCode * 59 + CharactersReservedPerUrl.GetHashCode();
				if (MaxCharacters != null)
					hashCode = hashCode * 59 + MaxCharacters.GetHashCode();
				if (MaxMediaAttachments != null)
					hashCode = hashCode * 59 + MaxMediaAttachments.GetHashCode();
				return hashCode;
			}
		}

		#region Operators

#pragma warning disable 1591

		public static bool operator ==(InstanceConfigurationStatuses left, InstanceConfigurationStatuses right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(InstanceConfigurationStatuses left, InstanceConfigurationStatuses right)
		{
			return !Equals(left, right);
		}

#pragma warning restore 1591

		#endregion Operators
	}
}