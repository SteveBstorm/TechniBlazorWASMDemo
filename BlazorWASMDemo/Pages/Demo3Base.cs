using BlazorWASMDemo.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWASMDemo.Pages
{
    public class Demo3Base : ComponentBase
    {
        public bool status { get; set; }
        protected Jeu MyNewGame { get; set; }

        public Demo3Base()
        {
            MyNewGame = new Jeu();
        }

        public void ValidSubmit()
        {
            status = true;
        }
    }
}
