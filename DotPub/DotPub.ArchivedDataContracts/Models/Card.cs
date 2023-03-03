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
    public partial class Card : IEquatable<Card>
    {
        /// <summary>
        /// The author of the original resource.
        /// </summary>
        /// <value>The author of the original resource.</value>

        [DataMember(Name = "author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// A link to the author of the original resource.
        /// </summary>
        /// <value>A link to the author of the original resource.</value>

        [DataMember(Name = "author_url")]
        public string AuthorUrl { get; set; }

        /// <summary>
        /// A hash computed by the BlurHash algorithm, for generating colorful preview thumbnails when media has not been downloaded yet.
        /// </summary>
        /// <value>A hash computed by the BlurHash algorithm, for generating colorful preview thumbnails when media has not been downloaded yet.</value>

        [DataMember(Name = "blurhash")]
        public string Blurhash { get; set; }

        /// <summary>
        /// Description of preview.
        /// </summary>
        /// <value>Description of preview.</value>

        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Used for photo embeds, instead of custom html.
        /// </summary>
        /// <value>Used for photo embeds, instead of custom html.</value>

        [DataMember(Name = "embed_url")]
        public string EmbedUrl { get; set; }

        /// <summary>
        /// Height of preview, in pixels.
        /// </summary>
        /// <value>Height of preview, in pixels.</value>

        [DataMember(Name = "height")]
        public long? Height { get; set; }

        /// <summary>
        /// HTML to be used for generating the preview card.
        /// </summary>
        /// <value>HTML to be used for generating the preview card.</value>

        [DataMember(Name = "html")]
        public string Html { get; set; }

        /// <summary>
        /// Preview thumbnail.
        /// </summary>
        /// <value>Preview thumbnail.</value>

        [DataMember(Name = "image")]
        public string Image { get; set; }

        /// <summary>
        /// The provider of the original resource.
        /// </summary>
        /// <value>The provider of the original resource.</value>

        [DataMember(Name = "provider_name")]
        public string ProviderName { get; set; }

        /// <summary>
        /// A link to the provider of the original resource.
        /// </summary>
        /// <value>A link to the provider of the original resource.</value>

        [DataMember(Name = "provider_url")]
        public string ProviderUrl { get; set; }

        /// <summary>
        /// Title of linked resource.
        /// </summary>
        /// <value>Title of linked resource.</value>

        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The type of the preview card.
        /// </summary>
        /// <value>The type of the preview card.</value>

        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Location of linked resource.
        /// </summary>
        /// <value>Location of linked resource.</value>

        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Width of preview, in pixels.
        /// </summary>
        /// <value>Width of preview, in pixels.</value>

        [DataMember(Name = "width")]
        public long? Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  AuthorUrl: ").Append(AuthorUrl).Append("\n");
            sb.Append("  Blurhash: ").Append(Blurhash).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EmbedUrl: ").Append(EmbedUrl).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  ProviderUrl: ").Append(ProviderUrl).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Card)obj);
        }

        /// <summary>
        /// Returns true if Card instances are equal
        /// </summary>
        /// <param name="other">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Card other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    AuthorName == other.AuthorName ||
                    AuthorName != null &&
                    AuthorName.Equals(other.AuthorName)
                ) &&
                (
                    AuthorUrl == other.AuthorUrl ||
                    AuthorUrl != null &&
                    AuthorUrl.Equals(other.AuthorUrl)
                ) &&
                (
                    Blurhash == other.Blurhash ||
                    Blurhash != null &&
                    Blurhash.Equals(other.Blurhash)
                ) &&
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) &&
                (
                    EmbedUrl == other.EmbedUrl ||
                    EmbedUrl != null &&
                    EmbedUrl.Equals(other.EmbedUrl)
                ) &&
                (
                    Height == other.Height ||
                    Height != null &&
                    Height.Equals(other.Height)
                ) &&
                (
                    Html == other.Html ||
                    Html != null &&
                    Html.Equals(other.Html)
                ) &&
                (
                    Image == other.Image ||
                    Image != null &&
                    Image.Equals(other.Image)
                ) &&
                (
                    ProviderName == other.ProviderName ||
                    ProviderName != null &&
                    ProviderName.Equals(other.ProviderName)
                ) &&
                (
                    ProviderUrl == other.ProviderUrl ||
                    ProviderUrl != null &&
                    ProviderUrl.Equals(other.ProviderUrl)
                ) &&
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) &&
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) &&
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) &&
                (
                    Width == other.Width ||
                    Width != null &&
                    Width.Equals(other.Width)
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
                if (AuthorName != null)
                    hashCode = hashCode * 59 + AuthorName.GetHashCode();
                if (AuthorUrl != null)
                    hashCode = hashCode * 59 + AuthorUrl.GetHashCode();
                if (Blurhash != null)
                    hashCode = hashCode * 59 + Blurhash.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (EmbedUrl != null)
                    hashCode = hashCode * 59 + EmbedUrl.GetHashCode();
                if (Height != null)
                    hashCode = hashCode * 59 + Height.GetHashCode();
                if (Html != null)
                    hashCode = hashCode * 59 + Html.GetHashCode();
                if (Image != null)
                    hashCode = hashCode * 59 + Image.GetHashCode();
                if (ProviderName != null)
                    hashCode = hashCode * 59 + ProviderName.GetHashCode();
                if (ProviderUrl != null)
                    hashCode = hashCode * 59 + ProviderUrl.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                if (Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(Card left, Card right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Card left, Card right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}