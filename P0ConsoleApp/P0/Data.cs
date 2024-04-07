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
                File.Create(path);
                
            }
            else
            {
                using FileStream json = File.OpenRead(path);
                gunplaList = JsonSerializer.Deserialize<List<Gunpla>>(json);
            }


        
            return gunplaList;
        }
        catch(Exception ex)
        {
            throw;
        }

    }
}
