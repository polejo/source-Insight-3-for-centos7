public class FormsAuthenticationEventArgs : System.EventArgs
{

	// Constructors
	public FormsAuthenticationEventArgs(System.Web.HttpContext context) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Principal.IPrincipal User { get{} set{} }
	public System.Web.HttpContext Context { get{} }
}

