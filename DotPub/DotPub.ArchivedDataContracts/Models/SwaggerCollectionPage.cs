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
    public partial class SwaggerCollectionPage : IEquatable<SwaggerCollectionPage>
    {
        /// <summary>
        /// ActivityStreams ID.
        /// </summary>
        /// <value>ActivityStreams ID.</value>

        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Items on this page.
        /// </summary>
        /// <value>Items on this page.</value>

        [DataMember(Name = "items")]
        public List<string> Items { get; set; }

        /// <summary>
        /// Link to the next page.
        /// </summary>
        /// <value>Link to the next page.</value>

        [DataMember(Name = "next")]
        public string Next { get; set; }

        /// <summary>
        /// Collection this page belongs to.
        /// </summary>
        /// <value>Collection this page belongs to.</value>

        [DataMember(Name = "partOf")]
        public string PartOf { get; set; }

        /// <summary>
        /// ActivityStreams type.
        /// </summary>
        /// <value>ActivityStreams type.</value>

        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwaggerCollectionPage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  PartOf: ").Append(PartOf).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SwaggerCollectionPage)obj);
        }

        /// <summary>
        /// Returns true if SwaggerCollectionPage instances are equal
        /// </summary>
        /// <param name="other">Instance of SwaggerCollectionPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwaggerCollectionPage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) &&
                (
                    Items == other.Items ||
                    Items != null &&
                    Items.SequenceEqual(other.Items)
                ) &&
                (
                    Next == other.Next ||
                    Next != null &&
                    Next.Equals(other.Next)
                ) &&
                (
                    PartOf == other.PartOf ||
                    PartOf != null &&
                    PartOf.Equals(other.PartOf)
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                if (Next != null)
                    hashCode = hashCode * 59 + Next.GetHashCode();
                if (PartOf != null)
                    hashCode = hashCode * 59 + PartOf.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(SwaggerCollectionPage left, SwaggerCollectionPage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SwaggerCollectionPage left, SwaggerCollectionPage right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}