using aula01;
//declarando uma variável

int number;

//atribuindo valor
number = 10;

//declarando constante
const int DAYS_IN_WEEK = 7;

//imprimindo string concatenada
Console.WriteLine($"A semana tem {DAYS_IN_WEEK} dias.");

//new TipoEnumerador() -> invoca o metódo construtor do objeto
//toda classe tem seu construtor padrão implícito sem argumentos/params
//é possível sobrescrever esse método especificando argumentos
//todavia, se o fizermos perdemos o original implícito e
//precisaremos definí-lo explicitamente
TipoEnumerador tipoEnum = new TipoEnumerador();

TipoEnumerador.Language enumEnglish =
     tipoEnum.GetLanguageEnum("inglês");
Console.WriteLine( $"O enum de english é {enumEnglish}" );