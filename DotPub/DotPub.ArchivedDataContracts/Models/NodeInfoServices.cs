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
    public partial class NodeInfoServices : IEquatable<NodeInfoServices>
    {
        /// <summary>
        /// Gets or Sets Inbound
        /// </summary>

        [DataMember(Name = "inbound")]
        public List<string> Inbound { get; set; }

        /// <summary>
        /// Gets or Sets Outbound
        /// </summary>

        [DataMember(Name = "outbound")]
        public List<string> Outbound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeInfoServices {\n");
            sb.Append("  Inbound: ").Append(Inbound).Append("\n");
            sb.Append("  Outbound: ").Append(Outbound).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NodeInfoServices)obj);
        }

        /// <summary>
        /// Returns true if NodeInfoServices instances are equal
        /// </summary>
        /// <param name="other">Instance of NodeInfoServices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeInfoServices other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Inbound == other.Inbound ||
                    Inbound != null &&
                    Inbound.SequenceEqual(other.Inbound)
                ) &&
                (
                    Outbound == other.Outbound ||
                    Outbound != null &&
                    Outbound.SequenceEqual(other.Outbound)
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
                if (Inbound != null)
                    hashCode = hashCode * 59 + Inbound.GetHashCode();
                if (Outbound != null)
                    hashCode = hashCode * 59 + Outbound.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(NodeInfoServices left, NodeInfoServices right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NodeInfoServices left, NodeInfoServices right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}