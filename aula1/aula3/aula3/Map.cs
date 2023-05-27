namespace aula3
{
    public class Map 
    {
        int variavel_da_matrix = 0; //valor a ser editado a cada passo dentro do jogo
        public static int map = 2;
        //char[,] Cell = Dados_obstaculos_vazios; //com a interface difinida basta q dentro da classe Map exista um array do tipo Cell[,], que deverá ser povoado por jóias, obstáculos ou espaços vazios, na medida do necessário

       // A classe Map deverá armazenar as informações do mapa 2D e implementar métodos para adição e remoção de joias e obstáculos. 
       //Além de um método para imprimir o mapa na tela. A impressão do mapa deverá seguir a seguinte regra: 
       //Robo será impresso como ME; Joias Red, como JR; Joias Green, como JG; Joias Blue, como JB; Obstáculos do tipo Tree, como $$; 
       //Obstáculos do tipo Water, como ##; Espaços vazios, como --.
       public static int xy = 2; //teste de troca de dados entre as classes



    }

    public interface ICell        // Declaração de uma interface com métodos prototipados
    {
     // bool MoveNext();
    // void Reset();
    }
}