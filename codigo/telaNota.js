const alunoLogado = JSON.parse(localStorage.getItem('alunoLogado'));
const idAlunoLogado = alunoLogado.id;
const url = `http://localhost:5095/api/Aluno/${idAlunoLogado}`;

// Função para buscar os dados do aluno
async function fetchStudentData() {
    try {
        console.log('Iniciando a requisição para:', url);
        const response = await fetch(url, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            },
            credentials: 'include' // Inclui cookies na requisição, se necessário
        });

        console.log('Resposta recebida:', response);

        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        const data = await response.json();
        console.log('Dados recebidos:', data);

        if (data) {
            // Atualiza o DOM com as informações do aluno
            document.getElementById('student-name').textContent = data.dados.nome;

            const gradesTableBody = document.getElementById('grades-table-body');
            gradesTableBody.innerHTML = `
                <tr>
                    <td>${data.dados.disciplina}</td>
                    <td>${data.dados.nota}</td>
                </tr>
            `;
        } else {
            console.error('Aluno não encontrado.');
        }
    } catch (error) {
        console.error('Erro ao buscar os dados do aluno:', error);
    }
}

// Chama a função para buscar os dados do aluno ao carregar a página
document.addEventListener('DOMContentLoaded', (event) => {
    console.log('Documento carregado, buscando dados do aluno.');
    fetchStudentData();
});
