namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>imageInfo</summary>
    public partial class MicrosoftGraphImageInfo
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Sample.API.Runtime.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Sample.API.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Sample.API.Runtime.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Sample.API.Runtime.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Sample.API.Runtime.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IMicrosoftGraphImageInfo.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IMicrosoftGraphImageInfo.</returns>
        public static Sample.API.Models.IMicrosoftGraphImageInfo FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new MicrosoftGraphImageInfo(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphImageInfo" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MicrosoftGraphImageInfo(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_addImageQuery = If( json?.PropertyT<Sample.API.Runtime.Json.JsonBoolean>("addImageQuery"), out var __jsonAddImageQuery) ? (bool?)__jsonAddImageQuery : AddImageQuery;}
            {_alternateText = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("alternateText"), out var __jsonAlternateText) ? (string)__jsonAlternateText : (string)AlternateText;}
            {_alternativeText = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("alternativeText"), out var __jsonAlternativeText) ? (string)__jsonAlternativeText : (string)AlternativeText;}
            {_iconUrl = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("iconUrl"), out var __jsonIconUrl) ? (string)__jsonIconUrl : (string)IconUrl;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphImageInfo" /> into a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphImageInfo" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </returns>
        public Sample.API.Runtime.Json.JsonNode ToJson(Sample.API.Runtime.Json.JsonObject container, Sample.API.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Sample.API.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != AddImageQuery ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonBoolean((bool)AddImageQuery) : null, "addImageQuery" ,container.Add );
            AddIf( null != (((object)AlternateText)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AlternateText.ToString()) : null, "alternateText" ,container.Add );
            AddIf( null != (((object)AlternativeText)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(AlternativeText.ToString()) : null, "alternativeText" ,container.Add );
            AddIf( null != (((object)IconUrl)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(IconUrl.ToString()) : null, "iconUrl" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}