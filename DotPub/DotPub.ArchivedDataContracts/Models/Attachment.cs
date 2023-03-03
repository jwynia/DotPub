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
    public partial class Attachment : IEquatable<Attachment>
    {
        /// <summary>
        /// A hash computed by the BlurHash algorithm, for generating colorful preview thumbnails when media has not been downloaded yet. See https://github.com/woltapp/blurhash
        /// </summary>
        /// <value>A hash computed by the BlurHash algorithm, for generating colorful preview thumbnails when media has not been downloaded yet. See https://github.com/woltapp/blurhash</value>

        [DataMember(Name = "blurhash")]
        public string Blurhash { get; set; }

        /// <summary>
        /// Alt text that describes what is in the media attachment.
        /// </summary>
        /// <value>Alt text that describes what is in the media attachment.</value>

        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the attachment.
        /// </summary>
        /// <value>The ID of the attachment.</value>

        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>

        [DataMember(Name = "meta")]
        public MediaMeta Meta { get; set; }

        /// <summary>
        /// The location of a scaled-down preview of the attachment on the remote server. Only defined for instances other than our own.
        /// </summary>
        /// <value>The location of a scaled-down preview of the attachment on the remote server. Only defined for instances other than our own.</value>

        [DataMember(Name = "preview_remote_url")]
        public string PreviewRemoteUrl { get; set; }

        /// <summary>
        /// The location of a scaled-down preview of the attachment.
        /// </summary>
        /// <value>The location of a scaled-down preview of the attachment.</value>

        [DataMember(Name = "preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// The location of the full-size original attachment on the remote server. Only defined for instances other than our own.
        /// </summary>
        /// <value>The location of the full-size original attachment on the remote server. Only defined for instances other than our own.</value>

        [DataMember(Name = "remote_url")]
        public string RemoteUrl { get; set; }

        /// <summary>
        /// A shorter URL for the attachment. In our case, we just give the URL again since we don&#39;t create smaller URLs.
        /// </summary>
        /// <value>A shorter URL for the attachment. In our case, we just give the URL again since we don&#39;t create smaller URLs.</value>

        [DataMember(Name = "text_url")]
        public string TextUrl { get; set; }

        /// <summary>
        /// The type of the attachment.
        /// </summary>
        /// <value>The type of the attachment.</value>

        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The location of the original full-size attachment.
        /// </summary>
        /// <value>The location of the original full-size attachment.</value>

        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  Blurhash: ").Append(Blurhash).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  PreviewRemoteUrl: ").Append(PreviewRemoteUrl).Append("\n");
            sb.Append("  PreviewUrl: ").Append(PreviewUrl).Append("\n");
            sb.Append("  RemoteUrl: ").Append(RemoteUrl).Append("\n");
            sb.Append("  TextUrl: ").Append(TextUrl).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Attachment)obj);
        }

        /// <summary>
        /// Returns true if Attachment instances are equal
        /// </summary>
        /// <param name="other">Instance of Attachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attachment other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
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
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) &&
                (
                    Meta == other.Meta ||
                    Meta != null &&
                    Meta.Equals(other.Meta)
                ) &&
                (
                    PreviewRemoteUrl == other.PreviewRemoteUrl ||
                    PreviewRemoteUrl != null &&
                    PreviewRemoteUrl.Equals(other.PreviewRemoteUrl)
                ) &&
                (
                    PreviewUrl == other.PreviewUrl ||
                    PreviewUrl != null &&
                    PreviewUrl.Equals(other.PreviewUrl)
                ) &&
                (
                    RemoteUrl == other.RemoteUrl ||
                    RemoteUrl != null &&
                    RemoteUrl.Equals(other.RemoteUrl)
                ) &&
                (
                    TextUrl == other.TextUrl ||
                    TextUrl != null &&
                    TextUrl.Equals(other.TextUrl)
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
                if (Blurhash != null)
                    hashCode = hashCode * 59 + Blurhash.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Meta != null)
                    hashCode = hashCode * 59 + Meta.GetHashCode();
                if (PreviewRemoteUrl != null)
                    hashCode = hashCode * 59 + PreviewRemoteUrl.GetHashCode();
                if (PreviewUrl != null)
                    hashCode = hashCode * 59 + PreviewUrl.GetHashCode();
                if (RemoteUrl != null)
                    hashCode = hashCode * 59 + RemoteUrl.GetHashCode();
                if (TextUrl != null)
                    hashCode = hashCode * 59 + TextUrl.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(Attachment left, Attachment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Attachment left, Attachment right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}