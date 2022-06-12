using System.Collections.Generic;

namespace MCTS
{
    public class State<TAction>
    {
        public int Id { get; set; }
        public double Points { get; set; } = 0.0;
        public int Passes { get; set; } = 0;
        public TAction Action { get; set; }

        public List<State<TAction>> Childs { get; set; } = new();

        public static State<TAction> Create(int id, TAction action)
        {
            return new()
            {
                Id = id,
                Action = action,
            };
        }

        public static State<TAction> CreateInitial()
        {
            return new()
            {
                Id = 0,
            };
        }

        public void AddChild(State<TAction> state)
        {
            Childs.Add(state);
        }

        public void Visit(double points)
        {
            Passes++;
            Points += points;
        }
    }
}
