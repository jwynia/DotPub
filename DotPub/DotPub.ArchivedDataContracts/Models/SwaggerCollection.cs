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
    public partial class SwaggerCollection : IEquatable<SwaggerCollection>
    {
        /// <summary>
        /// ActivityStreams context.
        /// </summary>
        /// <value>ActivityStreams context.</value>

        [DataMember(Name = "@context")]
        public string Context { get; set; }

        /// <summary>
        /// Gets or Sets First
        /// </summary>

        [DataMember(Name = "first")]
        public SwaggerCollectionPage First { get; set; }

        /// <summary>
        /// ActivityStreams ID.
        /// </summary>
        /// <value>ActivityStreams ID.</value>

        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>

        [DataMember(Name = "last")]
        public SwaggerCollectionPage Last { get; set; }

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
            sb.Append("class SwaggerCollection {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SwaggerCollection)obj);
        }

        /// <summary>
        /// Returns true if SwaggerCollection instances are equal
        /// </summary>
        /// <param name="other">Instance of SwaggerCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwaggerCollection other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Context == other.Context ||
                    Context != null &&
                    Context.Equals(other.Context)
                ) &&
                (
                    First == other.First ||
                    First != null &&
                    First.Equals(other.First)
                ) &&
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) &&
                (
                    Last == other.Last ||
                    Last != null &&
                    Last.Equals(other.Last)
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
                if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                if (First != null)
                    hashCode = hashCode * 59 + First.GetHashCode();
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Last != null)
                    hashCode = hashCode * 59 + Last.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(SwaggerCollection left, SwaggerCollection right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SwaggerCollection left, SwaggerCollection right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}