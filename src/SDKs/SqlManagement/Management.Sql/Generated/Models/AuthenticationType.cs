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
    /// Defines values for AuthenticationType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthenticationType
    {
        [EnumMember(Value = "SQL")]
        SQL,
        [EnumMember(Value = "ADPassword")]
        ADPassword
    }
    internal static class AuthenticationTypeEnumExtension
    {
        internal static string ToSerializedValue(this AuthenticationType? value)  =>
            value == null ? null : ((AuthenticationType)value).ToSerializedValue();

        internal static string ToSerializedValue(this AuthenticationType value)
        {
            switch( value )
            {
                case AuthenticationType.SQL:
                    return "SQL";
                case AuthenticationType.ADPassword:
                    return "ADPassword";
            }
            return null;
        }

        internal static AuthenticationType? ParseAuthenticationType(this string value)
        {
            switch( value )
            {
                case "SQL":
                    return AuthenticationType.SQL;
                case "ADPassword":
                    return AuthenticationType.ADPassword;
            }
            return null;
        }
    }
}
