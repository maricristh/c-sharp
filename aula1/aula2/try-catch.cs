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