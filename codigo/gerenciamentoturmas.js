document.addEventListener('DOMContentLoaded', () => {
    const apiUrl = "http://localhost:5095/api/Disciplina";
    const apiUrlAluno = "http://localhost:5095/api/Aluno";

    const turmasList = document.getElementById('turmas-list');
    const addTurmaBtn = document.getElementById('add-turma-btn');
    const turmaForm = document.getElementById('turma-form');
    const turmaFormElement = document.getElementById('turma-form-element');

    const alunosModal = document.getElementById('alunos-modal');
    const alunosList = document.getElementById('alunos-list');
    const closeAlunosBtn = document.querySelector('.close-alunos-btn');

    let turmas = [];
    let alunos = [];

    async function fetchTurmas() {
        try {
            const response = await fetch(apiUrl);
            if (!response.ok) {
                throw new Error(`Erro ao buscar turmas: ${response.statusText}`);
            }
            const data = await response.json();
            turmas = data.dados;
            renderTurmas();
        } catch (error) {
            console.error(error);
        }
    }

    async function fetchAlunos() {
        try {
            const response = await fetch(apiUrlAluno);
            if (!response.ok) {
                throw new Error(`Erro ao buscar alunos: ${response.statusText}`);
            }
            const data = await response.json();
            return data.dados;  // Retorna os dados dos alunos
        } catch (error) {
            console.error(error);
            return [];
        }
    }

    function renderTurmas() {
        turmasList.innerHTML = '';
        turmas.forEach(turma => {
            const tr = document.createElement('tr');
            tr.innerHTML = `
                <td>${turma.id}</td>
                <td><a href="#" class="disciplina-codigo" data-id="${turma.codigo}"> ${turma.codigo}</a></td>
                <td>${turma.nome}</td>
                <td>
                    <button onclick="editTurma(${turma.id})">Editar</button>
                    <button onclick="deleteTurma(${turma.id})">Excluir</button>
                </td>
            `;
            turmasList.appendChild(tr);
        });

        document.querySelectorAll('.disciplina-codigo').forEach(element => {
            element.addEventListener('click', async (e) => {
                e.preventDefault();
                const turmaId = parseInt(e.target.getAttribute('data-id'));
                await showAlunos(turmaId);
            });
        });
    }


    async function atualizarNotaAluno(aluno,nota) {
        try {
            const alunoAtual = {
                cpf: aluno.cpf,
                nome: aluno.nome,
                dataDeNascimento: aluno.dataDeNascimento,
                nota: nota, 
                disciplina: aluno.disciplina,
                faltas: aluno.faltas,
                id: aluno.id,
                email: aluno.email,
                senha: aluno.senha
            };
      
            const response = await fetch(apiUrlAluno, {
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


    // Função para exibir os alunos da turma e permitir a alteração da nota
async function showAlunos(turmaId) {
    const alunos = await fetchAlunos(); // Busca os dados dos alunos

    // Filtra a turma específica
    const turma = turmas.find(t => t.codigo === turmaId);
    if (!turma) {
        alert('Turma não encontrada!');
        return;
    }

    // Filtra os alunos pertencentes à turma específica
    const alunosTurma = alunos.filter(aluno => parseInt(aluno.disciplina) === turmaId); // Convertendo para inteiro

    // Limpa a lista de alunos antes de adicionar os novos
    alunosList.innerHTML = '';

    // Adiciona os alunos à lista na interface
    alunosTurma.forEach(aluno => {
        const tr = document.createElement('tr');
        tr.innerHTML = `
            <td>${aluno.nome}</td>
            <td>${aluno.nota}</td>
            <td>
                <button class="Btn-Alterar-Nota" data-aluno-id="${aluno.id}">Alterar nota</button>
            </td>
        `;
        alunosList.appendChild(tr);

        // Evento de clique para o botão de alterar nota
        const btnAlterarNota = tr.querySelector('.Btn-Alterar-Nota');
        btnAlterarNota.addEventListener('click', () => {
            // Exibe a modal para inserir a nova nota
            const modal = document.getElementById('modal-nota');
            modal.style.display = 'block';

            // Evento para salvar a nova nota quando o formulário for submetido
            const formNovaNota = document.getElementById('form-nova-nota');
            formNovaNota.onsubmit = async (e) => {
                e.preventDefault();
                const novaNota = document.getElementById('nova-nota').value.trim();
                if (novaNota !== '') {
                    // Chama a função para atualizar a nota do aluno
                    try {
                        const alunoAtualizado = await atualizarNotaAluno(aluno, novaNota.toString());
                        // Atualiza a nota na interface, se necessário
                        aluno.nota = novaNota;
                        tr.querySelector('td:nth-child(2)').textContent = novaNota;
                        console.log('Nota do aluno atualizada com sucesso:', alunoAtualizado);

                        // Fecha a modal após salvar a nota
                        modal.style.display = 'none';
                    } catch (error) {
                        console.error('Erro ao atualizar nota do aluno:', error);
                    }
                } else {
                    console.error('Nova nota não pode estar vazia.');
                }
            };

            // Evento para fechar a modal ao clicar no botão de fechar
            const closeBtn = modal.querySelector('.close');
            closeBtn.addEventListener('click', () => {
                modal.style.display = 'none';
            });

            // Fecha a modal se o usuário clicar fora dela
            window.onclick = function(event) {
                if (event.target === modal) {
                    modal.style.display = 'none';
                }
            };
        });
    });

    // Exibe o modal de alunos
    alunosModal.style.display = 'block';
}

    
    
    

    addTurmaBtn.addEventListener('click', () => {
        turmaForm.style.display = 'block';
        turmaFormElement.reset();
        turmaFormElement.onsubmit = async (e) => {
            e.preventDefault();
            const newTurma = {
                codigo: turmaFormElement['codigo'].value,
                nome: turmaFormElement['nome'].value
            };
            try {
                const response = await fetch(apiUrl, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(newTurma)
                });
                if (!response.ok) {
                    throw new Error(`Erro ao adicionar turma: ${response.statusText}`);
                }
                fetchTurmas();
                turmaForm.style.display = 'none';
            } catch (error) {
                console.error(error);
            }
        };
    });

    document.querySelector('.close').addEventListener('click', () => {
        turmaForm.style.display = 'none';
    });

    closeAlunosBtn.addEventListener('click', () => {
        alunosModal.style.display = 'none';
    });

    window.editTurma = async (id) => {
        try {
            const turma = turmas.find(t => t.id === id);
            if (!turma) {
                throw new Error(`Turma com ID ${id} não encontrada.`);
            }
            turmaForm.style.display = 'block';
            turmaFormElement['codigo'].value = turma.codigo;
            turmaFormElement['nome'].value = turma.nome;

            turmaFormElement.onsubmit = async (e) => {
                e.preventDefault();
                const updatedTurma = {
                    codigo: turmaFormElement['codigo'].value,
                    nome: turmaFormElement['nome'].value
                };
                try {
                    const updateResponse = await fetch(`${apiUrl}/${id}`, {
                        method: 'PUT',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(updatedTurma)
                    });
                    if (!updateResponse.ok) {
                        throw new Error(`Erro ao atualizar turma: ${updateResponse.statusText}`);
                    }
                    fetchTurmas();
                    turmaForm.style.display = 'none';
                } catch (error) {
                    console.error(error);
                }
            };
        } catch (error) {
            console.error(error);
        }
    };

    window.deleteTurma = async (id) => {
        try {
            const deleteResponse = await fetch(`${apiUrl}?ID=${id}`, {
                method: 'DELETE'
            });
            if (!deleteResponse.ok) {
                throw new Error(`Erro ao excluir turma: ${deleteResponse.statusText}`);
            }
            fetchTurmas();
        } catch (error) {
            console.error(error);
        }
    };

    fetchTurmas();
    fetchAlunos();
});
