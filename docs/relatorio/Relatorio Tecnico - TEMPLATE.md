# Informações do Projeto
`TÍTULO DO PROJETO`  
Estudio Ballet

`CURSO` 

Sistemas de Informação

## Participantes
> Os membros do grupo são: 
> - João Victor Teofilo Barbosa Morais
> - Iury Taveira
> - Gustavo Campos
> - Dyogo Huann
> - Artur Henrique

# Estrutura do Documento

- [Informações do Projeto](#informações-do-projeto)
  - [Participantes](#participantes)
- [Estrutura do Documento](#estrutura-do-documento)
- [Introdução](#introdução)
  - [Problema](#problema)
  - [Objetivos](#objetivos)
  - [Justificativa](#justificativa)
  - [Público-Alvo](#público-alvo)
- [Especificações do Projeto](#especificações-do-projeto)
  - [Personas e Mapas de Empatia](#personas-e-mapas-de-empatia)
  - [Histórias de Usuários](#histórias-de-usuários)
  - [Requisitos](#requisitos)
    - [Requisitos Funcionais](#requisitos-funcionais)
    - [Requisitos não Funcionais](#requisitos-não-funcionais)
  - [Restrições](#restrições)
- [Projeto de Interface](#projeto-de-interface)
  - [User Flow](#user-flow)
  - [Wireframes](#wireframes)
- [Metodologia](#metodologia)
  - [Divisão de Papéis](#divisão-de-papéis)
  - [Ferramentas](#ferramentas)
  - [Controle de Versão](#controle-de-versão)
- [Projeto da Solução](#projeto-da-solução)
  - [Tecnologias Utilizadas](#tecnologias-utilizadas)
  - [Arquitetura da solução](#arquitetura-da-solução)
- [Avaliação da Aplicação](#avaliação-da-aplicação)
  - [Plano de Testes](#plano-de-testes)
  - [Ferramentas de Testes (Opcional)](#ferramentas-de-testes-opcional)
  - [Registros de Testes](#registros-de-testes)
- [Referências](#referências)


# Introdução

## Problema

O Studio de Ballet Jessica Oliveira atualmente enfrenta desafios relacionados à falta de presença online e à ausência de sistemas automatizados para gerenciar suas tarefas. Como resultado, o studio pode estar enfrentando dificuldades para alcançar novos alunos, gerenciar eficientemente suas operações internas e manter registros precisos de suas atividades.

## Objetivos
O Obejtivo do projeto em que essa aplicação será usada é dentro do próprio estúdio de ballet. A aplicação envolverá o desenvolvimento de um site para o estúdio, onde possui a implementação de um sistema de gerenciamento de turmas e planejamentos de aulas, bem como possíveis funcionalidades adicionais para auxiliar na administração das finanças, na comunicação com os clientes e no acompanhamento do progresso dos alunos.

## Justificativa

A criação do site é importante para resolver a demanda do Studio Jessica Oliveira de poder transformar processos que eram feitos manualmente e no Excel em automatizados. Outro ponto importante é que com o novo sistema, um professor terá acesso ao plano de aula do outro, facilitando o trabalho em conjunto. A página inicial do site também ajudará na divulgação da escola, contribuindo para atrair mais alunos e também arrecadar patrocínios para a companhia da escola, o grupo EOS, formado por bolsistas, auxiliando nas apresentações e concursos futuros.

## Público-Alvo

O projeto visa atender a um público interessado em informações detalhadas sobre o studio de ballet, incluindo horário, endereço e história. Adicionalmente, proporcionamos aos pais dos alunos fácil acesso às principais redes de contato, facilitando a comunicação e o acompanhamento das atividades dos seus filhos. Além disso, tem como objetivo auxiliar na conquista de patrocínios para a EOS, uma companhia de dança composta por bolsistas do referido studio. Também incluímos uma aba de administrador para os professores, com funcionalidades automatizadas que visam simplificar suas tarefas diárias.
 
# Especificações do Projeto

O Studio de Ballet Jessica Oliveira enfrenta desafios significativos relacionados à falta de presença online e à ausência de sistemas automatizados para gerenciar suas tarefas. Essas dificuldades podem estar afetando a capacidade do estúdio de atrair novos alunos, gerenciar eficientemente suas operações internas e manter registros precisos de suas atividades.

O objetivo deste projeto é desenvolver uma aplicação para uso interno no próprio estúdio de ballet. A aplicação consistirá em um site para o estúdio, com a implementação de um sistema de gerenciamento de turmas e planejamento de aulas. Além disso, consideraremos a inclusão de funcionalidades adicionais para auxiliar na administração financeira, na comunicação com os clientes e no acompanhamento do progresso dos alunos.

As tecnologias e ferramentas que serão utilizadas incluem:

CSS: Para estilização e design visual do site.
HTML: Para estruturar as páginas e conteúdo do site.
Canva: Uma ferramenta de design gráfico que pode ser usada para criar elementos visuais, como logotipos, banners e imagens.
Trello: Para gerenciar tarefas, acompanhar o progresso e colaborar com a equipe.
Figma: Uma plataforma de design colaborativo para criar protótipos e layouts.
Visual Studio Code: Um ambiente de desenvolvimento integrado (IDE) para escrever e testar código.
Com essas ferramentas, esperamos criar uma solução eficaz que atenda às necessidades do Studio de Ballet Jessica Oliveira e melhore sua eficiência operacional. 

## Personas e Mapas de Empatia

![Persona](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/128499173/09cd9e18-76be-484f-af89-0263c7fd1781)


![Persona (1)](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/128499173/4fde1345-f61e-439c-9408-5d125577df36)


![Persona (2)](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/128499173/f6063f5f-15ac-430e-9dfa-0d3888fbfb42)


## Histórias de Usuários

![HistóriaDeUsuarios drawio](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/128499173/9c4a281e-34e0-4c0c-9f15-c75b101508c8)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais


|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve apresentar uma tela de login, contendo um formulário de cadastro para que o usuário possa se cadastrar no site.| ALTA | 
|RF-002| O sistema deve apresentar uma tela de login, contendo um formulário de cadastro para que o usuário possa se cadastrar no site. | ALTA |
|RF-003| O sistema deve apresentar uma tela inicial contendo informações importantes sobre o estúdio. | ALTA |
|RF-004| O sistema deve apresentar uma tela com o objetivo de gerenciar as turmas do estúdio. | ALTA |
|RF-005| O sistema deve apresentar a funcionalidade de inscrever alunos nas turmas. | ALTA |
|RF-006| O sistema deve apresentar o cronograma das aulas na tela de planejamento. | ALTA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivo móvel | MÉDIA | 
|RNF-002| O sistema deve ter alta disponibilidade, funcionando sempre que for exigido. | ALTA | 
|RNF-003| O sistema deverá ser capaz de funcionar em diferentes plataformas. | ALTA | 
|RNF-004| O sistema deve garantir usabilidade, possuindo uma interface que seja intuitiva e fácil de ser usada. | ALTA | 
|RNF-005| O sistema deve possuir um tempo de resposta pequeno para as solicitações do usuário. | ALTA | 
|RNF-006| O sistema deve garantir que apenas administradores tenham acesso aos dados protegidos. | ALTA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                                        |
|--|------------------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre            |
|02| Alunos não poderão acessar a tela do administrador               |
|03| O sistema não disponibilizará a funcionalidade de se matricular  |
|04| O sistema deverá ter uma restrição de capacidade, limitando a inscrição de novos alunos com base na capacidade do estúdio  |

# Projeto de Interface

O Studio de Ballet Jessica Oliveira enfrenta desafios significativos relacionados à ausência de presença online e à falta de sistemas automatizados para gerenciar suas tarefas. Essas limitações podem estar dificultando o alcance de novos alunos, a eficiência nas operações internas e a manutenção precisa dos registros de atividades.

Para atender a essas necessidades, o projeto propõe o desenvolvimento de um site para o estúdio, com foco em gerenciamento de turmas, planejamento de aulas e outras funcionalidades relevantes. Vamos explorar as principais interfaces da solução:

Página Inicial (Home):

Objetivo: Apresentar o estúdio, sua missão e valores.
Funcionalidades:
Banner: Exibir imagens do estúdio, dançarinos e eventos.
Informações de Contato: Incluir telefone, e-mail e endereço.
Links para Redes Sociais: Facilitar a conexão com o público.
Requisitos Funcionais: Exibir informações relevantes de forma atraente e acessível.

Página de Turmas:

Objetivo: Listar as turmas disponíveis.
Funcionalidades:
Detalhes da Turma: Horários, níveis, instrutores.
Botão de Inscrição: Permitir que novos alunos se inscrevam.
Requisitos Funcionais: Organizar as informações de forma clara e fornecer um meio de inscrição.

Página de Planejamento de Aulas:

Objetivo: Apresentar o cronograma de aulas.
Funcionalidades:
Calendário: Mostrar datas e horários das aulas.
Filtros: Permitir que os alunos escolham turmas específicas.
Requisitos Funcionais: Manter o calendário atualizado e permitir filtragem.

Página de Administração Financeira:

Objetivo: Auxiliar na gestão financeira do estúdio.
Funcionalidades:
Controle de Pagamentos: Registrar mensalidades e pagamentos.
Requisitos Funcionais: Garantir precisão nos registros financeiros.

Essas interfaces foram elaboradas considerando os requisitos funcionais (como inscrições, calendário de aulas e controle financeiro), os requisitos não funcionais (como usabilidade, desempenho e segurança) e as histórias de usuário abordadas nas Especificações do Projeto. A escolha das ferramentas (CSS, HTML, Canva, Trello, Figma e Visual Studio Code) deve contribuir para a eficácia e eficiência da solução.

## User Flow

![User Flow](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/127787843/b5242b17-0a2e-4d48-b3db-c68f3a7c5f07)

## Wireframes
LOGIN

![Login](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/127787843/d1455eb0-62c7-4db8-8559-ec28cb18f0e2)

Tela IniciaL

![Tela Inicial](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/127231260/053ad860-07fc-408f-b98d-8b0296babc85)

Tela Planejamento de aula

![TelaPlanejamentoAula](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/127527852/634cd6b1-7264-46ce-a5eb-b345e57435a6)

Tela Gerenciamento de turmas

![Wireframe](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/127527707/fd56fea5-4ab0-4904-a9aa-55155f611351)

Tela de controle de alunos

![19c553c948ad4e9291097ae7a23506f4](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/128499173/7913534a-76ba-4dd9-8059-6cb65893ff5c)



# Metodologia

Link Do Design Thinking

https://1drv.ms/b/c/3731a6fa54e99ab6/EfEM54IMNitBm8TOYN7-31wBHdU2Ghh2ENwxaIdXjQ5PDA?e=xK7Ff1

## Divisão de Papéis

### Divisão Sprint1:
> - Introdução - Iury
> - Especificação do projeto -  Arthur e gustavo
> - Projeto de interface - Dyogo
> - Metodologia - João

 Divisão de papéis feita pelo Trello, segue abaixo link da divisão 
> - [Link Trello](https://trello.com/b/Gw5jJOBr/organiza%C3%A7%C3%A3o-do-projeto)



## Ferramentas

| Ambiente  | Plataforma              |Link de Acesso |
|-----------|-------------------------|---------------|
|Repositório de código | GitHub | [GithubProjeto](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet) | 
|Hospedagem do site | Heroku |  https://XXXXXXX.herokuapp.com | 
|Protótipo Interativo | MavelApp ou Figma | [FigmaProjeto](https://www.figma.com/files/team/1225090478496638204/Ballet?fuid=1223021131448006920) | 

>
> - GitHub - Versionamento de código e organização
> - Teams e Trello - Reuniões e divisão de tarefas
> - Figma - Confecção de wireframes e personas
>


## Controle de Versão

> Criação do repositório feita diretamente na interface de plataforma de hospedagem(GitHub).
> A ferramenta de controle de versão adotada no projeto foi o
> [Github](https://github.com)
> 
> 
> O projeto segue a seguinte convenção para o nome de branchs:
> 
> - `master`: versão estável já testada do software
> - `unstable`: versão já testada do software, porém instável
> - `testing`: versão em testes do software
> - `dev`: versão de desenvolvimento do software
> 
> Quanto à gerência de issues, o projeto adota a seguinte convenção para
> etiquetas:
> 
> - `bugfix`: uma funcionalidade encontra-se com problemas
> - `enhancement`: uma funcionalidade precisa ser melhorada
> - `feature`: uma nova funcionalidade precisa ser introduzida

## Modelagem do processo de negócio
A modelagem "As Is" e "To Be" são complementares e essenciais para uma análise completa de processos. A modelagem "As Is" fornece a base necessária para entender a situação atual e identificar áreas de melhoria, enquanto a modelagem "To Be" oferece uma visão clara e estruturada do futuro desejado, guiando a organização em direção às mudanças necessárias.

Em resumo, a combinação de ambos os tipos de modelagem permite uma abordagem estruturada para a melhoria contínua dos processos, ajudando as organizações a se adaptarem e prosperarem em um ambiente de negócios em constante mudança.
### AS IS 
![Capturar](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/127527852/1f4e4330-47f6-4b0f-a6bc-85940527702f)

### TO BE
![To Be](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/127231260/435d479d-4b04-46e3-b2f6-57649fbfadf8)
## Diagrama de Entidade-Relacionamento e Modelo relacional 
O modelo relacional e o Diagrama de Entidade-Relacionamento são pilares essenciais no design e na gestão de bancos de dados. Ambos desempenham papéis vitais na organização e na representação estruturada dos dados, facilitando a compreensão, a manipulação e a integridade das informações. A integração desses conceitos permite uma modelagem eficiente, garantindo que os dados sejam armazenados de maneira lógica, coerente e facilmente acessível, atendendo às necessidades das organizações de forma precisa e eficaz.
### Diagrama de Entidade-Relacionamento
![Tiaw drawio](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/127527852/6a621cfa-625d-4b1d-8f4a-fd1fee713b70)

### Modelo Relacional
![tabela drawio](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/127527852/18986aca-5e7d-4ff8-a6c9-aac608cd040f)

# Projeto da Solução
O projeto teve como solução para a demanda solicitada pelo Studio Jessica Oliveira o desenvolvimento de um site web, com o intuito de solucionar os problemas relatados pela empresa. O projeto contém telas para administradores e alunos. Na tela de administradores, é possível criar turmas, planejar e administrar aulas, além de se organizar financeiramente. Na tela de aluno, ele consegue se manter informado sobre sua quantidade de faltas e suas notas. Nossa tela inicial contém todos os dados do studio, turmas e uma API com a localização, garantindo facilidade para que futuros clientes encontrem o studio.

## Tecnologias Utilizadas

Para a implementação da solução, utilizamos uma variedade de ferramentas e tecnologias. As principais ferramentas empregadas foram Visual Studio Code, Visual Studio, GitHub e SQL Server. No que diz respeito às linguagens de programação, a API foi desenvolvida em C#, enquanto o front-end foi criado utilizando HTML, CSS e JavaScript. Cada uma dessas tecnologias desempenhou um papel crucial na construção de uma aplicação robusta e eficiente, permitindo um desenvolvimento ágil e colaborativo através do GitHub, e garantindo a persistência de dados com o SQL Server.


## Arquitetura da solução
![Navegador (4)](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/127527852/2fd28c4d-9886-483f-bfbf-6bb1be7d6147)

# Avaliação da Aplicação

# Cenário 1: Registro de Usuário
Objetivo: Verificar se o usuário pode registrar-se com sucesso na aplicação.
Requisitos: O usuário deve preencher todos os campos obrigatórios corretamente (nome, cpf, senha, modalidade) e receber uma confirmação de registro bem-sucedido.
Passos:
1- Navegar para a página de registro.
2- Preencher o formulário com informações válidas.
3- Salvar o formulário.
4- Verificar a mensagem de sucesso.

# Cenário 2: Login de Usuário
Objetivo: Verificar se o usuário pode fazer login com credenciais corretas.
Requisitos: O usuário deve ser redirecionado para a página inicial após o login bem-sucedido.
Passos:
1- Navegar para a página de login.
2- Inserir nome e senha correta.
3- Redirecionar para a pagina inicial 

# Cenário 3: Financeiro
•	Objetivo: Verificar situação de pagamento e alterar.
•	Requisitos: O sistema deve mostrar os alunos cadastrados no banco de dados e o usuário deve poder alterar a situação do pagamento.
•	Passos:
1.	Navegar para a página Financeiro.
2.	Alterar em situação pagamento.

# Cenário 4: Turmas
•	Objetivo: Verificar alunos de cada turma e adicionar nota.
•	Requisitos: O sistema deve mostrar os alunos cadastrados no banco de dados e o usuário deve poder alterar a nota.
•	Passos:
1.	Navegar para a página Turmas.
2.	Clicar no código da turma.
3.	Alterar nota.
4.	Salvar. 

# Cenário 5: Aulas
•	Objetivo: Verificar aulas criadas e adicionar musica.
•	Requisitos: O sistema deve mostrar o nome do professor e da turma cadastrados no banco de dados e o usuário deve poder alterar a musica, excluir e adicionar um novo planejamento.
•	Passos:
1.	Navegar para a página Aulas.
2.	Escrever uma musica.
3.	Adicionar planejamento.
4.	Editar. 
5.	Excluir

# Cenário 6: Presença
•	Objetivo: Adicionar falta ao aluno.
•	Requisitos: O sistema deve mostrar o nome do aluno cadastrado no banco de dados e o usuário deve poder adicionar falta ao aluno.
•	Passos:
1.	Navegar para a página presença.
2.	Ver alunos.
3.	Checkbox nos alunos.
4.	Salvar. 

# Cenário 7: Informações aluno
•	Objetivo: Visualizar a nota e a situação de pagamento do aluno.
•	Requisitos: O sistema deve mostrar o nome, nota, CPF e situação de pagamento do aluno cadastrado no banco de dados.
•	Passos:
1.	Navegar para a página Informações alunos.

## Plano de Testes
# Cenário 1: Registro de Usuário
•	Objetivo: Verificar se o usuário pode registrar-se com sucesso na aplicação.
•	Requisitos: O usuário deve preencher todos os campos obrigatórios corretamente (nome, CPF, senha, modalidade) e receber uma confirmação de registro bem-sucedido.
•	Passos:
1.	Navegar para a página de registro.
2.	Preencher o formulário com informações válidas.
3.	Submeter o formulário.
4.	Verificar a mensagem de sucesso.
•	Grupo de Usuários: Novos usuários.
•	Ferramenta Utilizada:
o	Swagger: Para testar os endpoints de API que suportam o registro de usuários, verificando se os dados são enviados e armazenados corretamente.
# Cenário 2: Login de Usuário
•	Objetivo: Verificar se o usuário pode fazer login com credenciais corretas.
•	Requisitos: O usuário deve ser redirecionado para a página inicial após o login bem-sucedido.
•	Passos:
1.	Navegar para a página de login.
2.	Inserir nome e senha correto.
3.	Salvar o formulário.
4.	Verificar o redirecionamento para a página inicial.
•	Grupo de Usuários: Usuários registrados (testers internos com contas criadas previamente).
•	Ferramenta Utilizada:
o	Swagger: Para testar os endpoints de API que suportam a autenticação de usuários, garantindo que as credenciais sejam verificadas corretamente.
# Cenário 3: Financeiro
•	Objetivo: Verificar situação de pagamento e alterar.
•	Requisitos: O sistema deve mostrar os alunos cadastrados no banco de dados e o usuário deve poder alterar a situação do pagamento.
•	Passos:
1.	Navegar para a página Financeiro.
2.	Alterar a situação de pagamento.
•	Grupo de Usuários: Usuário de teste (logado como professor).
•	Ferramenta Utilizada:
o	Swagger: Para testar os endpoints de API que fornecem os dados financeiros do aluno e permitem alterações na situação de pagamento.
# Cenário 4: Turmas
•	Objetivo: Verificar alunos de cada turma e adicionar nota.
•	Requisitos: O sistema deve mostrar os alunos cadastrados no banco de dados e o usuário deve poder alterar a nota.
•	Passos:
1.	Navegar para a página Turmas.
2.	Clicar no código da turma.
3.	Alterar a nota.
4.	Salvar.
•	Grupo de Usuários: Usuário de teste (logado como professor).
•	Ferramenta Utilizada:
o	Swagger: Para testar os endpoints de API que fornecem dados das turmas e permitem alterações nas notas dos alunos.
# Cenário 5: Aulas
•	Objetivo: Verificar aulas criadas e adicionar música.
•	Requisitos: O sistema deve mostrar o nome do professor e da turma cadastrados no banco de dados e o usuário deve poder alterar a música, excluir e adicionar um novo planejamento.
•	Passos:
1.	Navegar para a página Aulas.
2.	Escrever uma música.
3.	Adicionar planejamento.
4.	Editar.
5.	Excluir.
•	Grupo de Usuários: Usuário de teste (logado como professor).
•	Ferramenta Utilizada:
o	Swagger: Para testar os endpoints de API que gerenciam aulas, professores e planejamentos.
# Cenário 6: Presença
•	Objetivo: Adicionar falta ao aluno.
•	Requisitos: O sistema deve mostrar o nome do aluno cadastrado no banco de dados e o usuário deve poder adicionar falta ao aluno.
•	Passos:
1.	Navegar para a página Presença.
2.	Ver alunos.
3.	Marcar checkbox nos alunos faltantes.
4.	Salvar.
•	Grupo de Usuários: Usuário de teste (logado como professor).
•	Ferramenta Utilizada:
o	Swagger: Para testar os endpoints de API que gerenciam a presença dos alunos.
# Cenário 7: Informações do Aluno
•	Objetivo: Visualizar a nota e a situação de pagamento do aluno.
•	Requisitos: O sistema deve mostrar o nome, nota, CPF e situação de pagamento do aluno cadastrado no banco de dados.
•	Passos:
1.	Navegar para a página Informações do Aluno.
•	Grupo de Usuários: Usuário de teste (logado como aluno).
•	Ferramenta Utilizada:
o	Swagger: Para testar os endpoints de API que fornecem as informações detalhadas dos alunos.

## Ferramentas de Testes 

# Swagger:
•	Descrição: Ferramenta para desenvolvimento e teste de APIs. Permite enviar requisições HTTP e visualizar respostas.

•	Imagem: 
![image](https://github.com/PSG-TIAPN-2022-1/psg-tiapn-2024-1-studio-ballet/assets/127527852/8a814b25-0685-41a2-8014-4a78f4474258)

•	Uso: Utilizado para validar os endpoints de API utilizados nos cenários de teste. Swagger garante que as operações de backend funcionem conforme esperado, permitindo testar a criação, leitura, atualização e exclusão de dados através das APIs.

## Registros de Testes
# Cenário 1: Registro de Usuário
•	Resultado: O registro de usuário foi bem-sucedido para todos os usuários de teste. Todos os campos obrigatórios foram validados corretamente, e as mensagens de sucesso foram exibidas conforme esperado.
•	Pontos Fortes: A validação de entrada nos campos de nome, CPF, senha e modalidade funcionou conforme o esperado, garantindo que apenas dados válidos fossem aceitos.
•	Pontos Fracos Identificados: Ter que escolher modalidade na hora de cadastrar.
•	Melhorias Futuras: Considerar a inclusão de validações adicionais, como verificação de formato de CPF e complexidade de senha, para aumentar a segurança e a robustez do sistema. Da ao usuário a possibilidade de cadastrar sem escolher modalidade.

# Cenário 2: Login de Usuário
•	Resultado: O login foi realizado com sucesso para todos os usuários de teste. Após inserir credenciais corretas, os usuários foram redirecionados para a página inicial.
•	Pontos Fortes: A autenticação funcionou corretamente, garantindo o acesso apenas a usuários registrados e autorizados.
•	Pontos Fracos Identificados: Nenhum ponto fraco significativo foi identificado neste cenário.
•	Melhorias Futuras: Trocar senha por código enviado ao e-mail.

# Cenário 3: Financeiro
•	Resultado: Os usuários conseguiram visualizar e alterar a situação de pagamento dos alunos. As operações de alteração foram concluídas com sucesso.
•	Pontos Fortes: As funcionalidades relacionadas ao financeiro estão operando conforme esperado, permitindo um controle dos pagamentos dos alunos.
•	Pontos Fracos Identificados: Nenhum ponto fraco significativo foi identificado neste cenário.
•	Melhorias Futuras: Incluir que o aluno consiga pagar pelo site.

# Cenário 4: Turmas
•	Resultado: As notas dos alunos puderam ser alteradas com sucesso pelos usuários. Todas as operações de modificação foram concluídas sem problemas.
•	Pontos Fortes: A funcionalidade de gestão de notas está operando de forma eficiente, permitindo aos professores atualizar informações dos alunos.
•	Pontos Fracos Identificados: Nenhum ponto fraco significativo foi identificado neste cenário.
•	Melhorias Futuras: Implementar um sistema de histórico de notas para acompanhar alterações ao longo do tempo.

# Cenário 5: Aulas
•	Resultado: Os usuários conseguiram criar, editar e excluir aulas conforme necessário. As operações de gerenciamento de aulas foram bem-sucedidas.
•	Pontos Fortes: A funcionalidade de gestão de aulas está completa, permitindo aos professores manter um planejamento didático eficiente.
•	Pontos Fracos Identificados: Ao adicionar planejamento, precisa recarregar para editar e excluir.
•	Melhorias Futuras: Incluir data da aula.

# Cenário 6: Presença
•	Resultado: Os usuários conseguiram marcar a presença dos alunos sem dificuldades. Todas as alterações foram salvas conforme esperado.
•	Pontos Fortes: A funcionalidade de controle de presença está operando de maneira eficaz, auxiliando no monitoramento da participação dos alunos.
•	Pontos Fracos Identificados: Nenhum ponto fraco significativo foi identificado neste cenário.
•	Melhorias Futuras: Implementar um método de tirar a falta.

# Cenário 7: Informações do Aluno
•	Resultado: As informações detalhadas dos alunos puderam ser visualizadas pelos usuários autorizados. Todos os dados foram exibidos corretamente.
•	Pontos Fortes: A funcionalidade de exibição de informações do aluno está funcionando conforme esperado, fornecendo dados precisos e atualizados.
•	Pontos Fracos Identificados: Nenhum ponto fraco significativo foi identificado neste cenário.
•	Melhorias Futuras: Implementar a frequência dos alunos.


# Referências

> **Links Úteis**:
> - [Camunda](https://modeler.cloud.camunda.io/login)
> - [Draw.io](https://www.drawio.com/)
> - [W3Schools](https://www.w3schools.com/)
