document.addEventListener('DOMContentLoaded', () => {
    const apiUrl = "http://localhost:5095/api/Disciplina";

    const turmasList = document.getElementById('turmas-list');
    const addTurmaBtn = document.getElementById('add-turma-btn');
    const turmaForm = document.getElementById('turma-form');
    const turmaFormElement = document.getElementById('turma-form-element');

    let turmas = []; // Array para armazenar as turmas obtidas da API

    async function fetchTurmas() {
        try {
            const response = await fetch(apiUrl);
            if (!response.ok) {
                throw new Error(`Erro ao buscar turmas: ${response.statusText}`);
            }
            const data = await response.json();
            turmas = data.dados; // Armazena as turmas na variável global
            renderTurmas();
        } catch (error) {
            console.error(error);
        }
    }

    function renderTurmas() {
        turmasList.innerHTML = '';
        turmas.forEach(turma => {
            const tr = document.createElement('tr');
            tr.innerHTML = `
                <td>${turma.id}</td>
                <td>${turma.codigo}</td>
                <td>${turma.nome}</td>
                <td>
                    <button onclick="editTurma(${turma.id})">Editar</button>
                    <button onclick="deleteTurma(${turma.id})">Excluir</button>
                </td>
            `;
            turmasList.appendChild(tr);
        });
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
});
