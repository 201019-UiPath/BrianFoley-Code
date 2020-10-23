using HerosLib;
using HerosDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HerosBL
{
    public class HeroBL
    {
        IRepository repo = new FileRepo();
        public void AddHero(Hero newHero){

            repo.AddHeroAsync(newHero);
        }

        public List<Hero> GetAllHeroes()
        {
            Task<List<Hero>> getHeroes = repo.GetAllHerosAsync();
            return getHeroes.Result;
        }
    }
}