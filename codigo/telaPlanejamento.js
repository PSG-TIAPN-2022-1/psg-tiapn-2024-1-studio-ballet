document.addEventListener("DOMContentLoaded", () => {
    const teacherInput = document.getElementById('teacher');
    const dateInput = document.getElementById('date');
    const musicInput = document.getElementById('music');
    const classInput = document.getElementById('class');
    const plansContainer = document.getElementById('plans');

    document.getElementById('addButton').addEventListener('click', () => {
        const teacher = teacherInput.value;
        const date = dateInput.value;
        const music = musicInput.value;
        const className = classInput.value;

        if (teacher && date && music && className) {
            const planDiv = document.createElement('div');
            planDiv.className = 'plan';
            planDiv.innerHTML = `
                <div class="form-group">
                    <label>Nome do Professor:</label>
                    <input type="text" value="${teacher}" disabled>
                </div>
                <div class="form-group">
                    <label>Dia da Aula:</label>
                    <input type="date" value="${date}" disabled>
                </div>
                <div class="form-group">
                    <label>Música:</label>
                    <input type="text" value="${music}" disabled>
                </div>
                <div class="form-group">
                    <label>Turma:</label>
                    <input type="text" value="${className}" disabled>
                </div>
                <div class="button-group">
                    <button class="editButton">Editar</button>
                    <button class="deleteButton">Excluir</button>
                    <button class="saveButton" style="display: none;">Salvar</button>
                </div>
            `;

            plansContainer.appendChild(planDiv);

            teacherInput.value = '';
            dateInput.value = '';
            musicInput.value = '';
            classInput.value = '';

            planDiv.querySelector('.editButton').addEventListener('click', () => {
                planDiv.querySelectorAll('input').forEach(input => input.disabled = false);
                planDiv.querySelector('.editButton').style.display = 'none';
                planDiv.querySelector('.saveButton').style.display = 'inline-block';
            });

            planDiv.querySelector('.deleteButton').addEventListener('click', () => {
                if (confirm("Tem certeza que deseja excluir?")) {
                    plansContainer.removeChild(planDiv);
                }
            });

            planDiv.querySelector('.saveButton').addEventListener('click', () => {
                planDiv.querySelectorAll('input').forEach(input => input.disabled = true);
                planDiv.querySelector('.editButton').style.display = 'inline-block';
                planDiv.querySelector('.saveButton').style.display = 'none';
                alert('Planejamento salvo com sucesso!');
            });
        } else {
            alert('Por favor, preencha todos os campos.');
        }
    });
});