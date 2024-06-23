const alunoLogado = JSON.parse(localStorage.getItem('alunoLogado'));
const idAlunoLogado = alunoLogado.id;
const url = `http://localhost:5095/api/Aluno/${idAlunoLogado}`;
const urlFinanceiro = `http://localhost:5095/api/Financeiro`;

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
        console.log('Dados recebidos do aluno:', data);

        if (data && data.dados) {
            // Atualiza o DOM com as informações do aluno
            document.getElementById('student-name').textContent = data.dados.nome;

            const gradesTableBody = document.getElementById('grades-table-body');
            gradesTableBody.innerHTML = `
                <tr>
                    <td>${data.dados.disciplina}</td>
                    <td>${data.dados.nota !== null ? data.dados.nota : 'N/A'}</td>
                </tr>
            `;
        } else {
            console.error('Aluno não encontrado ou dados inválidos.');
        }
    } catch (error) {
        console.error('Erro ao buscar os dados do aluno:', error);
    }
}

// Função para buscar os dados financeiros do aluno
async function fetchFinanceiroData() {
    try {
        console.log('Iniciando a requisição para:', urlFinanceiro);
        const response = await fetch(urlFinanceiro, {
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
        console.log('Dados financeiros recebidos:', data);

        // Verificação adicional para ver a estrutura exata dos dados
        console.log('Estrutura dos dados financeiros:', JSON.stringify(data, null, 2));

        if (data && data.dados && Array.isArray(data.dados) && data.dados.length > 0) {
            const paymentStatusTableBody = document.getElementById('payment-status-table-body');
            paymentStatusTableBody.innerHTML = ''; // Limpa a tabela antes de adicionar os novos dados

            let encontrouBoleto = false; // Flag para verificar se encontrou um boleto correspondente

            data.dados.forEach(boleto => {
                if (boleto.cpf === alunoLogado.cpf) {
                    encontrouBoleto = true;
                    const tr = document.createElement('tr');
                    const tdCpf = document.createElement('td');
                    const tdSituacao = document.createElement('td');

                    tdCpf.textContent = boleto.cpf;
                    tdSituacao.textContent = boleto.situacaoPagamento;

                    tr.appendChild(tdCpf);
                    tr.appendChild(tdSituacao);

                    paymentStatusTableBody.appendChild(tr);
                }
            });

            if (!encontrouBoleto) {
                console.error('Nenhum boleto encontrado para o CPF do aluno logado:', alunoLogado.cpf);
            }
        } else {
            console.error('Dados financeiros não encontrados ou lista de boletos vazia.');
        }
    } catch (error) {
        console.error('Erro ao buscar os dados financeiros:', error);
    }
}

// Chama as funções para buscar os dados do aluno e financeiros ao carregar a página
document.addEventListener('DOMContentLoaded', (event) => {
    console.log('Documento carregado, buscando dados do aluno e financeiros.');
    fetchStudentData();
    fetchFinanceiroData();
});