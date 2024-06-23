const AlunoApiUrl = 'http://localhost:5095/api/Aluno';

document.getElementById('loginForm').addEventListener('submit', async function(event) {
    event.preventDefault();

    const loginInput = document.getElementById('Login').value.trim();
    const senhaInput = document.getElementById('Senha').value.trim();

    if (loginInput === '' || senhaInput === '') {
        alert('Por favor, preencha todos os campos.');
        return;
    }

    try {
        const response = await fetch(AlunoApiUrl);
        if (!response.ok) {
            throw new Error('Erro ao buscar dados.');
        }

        const data = await response.json();

        // Verifica se 'data' é um objeto com a chave 'dados'
        if (!data || !Array.isArray(data.dados)) {
            throw new Error('Resposta da API inválida.');
        }

        // Verifica se há algum aluno com o nome de usuário e senha fornecidos
        const aluno = data.dados.find(item => item.nome === loginInput && item.senha === senhaInput);

        if (aluno) {
            // Armazena informações do aluno no localStorage
            localStorage.setItem('alunoLogado', JSON.stringify(aluno));
            
            alert('Login bem-sucedido!');
            window.location.href = 'paginaInicialAluno.html';
        } else {
            alert('Usuário ou senha inválidos.');
        }
    } catch (error) {
        console.error('Erro:', error);
        alert('Ocorreu um erro ao processar sua solicitação.');
    }
});
