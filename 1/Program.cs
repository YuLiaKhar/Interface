using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();
            arithProgression.setStart();
            arithProgression.getNext();
            Console.WriteLine(arithProgression.getNext());
            geomProgression.setStart();
            Console.WriteLine(geomProgression.getNext());
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int start { get; set; }
        int next { get; set; }
        int d { get; set; }
        public void setStart(int x = 2)
        {
            start = x;
            next = start;
        }
        public int getNext()
        {
            d = 4;
            next = next + d;
            return next;
        }
        public void reset()
        {
            next = start;
        }
    }
    class GeomProgression : ISeries
    {
        int start { get; set; }
        int next { get; set; }
        int d { get; set; }
        public void setStart(int x = 2)
        {
            start = x;
            next = start;
        }
        public int getNext()
        {
            d = 4;
            next = next * d;
            return next;
        }
        public void reset()
        {
            next = start;
        }
    }
}
