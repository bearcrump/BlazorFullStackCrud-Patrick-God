using System.Net.Http.Json;

namespace BlazorFullStackCrud.Client.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly HttpClient http;

        public SuperHeroService(HttpClient http)
        {
            this.http = http;
        }
        public List<SuperHero> Heroes { get; set; } = new List<SuperHero>();
        public List<Comic> Comics { get; set; } = new List<Comic>();

        public Task GetComics()
        {
            throw new NotImplementedException();
        }

        public Task<SuperHero> GetSuperHero(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetSuperHeroes()
        {
            var result = await this.http.GetFromJsonAsync<List<SuperHero>>("api/SuperHero");

            if (result != null)
            {
                Heroes = result;
            }
        }
    }
}
