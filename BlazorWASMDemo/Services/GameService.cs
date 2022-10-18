using BlazorWASMDemo.Models;

namespace BlazorWASMDemo.Services
{
    public class GameService
    {
        private List<Jeu> Games { get; set; }

        public GameService()
        {
            Games = new List<Jeu>
            {
                new Jeu{ Id = 1, Name = "The Ascent", Genre = "Shooter", Description = "C'est bien"}
            };
        }

        public List<Jeu> GetAll()
        {
            return Games;
        }

        public void Add(Jeu jeu)
        {
            Games.Add(jeu);
        }


    }
}
