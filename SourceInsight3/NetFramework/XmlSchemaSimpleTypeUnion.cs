public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
{

	// Constructors
	public XmlSchemaSimpleTypeUnion() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlSchemaObjectCollection BaseTypes { get{} }
	public System.Xml.XmlQualifiedName[] MemberTypes { get{} set{} }
	public XmlSchemaSimpleType[] BaseMemberTypes { get{} }
	public string Id { get{} set{} }
	public XmlSchemaAnnotation Annotation { get{} set{} }
	public System.Xml.XmlAttribute[] UnhandledAttributes { get{} set{} }
	public int LineNumber { get{} set{} }
	public int LinePosition { get{} set{} }
	public string SourceUri { get{} set{} }
	public XmlSchemaObject Parent { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}
