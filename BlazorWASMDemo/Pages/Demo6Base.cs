using BlazorWASMDemo.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace BlazorWASMDemo.Pages
{
    public class Demo6Base : ComponentBase
    {
        private readonly string url = "https://localhost:7219/api/";

        public List<Jeu> liste { get; set; }

        [Inject]
        public HttpClient client { get; set; }

        public Demo6Base()
        {
            liste = new List<Jeu>();
        }

        protected override async Task OnInitializedAsync() 
        {
            client.BaseAddress = new Uri(url);

            Jeu j = new Jeu { Id = 4, Name = "mon jeu", Description = "c'est un jeu", Genre = "toto" };

            await client.PostAsJsonAsync("game", j);

            liste = await client.GetFromJsonAsync<List<Jeu>>("game");
        }
    }
}
