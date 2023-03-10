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
    public partial class StatusCreateRequest : IEquatable<StatusCreateRequest>
    {
        /// <summary>
        /// Format to use when parsing this status. in: formData
        /// </summary>
        /// <value>Format to use when parsing this status. in: formData</value>

        [DataMember(Name = "format")]
        public string Format { get; set; }

        /// <summary>
        /// ID of the status being replied to, if status is a reply. in: formData
        /// </summary>
        /// <value>ID of the status being replied to, if status is a reply. in: formData</value>

        [DataMember(Name = "in_reply_to_id")]
        public string InReplyToId { get; set; }

        /// <summary>
        /// ISO 639 language code for this status. in: formData
        /// </summary>
        /// <value>ISO 639 language code for this status. in: formData</value>

        [DataMember(Name = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Array of Attachment ids to be attached as media. If provided, status becomes optional, and poll cannot be used.  If the status is being submitted as a form, the key is &#39;media_ids[]&#39;, but if it&#39;s json or xml, the key is &#39;media_ids&#39;.  in: formData
        /// </summary>
        /// <value>Array of Attachment ids to be attached as media. If provided, status becomes optional, and poll cannot be used.  If the status is being submitted as a form, the key is &#39;media_ids[]&#39;, but if it&#39;s json or xml, the key is &#39;media_ids&#39;.  in: formData</value>

        [DataMember(Name = "media_ids")]
        public List<string> MediaIds { get; set; }

        /// <summary>
        /// ISO 8601 Datetime at which to schedule a status. Providing this parameter will cause ScheduledStatus to be returned instead of Status. Must be at least 5 minutes in the future. in: formData
        /// </summary>
        /// <value>ISO 8601 Datetime at which to schedule a status. Providing this parameter will cause ScheduledStatus to be returned instead of Status. Must be at least 5 minutes in the future. in: formData</value>

        [DataMember(Name = "scheduled_at")]
        public string ScheduledAt { get; set; }

        /// <summary>
        /// Status and attached media should be marked as sensitive. in: formData
        /// </summary>
        /// <value>Status and attached media should be marked as sensitive. in: formData</value>

        [DataMember(Name = "sensitive")]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// Text to be shown as a warning or subject before the actual content. Statuses are generally collapsed behind this field. in: formData
        /// </summary>
        /// <value>Text to be shown as a warning or subject before the actual content. Statuses are generally collapsed behind this field. in: formData</value>

        [DataMember(Name = "spoiler_text")]
        public string SpoilerText { get; set; }

        /// <summary>
        /// Text content of the status. If media_ids is provided, this becomes optional. Attaching a poll is optional while status is provided. in: formData
        /// </summary>
        /// <value>Text content of the status. If media_ids is provided, this becomes optional. Attaching a poll is optional while status is provided. in: formData</value>

        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Visibility of the posted status. in: formData
        /// </summary>
        /// <value>Visibility of the posted status. in: formData</value>

        [DataMember(Name = "visibility")]
        public string Visibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusCreateRequest {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  InReplyToId: ").Append(InReplyToId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  MediaIds: ").Append(MediaIds).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  Sensitive: ").Append(Sensitive).Append("\n");
            sb.Append("  SpoilerText: ").Append(SpoilerText).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return obj.GetType() == GetType() && Equals((StatusCreateRequest)obj);
        }

        /// <summary>
        /// Returns true if StatusCreateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusCreateRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Format == other.Format ||
                    Format != null &&
                    Format.Equals(other.Format)
                ) &&
                (
                    InReplyToId == other.InReplyToId ||
                    InReplyToId != null &&
                    InReplyToId.Equals(other.InReplyToId)
                ) &&
                (
                    Language == other.Language ||
                    Language != null &&
                    Language.Equals(other.Language)
                ) &&
                (
                    MediaIds == other.MediaIds ||
                    MediaIds != null &&
                    MediaIds.SequenceEqual(other.MediaIds)
                ) &&
                (
                    ScheduledAt == other.ScheduledAt ||
                    ScheduledAt != null &&
                    ScheduledAt.Equals(other.ScheduledAt)
                ) &&
                (
                    Sensitive == other.Sensitive ||
                    Sensitive != null &&
                    Sensitive.Equals(other.Sensitive)
                ) &&
                (
                    SpoilerText == other.SpoilerText ||
                    SpoilerText != null &&
                    SpoilerText.Equals(other.SpoilerText)
                ) &&
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) &&
                (
                    Visibility == other.Visibility ||
                    Visibility != null &&
                    Visibility.Equals(other.Visibility)
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
                if (Format != null)
                    hashCode = hashCode * 59 + Format.GetHashCode();
                if (InReplyToId != null)
                    hashCode = hashCode * 59 + InReplyToId.GetHashCode();
                if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
                if (MediaIds != null)
                    hashCode = hashCode * 59 + MediaIds.GetHashCode();
                if (ScheduledAt != null)
                    hashCode = hashCode * 59 + ScheduledAt.GetHashCode();
                if (Sensitive != null)
                    hashCode = hashCode * 59 + Sensitive.GetHashCode();
                if (SpoilerText != null)
                    hashCode = hashCode * 59 + SpoilerText.GetHashCode();
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                if (Visibility != null)
                    hashCode = hashCode * 59 + Visibility.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(StatusCreateRequest left, StatusCreateRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StatusCreateRequest left, StatusCreateRequest right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}