document.addEventListener('DOMContentLoaded', () => {
    let turmas = JSON.parse(localStorage.getItem('turmas')) || [];
    let alunos = JSON.parse(localStorage.getItem('alunos')) || {};

    const turmasList = document.getElementById('turmas-list');
    const addTurmaBtn = document.getElementById('add-turma-btn');
    const turmaForm = document.getElementById('turma-form');
    const turmaFormElement = document.getElementById('turma-form-element');
    const alunoForm = document.getElementById('aluno-form');
    const alunoFormElement = document.getElementById('aluno-form-element');
    const alunosList = document.getElementById('alunos-list');

    function renderTurmas() {
        turmasList.innerHTML = '';
        turmas.forEach((turma, index) => {
            const tr = document.createElement('tr');
            tr.innerHTML = `
                <td>${turma.id}</td>
                <td>${turma.modalidade}</td>
                <td>${turma.faixaEtaria}</td>
                <td>
                    <button onclick="editTurma(${index})">Editar</button>
                    <button onclick="deleteTurma(${index})">Excluir</button>
                </td>
            `;
            tr.querySelector('td').addEventListener('click', () => {
                localStorage.setItem('currentTurma', JSON.stringify(turma));
                window.location.href = 'turma.html';
            });
            turmasList.appendChild(tr);
        });
    }

    function renderAlunos() {
        const currentTurma = JSON.parse(localStorage.getItem('currentTurma'));
        alunosList.innerHTML = '';
        if (alunos[currentTurma.id]) {
            alunos[currentTurma.id].forEach((aluno, index) => {
                const tr = document.createElement('tr');
                tr.innerHTML = `
                    <td>${aluno.id}</td>
                    <td>${aluno.nome}</td>
                    <td>${aluno.idade}</td>
                    <td>
                        <button onclick="editAluno(${index})">Editar</button>
                        <button onclick="deleteAluno(${index})">Excluir</button>
                    </td>
                `;
                alunosList.appendChild(tr);
            });
        }
    }

    if (addTurmaBtn) {
        addTurmaBtn.addEventListener('click', () => {
            turmaForm.style.display = 'block';
            turmaFormElement.reset();
            turmaFormElement.onsubmit = (e) => {
                e.preventDefault();
                const newTurma = {
                    id: turmaFormElement['turma-id'].value,
                    faixaEtaria: turmaFormElement['faixa-etaria'].value,
                    modalidade: turmaFormElement['modalidade'].value
                };
                turmas.push(newTurma);
                localStorage.setItem('turmas', JSON.stringify(turmas));
                renderTurmas();
                turmaForm.style.display = 'none';
            };
        });
    }

    document.querySelectorAll('.close').forEach(span => {
        span.addEventListener('click', () => {
            turmaForm.style.display = 'none';
            alunoForm.style.display = 'none';
        });
    });

    window.editTurma = (index) => {
        const turma = turmas[index];
        turmaForm.style.display = 'block';
        turmaFormElement['turma-id'].value = turma.id;
        turmaFormElement['faixa-etaria'].value = turma.faixaEtaria;
        turmaFormElement['modalidade'].value = turma.modalidade;
        turmaFormElement.onsubmit = (e) => {
            e.preventDefault();
            turma.id = turmaFormElement['turma-id'].value;
            turma.faixaEtaria = turmaFormElement['faixa-etaria'].value;
            turma.modalidade = turmaFormElement['modalidade'].value;
            turmas[index] = turma;
            localStorage.setItem('turmas', JSON.stringify(turmas));
            renderTurmas();
            turmaForm.style.display = 'none';
        };
    };

    window.deleteTurma = (index) => {
        turmas.splice(index, 1);
        localStorage.setItem('turmas', JSON.stringify(turmas));
        renderTurmas();
    };

    if (document.getElementById('add-aluno-btn')) {
        document.getElementById('add-aluno-btn').addEventListener('click', () => {
            alunoForm.style.display = 'block';
            alunoFormElement.reset();
            alunoFormElement.onsubmit = (e) => {
                e.preventDefault();
                const currentTurma = JSON.parse(localStorage.getItem('currentTurma'));
                const newAluno = {
                    id: alunoFormElement['aluno-id'].value,
                    nome: alunoFormElement['aluno-nome'].value,
                    idade: alunoFormElement['aluno-idade'].value
                };
                if (!alunos[currentTurma.id]) {
                    alunos[currentTurma.id] = [];
                }
                alunos[currentTurma.id].push(newAluno);
                localStorage.setItem('alunos', JSON.stringify(alunos));
                renderAlunos();
                alunoForm.style.display = 'none';
            };
        });
    }

    window.editAluno = (index) => {
        const currentTurma = JSON.parse(localStorage.getItem('currentTurma'));
        const aluno = alunos[currentTurma.id][index];
        alunoForm.style.display = 'block';
        alunoFormElement['aluno-id'].value = aluno.id;
        alunoFormElement['aluno-nome'].value = aluno.nome;
        alunoFormElement['aluno-idade'].value = aluno.idade;
        alunoFormElement.onsubmit = (e) => {
            e.preventDefault();
            aluno.id = alunoFormElement['aluno-id'].value;
            aluno.nome = alunoFormElement['aluno-nome'].value;
            aluno.idade = alunoFormElement['aluno-idade'].value;
            alunos[currentTurma.id][index] = aluno;
            localStorage.setItem('alunos', JSON.stringify(alunos));
            renderAlunos();
            alunoForm.style.display = 'none';
        };
    };

    window.deleteAluno = (index) => {
        const currentTurma = JSON.parse(localStorage.getItem('currentTurma'));
        alunos[currentTurma.id].splice(index, 1);
        localStorage.setItem('alunos', JSON.stringify(alunos));
        renderAlunos();
    };

    renderTurmas();
    if (alunosList) {
        renderAlunos();
    }
});
