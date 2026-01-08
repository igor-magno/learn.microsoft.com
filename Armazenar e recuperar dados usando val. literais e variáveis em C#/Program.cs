
// Observe que a letra b está entre aspas 'b' simples. As aspas simples criam um caractere literal.
// Lembre-se de que usar aspas duplas cria um string tipo de dados.
Console.WriteLine('b');

Console.WriteLine("Ola Mundo");

// // Força o erro: error CS1012: Too many characters in character literal
// Console.WriteLine('Ola Mundo!');

// Valor numérico inteiro (sem frações) no console de saída, poderá usar um literal int
Console.WriteLine(123);

// Um número de ponto flutuante é um número que contém uma decimal, por exemplo, 3.14159.
// O C# dá suporte a três tipos de dados para representar números decimais: float, doublee decimal.
// Cada tipo dá suporte a diferentes graus de precisão.
// Float Type    Precision
// ----------------------------
// float         ~6-9 digits        sufixo literal: F ou f
// double        ~15-17 digits      sufixo literal: sem sufixo o tipo double eo padrão
// decimal        28-29 digits      sufixo literal: M ou m

// Float
Console.WriteLine(0.25F);
Console.WriteLine(0.25f);

// Double
Console.WriteLine(2.625);

// Decimal
Console.WriteLine(12.39816M);
Console.WriteLine(12.39816m);

// O termo bool é curto para Boolean.
// No C#, eles são oficialmente chamados de "bool", mas geralmente os desenvolvedores usam o termo "Boolean".
Console.WriteLine(true);
Console.WriteLine(false);

// Recapitulação
// string para palavras, frases ou quaisquer dados alfanuméricos para apresentação, não para cálculo
// char para um único caractere alfanumérico
// int para um número inteiro
// decimal para um número com um componente fracionário
// bool para um true/false valor

// Declarar uma variável
// Para criar uma nova variável, primeiro você deve declarar o tipo de dados da variável e, em seguida, dar-lhe um nome.
string firstName;

char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;

// Recapitulação
// Variáveis são valores temporários que você armazena na memória do computador.
// Antes de usar uma variável, você precisa declará-la.
// Para declarar uma variável, primeiro selecione um tipo de dados para o tipo de dados que deseja armazenar e dê à variável um nome que siga as regras.

// Atribuir e recuperar um valor armazenado na variável
firstName = "Jon Do";
userOption = 'A';
gameScore = 99;
particlesPerMillion = 99.9876m;
processedCustomer = true;

Console.WriteLine(firstName);
Console.WriteLine(userOption);
Console.WriteLine(gameScore);
Console.WriteLine(particlesPerMillion);
Console.WriteLine(processedCustomer);

// Inicializar a variável
// Deve se definir um valor para a variável antes de tentar obter um valor da memsa. Caso contrário, você verá um erro.

// // Força o erro: CS0165: Use of unassigned local variable 'secondName'
// string secondName;
// Console.WriteLine(secondName);

// Declarar variáveis locais de tipo implícito
var message = "Ola Mundo";

// Como a variável message é imediatamente definida com o valor string"Hello World!",
// o compilador C# entende a intenção e trata cada instância de message como uma instância do tipo string.
// Na verdade, a message variável é digitada para ser um string e nunca pode ser alterada.

// // Força o erro: CS0029: Cannot implicitly convert type 'decimal' to 'string'
// message = 10.703m;

// Desafio: exibir valores literais e variáveis
// Armazene os seguintes valores em variáveis:
// Bob
// 3
// 34.4

string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");