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
    /// This can be metadata about an image, an audio file, video, etc.
    /// </summary>
    [DataContract]
    public partial class MediaMeta : IEquatable<MediaMeta>
    {
        /// <summary>
        /// Aspect ratio of the media. Equal to width / height.
        /// </summary>
        /// <value>Aspect ratio of the media. Equal to width / height.</value>

        [DataMember(Name = "aspect")]
        public float? Aspect { get; set; }

        /// <summary>
        /// Gets or Sets AudioBitrate
        /// </summary>

        [DataMember(Name = "audio_bitrate")]
        public string AudioBitrate { get; set; }

        /// <summary>
        /// Gets or Sets AudioChannels
        /// </summary>

        [DataMember(Name = "audio_channels")]
        public string AudioChannels { get; set; }

        /// <summary>
        /// Gets or Sets AudioEncode
        /// </summary>

        [DataMember(Name = "audio_encode")]
        public string AudioEncode { get; set; }

        /// <summary>
        /// Duration of the media in seconds. Only set for video and audio.
        /// </summary>
        /// <value>Duration of the media in seconds. Only set for video and audio.</value>

        [DataMember(Name = "duration")]
        public float? Duration { get; set; }

        /// <summary>
        /// Gets or Sets Focus
        /// </summary>

        [DataMember(Name = "focus")]
        public MediaFocus Focus { get; set; }

        /// <summary>
        /// Framerate of the media. Only set for video and gifs.
        /// </summary>
        /// <value>Framerate of the media. Only set for video and gifs.</value>

        [DataMember(Name = "fps")]
        public int? Fps { get; set; }

        /// <summary>
        /// Height of the media in pixels. Not set for audio.
        /// </summary>
        /// <value>Height of the media in pixels. Not set for audio.</value>

        [DataMember(Name = "height")]
        public long? Height { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>

        [DataMember(Name = "length")]
        public string Length { get; set; }

        /// <summary>
        /// Gets or Sets Original
        /// </summary>

        [DataMember(Name = "original")]
        public MediaDimensions Original { get; set; }

        /// <summary>
        /// Size of the media, in the format &#x60;[width]x[height]&#x60;. Not set for audio.
        /// </summary>
        /// <value>Size of the media, in the format &#x60;[width]x[height]&#x60;. Not set for audio.</value>

        [DataMember(Name = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets or Sets Small
        /// </summary>

        [DataMember(Name = "small")]
        public MediaDimensions Small { get; set; }

        /// <summary>
        /// Width of the media in pixels. Not set for audio.
        /// </summary>
        /// <value>Width of the media in pixels. Not set for audio.</value>

        [DataMember(Name = "width")]
        public long? Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaMeta {\n");
            sb.Append("  Aspect: ").Append(Aspect).Append("\n");
            sb.Append("  AudioBitrate: ").Append(AudioBitrate).Append("\n");
            sb.Append("  AudioChannels: ").Append(AudioChannels).Append("\n");
            sb.Append("  AudioEncode: ").Append(AudioEncode).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Focus: ").Append(Focus).Append("\n");
            sb.Append("  Fps: ").Append(Fps).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MediaMeta)obj);
        }

        /// <summary>
        /// Returns true if MediaMeta instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaMeta other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Aspect == other.Aspect ||
                    Aspect != null &&
                    Aspect.Equals(other.Aspect)
                ) &&
                (
                    AudioBitrate == other.AudioBitrate ||
                    AudioBitrate != null &&
                    AudioBitrate.Equals(other.AudioBitrate)
                ) &&
                (
                    AudioChannels == other.AudioChannels ||
                    AudioChannels != null &&
                    AudioChannels.Equals(other.AudioChannels)
                ) &&
                (
                    AudioEncode == other.AudioEncode ||
                    AudioEncode != null &&
                    AudioEncode.Equals(other.AudioEncode)
                ) &&
                (
                    Duration == other.Duration ||
                    Duration != null &&
                    Duration.Equals(other.Duration)
                ) &&
                (
                    Focus == other.Focus ||
                    Focus != null &&
                    Focus.Equals(other.Focus)
                ) &&
                (
                    Fps == other.Fps ||
                    Fps != null &&
                    Fps.Equals(other.Fps)
                ) &&
                (
                    Height == other.Height ||
                    Height != null &&
                    Height.Equals(other.Height)
                ) &&
                (
                    Length == other.Length ||
                    Length != null &&
                    Length.Equals(other.Length)
                ) &&
                (
                    Original == other.Original ||
                    Original != null &&
                    Original.Equals(other.Original)
                ) &&
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                ) &&
                (
                    Small == other.Small ||
                    Small != null &&
                    Small.Equals(other.Small)
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
                if (Aspect != null)
                    hashCode = hashCode * 59 + Aspect.GetHashCode();
                if (AudioBitrate != null)
                    hashCode = hashCode * 59 + AudioBitrate.GetHashCode();
                if (AudioChannels != null)
                    hashCode = hashCode * 59 + AudioChannels.GetHashCode();
                if (AudioEncode != null)
                    hashCode = hashCode * 59 + AudioEncode.GetHashCode();
                if (Duration != null)
                    hashCode = hashCode * 59 + Duration.GetHashCode();
                if (Focus != null)
                    hashCode = hashCode * 59 + Focus.GetHashCode();
                if (Fps != null)
                    hashCode = hashCode * 59 + Fps.GetHashCode();
                if (Height != null)
                    hashCode = hashCode * 59 + Height.GetHashCode();
                if (Length != null)
                    hashCode = hashCode * 59 + Length.GetHashCode();
                if (Original != null)
                    hashCode = hashCode * 59 + Original.GetHashCode();
                if (Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();
                if (Small != null)
                    hashCode = hashCode * 59 + Small.GetHashCode();
                if (Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(MediaMeta left, MediaMeta right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MediaMeta left, MediaMeta right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}