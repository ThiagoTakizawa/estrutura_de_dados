//Uma fila é a estrutura de dados que pode ser aplicada para representar a fila de atendimento da cantina 
//as pessoas que chegam entram no final da fila e as primeiras que chegam são as primeiras a ser atendidadas

//A função ENQUEUE é responsável por adicionar novos elementos à fila 
//A função DEQUEUE remove elementos da fila

//Desta forma, obedece o princípio do FIFO (FIRST IN, FIRST OUT)

using Filas;

Random random = new Random();

CallCenter center = new ();
center.Call(1234);
center.Call(1369);
center.Call(2468);
center.Call(1478);   

while(center.AreWaitingCalls())
{
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Thiago");
    Console.WriteLine(
        @$"{DateTime.Now:HH:mm:ss}
        Chamado: #{call.Id}
        De: {call.ClientId}
        Atendido por: {call.Consultant}"
    );
    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine(
        @$"Chamado: {call.Id}
            Encerrado às: {call.EndTime}"
    );
}