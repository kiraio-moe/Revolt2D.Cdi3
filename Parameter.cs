namespace Revolt2D.Cdi.Json
{
    public class Parameter
    {
        public string Id;
        public string GroupId;
        public string Name;

        public override string ToString()
        {
            return $"    Id: {Id}\n    Group Id: {GroupId}\n    Name: {Name}";
        }
    }
}
