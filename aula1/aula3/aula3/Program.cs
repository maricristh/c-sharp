   
   namespace aula3;
   // consigo usar o using ????
    public class Maps
    {
       /// A classe Map deverá armazenar as informações do mapa 2D e implementar métodos para adição e remoção de joias e obstáculos. 
       /// Além de um método para imprimir o mapa na tela. A impressão do mapa deverá seguir a seguinte regra: 
       /// Robo será impresso como ME; Joias Red, como JR; Joias Green, como JG; Joias Blue, como JB; Obstáculos do tipo Tree, como $$; 
       /// Obstáculos do tipo Water, como ##; Espaços vazios, como --.
       public static int xyz = 3; //o public e static estao aqui para permitir que a class JewelCollector a veja
    }

public class JewelCollector : Map {

  public static void Main() {
  
      bool running = true;
  
      do {
          Console.WriteLine("valor de map: " + xy); //testando troca de informacao entre as classes
          Console.WriteLine("Enter the command: ");
          string command = Console.ReadLine();
            Console.WriteLine("comando: " + command); //testando o comando apertado
          if (command.Equals("quit")) {
              running = false;
          } else if (command.Equals("w")) {
              
          } else if (command.Equals("a")) {
              
          } else if (command.Equals("s")) {
            
          } else if (command.Equals("d")) {
          
          } else if (command.Equals("g")) {

        printMap();

          }
      } while (running);
  }
}
  public class Empty {
    //pedido para criar na instrucao 2 do exercicio
  }
        void PrintMap() {
            //map = map.ToString();
            for (int i = 0; i < map.GetLength(0); i++) {
            for (int j = 0; j < map.GetLength(1); j++) {
         Console.Write(map[i, j]);
    }
    Console.Write("\n");
  }

}