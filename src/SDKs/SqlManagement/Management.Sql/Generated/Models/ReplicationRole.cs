// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ReplicationRole.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReplicationRole
    {
        [EnumMember(Value = "Primary")]
        Primary,
        [EnumMember(Value = "Secondary")]
        Secondary,
        [EnumMember(Value = "NonReadableSecondary")]
        NonReadableSecondary,
        [EnumMember(Value = "Source")]
        Source,
        [EnumMember(Value = "Copy")]
        Copy
    }
    internal static class ReplicationRoleEnumExtension
    {
        internal static string ToSerializedValue(this ReplicationRole? value)  =>
            value == null ? null : ((ReplicationRole)value).ToSerializedValue();

        internal static string ToSerializedValue(this ReplicationRole value)
        {
            switch( value )
            {
                case ReplicationRole.Primary:
                    return "Primary";
                case ReplicationRole.Secondary:
                    return "Secondary";
                case ReplicationRole.NonReadableSecondary:
                    return "NonReadableSecondary";
                case ReplicationRole.Source:
                    return "Source";
                case ReplicationRole.Copy:
                    return "Copy";
            }
            return null;
        }

        internal static ReplicationRole? ParseReplicationRole(this string value)
        {
            switch( value )
            {
                case "Primary":
                    return ReplicationRole.Primary;
                case "Secondary":
                    return ReplicationRole.Secondary;
                case "NonReadableSecondary":
                    return ReplicationRole.NonReadableSecondary;
                case "Source":
                    return ReplicationRole.Source;
                case "Copy":
                    return ReplicationRole.Copy;
            }
            return null;
        }
    }
}
