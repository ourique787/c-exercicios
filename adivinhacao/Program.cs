Random random = new Random();


int numeroAleatorio;


numeroAleatorio = random.Next(1,100);


int palpite = 0;


while(numeroAleatorio != palpite){
    Console.WriteLine("Digite um palpite");
    palpite = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("O numero aleatorio e: " + numeroAleatorio);
}
Console.WriteLine("Você acertou!");



