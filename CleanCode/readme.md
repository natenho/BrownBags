	• Por que precisamos de código limpo?
	• O que é Código Limpo?
	• Regra do escoteiro
	• Nomes significativos
	• Métodos limpos
	• Comentários de código
	• Princípios gerais
    
 Código Limpo

	- Simples e direto
	- Facilita o trabalho de outros desenvolvedores, oferencendo formas mais claras de fazer uma tarefa
		Melhora a comunicação entre os densevolvedores
	- Légivel como um romance be escrito - Desenvolvedor = Autor
	- Sempre parece que foi escrito por alguém que se importava

"Se quiser que seu código seja de fácil escrita (mantido), torne-o de fácil leitura"

Regra do Escoteiro (Boy Scout Rule)

Nomes significativos

	- Nomes pronunciáveis (fácil de falar com outras pessoas)
	- Nomes que revelam propósito
	- Usar nomes pesquisáveis (constantes)
	- Esqueça convenções ultrapassadas
		szParam (string terminada em zero)
		lpX (ponteiro para um long)
		iVariavel (int)
	- Evite sujeiras nos nomes
		CustomerData
		ProductInfo
		OrderManager
		
		Nomes de classe tendem a ser um substativo
		Nomes de método deveriam tender a ser um verbo
    
	- Nomes consistentes
		Evitar nomes diferentes pra mesma coisa
			BuscarClientes
			RecuperarAutores
			ObterProdutos
		Evitar nomes iguais para coisas diferentes
    
	- Nomes técnicos para padrões técnicos
		Design Patterns
			Factory - PipocaFactory
			Adapter - PipocaAdapter
			Decorator - PipocaDecorator
      
	- Contexto significativo
		"estado" -> não tem significado sozinha
		Mas dentro da classe "Endereco" faz todo sentido
		
"Vale a pena refatorar nomes para se ter boa legibilidade, mesmo que possa causar surpresas em curto prazo"

Métodos

Devem ser pequenos

Blocos if/else/loops
	Devem ter apenas uma linha
		If (x && Y & pasdapsda & sadlkjsalkdja)
		If(PodeFazer())
		
"Devem fazer uma coisa. Devem fazer direito e somente aquilo"

Como fazer uma coisa só?

	TalCoisa()
		BuscarValores
		TransformarValores
		Retornar
		
	GerarArquivo()
		Var conteudo = ProduzirConteudo()
		GravarArquivo(conteudo)		
		
Argumentos

	Qual o número ideal de argumentos para um método?
		Zero?
		1 ou 2
		3 devem ser evitados
		
	Parameter Object Pattern
	
		FileCreationOptions 
			Prop1
			Prop2
			Prop3
			
	Evite parâmetros de saída (out , byref)
	Argumentos "flag"
		Argumento bool
		If(flag) fazIsso else FazAquilo
		FazIssoCondicaoX
		FaAquiloCondicaoY
		

Efeitos Colaterais
	Mentiras
	Seu método promete fazer uma coisa e também faz outra.
	
	Mexer em variáveis inesperadamente
	
Command Query Separation

	CQRS
		Um método deve
			Fazer algo (mudar o estado de algum objeto)
		OU
			Responder algo (dar informação a respeito do objeto)
			
			
"Não se preocupe em escrever código limpo de primeira"

A polêmica sobre comentários de código
	
"O uso adequado de comentários é para compensar a nossa falha em nos expressar no código"

DRY (Don't repeat yourself)
	Não repita código
	Não repita design de código
		
KISS (Keep it simple, stupid)
	"Tudo deve ser feito da forma mais simples possível, mas não mais simples que isso"
	
POLS (Principle of Least Surprise/Astonishment)
	
	Calculadora
	
		Int Somar
		Int Subtrair
		Int Dividir
		String Multiplicar
		
		private string Multiplicar(int a, int b)
		{
			return (a * b).ToString();
		}
		
	ParseInt(string, radix) // radix = "base"
		
	ParseInt("70") = 70
	PraseInt("070") = 56 

YAGNI (You ain't gonna need it)

	Converte um número em um texto por extenso
		Pra permitir outros idiomas
		
	Não tente prever o futuro
	
	"Trabalhe com  o que você tem em mãos"
	
Law of Demeter

Outros (orientação a objeto)

SOLID
GRASP

Críticas 

Nomes de interface sem o prefixo "I".
	IAnimal
	Animal
	AnimalImpl
	
Prefixo de fields (C# exclusivamente)

	_nome
	_endereco
	
	this.nome
	this.endereco
	
Microsoft não recomenda _ (this)
Microsoft Github _

