// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Batch
{
    internal readonly partial struct InternalBatchErrorsObject : IEquatable<InternalBatchErrorsObject>
    {
        private readonly string _value;
        private const string ListValue = "list";

        public InternalBatchErrorsObject(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalBatchErrorsObject List { get; } = new InternalBatchErrorsObject(ListValue);

        public static bool operator ==(InternalBatchErrorsObject left, InternalBatchErrorsObject right) => left.Equals(right);

        public static bool operator !=(InternalBatchErrorsObject left, InternalBatchErrorsObject right) => !left.Equals(right);

        public static implicit operator InternalBatchErrorsObject(string value) => new InternalBatchErrorsObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalBatchErrorsObject other && Equals(other);

        public bool Equals(InternalBatchErrorsObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
