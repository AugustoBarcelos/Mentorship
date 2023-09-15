using System;

class DataConfiguracao
{
    private string formatoData;

    public void ConfigurarFormatoData()
    {
        Console.WriteLine("Selecione o formato de data:");
        Console.WriteLine("1. Utilizar minha configuração de sistema: 08/01/2021 20:48:13");
        Console.WriteLine("2. Formato simples: 08-01-21");
        Console.WriteLine("3. Formato longo: Friday, January 8, 2021");
        Console.WriteLine("4. Formato longo personalizado: 08-01-2021 08:48:13");
        Console.WriteLine("5. Formato RFC1123 pattern: Fri, 08 Jan 2021 20:48:13 GMT");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                formatoData = "g";
                break;
            case 2:
                formatoData = "dd-MM-yy";
                break;
            case 3:
                formatoData = "D";
                break;
            case 4:
                formatoData = "dd-MM-yyyy HH:mm:ss";
                break;
            case 5:
                formatoData = "r";
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                ConfigurarFormatoData();
                break;
        }
    }

    public void ExibirCabecalhoData(DateTime data)
    {
        Console.WriteLine("Data: " + data.ToString(formatoData));
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataConfiguracao dataConfig = new DataConfiguracao();

        dataConfig.ConfigurarFormatoData();

        Console.WriteLine("Selecione um evento:");
        Console.WriteLine("1. ENIAC");
        Console.WriteLine("2. RFC1");
        Console.WriteLine("3. Alan Turing");

        int opcaoEvento = int.Parse(Console.ReadLine());

        switch (opcaoEvento)
        {
            case 1:
                DateTime dataEniac = new DateTime(1946, 8, 15);
                dataConfig.ExibirCabecalhoData(dataEniac);
                Console.WriteLine("No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.");
                break;
            case 2:
                DateTime dataRfc1 = new DateTime(1969, 4, 17);
                dataConfig.ExibirCabecalhoData(dataRfc1);
                Console.WriteLine("Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.");
                break;
            case 3:
                DateTime dataTuring = new DateTime(1912, 6, 23);
                dataConfig.ExibirCabecalhoData(dataTuring);
                Console.WriteLine("Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o \"pai da informática\" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.");
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}