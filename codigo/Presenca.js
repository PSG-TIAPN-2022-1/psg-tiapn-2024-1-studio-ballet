
//Constante recebendo url da API
const url = 'http://localhost:5295/api/Aluno'; 


//Requisição GET da API
async function fetchData() {
  try {
    const response = await fetch(url, {
      method: 'GET',
      mode: 'cors',
      credentials: 'include'
    });

    if (!response.ok) {
      throw new Error(`Erro na requisição: ${response.status}`);
    }

    const data = await response.json();
    return data; 

  } catch (error) {
    console.error('Erro:', error);
    throw error;
  }
}

//Variaveis

const salva1= document.querySelector(".salva1");
const salva2= document.querySelector(".salva2");
const salva3= document.querySelector(".salva3");
const salva4= document.querySelector(".salva4");
const salva5= document.querySelector(".salva5");
const salva6= document.querySelector(".salva6");
const salva7= document.querySelector(".salva7");
let alunosNaClasse = []; 


//funções onclick para os botões que salvam as faltas 
salva1.addEventListener('click', function() {
  salvarFaltas('1');
  
});
salva2.addEventListener('click', function() {
  salvarFaltas('2');
  
});
salva3.addEventListener('click', function() {
  salvarFaltas('3');
  
});
salva4.addEventListener('click', function() {
  salvarFaltas('4');
  
});
salva5.addEventListener('click', function() {
  salvarFaltas('5');
  
});
salva6.addEventListener('click', function() {
  salvarFaltas('6');
  
});
salva7.addEventListener('click', function() {
  salvarFaltas('7');
  
});

//Funções para automatização com banco de dados adicionando os alunos da classe 1

async function criar1() {
  try {
    const data = await fetchData(); // Obtém os dados dos alunos da API
    const ul = document.getElementById('code1'); // Obtém o elemento <ul> com id 'code1'

    // Limpa o conteúdo atual dentro do <ul>
    ul.innerHTML = '';

    // Captura o valor da disciplina selecionada 
    const disciplinaSelecionada = '1'; // Pode ser dinâmico, dependendo da sua implementação

    // Filtra os alunos da disciplina selecionada
    const alunosDaDisciplina = data.dados.filter(item => item.disciplina == disciplinaSelecionada);

    // Verifica se há alunos para a disciplina selecionada
    if (alunosDaDisciplina.length === 0) {
      const li = document.createElement('li');
      li.textContent = 'Nenhum aluno encontrado para esta disciplina.';
      ul.appendChild(li);
      return;
    }

    // Itera sobre os alunos da disciplina selecionada e cria os elementos correspondentes
    alunosDaDisciplina.forEach((aluno, index) => {
      // Criando o elemento <li>
      const li = document.createElement('li');

      // Criando o elemento <div> com a classe "checkbox-container"
      const div = document.createElement('div');
      div.classList.add('checkbox-container');

      // Criando o elemento <input> do tipo checkbox
      const input = document.createElement('input');
      input.setAttribute('type', 'checkbox');
      input.setAttribute('id', `presenca-aluno-${aluno.id}`); // Usando aluno.id para IDs únicos

      // Criando o elemento <label> associado ao input
      const label = document.createElement('label');
      label.setAttribute('for', `presenca-aluno-${aluno.id}`);
      label.textContent = aluno.nome; // Preenche o texto do label com o nome do aluno

      // Adicionando o input e o label dentro do div
      div.appendChild(input);
      div.appendChild(label);

      // Adicionando o div dentro do li
      li.appendChild(div);

      // Adicionando o li dentro do <ul>
      ul.appendChild(li);
    });

  } catch (error) {
    console.error('Erro ao criar elementos:', error);
  }
}


//Funções para automatização com banco de dados adicionando os alunos da classe 2

async function criar2() {
  try {
    const data = await fetchData(); // Obtém os dados dos alunos da API
    const ul = document.getElementById('code2'); // Obtém o elemento <ul> com id 'code2'

    // Limpa o conteúdo atual dentro do <ul>
    ul.innerHTML = '';

    const disciplinaSelecionada = '2'; // Pode ser dinâmico, dependendo da sua implementação

    // Filtra os alunos da disciplina selecionada
    const alunosDaDisciplina = data.dados.filter(item => item.disciplina == disciplinaSelecionada);

    // Verifica se há alunos para a disciplina selecionada
    if (alunosDaDisciplina.length === 0) {
      const li = document.createElement('li');
      li.textContent = 'Nenhum aluno encontrado para esta disciplina.';
      ul.appendChild(li);
      return;
    }

    // Itera sobre os alunos da disciplina selecionada e cria os elementos correspondentes
    alunosDaDisciplina.forEach((aluno, index) => {
      // Criando o elemento <li>
      const li = document.createElement('li');

      // Criando o elemento <div> com a classe "checkbox-container"
      const div = document.createElement('div');
      div.classList.add('checkbox-container');

      // Criando o elemento <input> do tipo checkbox
      const input = document.createElement('input');
      input.setAttribute('type', 'checkbox');
      input.setAttribute('id', `presenca-aluno-${aluno.id}`); // Usando aluno.id para IDs únicos

      // Criando o elemento <label> associado ao input
      const label = document.createElement('label');
      label.setAttribute('for', `presenca-aluno-${aluno.id}`);
      label.textContent = aluno.nome; // Preenche o texto do label com o nome do aluno

      // Adicionando o input e o label dentro do div
      div.appendChild(input);
      div.appendChild(label);

      // Adicionando o div dentro do li
      li.appendChild(div);

      // Adicionando o li dentro do <ul>
      ul.appendChild(li);
    });

  } catch (error) {
    console.error('Erro ao criar elementos:', error);
  }
}


// Função para automaticação do banco de dados adicionando os alunos da classe 3
async function criar3() {
  try {
    const data = await fetchData(); // Obtém os dados dos alunos da API
    const ul = document.getElementById('code3'); // Obtém o elemento <ul> com id 'code3'

    // Limpa o conteúdo atual dentro do <ul>
    ul.innerHTML = '';

    const disciplinaSelecionada = '3'; // Pode ser dinâmico, dependendo da sua implementação

    // Filtra os alunos da disciplina selecionada
    const alunosDaDisciplina = data.dados.filter(item => item.disciplina == disciplinaSelecionada);

    // Verifica se há alunos para a disciplina selecionada
    if (alunosDaDisciplina.length === 0) {
      const li = document.createElement('li');
      li.textContent = 'Nenhum aluno encontrado para esta disciplina.';
      ul.appendChild(li);
      return;
    }

    // Itera sobre os alunos da disciplina selecionada e cria os elementos correspondentes
    alunosDaDisciplina.forEach((aluno, index) => {
      // Criando o elemento <li>
      const li = document.createElement('li');

      // Criando o elemento <div> com a classe "checkbox-container"
      const div = document.createElement('div');
      div.classList.add('checkbox-container');

      // Criando o elemento <input> do tipo checkbox
      const input = document.createElement('input');
      input.setAttribute('type', 'checkbox');
      input.setAttribute('id', `presenca-aluno-${aluno.id}`); // Usando aluno.id para IDs únicos

      // Criando o elemento <label> associado ao input
      const label = document.createElement('label');
      label.setAttribute('for', `presenca-aluno-${aluno.id}`);
      label.textContent = aluno.nome; // Preenche o texto do label com o nome do aluno

      // Adicionando o input e o label dentro do div
      div.appendChild(input);
      div.appendChild(label);

      // Adicionando o div dentro do li
      li.appendChild(div);

      // Adicionando o li dentro do <ul>
      ul.appendChild(li);
    });

  } catch (error) {
    console.error('Erro ao criar elementos:', error);
  }
}



// Função para automaticação do banco de dados adicionando os alunos da classe 4
async function criar4() {
  try {
    const data = await fetchData(); // Obtém os dados dos alunos da API
    const ul = document.getElementById('code4'); // Obtém o elemento <ul> com id 'code4'

    // Limpa o conteúdo atual dentro do <ul>
    ul.innerHTML = '';

    const disciplinaSelecionada = '4'; // Pode ser dinâmico, dependendo da sua implementação

    // Filtra os alunos da disciplina selecionada
    const alunosDaDisciplina = data.dados.filter(item => item.disciplina == disciplinaSelecionada);

    // Verifica se há alunos para a disciplina selecionada
    if (alunosDaDisciplina.length === 0) {
      const li = document.createElement('li');
      li.textContent = 'Nenhum aluno encontrado para esta disciplina.';
      ul.appendChild(li);
      return;
    }

    // Itera sobre os alunos da disciplina selecionada e cria os elementos correspondentes
    alunosDaDisciplina.forEach((aluno, index) => {
      // Criando o elemento <li>
      const li = document.createElement('li');

      // Criando o elemento <div> com a classe "checkbox-container"
      const div = document.createElement('div');
      div.classList.add('checkbox-container');

      // Criando o elemento <input> do tipo checkbox
      const input = document.createElement('input');
      input.setAttribute('type', 'checkbox');
      input.setAttribute('id', `presenca-aluno-${aluno.id}`); // Usando aluno.id para IDs únicos

      // Criando o elemento <label> associado ao input
      const label = document.createElement('label');
      label.setAttribute('for', `presenca-aluno-${aluno.id}`);
      label.textContent = aluno.nome; // Preenche o texto do label com o nome do aluno

      // Adicionando o input e o label dentro do div
      div.appendChild(input);
      div.appendChild(label);

      // Adicionando o div dentro do li
      li.appendChild(div);

      // Adicionando o li dentro do <ul>
      ul.appendChild(li);
    });

  } catch (error) {
    console.error('Erro ao criar elementos:', error);
  }
}



// Função para automaticação do banco de dados adicionando os alunos da classe 5
async function criar5() {
  try {
    const data = await fetchData(); // Obtém os dados dos alunos da API
    const ul = document.getElementById('code5'); // Obtém o elemento <ul> com id 'code5'

    // Limpa o conteúdo atual dentro do <ul>
    ul.innerHTML = '';

    const disciplinaSelecionada = '5'; // Pode ser dinâmico, dependendo da sua implementação

    // Filtra os alunos da disciplina selecionada
    const alunosDaDisciplina = data.dados.filter(item => item.disciplina == disciplinaSelecionada);

    // Verifica se há alunos para a disciplina selecionada
    if (alunosDaDisciplina.length === 0) {
      const li = document.createElement('li');
      li.textContent = 'Nenhum aluno encontrado para esta disciplina.';
      ul.appendChild(li);
      return;
    }

    // Itera sobre os alunos da disciplina selecionada e cria os elementos correspondentes
    alunosDaDisciplina.forEach((aluno, index) => {
      // Criando o elemento <li>
      const li = document.createElement('li');

      // Criando o elemento <div> com a classe "checkbox-container"
      const div = document.createElement('div');
      div.classList.add('checkbox-container');

      // Criando o elemento <input> do tipo checkbox
      const input = document.createElement('input');
      input.setAttribute('type', 'checkbox');
      input.setAttribute('id', `presenca-aluno-${aluno.id}`); // Usando aluno.id para IDs únicos

      // Criando o elemento <label> associado ao input
      const label = document.createElement('label');
      label.setAttribute('for', `presenca-aluno-${aluno.id}`);
      label.textContent = aluno.nome; // Preenche o texto do label com o nome do aluno

      // Adicionando o input e o label dentro do div
      div.appendChild(input);
      div.appendChild(label);

      // Adicionando o div dentro do li
      li.appendChild(div);

      // Adicionando o li dentro do <ul>
      ul.appendChild(li);
    });

  } catch (error) {
    console.error('Erro ao criar elementos:', error);
  }
}


// Função para automaticação do banco de dados adicionando os alunos da classe 6
async function criar6() {
  try {
    const data = await fetchData(); // Obtém os dados dos alunos da API
    const ul = document.getElementById('code6'); // Obtém o elemento <ul> com id 'code6'

    // Limpa o conteúdo atual dentro do <ul>
    ul.innerHTML = '';

    const disciplinaSelecionada = '6'; // Pode ser dinâmico, dependendo da sua implementação

    // Filtra os alunos da disciplina selecionada
    const alunosDaDisciplina = data.dados.filter(item => item.disciplina === disciplinaSelecionada);

    // Verifica se há alunos para a disciplina selecionada
    if (alunosDaDisciplina.length === 0) {
      const li = document.createElement('li');
      li.textContent = 'Nenhum aluno encontrado para esta disciplina.';
      ul.appendChild(li);
      return;
    }

    // Itera sobre os alunos da disciplina selecionada e cria os elementos correspondentes
    alunosDaDisciplina.forEach((aluno, index) => {
      // Criando o elemento <li>
      const li = document.createElement('li');

      // Criando o elemento <div> com a classe "checkbox-container"
      const div = document.createElement('div');
      div.classList.add('checkbox-container');

      // Criando o elemento <input> do tipo checkbox
      const input = document.createElement('input');
      input.setAttribute('type', 'checkbox');
      input.setAttribute('id', `presenca-aluno-${aluno.id}`); // Usando aluno.id para IDs únicos

      // Criando o elemento <label> associado ao input
      const label = document.createElement('label');
      label.setAttribute('for', `presenca-aluno-${aluno.id}`);
      label.textContent = aluno.nome; // Preenche o texto do label com o nome do aluno

      // Adicionando o input e o label dentro do div
      div.appendChild(input);
      div.appendChild(label);

      // Adicionando o div dentro do li
      li.appendChild(div);

      // Adicionando o li dentro do <ul>
      ul.appendChild(li);
    });

  } catch (error) {
    console.error('Erro ao criar elementos:', error);
  }
}


// Função para automaticação do banco de dados adicionando os alunos da classe 7
async function criar7() {
  try {
    const data = await fetchData(); // Obtém os dados dos alunos da API
    const ul = document.getElementById('code7'); // Obtém o elemento <ul> com id 'code7'

    // Limpa o conteúdo atual dentro do <ul>
    ul.innerHTML = '';

    const disciplinaSelecionada = '7'; // Pode ser dinâmico, dependendo da sua implementação

    // Filtra os alunos da disciplina selecionada
    const alunosDaDisciplina = data.dados.filter(item => item.disciplina === disciplinaSelecionada);

    // Verifica se há alunos para a disciplina selecionada
    if (alunosDaDisciplina.length === 0) {
      const li = document.createElement('li');
      li.textContent = 'Nenhum aluno encontrado para esta disciplina.';
      ul.appendChild(li);
      return;
    }

    // Itera sobre os alunos da disciplina selecionada e cria os elementos correspondentes
    alunosDaDisciplina.forEach((aluno, index) => {
      // Criando o elemento <li>
      const li = document.createElement('li');

      // Criando o elemento <div> com a classe "checkbox-container"
      const div = document.createElement('div');
      div.classList.add('checkbox-container');

      // Criando o elemento <input> do tipo checkbox
      const input = document.createElement('input');
      input.setAttribute('type', 'checkbox');
      input.setAttribute('id', `presenca-aluno-${aluno.id}`); // Usando aluno.id para IDs únicos

      // Criando o elemento <label> associado ao input
      const label = document.createElement('label');
      label.setAttribute('for', `presenca-aluno-${aluno.id}`);
      label.textContent = aluno.nome; // Preenche o texto do label com o nome do aluno

      // Adicionando o input e o label dentro do div
      div.appendChild(input);
      div.appendChild(label);

      // Adicionando o div dentro do li
      li.appendChild(div);

      // Adicionando o li dentro do <ul>
      ul.appendChild(li);
    });

  } catch (error) {
    console.error('Erro ao criar elementos:', error);
  }
}



async function atualizarFaltaAluno(aluno) {
  try {
      // Converte faltas para inteiro e incrementa 1
      const faltasInt = parseInt(aluno.faltas, 10) + 1;

      const alunoAtual = {
          cpf: aluno.cpf,
          nome: aluno.nome,
          dataDeNascimento: aluno.dataDeNascimento,
          nota: aluno.nota, 
          disciplina: aluno.disciplina,
          faltas: faltasInt.toString(),
          id: aluno.id,
          email: aluno.email,
          senha: aluno.senha
      };

      const response = await fetch(url, {
          method: 'PUT',
          headers: {
              'Content-Type': 'application/json'
          },
          body: JSON.stringify(alunoAtual)
      });

      if (!response.ok) {
          throw new Error(`Erro ao atualizar o aluno: ${response.statusText}`);
      }

      const data = await response.json();
      console.log('Aluno atualizado com sucesso:', data);
      return data; 
  } catch (error) {
      console.error('Erro ao atualizar o aluno:', error);
      throw error; 
  }
}








async function salvarFaltas(idClasse) {
  try {
    const data = await fetchData(); // Obtém os dados dos alunos da API

    // Verifique se os dados existem e são um array
    if (!data || !data.dados || !Array.isArray(data.dados)) {
      throw new Error('Dados inválidos recebidos.');
    }

    // Filtrar os alunos pela disciplina (idClasse)
    const alunosNaClasse = data.dados.filter(item => item.disciplina === idClasse);
    console.log('Alunos na classe:', alunosNaClasse);

    // Verifica se há alunos para a disciplina selecionada
    if (alunosNaClasse.length === 0) {
      console.log('Nenhum aluno encontrado para esta disciplina.');
      alert("Nenhum aluno encontrado para esta disciplina.");
      return;
    }

    // Obtém a lista (<ul>) correspondente à turma
    const ul = document.getElementById(`code${idClasse}`);
    console.log('UL:', ul); // Verifica se ul está sendo encontrado corretamente

    // Verifica se o elemento <ul> foi encontrado
    if (!ul) {
      throw new Error(`Elemento <ul> com id 'code${idClasse}' não encontrado.`);
    }

    // Filtra os alunos faltosos (com checkbox marcada)
    const alunosFaltosos = alunosNaClasse.filter(aluno => {
      // Obtém a checkbox específica do aluno
      const checkbox = ul.querySelector(`#presenca-aluno-${aluno.id}`);
      console.log('Checkbox para aluno', aluno.nome, checkbox); // Verifica qual checkbox está sendo encontrado
      return checkbox && checkbox.checked;
    });

    // Verificar se há alunos faltosos
    if (alunosFaltosos.length === 0) {
      console.log('Nenhum aluno faltoso encontrado.');
      alert("Nenhum aluno faltoso para salvar.");
      return;
    }

    // Mapeia as chamadas para atualizarFaltaAluno em promessas
    const atualizacoesPromises = alunosFaltosos.map(aluno => atualizarFaltaAluno(aluno));

    // Aguarda todas as promessas serem resolvidas
    await Promise.all(atualizacoesPromises);

    console.log(`Faltas salvas para os alunos:`, alunosFaltosos);

    // Mensagem de sucesso após todas as atualizações
    alert("Faltas salvas com sucesso!");
  } catch (error) {
    console.error('Erro ao salvar faltas:', error);
    alert("Ocorreu um erro ao salvar as faltas. Tente novamente.");
  }
}





//Função para abrir alunos da turma
function toggleAlunos(id) {
    var alunosDiv = document.getElementById(id);
      // Verifica se a div de alunos está visível ou não
      if (alunosDiv.style.display === 'none' || alunosDiv.style.display === '') {
        alunosDiv.style.display = 'block';
      } else {
        alunosDiv.style.display = 'none';
      }
  }





  criar1();
  criar2();
  criar3();
  criar4();
  criar5();
  criar6();
  criar7();