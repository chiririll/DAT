namespace DAT.Model
{
    internal class VirtualMemory
    {
        public int Size { get; private set; }

        public VirtualMemory(int size)
        {
            Size = size;
        }
    }
}
