using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace estruturasCS
{
    internal class Program
    {
        //struct

        struct Carro
        {
            public string Marca;
            public string Modelo;
            public string Cor;
            public string Placa;



            public Carro(string marca, string modelo, string cor, string placa)//construtor da struct
            {
                Marca = marca;
                Modelo = modelo;
                Cor = cor;
                Placa = placa;
            }



            public void Exibirdados()            {
                
                Console.WriteLine($"Marca.: {Marca} \nModelo: {Modelo} \nCor...: {Cor} \nPlaca.: {Placa}");
            }



        }




        static void Main(string[] args)
        {



            //Carro carro = new Carro();
            //carro.Marca = "Honda";
            //carro.Modelo = "civic";
            //carro.Cor = "000000";//preto
            Carro carro2 = new Carro("ford", "Ka", "Azul", "Preto");
            //Console.WriteLine("Marca: " + carro.Marca);
            //Console.WriteLine("Modelo: {0}", carro.Modelo);
            //Console.WriteLine($"Cor: {carro.Cor} \n Placa: {carro.Placa}");

            carro2.Exibirdados();





            //Array - Matrizes            



            //Stack - Pilhas
            Console.WriteLine("---------------------------------------------\nStack\n---------------------------------------------");

            Stack  <int> stack = new Stack<int>();
            stack.Push(1); // Adiciona elemento da pilha
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            //foreach (int item in stack)
            //{
            //    Console.WriteLine(item);
            //}
           // stack.Pop(); retira o elemento da pilha
              Console.WriteLine("Removemos o primeiro elemento da pilha: {0}", stack.Pop());
            Console.WriteLine("Removemos o primeiro elemento da pilha: {0}", stack.Peek());

            //list - Listas
            Console.WriteLine("---------------------------------------------\nList\n---------------------------------------------");
            List <Carro> carros = new List<Carro>();
            carros.Add(new Carro("ford", "Ka", "Azul", "EJC1203"));
            carros.Add(new Carro("VW", "fusta", "Azul", "ADE7989"));
            carros.Add(new Carro("Kia", "Soul", "Cinza", "GGK0712"));
            foreach (Carro carro in carros)
            {
                carro.Exibirdados();
                Console.WriteLine();
            }
            //List<object> list = new List<object>();//outra lista, detro da lista anterior
            //list.Add(carros);

            var teste = carros.Contains(
               new Carro("ford", "fuca", "branco", "BGT7896")
               ) ? "Tem sim, mano!" : "Tem não, Sangue!";
            Console.WriteLine(teste);

            //Queue - Filas

            Console.WriteLine("---------------------------------------------\nQueue\n---------------------------------------------");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("José");
            queue.Enqueue("Elias");
            queue.Enqueue("Pedreirista");

            Console.WriteLine("Numero de pessoas na fila: {0}", queue.Count);  // Exibe o numero de pessoas na fila
            Console.WriteLine("Proximo da fila é o: {0}",queue.Peek()); // Exibe o próximo elemento da fila
            Console.WriteLine("Numero de pessoas na fila: {0}", queue.Count);
            Console.WriteLine("Sr {0} será atendido no guichê 4", queue.Dequeue()); // Retira e põe o elemento 
            Console.WriteLine("Numero de pessoas na fila: {0}", queue.Count);
            Console.WriteLine("Sr {0} será atendido no guichê 4", queue.Dequeue());


            Console.ReadKey();
        }
    }
}

