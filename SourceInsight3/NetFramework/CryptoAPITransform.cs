public class CryptoAPITransform : ICryptoTransform, System.IDisposable
{

	// Methods
	public void Clear() {}
	public void Reset() {}
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) {}
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IntPtr KeyHandle { get{} }
	public int InputBlockSize { get{} }
	public int OutputBlockSize { get{} }
	public bool CanTransformMultipleBlocks { get{} }
	public bool CanReuseTransform { get{} }
}

