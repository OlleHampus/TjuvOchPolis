using System;

namespace TjuvOchPolis
{
    public class Tjuv : Person
    {
        public Tjuv(int x, int y, int xdirection, int ydirection, string sort) : base(x, y, xdirection, ydirection, sort)
        {
        }
        public override void DoMove()
        {
            X += Xdirection;
            Y += Ydirection;
            if (X < 0) { X = Var.stad_bredd - 1; }
            if (Y < 0) { Y = Var.stad_hojd - 1; }
            if (X >= Var.stad_bredd) { X = 0; }
            if (Y >= Var.stad_hojd) { Y = 0; }
            
            Var.Rutnat[X, Y] = "T";
            
        }
    }
}