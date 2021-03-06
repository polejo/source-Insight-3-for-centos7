public class StringComparison : Enum, IComparable, IFormattable, IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(IFormatProvider provider) {}
	public virtual TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public StringComparison CurrentCulture;
	public StringComparison CurrentCultureIgnoreCase;
	public StringComparison InvariantCulture;
	public StringComparison InvariantCultureIgnoreCase;
	public StringComparison Ordinal;
	public StringComparison OrdinalIgnoreCase;
}

