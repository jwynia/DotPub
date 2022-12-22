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
    public partial class Emoji : IEquatable<Emoji>
    { 
        /// <summary>
        /// Used for sorting custom emoji in the picker.
        /// </summary>
        /// <value>Used for sorting custom emoji in the picker.</value>

        [DataMember(Name="category")]
        public string Category { get; set; }

        /// <summary>
        /// The name of the custom emoji.
        /// </summary>
        /// <value>The name of the custom emoji.</value>

        [DataMember(Name="shortcode")]
        public string Shortcode { get; set; }

        /// <summary>
        /// A link to a static copy of the custom emoji.
        /// </summary>
        /// <value>A link to a static copy of the custom emoji.</value>

        [DataMember(Name="static_url")]
        public string StaticUrl { get; set; }

        /// <summary>
        /// Web URL of the custom emoji.
        /// </summary>
        /// <value>Web URL of the custom emoji.</value>

        [DataMember(Name="url")]
        public string Url { get; set; }

        /// <summary>
        /// Emoji is visible in the emoji picker of the instance.
        /// </summary>
        /// <value>Emoji is visible in the emoji picker of the instance.</value>

        [DataMember(Name="visible_in_picker")]
        public bool? VisibleInPicker { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Emoji {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Shortcode: ").Append(Shortcode).Append("\n");
            sb.Append("  StaticUrl: ").Append(StaticUrl).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  VisibleInPicker: ").Append(VisibleInPicker).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Emoji)obj);
        }

        /// <summary>
        /// Returns true if Emoji instances are equal
        /// </summary>
        /// <param name="other">Instance of Emoji to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Emoji other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.Equals(other.Category)
                ) && 
                (
                    Shortcode == other.Shortcode ||
                    Shortcode != null &&
                    Shortcode.Equals(other.Shortcode)
                ) && 
                (
                    StaticUrl == other.StaticUrl ||
                    StaticUrl != null &&
                    StaticUrl.Equals(other.StaticUrl)
                ) && 
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) && 
                (
                    VisibleInPicker == other.VisibleInPicker ||
                    VisibleInPicker != null &&
                    VisibleInPicker.Equals(other.VisibleInPicker)
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
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (Shortcode != null)
                    hashCode = hashCode * 59 + Shortcode.GetHashCode();
                    if (StaticUrl != null)
                    hashCode = hashCode * 59 + StaticUrl.GetHashCode();
                    if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                    if (VisibleInPicker != null)
                    hashCode = hashCode * 59 + VisibleInPicker.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Emoji left, Emoji right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Emoji left, Emoji right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
