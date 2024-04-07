using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace P0;

class Data
{
    public static List<Gunpla>? LoadGunpla() 
    {
        try{
            List<Gunpla>? gunplaList = new();
            string path = "GunplaFile.json";

            if(!File.Exists(path))
            {
                File.Create(path).Close();
                
            }
            else
            {
                string json = File.ReadAllText(path);
                if(string.IsNullOrEmpty(json))
                {
                    return gunplaList;
                }
                else
                {
                    gunplaList = JsonSerializer.Deserialize<List<Gunpla>>(json);
                }
            }
        
            return gunplaList;
        }
        catch(Exception ex)
        {
            throw;
        }

    }

    public static void SaveGunpla(List<Gunpla>? gunplaList)
    {
        string json = JsonSerializer.Serialize(gunplaList);

        string path = "GunplaFile.json";

        File.WriteAllText(path, json);
    }
}
