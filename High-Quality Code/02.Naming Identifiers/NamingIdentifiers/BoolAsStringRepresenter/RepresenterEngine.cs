namespace BoolAsStringRepresenter
{
    public class RepresenterEngine
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            var representer = new Representer();

            representer.RepresentBoolAsString(true);
        }
    }
}
