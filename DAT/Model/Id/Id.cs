namespace DAT.Model
{
    public class Id
    {
        private int id;

        public Id()
        {
            id = IdUtils.Generate();
        }

        public static implicit operator int(Id id) => id.id;
    }
}
