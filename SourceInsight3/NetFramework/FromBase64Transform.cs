public class FromBase64Transform : ICryptoTransform, System.IDisposable
{

	// Constructors
	public FromBase64Transform() {}
	public FromBase64Transform(FromBase64TransformMode whitespaces) {}

	// Methods
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) {}
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) {}
	public void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int InputBlockSize { get{} }
	public int OutputBlockSize { get{} }
	public bool CanTransformMultipleBlocks { get{} }
	public bool CanReuseTransform { get{} }
}

