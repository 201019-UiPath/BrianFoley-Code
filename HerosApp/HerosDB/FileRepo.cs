using System.Collections.Generic;
using HerosLib;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace HerosDB
{
    public class FileRepo : IRepository
    {
        private const string V = "HerosDB/HerosDataPlace.txt";
        string filepath = V;
        
        /// <param name="hero"></param>
        
        public async void AddHeroAsync(Hero hero)
        {
            System.Console.WriteLine(filepath);
            using(FileStream fs = File.Create(filepath)){
                await JsonSerializer.SerializeAsync(fs, hero);
                System.Console.WriteLine("Hero is being written to file");
            }
        }

        public async Task<List<Hero>> GetAllHerosAsync()
        {
            List<Hero> allHeroes = new List<Hero>();
            using(FileStream fs = File.OpenRead(filepath))
            {
                allHeroes.Add(await JsonSerializer.DeserializeAsync<Hero>(fs));
            }
            return allHeroes;
        }
    }
}

