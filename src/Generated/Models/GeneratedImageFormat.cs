// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Images
{
    public readonly partial struct GeneratedImageFormat : IEquatable<GeneratedImageFormat>
    {
        private readonly string _value;
        private const string UrlValue = "url";
        private const string B64JsonValue = "b64_json";

        public GeneratedImageFormat(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static bool operator ==(GeneratedImageFormat left, GeneratedImageFormat right) => left.Equals(right);

        public static bool operator !=(GeneratedImageFormat left, GeneratedImageFormat right) => !left.Equals(right);

        public static implicit operator GeneratedImageFormat(string value) => new GeneratedImageFormat(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GeneratedImageFormat other && Equals(other);

        public bool Equals(GeneratedImageFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
