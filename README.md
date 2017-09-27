## Cotações e Outras Informações do Banco Central do Brasil

Este repositório apresenta um exemplo de código em C# para pesquisa de cotação do dolar no banco central do Brasil. 

O endereço do webservice do banco central é https://www3.bcb.gov.br/sgspub/JSP/sgsgeral/FachadaWSSGS.wsdl.

### Series Temporais ###

As séries temporais representam o tipo de consulta que deve ser realizado no webservice do bcb. Na 
tabela abaixo, algumas informações que podem ser consultadas.

|CÓDIGO         |  NOME         |
| ------------- | ------------- |
|1              |Dólar (venda)  |
|10813          |Dólar (compra) |
|21619          |Euro (venda)   |
|21620          |Euro (compra)  |
|21635          |Dólar Canadense (venda)|
|21636          |Dólar Canadense (compra)|

### Operações Disponíveis ###

**getUltimoValorVO**  - Recupera o último valor de uma determinada série e retorna um objeto do tipo
WSSerieVO.
 

**GetUltimoValorXML** - Recupera o último valor de uma determinada série e retorna o resultado em
formato XML.
 
**getValor** - Recupera o valor de uma série em uma determinada data (dd/MM/aaaa).

**getValorEspecial** - Recupera o valor de uma série especial em um período.

**getValoresSeriesXML** - Recupera os valores de uma ou mais séries dentro de um determinado período.
O resultado da consulta é devolvido ao cliente em formato XML.

**getValoresSeriesVO** - Recupera os valores de uma ou mais séries dentro de um determinado período e
retorna o resultado em forma de Array de objetos do tipo WSSerieVO.


A documentação oficial com todas as operações disponíveis no webservice está localizada em https://www3.bcb.gov.br/sgspub/JSP/sgsgeral/sgsAjuda.jsp#SA.





