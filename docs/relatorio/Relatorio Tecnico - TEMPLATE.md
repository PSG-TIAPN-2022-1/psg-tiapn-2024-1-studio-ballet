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
- [**############## SPRINT 1 ACABA AQUI #############**](#-sprint-1-acaba-aqui-)
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
Relatórios Financeiros: Visualizar receitas e despesas.
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

# **############## SPRINT 1 ACABA AQUI #############**


# Projeto da Solução

......  COLOQUE AQUI O SEU TEXTO ......

## Tecnologias Utilizadas

......  COLOQUE AQUI O SEU TEXTO ......

> Descreva aqui qual(is) tecnologias você vai usar para resolver o seu
> problema, ou seja, implementar a sua solução. Liste todas as
> tecnologias envolvidas, linguagens a serem utilizadas, serviços web,
> frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.
> Apresente também uma figura explicando como as tecnologias estão
> relacionadas ou como uma interação do usuário com o sistema vai ser
> conduzida, por onde ela passa até retornar uma resposta ao usuário.
> 
> Inclua os diagramas de User Flow, esboços criados pelo grupo
> (stoyboards), além dos protótipos de telas (wireframes). Descreva cada
> item textualmente comentando e complementando o que está apresentado
> nas imagens.

## Arquitetura da solução

......  COLOQUE AQUI O SEU TEXTO E O DIAGRAMA DE ARQUITETURA .......

> Inclua um diagrama da solução e descreva os módulos e as tecnologias
> que fazem parte da solução. Discorra sobre o diagrama.
> 
> **Exemplo do diagrama de Arquitetura**:
> 
> ![Exemplo de Arquitetura](images/arquitetura-exemplo.png)


# Avaliação da Aplicação

......  COLOQUE AQUI O SEU TEXTO ......

> Apresente os cenários de testes utilizados na realização dos testes da
> sua aplicação. Escolha cenários de testes que demonstrem os requisitos
> sendo satisfeitos.

## Plano de Testes

......  COLOQUE AQUI O SEU TEXTO ......

> Enumere quais cenários de testes foram selecionados para teste. Neste
> tópico o grupo deve detalhar quais funcionalidades avaliadas, o grupo
> de usuários que foi escolhido para participar do teste e as
> ferramentas utilizadas.
> 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)

## Ferramentas de Testes (Opcional)

......  COLOQUE AQUI O SEU TEXTO ......

> Comente sobre as ferramentas de testes utilizadas.
> 
> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)

## Registros de Testes

......  COLOQUE AQUI O SEU TEXTO ......

> Discorra sobre os resultados do teste. Ressaltando pontos fortes e
> fracos identificados na solução. Comente como o grupo pretende atacar
> esses pontos nas próximas iterações. Apresente as falhas detectadas e
> as melhorias geradas a partir dos resultados obtidos nos testes.


# Referências

......  COLOQUE AQUI O SEU TEXTO ......

> Inclua todas as referências (livros, artigos, sites, etc) utilizados
> no desenvolvimento do trabalho.
> 
> **Links Úteis**:
> - [Formato ABNT](https://www.normastecnicas.com/abnt/trabalhos-academicos/referencias/)
> - [Referências Bibliográficas da ABNT](https://comunidade.rockcontent.com/referencia-bibliografica-abnt/)
