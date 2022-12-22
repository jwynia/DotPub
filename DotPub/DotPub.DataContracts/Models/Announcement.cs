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
    public partial class Announcement : IEquatable<Announcement>
    { 
        /// <summary>
        /// Announcement doesn&#39;t have begin time and end time, but begin day and end day.
        /// </summary>
        /// <value>Announcement doesn&#39;t have begin time and end time, but begin day and end day.</value>

        [DataMember(Name="all_day")]
        public bool? AllDay { get; set; }

        /// <summary>
        /// The body of the announcement. Should be HTML formatted.
        /// </summary>
        /// <value>The body of the announcement. Should be HTML formatted.</value>

        [DataMember(Name="content")]
        public string Content { get; set; }

        /// <summary>
        /// Emojis used in this announcement.
        /// </summary>
        /// <value>Emojis used in this announcement.</value>

        [DataMember(Name="emoji")]
        public List<Emoji> Emoji { get; set; }

        /// <summary>
        /// When the announcement should stop being displayed (ISO 8601 Datetime). If the announcement has no end time, this will be omitted or empty.
        /// </summary>
        /// <value>When the announcement should stop being displayed (ISO 8601 Datetime). If the announcement has no end time, this will be omitted or empty.</value>

        [DataMember(Name="ends_at")]
        public string EndsAt { get; set; }

        /// <summary>
        /// The ID of the announcement.
        /// </summary>
        /// <value>The ID of the announcement.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Mentions this announcement contains.
        /// </summary>
        /// <value>Mentions this announcement contains.</value>

        [DataMember(Name="mentions")]
        public List<Mention> Mentions { get; set; }

        /// <summary>
        /// Announcement is &#39;published&#39;, ie., visible to users. Announcements that are not published should be shown only to admins.
        /// </summary>
        /// <value>Announcement is &#39;published&#39;, ie., visible to users. Announcements that are not published should be shown only to admins.</value>

        [DataMember(Name="published")]
        public bool? Published { get; set; }

        /// <summary>
        /// When the announcement was first published (ISO 8601 Datetime).
        /// </summary>
        /// <value>When the announcement was first published (ISO 8601 Datetime).</value>

        [DataMember(Name="published_at")]
        public string PublishedAt { get; set; }

        /// <summary>
        /// Reactions to this announcement.
        /// </summary>
        /// <value>Reactions to this announcement.</value>

        [DataMember(Name="reactions")]
        public List<AnnouncementReaction> Reactions { get; set; }

        /// <summary>
        /// Requesting account has seen this announcement.
        /// </summary>
        /// <value>Requesting account has seen this announcement.</value>

        [DataMember(Name="read")]
        public bool? Read { get; set; }

        /// <summary>
        /// When the announcement should begin to be displayed (ISO 8601 Datetime). If the announcement has no start time, this will be omitted or empty.
        /// </summary>
        /// <value>When the announcement should begin to be displayed (ISO 8601 Datetime). If the announcement has no start time, this will be omitted or empty.</value>

        [DataMember(Name="starts_at")]
        public string StartsAt { get; set; }

        /// <summary>
        /// Statuses contained in this announcement.
        /// </summary>
        /// <value>Statuses contained in this announcement.</value>

        [DataMember(Name="statuses")]
        public List<Status> Statuses { get; set; }

        /// <summary>
        /// Tags used in this announcement.
        /// </summary>
        /// <value>Tags used in this announcement.</value>

        [DataMember(Name="tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// When the announcement was last updated (ISO 8601 Datetime).
        /// </summary>
        /// <value>When the announcement was last updated (ISO 8601 Datetime).</value>

        [DataMember(Name="updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Announcement {\n");
            sb.Append("  AllDay: ").Append(AllDay).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Emoji: ").Append(Emoji).Append("\n");
            sb.Append("  EndsAt: ").Append(EndsAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Mentions: ").Append(Mentions).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  PublishedAt: ").Append(PublishedAt).Append("\n");
            sb.Append("  Reactions: ").Append(Reactions).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  StartsAt: ").Append(StartsAt).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonSerializer.Serialize(this,new JsonSerializerOptions(){WriteIndented = true});
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
            return obj.GetType() == GetType() && Equals((Announcement)obj);
        }

        /// <summary>
        /// Returns true if Announcement instances are equal
        /// </summary>
        /// <param name="other">Instance of Announcement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Announcement other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AllDay == other.AllDay ||
                    AllDay != null &&
                    AllDay.Equals(other.AllDay)
                ) && 
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.Equals(other.Content)
                ) && 
                (
                    Emoji == other.Emoji ||
                    Emoji != null &&
                    Emoji.SequenceEqual(other.Emoji)
                ) && 
                (
                    EndsAt == other.EndsAt ||
                    EndsAt != null &&
                    EndsAt.Equals(other.EndsAt)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Mentions == other.Mentions ||
                    Mentions != null &&
                    Mentions.SequenceEqual(other.Mentions)
                ) && 
                (
                    Published == other.Published ||
                    Published != null &&
                    Published.Equals(other.Published)
                ) && 
                (
                    PublishedAt == other.PublishedAt ||
                    PublishedAt != null &&
                    PublishedAt.Equals(other.PublishedAt)
                ) && 
                (
                    Reactions == other.Reactions ||
                    Reactions != null &&
                    Reactions.SequenceEqual(other.Reactions)
                ) && 
                (
                    Read == other.Read ||
                    Read != null &&
                    Read.Equals(other.Read)
                ) && 
                (
                    StartsAt == other.StartsAt ||
                    StartsAt != null &&
                    StartsAt.Equals(other.StartsAt)
                ) && 
                (
                    Statuses == other.Statuses ||
                    Statuses != null &&
                    Statuses.SequenceEqual(other.Statuses)
                ) && 
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
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
                    if (AllDay != null)
                    hashCode = hashCode * 59 + AllDay.GetHashCode();
                    if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                    if (Emoji != null)
                    hashCode = hashCode * 59 + Emoji.GetHashCode();
                    if (EndsAt != null)
                    hashCode = hashCode * 59 + EndsAt.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Mentions != null)
                    hashCode = hashCode * 59 + Mentions.GetHashCode();
                    if (Published != null)
                    hashCode = hashCode * 59 + Published.GetHashCode();
                    if (PublishedAt != null)
                    hashCode = hashCode * 59 + PublishedAt.GetHashCode();
                    if (Reactions != null)
                    hashCode = hashCode * 59 + Reactions.GetHashCode();
                    if (Read != null)
                    hashCode = hashCode * 59 + Read.GetHashCode();
                    if (StartsAt != null)
                    hashCode = hashCode * 59 + StartsAt.GetHashCode();
                    if (Statuses != null)
                    hashCode = hashCode * 59 + Statuses.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                    if (UpdatedAt != null)
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Announcement left, Announcement right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Announcement left, Announcement right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
