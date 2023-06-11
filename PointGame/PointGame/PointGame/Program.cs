using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PointGame.BL;

namespace PointGame

{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] Player = new char[,]
            {   {' ' , ' ' , 'o' , ' '},
            {' ' , '/' , '|' , '\\'},            
            { ' ' , '/' , ' ' , '\\'}
            };
            Boundary b = new Boundary();
            GameObject o = new GameObject(Player, new Point(6, 0), b, "Diagonal");
            while (true)
            {
                Thread.Sleep(100);
                o.Remove();
                o.Move();
                o.Draw();
            }
        }
    }
}
