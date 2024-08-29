namespace PilhaCsharpe;

 class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Criação de uma pilha de inteiros
                Pilha<int> pilha = new Pilha<int>();

                // Empilhando elementos na pilha
                pilha.Push(10);
                pilha.Push(20);
                pilha.Push(30);

                // Exibindo o topo da pilha
                Console.WriteLine("Topo da pilha: " + pilha.Peek()); // 30

                // Desempilhando elementos da pilha
                Console.WriteLine("Desempilhando: " + pilha.Pop()); // 30
                Console.WriteLine("Novo topo da pilha: " + pilha.Peek()); // 20

                // Verificando se a pilha está vazia
                Console.WriteLine("A pilha está vazia? " + pilha.IsEmpty()); // False

                // Desempilhando mais elementos
                pilha.Pop();
                pilha.Pop();

                // Tentando desempilhar de uma pilha vazia (lança exceção)
                Console.WriteLine("Tentando desempilhar da pilha vazia...");
                pilha.Pop();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }

