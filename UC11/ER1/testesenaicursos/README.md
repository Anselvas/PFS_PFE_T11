




















Testes de navegabilidade: 
site SENAI
Índice 
1. Introdução.......................................................................................................................……... 3
2. Plano de testes..............................................................................................................…..... 3
2.1. Introdução.....................................................................................................…....... 3
2.1.2 Objetivos.....................................................................................................…........ 3
2.1.3 Escopo.............................................................................................................…..….3
2.2 Requisitos a Testar............................................................................................... 4
2.3. Estratégia de Teste…........................................................................................... 4
2.3.1 Tipos de Teste.............................................................................................…....... 4
2.3.2 Ferramentas........................................................................................................ 4
2.4. Recursos.......................................................................................................…........ 4
2.4.1 Sistema......................................................................................................……........ 4
2.5. Cronograma..................................................................................................…........ 4
3. Caso de testes...............................................................................................................……...... 5
4. Desenho do teste............................................................................................................…….... 6

Plano de testes
       2.1 Introdução
Testar de usabilidade e algorítimo de botão de buscar cursos no site https://informatica.sp.senai.br e suas funcionalidades

       2.1.2 Objetivo
            ▪ Identificação dos componentes que serão testados.
    • Listar os requisitos recomendados para o teste.
    • Descrever as estratégias de testes que serão utilizadas. 
    • Identificar os recursos necessários para a realização dos testes. 
    • Teste de navegabilidade e usabilidade e algoritmo de automatização.

       2.1.3 Escopo 
Teste de navegabilidade e usabilidade e algoritmo de automatização para site https://informatica.sp.senai.br. Teste de usabilidade e botão de buscar termo por “gestão”, obtendo o resultados os cursos. Algoritmo simulando o usuário, acessando a página inicial da plataforma e interagindo com busca de campo, cursos, confirmadas com sucesso.
	2.2 Requisitos a Testar
Teste com foco a busca de cursos nas plataformas  SENAI, com entento o algoritmo de teste que para simular o usuário, ao acessar a página home das plataformas, interaja com o campo de busca, procure pelo termo “gestão” e obtenha como resultado os cursos com esta palavra-chave, com sucesso.

	2.3 Tipos de Teste
Testes realizados em nível de interface do usuário, espelhando o fluxo de interações do usuário no sistema, o uso de campo de busca de cursos, serão testados os atributos de funcionalidade e confiabilidade sem apresentar erro, utilizando o termo de buscar “gestão” traga os resultados de cursos.

	


	2.3.1. Ferramentas utilizadas
Etapa de teste 
Ferramenta 
Proprietário 
Planejamento de teste
Processador de texto
Microsoft 
Desenho de teste 
Eclipse IDE 
Eclipse Fundation 
Execução de teste
Java
Oracle

	2.4. Recursos e Sistema
Recurso
Aplicação/equipamento

Código de automatizador de Teste
Java - Selenium e JUnit

Repositório de Testes
Computador para desenvolvimento dos testes


 
 	2.4.1 Cronograma 
Tarefa
Data início
 Data término
Planejar Teste
03/02/2022
19/02/2023
Executar Teste
21/02/2022
21/02/2023
Avaliar Teste
21/02/2022
21/02/2023


	



	3. Caso teste
Refere-se à utilização do campo de busca de cursos e produtos com o termo escolhido.
Fluxo básico (FB)
FB1 - O usuário abre a pagina do Senai-SP.
FB2 - O usuário clica no campo de busca.
FB3 - O usuário digita o termo "gestão".
FB4 - O usuário clica na lupa.
FB5 - Ousuário visualiza o resultado de busca pelo termo "gestão".

3.1 Cenário
Caso de teste
Entrada
Resultado esperado
CT1 - Entrar no site do Senai
Url do site no navegador
Carregamento correto da página
CT3 - Input no campo de busca
Termo “escolhido”
 inserção e visualização dos caracteres alfa numéricos digitados
CT4 - Busca pelo termo digitado
Clique no ícone de lupa
Listar os itens escolhidos com o termo selecionado.


	





















	4. Desenho do teste
Testes automatizados segue as ferramentas usadas:

Selenium:  framework utilizado para testes de aplicações web que permite automatização do navegador, Java como linguagem de programação.
Webdriver: recurso do selenium para a realização dos testes automatizados dentro do navegador,  Google Chrome.
 Eclipse: no desenvolvimento para a execução da automação, configurado com o pacote de utilitários JAVA JDK-8 e o gerenciador de dependências Apache Maven.

Os testes de códigos JAVA a seguir:








