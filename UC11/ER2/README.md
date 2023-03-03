














Testes de navegabilidade: 
E-PLAYERS


Índice 
1. Introdução.......................................................................................................................……... 3
2. Plano de testes.................................................................................................................…..... 3
2.1. Introdução..................................................................................................................…....... 3
2.1.2 Objetivos.................................................................................................................…........ 3
2.1.3 Escopo.........................................................................................................................…..….3
2.2 Requisitos_a_Testar.................................................................................................................. 3
2.3. Estratégia_de_Teste…................................................................................................................ 4
2.3.1 Tipos_de_Teste.............................................................................................…....................... 4
2.3.2 Ferramentas........................................................................................................................ 4
2.4. Recursos.......................................................................................................….................... 4
2.4.1 Sistema......................................................................................................…….................... 4
2.5. Cronograma..................................................................................................…....................... 5
3. Caso de testes................................................................................................................……...... 5
4. Desenho do teste................................................................................................................…….... 6

Plano de testes

       2.1 Introdução
Testar de usabilidade e algorítimo de botão de buscar , assim como: testes de e-mail e senhas https://e-players.com.br e suas funcionalidades

       2.1.2 Objetivo
       Segue os planos de testes na plataforma E-PLAYERS e-Commerce: 
            ▪ Identificação dos componentes que serão testados.
    • Listar os requisitos recomendados para o teste.
    • Descrever as estratégias de testes que serão utilizadas. 
    • Identificar os recursos necessários para a realização dos testes. 
    • Teste de navegabilidade e usabilidade e algoritmo de automatização.
    • Verificação e testes de e-mail, senhas e botão login

       2.1.3 Escopo 
Teste de navegabilidade e usabilidade e algoritmo de automatização para site https://e-players.com.br . Foram feitas as codificações para login com email e senhas e realização de teste de autentificação e erros de email e senhas.
Teste de usabilidade, e-mail, senhas e botão login, obtendo o resultado logando na plataforma. Algoritmo simulando o usuário, acessando a página inicial da plataforma e interagindo com campo de e-mail, senha e botão login, confirmadas com sucesso.



	2.2 Requisitos a Testar
Teste com foco em login através de e-mail e senha e botão login na plataforma e-Commerce E-Players, com através do algoritmo de teste que para simular o usuário, ao acessar a página home da plataforma, interaja com o login, campo de e-mail e senha, botão login em seguida e obtendo como resultado o acesso a plataforma, com sucesso.

	
2.3 Tipos de Teste
Testes realizados em nível de interface do usuário, espelhando o fluxo de interações do usuário no sistema, o uso de campo de login, serão testados os atributos de funcionalidade e confiabilidade sem apresentar erro, utilizando os campos e-mail e senha de login, adentre na plataforma

	


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
03/02/2023
19/02/2023
Executar Teste
21/02/2023
21/02/2023
Avaliar Teste
21/02/2023
21/02/2023


	
	3. Caso teste
Refere-se à utilização do campo de busca de cursos e produtos com o termo escolhido.
Fluxo básico (FB)
FB1 - O usuário abre a pagina E-Players.
FB2 - O usuário clica no campo de email.
FB3 - FB2 - O usuário clica no campo de senha.
FB4 - O usuário clica no botão login.
FB5 – O usuário visualiza o resultado logado no sistema.

3.1 Cenário
Caso de teste
Entrada
Resultado esperado
CT1 - Entrar no site do E-Players
Url do site no navegador
Carregamento correto da página
CT3 - Input no campo de email
Campo de email
 inserção e visualização dos caracteres alfa numéricos digitados
CT4- Input no campo de senha
Campo de senha
 inserção e visualização dos caracteres alfa numéricos digitados
CT5 – Click no botão de login
Clique no botão de login
Acesso ao conteúdo da plataforma


	

	4. Desenho do teste
	
Testes automatizados segue as ferramentas usadas:

Selenium:  framework utilizado para testes de aplicações web que permite automatização do navegador, Java como linguagem de programação.
Webdriver: recurso do selenium para a realização dos testes automatizados dentro do navegador,  Google Chrome.
 Eclipse: no desenvolvimento para a execução da automação, configurado com o pacote de utilitários JAVA JDK-8 e o gerenciador de dependências Apache Maven.

Os testes de códigos JAVA a seguir:

public class testeSenhas {
    private WebDriver driver;
    
    @Before
    public void abrirNavegador () {
        
        System.setProperty("webdriver.chrome.driver", "C:\\Program Files\\chromedriver\\chromedriver.exe");
        driver = new ChromeDriver ();
        driver.manage().window().maximize();
    }
    
    @Test
    public void testeNavegador() {
        driver.get("http://localhost:4200/login");
        WebElement inputEmail = driver.findElement(By.id("email"));
        WebElement inputSenha = driver.findElement(By.id("senha"));
        WebElement botaoLogin = driver.findElement(By.id("botao-enviar"));
        
        /*inputEmail.sendKeys ("luiz@email.com");
        inputSenha.sendKeys ("vip123");
        botaoLogin.click();     
        */
        
        String [] listaSenhas = {"senhaum", "senhadois", "senhaerrada", "outrasenhaerrada","vip123"};
        
        for(int tentativas = 0; tentativas < listaSenhas.length; tentativas ++ ) {
            try {
                inputEmail.clear();
                inputSenha.clear();
                inputEmail.sendKeys ("luiz@email.com");
                inputSenha.sendKeys (listaSenhas [tentativas]);
                botaoLogin.click();
                Thread.sleep(3000);
            }
            
            catch (InterruptedException e) {
                    e.printStackTrace();
                
            }
            
            
        }
    }

}
