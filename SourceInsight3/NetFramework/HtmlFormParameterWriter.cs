public class HtmlFormParameterWriter : UrlEncodedParameterWriter
{

	// Constructors
	public HtmlFormParameterWriter() {}

	// Methods
	public virtual void InitializeRequest(System.Net.WebRequest request, object[] values) {}
	public virtual void WriteRequest(System.IO.Stream requestStream, object[] values) {}
	public virtual object GetInitializer(LogicalMethodInfo methodInfo) {}
	public virtual void Initialize(object initializer) {}
	public virtual string GetRequestUrl(string url, object[] parameters) {}
	public virtual object[] GetInitializers(LogicalMethodInfo[] methodInfos) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool UsesWriteRequest { get{} }
	public System.Text.Encoding RequestEncoding { get{} set{} }
}

