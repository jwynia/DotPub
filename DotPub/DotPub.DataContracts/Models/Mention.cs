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
    public partial class Mention : IEquatable<Mention>
    { 
        /// <summary>
        /// The account URI as discovered via webfinger. Equal to username for local users, or username@domain for remote users.
        /// </summary>
        /// <value>The account URI as discovered via webfinger. Equal to username for local users, or username@domain for remote users.</value>

        [DataMember(Name="acct")]
        public string Acct { get; set; }

        /// <summary>
        /// The ID of the mentioned account.
        /// </summary>
        /// <value>The ID of the mentioned account.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// The web URL of the mentioned account&#39;s profile.
        /// </summary>
        /// <value>The web URL of the mentioned account&#39;s profile.</value>

        [DataMember(Name="url")]
        public string Url { get; set; }

        /// <summary>
        /// The username of the mentioned account.
        /// </summary>
        /// <value>The username of the mentioned account.</value>

        [DataMember(Name="username")]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mention {\n");
            sb.Append("  Acct: ").Append(Acct).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Mention)obj);
        }

        /// <summary>
        /// Returns true if Mention instances are equal
        /// </summary>
        /// <param name="other">Instance of Mention to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mention other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Acct == other.Acct ||
                    Acct != null &&
                    Acct.Equals(other.Acct)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) && 
                (
                    Username == other.Username ||
                    Username != null &&
                    Username.Equals(other.Username)
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
                    if (Acct != null)
                    hashCode = hashCode * 59 + Acct.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                    if (Username != null)
                    hashCode = hashCode * 59 + Username.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Mention left, Mention right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Mention left, Mention right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
