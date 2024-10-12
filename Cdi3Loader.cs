using System.Text.Json;

namespace Revolt2D.Cdi.Json
{
    public class Cdi3Loader
    {
        private Cdi3 _cdi;

        public Cdi3Loader(string filePath)
        {
            _cdi = LoadFromFile(filePath);
        }

        public Cdi3 GetCdi()
        {
            return _cdi;
        }

        public Cdi3? LoadFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                throw new Exception($"Invalid path! {filePath}");

            string? jsonData = File.ReadAllText(filePath);
            return LoadJson(jsonData);
        }

        public Cdi3? LoadJson(string jsonData)
        {
            try
            {
                if (string.IsNullOrEmpty(jsonData))
                    throw new Exception("JSON data empty!");

                JsonSerializerOptions options = new JsonSerializerOptions { IncludeFields = true };
                return JsonSerializer.Deserialize<Cdi3>(jsonData, options);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}
