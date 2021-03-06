public class IsolatedStoragePermission : System.Security.CodeAccessPermission, System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk, IUnrestrictedPermission
{

	// Methods
	public virtual bool IsUnrestricted() {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual void FromXml(System.Security.SecurityElement esd) {}
	public virtual void Assert() {}
	public virtual void Demand() {}
	public virtual void Deny() {}
	public virtual void PermitOnly() {}
	public virtual System.Security.IPermission Union(System.Security.IPermission other) {}
	public virtual string ToString() {}
	public abstract virtual System.Security.IPermission Copy() {}
	public abstract virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public abstract virtual bool IsSubsetOf(System.Security.IPermission target) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public long UserQuota { get{} set{} }
	public IsolatedStorageContainment UsageAllowed { get{} set{} }
}

