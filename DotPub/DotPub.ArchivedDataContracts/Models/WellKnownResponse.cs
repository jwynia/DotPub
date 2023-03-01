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
    /// See https://webfinger.net/
    /// </summary>
    [DataContract]
    public partial class WellKnownResponse : IEquatable<WellKnownResponse>
    { 
        /// <summary>
        /// Gets or Sets Aliases
        /// </summary>

        [DataMember(Name="aliases")]
        public List<string> Aliases { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>

        [DataMember(Name="links")]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>

        [DataMember(Name="subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WellKnownResponse {\n");
            sb.Append("  Aliases: ").Append(Aliases).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return obj.GetType() == GetType() && Equals((WellKnownResponse)obj);
        }

        /// <summary>
        /// Returns true if WellKnownResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WellKnownResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WellKnownResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Aliases == other.Aliases ||
                    Aliases != null &&
                    Aliases.SequenceEqual(other.Aliases)
                ) && 
                (
                    Links == other.Links ||
                    Links != null &&
                    Links.SequenceEqual(other.Links)
                ) && 
                (
                    Subject == other.Subject ||
                    Subject != null &&
                    Subject.Equals(other.Subject)
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
                    if (Aliases != null)
                    hashCode = hashCode * 59 + Aliases.GetHashCode();
                    if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                    if (Subject != null)
                    hashCode = hashCode * 59 + Subject.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(WellKnownResponse left, WellKnownResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WellKnownResponse left, WellKnownResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}