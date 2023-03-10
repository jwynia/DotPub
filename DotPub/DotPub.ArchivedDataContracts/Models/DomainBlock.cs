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
    /// DomainBlock represents a block on one domain
    /// </summary>
    [DataContract]
    public partial class DomainBlock : IEquatable<DomainBlock>
    {
        /// <summary>
        /// Time at which this block was created (ISO 8601 Datetime).
        /// </summary>
        /// <value>Time at which this block was created (ISO 8601 Datetime).</value>

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// ID of the account that created this domain block.
        /// </summary>
        /// <value>ID of the account that created this domain block.</value>

        [DataMember(Name = "created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The hostname of the domain.
        /// </summary>
        /// <value>The hostname of the domain.</value>

        [DataMember(Name = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the domain block.
        /// </summary>
        /// <value>The ID of the domain block.</value>

        [DataMember(Name = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Obfuscate the domain name when serving this domain block publicly. A useful anti-harassment tool.
        /// </summary>
        /// <value>Obfuscate the domain name when serving this domain block publicly. A useful anti-harassment tool.</value>

        [DataMember(Name = "obfuscate")]
        public bool? Obfuscate { get; set; }

        /// <summary>
        /// Private comment for this block, visible to our instance admins only.
        /// </summary>
        /// <value>Private comment for this block, visible to our instance admins only.</value>

        [DataMember(Name = "private_comment")]
        public string PrivateComment { get; set; }

        /// <summary>
        /// If the domain is blocked, what&#39;s the publicly-stated reason for the block.
        /// </summary>
        /// <value>If the domain is blocked, what&#39;s the publicly-stated reason for the block.</value>

        [DataMember(Name = "public_comment")]
        public string PublicComment { get; set; }

        /// <summary>
        /// Time at which this domain was silenced. Key will not be present on open domains.
        /// </summary>
        /// <value>Time at which this domain was silenced. Key will not be present on open domains.</value>

        [DataMember(Name = "silenced_at")]
        public string SilencedAt { get; set; }

        /// <summary>
        /// The ID of the subscription that created/caused this domain block.
        /// </summary>
        /// <value>The ID of the subscription that created/caused this domain block.</value>

        [DataMember(Name = "subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Time at which this domain was suspended. Key will not be present on open domains.
        /// </summary>
        /// <value>Time at which this domain was suspended. Key will not be present on open domains.</value>

        [DataMember(Name = "suspended_at")]
        public string SuspendedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainBlock {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Obfuscate: ").Append(Obfuscate).Append("\n");
            sb.Append("  PrivateComment: ").Append(PrivateComment).Append("\n");
            sb.Append("  PublicComment: ").Append(PublicComment).Append("\n");
            sb.Append("  SilencedAt: ").Append(SilencedAt).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  SuspendedAt: ").Append(SuspendedAt).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DomainBlock)obj);
        }

        /// <summary>
        /// Returns true if DomainBlock instances are equal
        /// </summary>
        /// <param name="other">Instance of DomainBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainBlock other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) &&
                (
                    CreatedBy == other.CreatedBy ||
                    CreatedBy != null &&
                    CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    Domain == other.Domain ||
                    Domain != null &&
                    Domain.Equals(other.Domain)
                ) &&
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) &&
                (
                    Obfuscate == other.Obfuscate ||
                    Obfuscate != null &&
                    Obfuscate.Equals(other.Obfuscate)
                ) &&
                (
                    PrivateComment == other.PrivateComment ||
                    PrivateComment != null &&
                    PrivateComment.Equals(other.PrivateComment)
                ) &&
                (
                    PublicComment == other.PublicComment ||
                    PublicComment != null &&
                    PublicComment.Equals(other.PublicComment)
                ) &&
                (
                    SilencedAt == other.SilencedAt ||
                    SilencedAt != null &&
                    SilencedAt.Equals(other.SilencedAt)
                ) &&
                (
                    SubscriptionId == other.SubscriptionId ||
                    SubscriptionId != null &&
                    SubscriptionId.Equals(other.SubscriptionId)
                ) &&
                (
                    SuspendedAt == other.SuspendedAt ||
                    SuspendedAt != null &&
                    SuspendedAt.Equals(other.SuspendedAt)
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
                if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                if (CreatedBy != null)
                    hashCode = hashCode * 59 + CreatedBy.GetHashCode();
                if (Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Obfuscate != null)
                    hashCode = hashCode * 59 + Obfuscate.GetHashCode();
                if (PrivateComment != null)
                    hashCode = hashCode * 59 + PrivateComment.GetHashCode();
                if (PublicComment != null)
                    hashCode = hashCode * 59 + PublicComment.GetHashCode();
                if (SilencedAt != null)
                    hashCode = hashCode * 59 + SilencedAt.GetHashCode();
                if (SubscriptionId != null)
                    hashCode = hashCode * 59 + SubscriptionId.GetHashCode();
                if (SuspendedAt != null)
                    hashCode = hashCode * 59 + SuspendedAt.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(DomainBlock left, DomainBlock right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DomainBlock left, DomainBlock right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}