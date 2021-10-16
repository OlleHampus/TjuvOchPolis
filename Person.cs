using System;

namespace TjuvOchPolis
{
    public class Person : IPerson
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Xdirection { get; set; }
        public int Ydirection { get; set; }
        public string Sort { get; set; }
        public Person(int x, int y, int xdirection, int ydirection, string sort)
        {
            X = x;
            Y = y;
            Xdirection = xdirection;
            Ydirection = ydirection;
            Sort = sort;
        }
        public virtual void DoMove()
        {
            X += Xdirection;
            Y += Ydirection;
            if (X < 0) { X = Var.stad_bredd; }
            if (Y < 0) { Y = Var.stad_hojd; }
            if (X >= Var.stad_bredd) { X = 0; }
            if (Y >= Var.stad_hojd) { Y = 0; }

            Var.Rutnat[X, Y] = "x";

        }
        public bool Comparexy(object obj)
        {
            // var person
            var person = (Person)obj;
            return X.Equals(person.X) && Y.Equals(person.Y);

        }
        public string CheckSort()
        {
            return Sort;
        }


    }
}
