namespace DAT.Model
{
    public class Page
    {
        public Id Id { get; }

        public bool InPrimary { get; private set; } = false;
        public int Address { get; private set; } = -1;
        public int Frame { get; private set; } = -1;

        public void Unload(int address)
        {
            InPrimary = false;
            Address = address;
            Frame = -1;
        }

        public void Load(int frame)
        {
            InPrimary = true;
            Address = -1;
            Frame = frame;
        }
    }
}
