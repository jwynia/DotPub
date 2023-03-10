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
    public partial class UpdateSource : IEquatable<UpdateSource>
    {
        /// <summary>
        /// Default language to use for authored statuses. (ISO 6391)
        /// </summary>
        /// <value>Default language to use for authored statuses. (ISO 6391)</value>

        [DataMember(Name = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Default post privacy for authored statuses.
        /// </summary>
        /// <value>Default post privacy for authored statuses.</value>

        [DataMember(Name = "privacy")]
        public string Privacy { get; set; }

        /// <summary>
        /// Mark authored statuses as sensitive by default.
        /// </summary>
        /// <value>Mark authored statuses as sensitive by default.</value>

        [DataMember(Name = "sensitive")]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// Default format for authored statuses (plain or markdown).
        /// </summary>
        /// <value>Default format for authored statuses (plain or markdown).</value>

        [DataMember(Name = "status_format")]
        public string StatusFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSource {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Sensitive: ").Append(Sensitive).Append("\n");
            sb.Append("  StatusFormat: ").Append(StatusFormat).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdateSource)obj);
        }

        /// <summary>
        /// Returns true if UpdateSource instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSource other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Language == other.Language ||
                    Language != null &&
                    Language.Equals(other.Language)
                ) &&
                (
                    Privacy == other.Privacy ||
                    Privacy != null &&
                    Privacy.Equals(other.Privacy)
                ) &&
                (
                    Sensitive == other.Sensitive ||
                    Sensitive != null &&
                    Sensitive.Equals(other.Sensitive)
                ) &&
                (
                    StatusFormat == other.StatusFormat ||
                    StatusFormat != null &&
                    StatusFormat.Equals(other.StatusFormat)
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
                if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
                if (Privacy != null)
                    hashCode = hashCode * 59 + Privacy.GetHashCode();
                if (Sensitive != null)
                    hashCode = hashCode * 59 + Sensitive.GetHashCode();
                if (StatusFormat != null)
                    hashCode = hashCode * 59 + StatusFormat.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(UpdateSource left, UpdateSource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateSource left, UpdateSource right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}