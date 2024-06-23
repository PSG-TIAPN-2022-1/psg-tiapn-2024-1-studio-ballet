document.addEventListener("DOMContentLoaded", async () => {
    const teacherInput = document.getElementById('teacher');
    const musicInput = document.getElementById('music');
    const classInput = document.getElementById('class');
    const plansContainer = document.getElementById('plans');
    const professorApiUrl = 'http://localhost:5095/api/Professor/5';
    const planoDeAulaApiUrl = 'http://localhost:5095/api/PlanoDeAula';

    async function fetchProfessor() {
        try {
            const response = await fetch(professorApiUrl);
            const data = await response.json();
            if (data.sucesso) {
                const professor = data.dados;
                teacherInput.value = professor.nome;
                classInput.value = professor.disciplina;
            } else {
                console.error("Falha ao buscar dados do professor:", data.mensagem);
                alert("Falha ao buscar dados do professor.");
            }
        } catch (error) {
            console.error('Erro ao buscar dados do professor:', error);
            alert("Erro ao buscar dados do professor.");
        }
    }

    async function fetchPlanosDeAula() {
        try {
            const response = await fetch(planoDeAulaApiUrl);
            const data = await response.json();
            if (data.sucesso) {
                data.dados.forEach(plan => {
                    displayPlan(plan);
                });
            } else {
                console.error("Falha ao buscar planos de aula:", data.mensagem);
                alert("Falha ao buscar planos de aula.");
            }
        } catch (error) {
            console.error('Erro ao buscar planos de aula:', error);
            alert("Erro ao buscar planos de aula.");
        }
    }

    function displayPlan(plan) {
        const planDiv = document.createElement('div');
        planDiv.className = 'plan';
        planDiv.setAttribute('data-id', plan.id);
        planDiv.innerHTML = `
            <div class="form-group">
                <label>Nome do Professor:</label>
                <input type="text" value="${teacherInput.value}" disabled>
            </div>
            <div class="form-group">
                <label>Música:</label>
                <input type="text" value="${plan.musica}" disabled>
            </div>
            <div class="form-group">
                <label>Turma:</label>
                <input type="text" value="${classInput.value}" disabled>
            </div>
            <div class="button-group">
                <button class="editButton">Editar</button>
                <button class="deleteButton">Excluir</button>
                <button class="saveButton" style="display: none;">Salvar</button>
            </div>
        `;

        plansContainer.appendChild(planDiv);

        const musicInput = planDiv.querySelector('.form-group:nth-child(2) input');
        const editButton = planDiv.querySelector('.editButton');
        const saveButton = planDiv.querySelector('.saveButton');

        editButton.addEventListener('click', () => {
            enableEditing(planDiv);
        });

        saveButton.addEventListener('click', async () => {
            await savePlan(planDiv, musicInput.value.trim());
        });

        planDiv.querySelector('.deleteButton').addEventListener('click', async () => {
            if (confirm("Tem certeza que deseja excluir?")) {
                await deletePlan(planDiv);
            }
        });
    }

    function enableEditing(planDiv) {
        const musicInput = planDiv.querySelector('.form-group:nth-child(2) input');
        musicInput.disabled = false;
        planDiv.querySelector('.editButton').style.display = 'none';
        planDiv.querySelector('.saveButton').style.display = 'inline-block';
    }

    function disableEditing(planDiv) {
        const musicInput = planDiv.querySelector('.form-group:nth-child(2) input');
        musicInput.disabled = true;
        planDiv.querySelector('.editButton').style.display = 'inline-block';
        planDiv.querySelector('.saveButton').style.display = 'none';
    }

    async function savePlan(planDiv, newMusic) {
        const id = planDiv.getAttribute('data-id');
        try {
            const updatedPlan = {
                id: id,
                codigo: planDiv.querySelector('.form-group:nth-child(1) input').value.trim(),
                cpfprofessor: "9876",
                numeroSala: 1,
                musica: newMusic
            };
            const response = await fetch(`${planoDeAulaApiUrl}/`, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(updatedPlan)
            });
            const result = await response.json();

            if (result.sucesso) {
                alert('Planejamento salvo com sucesso!');
                disableEditing(planDiv);
            } else {
                console.error("Falha ao salvar planejamento:", result.mensagem);
                alert("Falha ao salvar planejamento.");
            }
        } catch (error) {
            console.error('Erro ao editar planejamento:', error);
            alert("Erro ao editar planejamento.");
        }
    }

    async function deletePlan(planDiv) {
        const id = planDiv.getAttribute('data-id');
        try {
            const response = await fetch(`${planoDeAulaApiUrl}?ID=${id}`, {
                method: 'DELETE'
            });
            const result = await response.json();

            if (result.sucesso) {
                plansContainer.removeChild(planDiv);
            } else {
                console.error("Falha ao excluir planejamento:", result.mensagem);
                alert("Falha ao excluir planejamento.");
            }
        } catch (error) {
            console.error('Erro ao excluir planejamento:', error);
            alert("Erro ao excluir planejamento.");
        }
    }

    document.getElementById('addButton').addEventListener('click', async () => {
        const music = musicInput.value.trim();

        if (music !== '') {
            const newPlan = {
                codigo: Math.floor(Math.random() * 1000).toString(),
                cpfprofessor: "9876",
                numeroSala: 1,
                musica: music
            };

            try {
                const response = await fetch(planoDeAulaApiUrl, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(newPlan)
                });
                const result = await response.json();

                if (result.sucesso) {
                    displayPlan({
                        id: result.dados.id,
                        musica: newPlan.musica
                    });
                    musicInput.value = '';
                } else {
                    console.error("Falha ao adicionar planejamento:", result.mensagem);
                    alert("Falha ao adicionar planejamento.");
                }
            } catch (error) {
                console.error('Erro ao adicionar planejamento:', error);
                alert("Erro ao adicionar planejamento.");
            }
        } else {
            alert('Por favor, preencha o campo de música.');
        }
    });

    await fetchProfessor();
    await fetchPlanosDeAula();
});
