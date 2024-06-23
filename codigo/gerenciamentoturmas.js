document.addEventListener('DOMContentLoaded', () => {
    const apiBaseUrl = "http://localhost:5095/api";

    const turmasList = document.getElementById('turmas-list');
    const addTurmaBtn = document.getElementById('add-turma-btn');
    const turmaForm = document.getElementById('turma-form');
    const turmaFormElement = document.getElementById('turma-form-element');
    const alunoForm = document.getElementById('aluno-form');
    const alunoFormElement = document.getElementById('aluno-form-element');
    const alunosList = document.getElementById('alunos-list');
    
    let currentTurmaId = null;

    async function fetchTurmas() {
        try {
            const response = await fetch(`${apiBaseUrl}/Disciplina`);
            if (!response.ok) {
                throw new Error(`Erro ao buscar turmas: ${response.statusText}`);
            }
            const turmas = await response.json();
            renderTurmas(turmas);
        } catch (error) {
            console.error(error);
        }
    }

    async function fetchAlunos(turmaId) {
        try {
            const response = await fetch(`${apiBaseUrl}/Aluno`);
            if (!response.ok) {
                throw new Error(`Erro ao buscar alunos: ${response.statusText}`);
            }
            const alunos = await response.json();
            renderAlunos(alunos.filter(aluno => aluno.turmaId === turmaId));
        } catch (error) {
            console.error(error);
        }
    }

    function renderTurmas(turmas) {
        turmasList.innerHTML = '';
        turmas.forEach((turma, index) => {
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
            tr.querySelector('td').addEventListener('click', () => {
                currentTurmaId = turma.id;
                fetchAlunos(turma.id);
            });
            turmasList.appendChild(tr);
        });
    }

    function renderAlunos(alunos) {
        alunosList.innerHTML = '';
        alunos.forEach((aluno, index) => {
            const tr = document.createElement('tr');
            tr.innerHTML = `
                <td>${aluno.id}</td>
                <td>${aluno.nome}</td>
                <td>${aluno.nota}</td>
                <td>
                    <button onclick="editAluno(${aluno.id})">Editar</button>
                    <button onclick="deleteAluno(${aluno.id})">Excluir</button>
                </td>
            `;
            alunosList.appendChild(tr);
        });
    }

    if (addTurmaBtn) {
        addTurmaBtn.addEventListener('click', () => {
            turmaForm.style.display = 'block';
            turmaFormElement.reset();
            turmaFormElement.onsubmit = async (e) => {
                e.preventDefault();
                const newTurma = {
                    id: turmaFormElement['turma-id'].value,
                    codigo: turmaFormElement['codigo'].value,
                    nome: turmaFormElement['nome'].value
                };
                try {
                    const response = await fetch(`${apiBaseUrl}/Disciplina`, {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(newTurma)
                    });
                    if (!response.ok) {
                        throw new Error(`Erro ao salvar turma: ${response.statusText}`);
                    }
                    fetchTurmas();
                    turmaForm.style.display = 'none';
                } catch (error) {
                    console.error(error);
                }
            };
        });
    }

    document.querySelectorAll('.close').forEach(span => {
        span.addEventListener('click', () => {
            turmaForm.style.display = 'none';
            alunoForm.style.display = 'none';
        });
    });

    window.editTurma = async (id) => {
        try {
            const response = await fetch(`${apiBaseUrl}/Disciplina/${id}`);
            if (!response.ok) {
                throw new Error(`Erro ao buscar turma: ${response.statusText}`);
            }
            const turma = await response.json();
            turmaForm.style.display = 'block';
            turmaFormElement['turma-id'].value = turma.id;
            turmaFormElement['codigo'].value = turma.codigo;
            turmaFormElement['nome'].value = turma.nome;
            turmaFormElement.onsubmit = async (e) => {
                e.preventDefault();
                turma.id = turmaFormElement['turma-id'].value;
                turma.codigo = turmaFormElement['codigo'].value;
                turma.nome = turmaFormElement['nome'].value;
                try {
                    const response = await fetch(`${apiBaseUrl}/Disciplina/${turma.id}`, {
                        method: 'PUT',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(turma)
                    });
                    if (!response.ok) {
                        throw new Error(`Erro ao atualizar turma: ${response.statusText}`);
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
            const deleteResponse = await fetch(`${apiBaseUrl}/Disciplina/${id}`, {
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

    if (document.getElementById('add-aluno-btn')) {
        document.getElementById('add-aluno-btn').addEventListener('click', () => {
            alunoForm.style.display = 'block';
            alunoFormElement.reset();
            alunoFormElement.onsubmit = async (e) => {
                e.preventDefault();
                const newAluno = {
                    id: alunoFormElement['aluno-id'].value,
                    nome: alunoFormElement['aluno-nome'].value,
                    nota: alunoFormElement['aluno-nota'].value,
                    turmaId: currentTurmaId
                };
                try {
                    const response = await fetch(`${apiBaseUrl}/Aluno`, {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(newAluno)
                    });
                    if (!response.ok) {
                        throw new Error(`Erro ao salvar aluno: ${response.statusText}`);
                    }
                    fetchAlunos(currentTurmaId);
                    alunoForm.style.display = 'none';
                } catch (error) {
                    console.error(error);
                }
            };
        });
    }

    window.editAluno = async (id) => {
        try {
            const response = await fetch(`${apiBaseUrl}/Aluno/${id}`);
            if (!response.ok) {
                throw new Error(`Erro ao buscar aluno: ${response.statusText}`);
            }
            const aluno = await response.json();
            alunoForm.style.display = 'block';
            alunoFormElement['aluno-id'].value = aluno.id;
            alunoFormElement['aluno-nome'].value = aluno.nome;
            alunoFormElement['aluno-nota'].value = aluno.nota;
            alunoFormElement.onsubmit = async (e) => {
                e.preventDefault();
                aluno.id = alunoFormElement['aluno-id'].value;
                aluno.nome = alunoFormElement['aluno-nome'].value;
                aluno.nota = alunoFormElement['aluno-nota'].value;
                try {
                    const response = await fetch(`${apiBaseUrl}/Aluno/${aluno.id}`, {
                        method: 'PUT',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(aluno)
                    });
                    if (!response.ok) {
                        throw new Error(`Erro ao atualizar aluno: ${response.statusText}`);
                    }
                    fetchAlunos(currentTurmaId);
                    alunoForm.style.display = 'none';
                } catch (error) {
                    console.error(error);
                }
            };
        } catch (error) {
            console.error(error);
        }
    };

    window.deleteAluno = async (id) => {
        try {
            const deleteResponse = await fetch(`${apiBaseUrl}/Aluno/${id}`, {
                method: 'DELETE'
            });
            if (!deleteResponse.ok) {
                throw new Error(`Erro ao excluir aluno: ${deleteResponse.statusText}`);
            }
            fetchAlunos(currentTurmaId);
        } catch (error) {
            console.error(error);
        }
    };

    fetchTurmas();
});
