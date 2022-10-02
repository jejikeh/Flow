namespace Engine
{
    public abstract class FlowGame
    {
        public Form WindowForm { get => new FlowWindow(this); }

        public void Run()
        {
            while (true)
                Console.WriteLine("Hello Flow");
        }

        public abstract void Start();
    }
}