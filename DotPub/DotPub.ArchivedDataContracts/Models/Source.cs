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
    /// Returned as an additional entity when verifying and updated credentials, as an attribute of Account.
    /// </summary>
    [DataContract]
    public partial class Source : IEquatable<Source>
    { 
        /// <summary>
        /// Metadata about the account.
        /// </summary>
        /// <value>Metadata about the account.</value>

        [DataMember(Name="fields")]
        public List<Field> Fields { get; set; }

        /// <summary>
        /// The number of pending follow requests.
        /// </summary>
        /// <value>The number of pending follow requests.</value>

        [DataMember(Name="follow_requests_count")]
        public long? FollowRequestsCount { get; set; }

        /// <summary>
        /// The default posting language for new statuses.
        /// </summary>
        /// <value>The default posting language for new statuses.</value>

        [DataMember(Name="language")]
        public string Language { get; set; }

        /// <summary>
        /// Profile bio.
        /// </summary>
        /// <value>Profile bio.</value>

        [DataMember(Name="note")]
        public string Note { get; set; }

        /// <summary>
        /// The default post privacy to be used for new statuses. public &#x3D; Public post unlisted &#x3D; Unlisted post private &#x3D; Followers-only post direct &#x3D; Direct post
        /// </summary>
        /// <value>The default post privacy to be used for new statuses. public &#x3D; Public post unlisted &#x3D; Unlisted post private &#x3D; Followers-only post direct &#x3D; Direct post</value>

        [DataMember(Name="privacy")]
        public string Privacy { get; set; }

        /// <summary>
        /// Whether new statuses should be marked sensitive by default.
        /// </summary>
        /// <value>Whether new statuses should be marked sensitive by default.</value>

        [DataMember(Name="sensitive")]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// The default posting format for new statuses.
        /// </summary>
        /// <value>The default posting format for new statuses.</value>

        [DataMember(Name="status_format")]
        public string StatusFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Source {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  FollowRequestsCount: ").Append(FollowRequestsCount).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Source)obj);
        }

        /// <summary>
        /// Returns true if Source instances are equal
        /// </summary>
        /// <param name="other">Instance of Source to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Source other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Fields == other.Fields ||
                    Fields != null &&
                    Fields.SequenceEqual(other.Fields)
                ) && 
                (
                    FollowRequestsCount == other.FollowRequestsCount ||
                    FollowRequestsCount != null &&
                    FollowRequestsCount.Equals(other.FollowRequestsCount)
                ) && 
                (
                    Language == other.Language ||
                    Language != null &&
                    Language.Equals(other.Language)
                ) && 
                (
                    Note == other.Note ||
                    Note != null &&
                    Note.Equals(other.Note)
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
                    if (Fields != null)
                    hashCode = hashCode * 59 + Fields.GetHashCode();
                    if (FollowRequestsCount != null)
                    hashCode = hashCode * 59 + FollowRequestsCount.GetHashCode();
                    if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
                    if (Note != null)
                    hashCode = hashCode * 59 + Note.GetHashCode();
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

        public static bool operator ==(Source left, Source right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Source left, Source right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}