document.addEventListener('DOMContentLoaded', () => {
 
    const studentForm = document.getElementById('studentForm');
    const studentNameInput = document.getElementById('studentName');
    const studentBolsaInput = document.getElementById('studentBolsa');
    const studentStatusInput = document.getElementById('studentStatus');
    const studentsTableContainer = document.getElementById('studentsTableContainer');

    async function getStudents() {
        response = await fetch("https://375f818b-2156-47fc-8e41-92f636bfb6ac.mock.pstmn.io/api/Aluno")
        json = await response.json()

        return json.dados;
    }

    function saveStudentsToStorage(students) {
        localStorage.setItem('students', JSON.stringify(students));
    }

    async function renderStudents() {
        const students = await getStudents();
        let tableHTML = `<table border="1">
                            <tr>
                                <td><strong>Nome do Aluno</strong></td>
                                <td><strong>Participante do programa de bolsa</strong></td>
                                <td><strong>Mensalidade em dia</strong></td>
                                <td><strong>Ações</strong></td>
                            </tr>`;
        students.forEach((student, index) => {
            tableHTML += `<tr>
                            <td contenteditable="true" oninput="updateStudent(${index}, 'name', this.textContent)">${student.nome}</td>
                            <td contenteditable="true" oninput="updateStudent(${index}, 'bolsa', this.textContent)">${student.bolsa}</td>
                            <td contenteditable="true" oninput="updateStudent(${index}, 'status', this.textContent)">${student.pagamentoPendente}</td>
                            <td><button onclick="deleteStudent(${index})">Deletar</button></td>
                          </tr>`;
        });

        tableHTML += '</table>';
        studentsTableContainer.innerHTML = tableHTML;
    }
    window.deleteStudent = (index) => {
        const students = getStudents();
        students.splice(index, 1);
        saveStudentsToStorage(students);
        renderStudents();
    };

    renderStudents();
});
