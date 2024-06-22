using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace RockPaperScissors_WPF
{
    internal static class GameStates
    {
        public enum States
        {
            Камень,
            Ножницы,
            Бумага
        }

        public static Comparer<States> Comparer { get; } = new StateComparer();

             private class StateComparer : Comparer<States>
        {
            public override int Compare(States x, States y)
            {
                if (x == y) return 0;

                switch (x)
                {
                    case States.Камень:
                        return (y == States.Ножницы) ? 1 : -1;
                    case States.Ножницы:
                        return (y == States.Бумага) ? 1 : -1;
                    case States.Бумага:
                        return (y == States.Камень) ? 1 : -1;
                    default:
                        throw new ArgumentException("Некорректное состояние!");
                }
            }
        }
        public static States GetRandomState()
        {
            States state = new States();
            Random random = new Random();
            int num = random.Next(1,4);
            switch (num) { 
            case 1: state = States.Камень; break;
            case 2: state = States.Ножницы; break;
            case 3: state = States.Бумага; break;                
            }
            return state;
        }
    }
}
