using System.Globalization;

//Parse é um método nativo do C#, que permite a conversão de Strings(!) para outros tipos (o Convert seria para conversões de quaisquer tipos)
var valor = int.Parse("10"); //10
var valor1 = bool.Parse("true"); //true
var valor2 = DateTime.Parse("13/01/2022", new CultureInfo("pt-BR")); //13/01/2022 00:00:00

//O TryParse evita que o código seja quebrado em tempo de execução. Porém ele retorna um bool, e não atribui valor (ele é um método de verificação)
//Porém, é possível armazenar o valor na variável result
valor2 = DateTime.TryParse("50/01/2022", out var result) ?
    DateTime.Parse("13/01/2022", new CultureInfo("pt-BR")) :
    new DateTime(2022, 1, 1); //Se fosse o result: 01/01/0001 00:00:00 (valor padrão para DateTime)

Console.WriteLine(valor2);