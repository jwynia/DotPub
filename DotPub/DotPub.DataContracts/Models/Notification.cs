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
    public partial class Notification : IEquatable<Notification>
    { 
        /// <summary>
        /// Gets or Sets Account
        /// </summary>

        [DataMember(Name="account")]
        public Account Account { get; set; }

        /// <summary>
        /// The timestamp of the notification (ISO 8601 Datetime)
        /// </summary>
        /// <value>The timestamp of the notification (ISO 8601 Datetime)</value>

        [DataMember(Name="created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The id of the notification in the database.
        /// </summary>
        /// <value>The id of the notification in the database.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>

        [DataMember(Name="status")]
        public Status Status { get; set; }

        /// <summary>
        /// The type of event that resulted in the notification. follow &#x3D; Someone followed you follow_request &#x3D; Someone requested to follow you mention &#x3D; Someone mentioned you in their status reblog &#x3D; Someone boosted one of your statuses favourite &#x3D; Someone favourited one of your statuses poll &#x3D; A poll you have voted in or created has ended status &#x3D; Someone you enabled notifications for has posted a status
        /// </summary>
        /// <value>The type of event that resulted in the notification. follow &#x3D; Someone followed you follow_request &#x3D; Someone requested to follow you mention &#x3D; Someone mentioned you in their status reblog &#x3D; Someone boosted one of your statuses favourite &#x3D; Someone favourited one of your statuses poll &#x3D; A poll you have voted in or created has ended status &#x3D; Someone you enabled notifications for has posted a status</value>

        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Notification)obj);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="other">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Account == other.Account ||
                    Account != null &&
                    Account.Equals(other.Account)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
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
                    if (Account != null)
                    hashCode = hashCode * 59 + Account.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Notification left, Notification right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Notification left, Notification right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}