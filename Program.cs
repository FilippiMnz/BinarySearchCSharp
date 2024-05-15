using System;
using System.Runtime.CompilerServices;
namespace Program{
    public class Program{
        public static void Main(string[] args) {
            int[] Lista = { 1, 2, 4, 9, 10, 40};
            int Item = 9;
            Console.WriteLine(Binary(Lista, Item));
        }

        public static int Binary(int[] Lista, int Item){
            int Baixo = 0;
            int Alto = Lista.Length -1;
            
            while(Baixo <= Alto){
                int Meio = (Baixo + Alto)/2;
                int Chute = Lista[Meio];
                if(Chute == Item){
                    return Meio;
                }if(Chute > Item){
                    Alto = Meio - 1;
                }else{
                    Baixo = Meio + 1;
                }
                
            }
            return 0;

        }
    }
}