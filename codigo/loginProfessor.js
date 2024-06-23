const ProfessorApiUrl = 'http://localhost:5095/api/Professor';

document.getElementById('loginForm').addEventListener('submit', async function(event) {
    event.preventDefault();

    const disciplinaInput = document.getElementById('Disciplina').value.trim();
    const nomeInput = document.getElementById('Nome').value.trim();

    console.log('Disciplina digitada:', disciplinaInput);
    console.log('Nome digitado:', nomeInput);

    if (disciplinaInput === '' || nomeInput === '') {
        alert('Por favor, preencha todos os campos.');
        return;
    }

    try {
        const response = await fetch(ProfessorApiUrl);
        if (!response.ok) {
            throw new Error('Erro ao buscar dados.');
        }

        const data = await response.json();
        console.log('Dados da API:', data);

        // Verifica se 'data' é um objeto com a chave 'dados'
        if (!data || !Array.isArray(data.dados)) {
            throw new Error('Resposta da API inválida.');
        }

        // Verifica se há algum professor com a Disciplina e nome fornecidos
        const professor = data.dados.find(item => item.disciplina === disciplinaInput && item.nome === nomeInput);

        if (professor) {
            // Armazena informações do professor no localStorage
            localStorage.setItem('professorLogado', JSON.stringify(professor));
            
            alert('Login bem-sucedido!');
            window.location.href = 'paginaInicialAdmin.html';
        } else {
            alert('Usuário ou senha inválidos.');
        }
    } catch (error) {
        console.error('Erro:', error);
        alert('Ocorreu um erro ao processar sua solicitação.');
    }
});