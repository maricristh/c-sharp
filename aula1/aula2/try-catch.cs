try{
int y = Calc(5);        // Exceção causada pela divisão por zero
Console.WriteLine(y);

int Calc(int x) { return 10 / x; }
}
    catch(DivideByZeroException ex){
        Console.WriteLine("Erro: Voce nao pode dividir por zero!");
    }
finally{
    Console.WriteLine("Cheguei no Finally agora"); // o finally executa de qualquer forma, mesmo com erro ou nao
}

    Console.WriteLine("Agora mexendo nas arrays: ");

    int[,] theArray = new int[5, 10];
        System.Console.WriteLine("O Array tem {0} dimensions.", theArray.Rank);
        Console.WriteLine("O array percorre o primeiro valor ", theArray.GetValue(0,0));

    Console.WriteLine("----- Segundo teste com Matriz / Array -----");

    int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
    foreach (int i in numbers)
    {
    System.Console.Write("{0} ", i);
    }
    // Output: 4 5 6 1 2 3 -2 -1 0
    
    Console.WriteLine("-----------------------");
       // int[,] numbers = [{4, 5},{ 6, 1},{2, 3}]; //tentando montar o array com elementos das coordenadas
    foreach (int i in numbers)
    {
    System.Console.Write("{0} ", i);
    }
    // Output: 4 5 6 1 2 3 -2 -1 0


    (double, int) valor ={(4.5, 3), (5.1, 2)}; //se coloco somente dois valores funciona, se coloco 4 (2 + 2) então para de funcionar.
    Console.WriteLine("Meu valor ", valor.ToString());
    Console.WriteLine($"Hash code of {valor} is {valor.GetHashCode()}.");