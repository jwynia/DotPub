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
    public partial class EmojiUpdateRequest : IEquatable<EmojiUpdateRequest>
    { 
        /// <summary>
        /// Category in which to place the emoji.
        /// </summary>
        /// <value>Category in which to place the emoji.</value>

        [DataMember(Name="CategoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// Image file to use for the emoji. Must be png or gif and no larger than 50kb.
        /// </summary>
        /// <value>Image file to use for the emoji. Must be png or gif and no larger than 50kb.</value>

        [DataMember(Name="Image")]
        public Object Image { get; set; }

        /// <summary>
        /// Desired shortcode for the emoji, without surrounding colons. This must be unique for the domain.
        /// </summary>
        /// <value>Desired shortcode for the emoji, without surrounding colons. This must be unique for the domain.</value>

        [DataMember(Name="Shortcode")]
        public string Shortcode { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>

        [DataMember(Name="type")]
        public EmojiUpdateType Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmojiUpdateRequest {\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Shortcode: ").Append(Shortcode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EmojiUpdateRequest)obj);
        }

        /// <summary>
        /// Returns true if EmojiUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EmojiUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmojiUpdateRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CategoryName == other.CategoryName ||
                    CategoryName != null &&
                    CategoryName.Equals(other.CategoryName)
                ) && 
                (
                    Image == other.Image ||
                    Image != null &&
                    Image.Equals(other.Image)
                ) && 
                (
                    Shortcode == other.Shortcode ||
                    Shortcode != null &&
                    Shortcode.Equals(other.Shortcode)
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
                    if (CategoryName != null)
                    hashCode = hashCode * 59 + CategoryName.GetHashCode();
                    if (Image != null)
                    hashCode = hashCode * 59 + Image.GetHashCode();
                    if (Shortcode != null)
                    hashCode = hashCode * 59 + Shortcode.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EmojiUpdateRequest left, EmojiUpdateRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EmojiUpdateRequest left, EmojiUpdateRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}