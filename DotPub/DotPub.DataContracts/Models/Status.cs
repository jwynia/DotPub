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
    public partial class Status : IEquatable<Status>
    { 
        /// <summary>
        /// Gets or Sets Account
        /// </summary>

        [DataMember(Name="account")]
        public Account Account { get; set; }

        /// <summary>
        /// Gets or Sets Application
        /// </summary>

        [DataMember(Name="application")]
        public Application Application { get; set; }

        /// <summary>
        /// This status has been bookmarked by the account viewing it.
        /// </summary>
        /// <value>This status has been bookmarked by the account viewing it.</value>

        [DataMember(Name="bookmarked")]
        public bool? Bookmarked { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>

        [DataMember(Name="card")]
        public Card Card { get; set; }

        /// <summary>
        /// The content of this status. Should be HTML, but might also be plaintext in some cases.
        /// </summary>
        /// <value>The content of this status. Should be HTML, but might also be plaintext in some cases.</value>

        [DataMember(Name="content")]
        public string Content { get; set; }

        /// <summary>
        /// The date when this status was created (ISO 8601 Datetime).
        /// </summary>
        /// <value>The date when this status was created (ISO 8601 Datetime).</value>

        [DataMember(Name="created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Custom emoji to be used when rendering status content.
        /// </summary>
        /// <value>Custom emoji to be used when rendering status content.</value>

        [DataMember(Name="emojis")]
        public List<Emoji> Emojis { get; set; }

        /// <summary>
        /// This status has been favourited by the account viewing it.
        /// </summary>
        /// <value>This status has been favourited by the account viewing it.</value>

        [DataMember(Name="favourited")]
        public bool? Favourited { get; set; }

        /// <summary>
        /// Number of favourites/likes this status has received, according to our instance.
        /// </summary>
        /// <value>Number of favourites/likes this status has received, according to our instance.</value>

        [DataMember(Name="favourites_count")]
        public long? FavouritesCount { get; set; }

        /// <summary>
        /// ID of the status.
        /// </summary>
        /// <value>ID of the status.</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// ID of the account being replied to.
        /// </summary>
        /// <value>ID of the account being replied to.</value>

        [DataMember(Name="in_reply_to_account_id")]
        public string InReplyToAccountId { get; set; }

        /// <summary>
        /// ID of the status being replied to.
        /// </summary>
        /// <value>ID of the status being replied to.</value>

        [DataMember(Name="in_reply_to_id")]
        public string InReplyToId { get; set; }

        /// <summary>
        /// Primary language of this status (ISO 639 Part 1 two-letter language code). Will be null if language is not known.
        /// </summary>
        /// <value>Primary language of this status (ISO 639 Part 1 two-letter language code). Will be null if language is not known.</value>

        [DataMember(Name="language")]
        public string Language { get; set; }

        /// <summary>
        /// Media that is attached to this status.
        /// </summary>
        /// <value>Media that is attached to this status.</value>

        [DataMember(Name="media_attachments")]
        public List<Attachment> MediaAttachments { get; set; }

        /// <summary>
        /// Mentions of users within the status content.
        /// </summary>
        /// <value>Mentions of users within the status content.</value>

        [DataMember(Name="mentions")]
        public List<Mention> Mentions { get; set; }

        /// <summary>
        /// Replies to this status have been muted by the account viewing it.
        /// </summary>
        /// <value>Replies to this status have been muted by the account viewing it.</value>

        [DataMember(Name="muted")]
        public bool? Muted { get; set; }

        /// <summary>
        /// This status has been pinned by the account viewing it (only relevant for your own statuses).
        /// </summary>
        /// <value>This status has been pinned by the account viewing it (only relevant for your own statuses).</value>

        [DataMember(Name="pinned")]
        public bool? Pinned { get; set; }

        /// <summary>
        /// Gets or Sets Poll
        /// </summary>

        [DataMember(Name="poll")]
        public Poll Poll { get; set; }

        /// <summary>
        /// Gets or Sets Reblog
        /// </summary>

        [DataMember(Name="reblog")]
        public StatusReblogged Reblog { get; set; }

        /// <summary>
        /// This status has been boosted/reblogged by the account viewing it.
        /// </summary>
        /// <value>This status has been boosted/reblogged by the account viewing it.</value>

        [DataMember(Name="reblogged")]
        public bool? Reblogged { get; set; }

        /// <summary>
        /// Number of times this status has been boosted/reblogged, according to our instance.
        /// </summary>
        /// <value>Number of times this status has been boosted/reblogged, according to our instance.</value>

        [DataMember(Name="reblogs_count")]
        public long? ReblogsCount { get; set; }

        /// <summary>
        /// Number of replies to this status, according to our instance.
        /// </summary>
        /// <value>Number of replies to this status, according to our instance.</value>

        [DataMember(Name="replies_count")]
        public long? RepliesCount { get; set; }

        /// <summary>
        /// Status contains sensitive content.
        /// </summary>
        /// <value>Status contains sensitive content.</value>

        [DataMember(Name="sensitive")]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// Subject, summary, or content warning for the status.
        /// </summary>
        /// <value>Subject, summary, or content warning for the status.</value>

        [DataMember(Name="spoiler_text")]
        public string SpoilerText { get; set; }

        /// <summary>
        /// Hashtags used within the status content.
        /// </summary>
        /// <value>Hashtags used within the status content.</value>

        [DataMember(Name="tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Plain-text source of a status. Returned instead of content when status is deleted, so the user may redraft from the source text without the client having to reverse-engineer the original text from the HTML content.
        /// </summary>
        /// <value>Plain-text source of a status. Returned instead of content when status is deleted, so the user may redraft from the source text without the client having to reverse-engineer the original text from the HTML content.</value>

        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// ActivityPub URI of the status. Equivalent to the status&#39;s activitypub ID.
        /// </summary>
        /// <value>ActivityPub URI of the status. Equivalent to the status&#39;s activitypub ID.</value>

        [DataMember(Name="uri")]
        public string Uri { get; set; }

        /// <summary>
        /// The status&#39;s publicly available web URL. This link will only work if the visibility of the status is &#39;public&#39;.
        /// </summary>
        /// <value>The status&#39;s publicly available web URL. This link will only work if the visibility of the status is &#39;public&#39;.</value>

        [DataMember(Name="url")]
        public string Url { get; set; }

        /// <summary>
        /// Visibility of this status.
        /// </summary>
        /// <value>Visibility of this status.</value>

        [DataMember(Name="visibility")]
        public string Visibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Status {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Bookmarked: ").Append(Bookmarked).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Emojis: ").Append(Emojis).Append("\n");
            sb.Append("  Favourited: ").Append(Favourited).Append("\n");
            sb.Append("  FavouritesCount: ").Append(FavouritesCount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InReplyToAccountId: ").Append(InReplyToAccountId).Append("\n");
            sb.Append("  InReplyToId: ").Append(InReplyToId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  MediaAttachments: ").Append(MediaAttachments).Append("\n");
            sb.Append("  Mentions: ").Append(Mentions).Append("\n");
            sb.Append("  Muted: ").Append(Muted).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  Poll: ").Append(Poll).Append("\n");
            sb.Append("  Reblog: ").Append(Reblog).Append("\n");
            sb.Append("  Reblogged: ").Append(Reblogged).Append("\n");
            sb.Append("  ReblogsCount: ").Append(ReblogsCount).Append("\n");
            sb.Append("  RepliesCount: ").Append(RepliesCount).Append("\n");
            sb.Append("  Sensitive: ").Append(Sensitive).Append("\n");
            sb.Append("  SpoilerText: ").Append(SpoilerText).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Status)obj);
        }

        /// <summary>
        /// Returns true if Status instances are equal
        /// </summary>
        /// <param name="other">Instance of Status to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Status other)
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
                    Application == other.Application ||
                    Application != null &&
                    Application.Equals(other.Application)
                ) && 
                (
                    Bookmarked == other.Bookmarked ||
                    Bookmarked != null &&
                    Bookmarked.Equals(other.Bookmarked)
                ) && 
                (
                    Card == other.Card ||
                    Card != null &&
                    Card.Equals(other.Card)
                ) && 
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.Equals(other.Content)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    Emojis == other.Emojis ||
                    Emojis != null &&
                    Emojis.SequenceEqual(other.Emojis)
                ) && 
                (
                    Favourited == other.Favourited ||
                    Favourited != null &&
                    Favourited.Equals(other.Favourited)
                ) && 
                (
                    FavouritesCount == other.FavouritesCount ||
                    FavouritesCount != null &&
                    FavouritesCount.Equals(other.FavouritesCount)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    InReplyToAccountId == other.InReplyToAccountId ||
                    InReplyToAccountId != null &&
                    InReplyToAccountId.Equals(other.InReplyToAccountId)
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
                    MediaAttachments == other.MediaAttachments ||
                    MediaAttachments != null &&
                    MediaAttachments.SequenceEqual(other.MediaAttachments)
                ) && 
                (
                    Mentions == other.Mentions ||
                    Mentions != null &&
                    Mentions.SequenceEqual(other.Mentions)
                ) && 
                (
                    Muted == other.Muted ||
                    Muted != null &&
                    Muted.Equals(other.Muted)
                ) && 
                (
                    Pinned == other.Pinned ||
                    Pinned != null &&
                    Pinned.Equals(other.Pinned)
                ) && 
                (
                    Poll == other.Poll ||
                    Poll != null &&
                    Poll.Equals(other.Poll)
                ) && 
                (
                    Reblog == other.Reblog ||
                    Reblog != null &&
                    Reblog.Equals(other.Reblog)
                ) && 
                (
                    Reblogged == other.Reblogged ||
                    Reblogged != null &&
                    Reblogged.Equals(other.Reblogged)
                ) && 
                (
                    ReblogsCount == other.ReblogsCount ||
                    ReblogsCount != null &&
                    ReblogsCount.Equals(other.ReblogsCount)
                ) && 
                (
                    RepliesCount == other.RepliesCount ||
                    RepliesCount != null &&
                    RepliesCount.Equals(other.RepliesCount)
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
                    Tags == other.Tags ||
                    Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Uri == other.Uri ||
                    Uri != null &&
                    Uri.Equals(other.Uri)
                ) && 
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
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
                    if (Account != null)
                    hashCode = hashCode * 59 + Account.GetHashCode();
                    if (Application != null)
                    hashCode = hashCode * 59 + Application.GetHashCode();
                    if (Bookmarked != null)
                    hashCode = hashCode * 59 + Bookmarked.GetHashCode();
                    if (Card != null)
                    hashCode = hashCode * 59 + Card.GetHashCode();
                    if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    if (Emojis != null)
                    hashCode = hashCode * 59 + Emojis.GetHashCode();
                    if (Favourited != null)
                    hashCode = hashCode * 59 + Favourited.GetHashCode();
                    if (FavouritesCount != null)
                    hashCode = hashCode * 59 + FavouritesCount.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (InReplyToAccountId != null)
                    hashCode = hashCode * 59 + InReplyToAccountId.GetHashCode();
                    if (InReplyToId != null)
                    hashCode = hashCode * 59 + InReplyToId.GetHashCode();
                    if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
                    if (MediaAttachments != null)
                    hashCode = hashCode * 59 + MediaAttachments.GetHashCode();
                    if (Mentions != null)
                    hashCode = hashCode * 59 + Mentions.GetHashCode();
                    if (Muted != null)
                    hashCode = hashCode * 59 + Muted.GetHashCode();
                    if (Pinned != null)
                    hashCode = hashCode * 59 + Pinned.GetHashCode();
                    if (Poll != null)
                    hashCode = hashCode * 59 + Poll.GetHashCode();
                    if (Reblog != null)
                    hashCode = hashCode * 59 + Reblog.GetHashCode();
                    if (Reblogged != null)
                    hashCode = hashCode * 59 + Reblogged.GetHashCode();
                    if (ReblogsCount != null)
                    hashCode = hashCode * 59 + ReblogsCount.GetHashCode();
                    if (RepliesCount != null)
                    hashCode = hashCode * 59 + RepliesCount.GetHashCode();
                    if (Sensitive != null)
                    hashCode = hashCode * 59 + Sensitive.GetHashCode();
                    if (SpoilerText != null)
                    hashCode = hashCode * 59 + SpoilerText.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (Uri != null)
                    hashCode = hashCode * 59 + Uri.GetHashCode();
                    if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                    if (Visibility != null)
                    hashCode = hashCode * 59 + Visibility.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Status left, Status right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Status left, Status right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
