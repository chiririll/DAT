using System;

namespace DAT.Model.Paged
{
    public class Page
    {
        public Id Id { get; } = new Id();

        public Page(bool inPrimary, int address = -1, int frame = -1)
        {
            if (inPrimary)
            {
                Load(frame);
            }
            else
            {
                Unload(address);
            }
        }

        public bool InPrimary { get; private set; } = false;
        public int Address { get; private set; } = -1;
        public int Frame { get; private set; } = -1;

        public event Action<Id> OnChanged;

        public void Unload(int address)
        {
            InPrimary = false;
            Address = address;
            Frame = -1;

            OnChanged?.Invoke(Id);
        }

        public void Load(int frame)
        {
            InPrimary = true;
            Address = -1;
            Frame = frame;

            OnChanged?.Invoke(Id);
        }
    }
}
