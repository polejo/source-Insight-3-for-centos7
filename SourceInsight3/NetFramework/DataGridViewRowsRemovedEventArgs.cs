public class DataGridViewRowsRemovedEventArgs : System.EventArgs
{

	// Constructors
	public DataGridViewRowsRemovedEventArgs(int rowIndex, int rowCount) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int RowIndex { get{} }
	public int RowCount { get{} }
}

