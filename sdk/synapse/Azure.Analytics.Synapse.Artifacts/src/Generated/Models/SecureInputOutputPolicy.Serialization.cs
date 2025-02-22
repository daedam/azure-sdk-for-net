// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SecureInputOutputPolicyConverter))]
    public partial class SecureInputOutputPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SecureInput))
            {
                writer.WritePropertyName("secureInput"u8);
                writer.WriteBooleanValue(SecureInput.Value);
            }
            if (Optional.IsDefined(SecureOutput))
            {
                writer.WritePropertyName("secureOutput"u8);
                writer.WriteBooleanValue(SecureOutput.Value);
            }
            writer.WriteEndObject();
        }

        internal static SecureInputOutputPolicy DeserializeSecureInputOutputPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> secureInput = default;
            Optional<bool> secureOutput = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secureInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secureInput = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("secureOutput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secureOutput = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SecureInputOutputPolicy(Optional.ToNullable(secureInput), Optional.ToNullable(secureOutput));
        }

        internal partial class SecureInputOutputPolicyConverter : JsonConverter<SecureInputOutputPolicy>
        {
            public override void Write(Utf8JsonWriter writer, SecureInputOutputPolicy model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SecureInputOutputPolicy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSecureInputOutputPolicy(document.RootElement);
            }
        }
    }
}
