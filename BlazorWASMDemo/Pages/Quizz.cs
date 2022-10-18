namespace BlazorWASMDemo.Pages
{
    public partial class Quizz
    {
        public string Username { get; set; }
        public List<string> Questions{ get; set; }
        public List<string> Answers{ get; set; }
        public int pos { get; set; }

        public string InfoPos { get; set; }
        public string CurrentQuestion { get; set; }

        public Quizz()
        {
            Answers = new List<string>();
            Questions = new List<string>
            {
                "Aimes tu les pizzas ?",
                "As tu lu tout les livre LOTR ?",
                "Ce quizz sert il a quelque chose ?",
                "Il est chiant lui",
                "il veut rajouter des questions"
            };
            pos = 1;
            CurrentQuestion = Questions[0];
            InfoPos = "Voici la question n°" + pos;
        }

        public void Answer(string rep)
        {
            pos++;
            InfoPos = "Voici la question n°" + pos;
            Answers.Add(rep);
            if(pos > Questions.Count())
            {
                CurrentQuestion = "";
                InfoPos = "Vous avez terminé le quizz";
            }
            else
            {
                CurrentQuestion = Questions[pos-1];
            }
        }

    }
}
