using BibliotecaCalcDatas;
while (true)
{
    CalculaDatas.Menu();
    Console.Write("Digite umadas opções: ");
    byte opcao = Convert.ToByte(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Clear();
            Console.Write("Digite uma data: ");
            string data = Console.ReadLine();   
           
            Console.Write("Digite a quantidade de dias que irá adicionar: ");
            int quantDias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"sua data final será: {CalculaDatas.CalcularSomaDias(data, quantDias).ToString("d")}");
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            Console.Clear();
            Console.Write("Digite a primeira data: ");
            string dataInicial = Console.ReadLine();
            Console.Write("Digite a segunda data: ");
            string dataFinal = Console.ReadLine();

            Console.WriteLine($"A diferença das datas {dataInicial} e {dataFinal} é igual: {CalculaDatas.CalcularDiferencaDatas(dataInicial, dataFinal)} dias");
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            Console.Clear();
            Console.Write("Digite a primeira data: ");
            dataInicial = Console.ReadLine();
            Console.Write("Digite a segunda data: ");
            dataFinal = Console.ReadLine();

            Console.WriteLine($"A diferença das datas {dataInicial} e {dataFinal} é igual: {CalculaDatas.CalcularDiferencaDataMes(dataInicial, dataFinal)} meses");
            Console.ReadKey();
            Console.Clear();
            break;
        case 4:
            Console.Clear();
            Console.Write("Digite a primeira data: ");
            dataInicial = Console.ReadLine();
            Console.Write("Digite a segunda data: ");
            dataFinal = Console.ReadLine();

            Console.WriteLine($"A diferença das datas {dataInicial} e {dataFinal} é igual: {CalculaDatas.CalcularDiferencaDataAno(dataInicial, dataFinal)} anos completos");
            Console.ReadKey();
            Console.Clear();
            break;
        case 5:
            Console.Clear();
            Console.Write("Digite a primeira data: ");
            dataInicial = Console.ReadLine();
            Console.Write("Digite a segunda data: ");
            dataFinal = Console.ReadLine();

            Console.WriteLine($"A diferença das datas {dataInicial} e {dataFinal} é igual: {CalculaDatas.CalcularDiferencaDataHoras(dataInicial, dataFinal).TotalDays} dias, {CalculaDatas.CalcularDiferencaDataHoras(dataInicial, dataFinal).TotalHours} horas e {CalculaDatas.CalcularDiferencaDataHoras(dataInicial, dataFinal).TotalMinutes} minutos");
            Console.ReadKey();
            Console.Clear();
            break;
        case 6:
            Console.Clear();
            Console.Write("Digite a primeira data: ");
            dataInicial = Console.ReadLine();
            Console.Write("Digite a segunda data: ");
            dataFinal = Console.ReadLine();

            Console.WriteLine($"A diferença das datas {dataInicial} e {dataFinal} é igual:{CalculaDatas.CalcularDiferencaDataMes(dataInicial, dataFinal)} meses, {CalculaDatas.CalcularDiferencaDataHoras(dataInicial, dataFinal).TotalDays} dias, {CalculaDatas.CalcularDiferencaDataHoras(dataInicial, dataFinal).TotalHours} horas e {CalculaDatas.CalcularDiferencaDataHoras(dataInicial, dataFinal).TotalMinutes} minutos");
            Console.ReadKey();
            Console.Clear();
            break;
        case 7:
            Console.Clear();
            Console.Write("Digite a primeira data: ");
            dataInicial = Console.ReadLine();
            Console.Write("Digite a segunda data: ");
            dataFinal = Console.ReadLine();

            
            Console.WriteLine($"A diferença das datas {dataInicial} e {dataFinal} é igual:{CalculaDatas.CalcularDiferencaDataAno(dataInicial, dataFinal)} anos, {CalculaDatas.CalcularDiferencaDataMes(dataInicial, dataFinal)} meses, {CalculaDatas.CalcularDiferencaDataHoras(dataInicial, dataFinal).TotalDays} dias, {CalculaDatas.CalcularDiferencaDataHoras(dataInicial, dataFinal).TotalHours} horas e {CalculaDatas.CalcularDiferencaDataHoras(dataInicial, dataFinal).TotalMinutes} minutos");
            Console.ReadKey();
            Console.Clear();
            break;
        case 8:
            Console.Clear();
            Console.Write("Digite a data de entrada: ");
            dataInicial = Console.ReadLine();
            Console.Write("Digite a data de saída: ");
            dataFinal = Console.ReadLine();
            Console.Write("Digite o valor da diária: ");
            double diaria = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O valor da diária ficará {CalculaDatas.CalcularValorDaDiaria(dataInicial, dataFinal, diaria).ToString("C2")}");
            Console.ReadKey();
            Console.Clear();
            break;

        case 9:
            Console.Clear();
            Console.Write("Digite a data de entrada: ");
            dataInicial = Console.ReadLine();
            Console.Write("Digite a data de saída: ");
            dataFinal = Console.ReadLine();
            Console.Write("Digite o valor da diária: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o parâmetro de tempo: ");
            char parametroTempo = Convert.ToChar(Console.ReadLine());

            if ((parametroTempo == 'D' || parametroTempo == 'd') == CalculaDatas.CalcularValorDaDiariaComDias(dataInicial, dataFinal, valor, parametroTempo))
            {
                //não consegui fazer além disso, pelo menos tentei😭
            }
            Console.ReadKey();
            Console.Clear();
            break;
        case 10:
            goto sair;
        default:
            Console.WriteLine("--> OPÇÃO INVÁLIDA <--");
            break;
    }
sair:;
}
