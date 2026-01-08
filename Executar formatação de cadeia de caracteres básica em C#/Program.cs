// Sequências de escape de caracteres
// Uma sequência de caracteres de escape é uma instrução especial para que o runtime insira um caractere especial
// que afetará a saída da cadeia de caracteres.
// Em C#, a sequência de caracteres de escape começa com uma barra invertida \ seguida pelo caractere que será escapado.
// Por exemplo, a sequência \n adicionará uma nova linha e uma sequência \t adicionará uma guia.

// Console.WriteLine("Ola\nMundo!");
// Console.WriteLine("Ola\tMundo!");
// Console.WriteLine("Ola \"Mundo\"!");

// E se você precisar usar a barra invertida para outras finalidades, como exibir um caminho de arquivo?
// Console.WriteLine("c:\\caminho\\pasta\\arquivo.txt");

// Exercício
// Imagine que o seu gerente pediu que você criasse um modelo de uma ferramenta de linha de comando para gerar faturas em inglês e em japonês.
// Você não precisa criar a funcionalidade real que gera as faturas ainda.
// Você só precisará fornecer a interface de linha de comando para clientes internos no departamento de cobrança para aprovação.
// Seu gerente pediu para você ter certeza de que adicionou formatação para tornar claro o progresso atual da ferramenta.
// Seu gerente também pediu para fornecer instruções para os usuários japoneses sobre como gerar faturas em japonês.

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");

// Console.WriteLine(@"    c:\source\repos    
//         (this is where your code goes)");

Console.Write(@"c:\invoices");

// Kon'nichiwa World
// Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// Recapitulação
// Use as sequências de escape de caractere quando precisar inserir um caractere especial em uma cadeia de caracteres literal, como uma tabulação \t, uma nova linha \n ou uma aspa dupla \".
// Use um caractere de escape para a barra invertida \\ quando precisar usar uma barra invertida em todos os outros cenários.
// Use a diretiva @ para criar um literal de cadeia de caracteres que mantenha toda a formatação de espaço em branco e caracteres de barra invertida em uma cadeia de caracteres.
// Use o \u mais um código de quatro caracteres para representar caracteres Unicode (UTF-16) em uma cadeia de caracteres.
// Os caracteres Unicode podem não ser impressos corretamente dependendo do aplicativo.


Console.WriteLine("\n###########################################################");
Console.WriteLine("Combinar cadeias de caracteres usando a concatenação de cadeias de caracteres");
// string firstName = "Jon Do";
// string message = "Ola " + firstName;
// Console.WriteLine(message);

string firstName = "Jon Do";
string greeting = "Ola";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);
// ou
Console.WriteLine(greeting + " " + firstName + "!");

// Recapitulação
// A concatenação de cadeia de caracteres permite combinar cadeias de caracteres literais menores e variáveis em uma única cadeia de caracteres.
// Evite criar variáveis intermediárias se adicioná-las não aumentar a legibilidade.

Console.WriteLine("Exercício – Combinar cadeias de caracteres usando a interpolação de cadeias de caracteres");

// O que é interpolação de cadeia de caracteres?
// A interpolação de cadeia de caracteres combina vários valores em uma única cadeia de caracteres literal usando um "modelo" e uma ou mais expressões de interpolação.
// Uma expressão de interpolação é indicada por um símbolo de chave de abertura e fechamento { }.
// Você pode colocar qualquer expressão C# que retorne um valor entre chaves.
// A cadeia de caracteres literal se torna um modelo quando é prefixada pelo $ caractere.

string message1 = greeting + " " + firstName + "!" + " (Sem interpolação)"; // Sem interpolação
string message2 = $"{greeting} {firstName}! (Com interpolação)"; // Com interpolação

Console.WriteLine(message1);
Console.WriteLine(message2);

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

string projectName1 = "First-Project";
Console.WriteLine($@"C:\Output\{projectName1}\Data");

// Recapitulação
// A interpolação de cadeia de caracteres fornece uma melhoria em relação à concatenação de cadeia de caracteres, reduzindo o número de caracteres necessários em algumas situações.
// Você pode combinar a interpolação de cadeias de caracteres e literais textuais combinando os símbolos para cada um e usando-o como um prefixo para o modelo de cadeia de caracteres.

Console.WriteLine("\n###########################################################");
Console.WriteLine("Desafio: formatar e exibir instruções");

// Neste desafio, você imprimirá instruções para o usuário final para que ele saiba onde seu aplicativo gerará arquivos de dados.
// Na verdade, você não vai criar nenhum arquivo.
// Você só vai exibir algumas instruções formatadas na janela do console.

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// A variável projectName será usada duas vezes na saída desejada.

// A variável russianMessage contém a mensagem "Exibir saída russa" em russo.
// Você precisa usar essa variável em seu código que imprime a mensagem.

// Você não pode alterar essas duas linhas de código, mas pode adicionar código acima e abaixo de cada linha.
// Você precisa usar essas duas linhas de código para formar a saída desejada.

// Você só pode usar o Console.WriteLine() ou o método Console.Write() duas vezes.
// Em outras palavras, para concluir esse desafio, você só pode criar duas instruções que realmente imprimem a saída no console.
// Se você precisar imprimir novas linhas adicionais ou adicionar qualquer formatação, deverá usar o que aprendeu neste módulo para realizar a tarefa.

// Use sequências de escape de caractere, cadeias de caracteres textuais, Unicode e interpolação de cadeia de caracteres para gerar a saída.
Console.Write("\n");
Console.WriteLine($@"View English output:
    c:\Exercise\{projectName}\data.txt");
Console.WriteLine($@"{russianMessage}:
    c:\Exercise\{projectName}\ru-RU\data.txt");

Console.Write("\nOu\n");

string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t{englishLocation}\n");
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t{russianLocation}\n");