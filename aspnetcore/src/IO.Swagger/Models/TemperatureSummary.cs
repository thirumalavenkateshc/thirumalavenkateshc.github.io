/*
 * Sample IoT APIs
 *
 * These are public domain APIs, currently used for demo purpose.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// ok
    /// </summary>
    [DataContract]
    public partial class TemperatureSummary : IEquatable<TemperatureSummary>
    { 
        /// <summary>
        /// Gets or Sets Zones
        /// </summary>
        [DataMember(Name="zones")]
        public List<TemperatureZone> Zones { get; set; }

        /// <summary>
        /// Gets or Sets ZoneStatus
        /// </summary>
        [DataMember(Name="zoneStatus")]
        public List<TemperatueZoneStatus> ZoneStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemperatureSummary {\n");
            sb.Append("  Zones: ").Append(Zones).Append("\n");
            sb.Append("  ZoneStatus: ").Append(ZoneStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
            return obj.GetType() == GetType() && Equals((TemperatureSummary)obj);
        }

        /// <summary>
        /// Returns true if TemperatureSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of TemperatureSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemperatureSummary other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Zones == other.Zones ||
                    Zones != null &&
                    Zones.SequenceEqual(other.Zones)
                ) && 
                (
                    ZoneStatus == other.ZoneStatus ||
                    ZoneStatus != null &&
                    ZoneStatus.SequenceEqual(other.ZoneStatus)
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
                    if (Zones != null)
                    hashCode = hashCode * 59 + Zones.GetHashCode();
                    if (ZoneStatus != null)
                    hashCode = hashCode * 59 + ZoneStatus.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TemperatureSummary left, TemperatureSummary right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TemperatureSummary left, TemperatureSummary right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
