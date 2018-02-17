using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public static class Program
    {
        public static void Main()
        { }
    }

    public interface IMove
    {
        void Process(Field files);
    }

    public class AddMove : IMove
    {
        public Figure figure;
        public Point point;

        public void Process(Field field)
        { }
    }

    public class Figure
    {
        public IPlayer Player;
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Field
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Figure> Figures;

        public void Add(Point p, Figure f)
        {
            throw new NotImplementedException();
        }

        public void Remove(Figure f)
        {
            throw new NotImplementedException();
        }

        public void Get(Point p)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPlayer
    {
        string Name { get; set; }

        IMove CreateMove(Field f);
    }

    public class Game
    {
        private Field field;

        public void MakeMove(IMove m)
        { }
    }

    public class GameApplication
    {
        public Game CurrentGame;
        public List<Game> AvailableGames;
    }

    public class Reversi
    {
        private Game game;

        public bool CheckMove(IMove m)
        {
            throw new NotImplementedException();
        }
    }

    public class NetReversiPlayer : IPlayer
    {
        public string Name { get; set; }
        public IMove CreateMove(Field f)
        {
            throw new NotImplementedException();
        }
    }
}
