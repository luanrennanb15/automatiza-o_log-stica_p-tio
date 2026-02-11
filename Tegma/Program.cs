using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static string arquivo = "cargas.txt";

    static void Main()
    {
        // introduzi um menu onde voce pode ter diversas opções dentro da sua nescessidade

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA LOGÍSTICA DE PÁTIO ===");
            Console.WriteLine("1 - Cadastrar carga");
            Console.WriteLine("2 - Listar cargas");
            Console.WriteLine("3 - Consultar por frota/placa + composição");
            Console.WriteLine("0 - Sair");
            Console.Write("\nOpção: ");

            string op = Console.ReadLine();
        // poderia ter feito swtch case também mas prefiri fazer dentro de condições

            if (op == "1") CadastrarCarga();
            else if (op == "2") ListarCargas();
            else if (op == "3") ConsultarPorComposicao();
            else if (op == "0") break;
        }
    }

    // ================= CADASTRO =================

    static void CadastrarCarga()
    {
        Console.Clear();

        Console.Write("Frota (5 dígitos): ");
        string frota = Console.ReadLine();
        if (!FrotaValida(frota))
        {
            Erro("Frota inválida.");
            return;
        }

        Console.Write("Placa do cavalo (7): ");
        string placa = Console.ReadLine().ToUpper();
        if (!PlacaValida(placa))
        {
            Erro("Placa inválida.");
            return;
        }

        Console.Write("Quantidade de veículos a carregar (0 a 12): ");
        int totalCarga = int.Parse(Console.ReadLine());

        if (totalCarga < 0 || totalCarga > 12)
        {
            Erro("Carga não comportada.");
            return;
        }

        Dictionary<string, int> composicao = new Dictionary<string, int>();
        int acumulado = 0;

        while (acumulado < totalCarga)
        {
            Console.Write("\nModelo do carro: ");
            string modelo = Console.ReadLine().Trim().ToUpper();

            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            if (acumulado + qtd > totalCarga)
            {
                Console.WriteLine(" Quantidade ultrapassa o total da carga.");
                continue;
            }

            if (!composicao.ContainsKey(modelo))
                composicao[modelo] = 0;

            composicao[modelo] += qtd;
            acumulado += qtd;

            Console.WriteLine($"Total carregado até agora: {acumulado}/{totalCarga}");
        }

        // Verifica duplicidade
        var cargas = LerCargas();
        foreach (var c in cargas.Where(x => x.Frota == frota || x.Placa == placa))
        {
            if (ComposicaoIgual(c.Carros, composicao))
            {
                Erro("Essa composição já foi carregada para essa frota/placa.");
                return;
            }
        }
        
        List<Carro> carros = new List<Carro>();
        Console.WriteLine("\nInforme as posições dos carros:");

        foreach (var item in composicao)
        {
            for (int i = 0; i < item.Value; i++)
            {
                Console.Write($"{item.Key} - posição: ");
                int pos = int.Parse(Console.ReadLine());
                carros.Add(new Carro { Modelo = item.Key, Posicao = pos });
            }
        }

        Console.Write("Observação: ");
        string obs = Console.ReadLine();

        string linha =
            $"{DateTime.Now}|{frota}|{placa}|{obs}|" +
            string.Join(",", carros.Select(c => c.Modelo + "-" + c.Posicao));

        File.AppendAllText(arquivo, linha + Environment.NewLine);

        Console.WriteLine("\n Carga cadastrada com sucesso!");
        Console.ReadKey();
    }

    // ================= LISTAR =================

    static void ListarCargas()
    {
        Console.Clear();
        var cargas = LerCargas();

        if (cargas.Count == 0)
        {
            Erro("Nenhuma carga cadastrada.");
            return;
        }

        foreach (var c in cargas)
            MostrarCarga(c);

        Console.ReadKey();
    }

    // ================= CONSULTA =================

    static void ConsultarPorComposicao()
    {
        Console.Clear();
        Console.Write("Digite Frota ou Placa: ");
        string termo = Console.ReadLine().ToUpper();

        if (!(FrotaValida(termo) || PlacaValida(termo)))
        {
            Erro("Valor inválido.");
            return;
        }

        var cargas = LerCargas()
            .Where(c => c.Frota == termo || c.Placa == termo)
            .ToList();

        if (cargas.Count == 0)
        {
            Erro("Nenhuma carga encontrada.");
            return;
        }

        Console.Write("Quantidade total de veículos da consulta: ");
        int total = int.Parse(Console.ReadLine());

        Dictionary<string, int> consulta = new Dictionary<string, int>();
        int acumulado = 0;

        while (acumulado < total)
        {
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine().Trim().ToUpper();

            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            if (acumulado + qtd > total)
            {
                Console.WriteLine("Ultrapassa o total.");
                continue;
            }

            if (!consulta.ContainsKey(modelo))
                consulta[modelo] = 0;

            consulta[modelo] += qtd;
            acumulado += qtd;
        }

        foreach (var c in cargas)
        {
            if (ComposicaoIgual(c.Carros, consulta))
            {
                Console.WriteLine("\n CARGA ENCONTRADA:\n");
                MostrarCarga(c);
                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine("\n Essa composição nunca foi carregada.");
        Console.ReadKey();
    }

    // ================= UTIL =================

    static bool ComposicaoIgual(List<Carro> carros, Dictionary<string, int> comp)
    {
        var cargaComp = carros
            .GroupBy(c => c.Modelo)
            .ToDictionary(g => g.Key, g => g.Count());

        return cargaComp.Count == comp.Count &&
               cargaComp.All(c => comp.ContainsKey(c.Key) && comp[c.Key] == c.Value);
    }

    static List<Carga> LerCargas()
    {
        List<Carga> lista = new List<Carga>();
        if (!File.Exists(arquivo)) return lista;

        foreach (var linha in File.ReadAllLines(arquivo))
        {
            var p = linha.Split('|');
            var carros = new List<Carro>();

            foreach (var c in p[4].Split(','))
            {
                var d = c.Split('-');
                carros.Add(new Carro { Modelo = d[0], Posicao = int.Parse(d[1]) });
            }

            lista.Add(new Carga
            {
                Data = DateTime.Parse(p[0]),
                Frota = p[1],
                Placa = p[2],
                Observacao = p[3],
                Carros = carros
            });
        }

        return lista;
    }

    static void MostrarCarga(Carga c)
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Data: " + c.Data);
        Console.WriteLine("Frota: " + c.Frota);
        Console.WriteLine("Placa: " + c.Placa);
        Console.WriteLine("Observação: " + c.Observacao);

        foreach (var g in c.Carros.GroupBy(x => x.Modelo))
            Console.WriteLine($"{g.Key}: {g.Count()}");

        Console.WriteLine("Posições:");
        foreach (var car in c.Carros.OrderBy(x => x.Posicao))
            Console.WriteLine($"Pos {car.Posicao} - {car.Modelo}");
    }

    static void Erro(string msg)
    {
        Console.WriteLine("\n❌ " + msg);
        Console.ReadKey();
    }

    static bool FrotaValida(string f) => f.Length == 5 && f.All(char.IsDigit);
    static bool PlacaValida(string p) => p.Length == 7;
}

// ================= MODELOS =================

class Carga
{
    public DateTime Data;
    public string Frota;
    public string Placa;
    public string Observacao;
    public List<Carro> Carros;
}

class Carro
{
    public string Modelo;
    public int Posicao;
}
