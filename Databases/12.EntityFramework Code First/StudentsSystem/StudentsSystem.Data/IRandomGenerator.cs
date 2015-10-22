namespace StudentsSystem.Data
{
    public interface IRandomGenerator
    {
        int GetRandomNumber(int min, int max);

        string GetRandomString(int min, int max);
    }
}