namespace BlazorWASMDemo.Pages
{
    public partial class Demo2
    {

        public int Valeur { get; set; } = 5;

        public void ajout(int x)
        {
            Valeur += x;
        }
        public void Add()
        {
            Valeur++;
        }
        public void Remove()
        {
            Valeur--;
        }
    }
}
