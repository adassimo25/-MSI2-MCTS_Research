using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCTS
{
    public interface Engine<TAction>
    {
        public TAction CalculateFromExecutedActions(MCTSable<TAction> game, IEnumerable<TAction> actions);
    }
}
