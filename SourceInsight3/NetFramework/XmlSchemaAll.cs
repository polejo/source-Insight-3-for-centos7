public class XmlSchemaAll : XmlSchemaGroupBase
{

	// Constructors
	public XmlSchemaAll() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlSchemaObjectCollection Items { get{} }
	public string MinOccursString { get{} set{} }
	public string MaxOccursString { get{} set{} }
	public decimal MinOccurs { get{} set{} }
	public decimal MaxOccurs { get{} set{} }
	public string Id { get{} set{} }
	public XmlSchemaAnnotation Annotation { get{} set{} }
	public System.Xml.XmlAttribute[] UnhandledAttributes { get{} set{} }
	public int LineNumber { get{} set{} }
	public int LinePosition { get{} set{} }
	public string SourceUri { get{} set{} }
	public XmlSchemaObject Parent { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

