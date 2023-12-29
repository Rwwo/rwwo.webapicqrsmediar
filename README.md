### Introdu��o ao Padr�o CQRS
## Quando usar o CQRS
## MediatR

## Pr�-requisitos
* Visual Studio 2022
* PostgreSQL
* .NET Core 6

## Introdu��o ao Padr�o CQRS
CQRS significa Command and Query Responsibility Segregation e � utilizado para separar as opera��es de leitura (consultas) das opera��es de escrita (comandos).

Nesse contexto, as consultas realizam opera��es de leitura, enquanto os comandos realizam opera��es de escrita, como criar, atualizar,
excluir e retornar dados.

Como sabemos, em nossa aplica��o, geralmente utilizamos um �nico modelo de dados para ler e escrever dados, o que funciona bem e permite realizar 
opera��es CRUD facilmente. No entanto, quando a aplica��o se torna extensa, nossas consultas passam a retornar diferentes tipos de dados como objeto,
tornando dif�cil gerenciar diferentes objetos DTO. Al�m disso, o mesmo modelo � utilizado para realizar opera��es de escrita, resultando em um modelo 
complexo.

Al�m disso, ao usar o mesmo modelo para opera��es de leitura e escrita, a seguran�a tamb�m se torna dif�cil de gerenciar quando a aplica��o � grande,
e a entidade pode expor dados no contexto errado devido � carga de trabalho no mesmo modelo. O CQRS ajuda a desacoplar as opera��es e torna a aplica��o
mais escal�vel e flex�vel em grande escala.

## Quando utilizar o CQRS

Podemos utilizar a Segrega��o de Responsabilidades de Comando e Consulta (CQRS) quando a aplica��o � extensa e acessa os mesmos dados em paralelo.
O CQRS ajuda a reduzir conflitos de mesclagem ao realizar v�rias opera��es com os dados.

Em termos de Domain-Driven Design (DDD), se o modelo de dados do dom�nio for complexo e precisar realizar muitas opera��es com prioridade,
como valida��es e execu��o de l�gica de neg�cios, nesse caso, precisamos da consist�ncia que ser� alcan�ada utilizando o CQRS.

## Padr�o MediatR

O padr�o MediatR ajuda a reduzir a depend�ncia direta entre m�ltiplos objetos e a torn�-los colaborativos por meio do MediatR. No .NET Core, 
o MediatR fornece classes que ajudam a comunicar eficientemente com v�rios objetos de maneira desacoplada.

![Resultado API](./images/swagger.png)