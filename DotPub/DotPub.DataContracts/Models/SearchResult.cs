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
    public partial class SearchResult : IEquatable<SearchResult>
    { 
        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>

        [DataMember(Name="accounts")]
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets Hashtags
        /// </summary>

        [DataMember(Name="hashtags")]
        public List<Tag> Hashtags { get; set; }

        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>

        [DataMember(Name="statuses")]
        public List<Status> Statuses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResult {\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Hashtags: ").Append(Hashtags).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SearchResult)obj);
        }

        /// <summary>
        /// Returns true if SearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResult other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Accounts == other.Accounts ||
                    Accounts != null &&
                    Accounts.SequenceEqual(other.Accounts)
                ) && 
                (
                    Hashtags == other.Hashtags ||
                    Hashtags != null &&
                    Hashtags.SequenceEqual(other.Hashtags)
                ) && 
                (
                    Statuses == other.Statuses ||
                    Statuses != null &&
                    Statuses.SequenceEqual(other.Statuses)
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
                    if (Accounts != null)
                    hashCode = hashCode * 59 + Accounts.GetHashCode();
                    if (Hashtags != null)
                    hashCode = hashCode * 59 + Hashtags.GetHashCode();
                    if (Statuses != null)
                    hashCode = hashCode * 59 + Statuses.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SearchResult left, SearchResult right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SearchResult left, SearchResult right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}