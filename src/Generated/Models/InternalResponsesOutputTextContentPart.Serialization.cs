// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalResponsesOutputTextContentPart : IJsonModel<InternalResponsesOutputTextContentPart>
    {
        internal InternalResponsesOutputTextContentPart()
        {
        }

        void IJsonModel<InternalResponsesOutputTextContentPart>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesOutputTextContentPart>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesOutputTextContentPart)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("annotations") != true)
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (ResponseMessageAnnotation item in Annotations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (_additionalBinaryDataProperties?.ContainsKey("text") != true)
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(InternalText);
            }
        }

        InternalResponsesOutputTextContentPart IJsonModel<InternalResponsesOutputTextContentPart>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalResponsesOutputTextContentPart)JsonModelCreateCore(ref reader, options);

        protected override ResponseContentPart JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesOutputTextContentPart>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesOutputTextContentPart)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponsesOutputTextContentPart(document.RootElement, options);
        }

        internal static InternalResponsesOutputTextContentPart DeserializeInternalResponsesOutputTextContentPart(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalResponsesContentType internalType = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            IList<ResponseMessageAnnotation> annotations = default;
            string internalText = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    internalType = new InternalResponsesContentType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("annotations"u8))
                {
                    List<ResponseMessageAnnotation> array = new List<ResponseMessageAnnotation>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ResponseMessageAnnotation.DeserializeResponseMessageAnnotation(item, options));
                    }
                    annotations = array;
                    continue;
                }
                if (prop.NameEquals("text"u8))
                {
                    internalText = prop.Value.GetString();
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalResponsesOutputTextContentPart(internalType, additionalBinaryDataProperties, annotations, internalText);
        }

        BinaryData IPersistableModel<InternalResponsesOutputTextContentPart>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesOutputTextContentPart>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesOutputTextContentPart)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponsesOutputTextContentPart IPersistableModel<InternalResponsesOutputTextContentPart>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalResponsesOutputTextContentPart)PersistableModelCreateCore(data, options);

        protected override ResponseContentPart PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesOutputTextContentPart>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponsesOutputTextContentPart(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesOutputTextContentPart)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponsesOutputTextContentPart>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalResponsesOutputTextContentPart internalResponsesOutputTextContentPart)
        {
            if (internalResponsesOutputTextContentPart == null)
            {
                return null;
            }
            return BinaryContent.Create(internalResponsesOutputTextContentPart, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalResponsesOutputTextContentPart(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalResponsesOutputTextContentPart(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
