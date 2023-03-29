namespace DAT.Model
{
    public static class IdUtils
    {
        private static int lastFree = 0;

        public static int Generate() => lastFree++;
    }
}
