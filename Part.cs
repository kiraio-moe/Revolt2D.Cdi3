namespace Revolt2D.Cdi.Json
{
    public class Part
    {
        public string Id;
        public string Name;

        public override string ToString()
        {
            return $"    Id: {Id}\n    Name: {Name}";
        }
    }
}
