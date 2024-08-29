namespace PilhaCsharpe;

public interface IPilha<T>
{
   void Push(T item); // Insere um item no topo da pilha
	T Pop(); // Remove e retorna o item do topo da pilha
	T Peek(); // Retorna o item do topo sem remover
	bool IsEmpty(); // Verifica se a pilha está vazia
}