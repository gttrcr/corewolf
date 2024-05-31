namespace CoreWolf.Types
{
    public class String
    {
        public string? Value { get; protected set; }

        public String()
        {
            Value = null;
        }

        public String(string value)
        {
            Value = value;
        }

        public static implicit operator String(string value)
        {
            return new String(value);
        }

        public override string? ToString()
        {
            return Value;
        }
    }

    public class ZeroString : String
    {
        public ZeroString()
        {
            Value = "0";
        }

        public ZeroString(string value) : base(value)
        {

        }

        public static implicit operator ZeroString(string value)
        {
            return new ZeroString(value);
        }

        public static implicit operator string(ZeroString value)
        {
            return value.Value ?? "0";
        }

        public override string ToString()
        {
            return Value ?? "0";
        }
    }

    public class EmptyString : String
    {
        public EmptyString()
        {
            Value = string.Empty;
        }

        public EmptyString(string value) : base(value)
        {

        }

        public static implicit operator string(EmptyString value)
        {
            return value.Value ?? string.Empty;
        }

        public override string ToString()
        {
            return Value ?? string.Empty;
        }
    }
}