using System;

namespace tower_of_hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Move(3, "Source", "Destination", "Auxilliary");
            //PrintTowers();
            //PrintDiscs(3);
        }

        private static void Move(int disc, String source, String dest, String aux){
            if(disc == 1){
                Console.WriteLine(source + "-> " + dest);
            }
            else{
                Move(disc -1, source, aux, dest);
                Console.WriteLine(source + "-> " + dest);
                Move(disc -1, aux, dest, source);
            }
        }

        private static void PrintTowers(){
            for (int i = 0; i < 5; i++){
                Console.Write(" |");
                Console.Write("\t");
                Console.Write(" |");
                Console.Write("\t");
                Console.Write(" |");
                Console.WriteLine("");
            }
        }

        private static void PrintDiscs(int amount){
            for (int i = 0; i <= amount; i++)
            {
                PrintDisc(i);
            }
        }

        private static void PrintDisc(int size){
            for (int i = 0; i < size; i++)
            {
                Console.Write("###");
            }
            Console.WriteLine();
            Console.Write(" ");
        }

        private static void MoveDisc(int size, String tower){
            switch(tower){
                case "Source":
                    PrintDisc(size);
                    break;
                case "Destination":
                    Console.Write("\t");
                    PrintDisc(size);
                    break;
                case "Auxilliary":
                    Console.Write("\t\t");
                    PrintDisc(size);
                    break;
            }

        }

    }
}
