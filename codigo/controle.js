document.addEventListener('DOMContentLoaded', () => {
 
    const studentForm = document.getElementById('studentForm');
    const studentNameInput = document.getElementById('studentName');
    const studentBolsaInput = document.getElementById('studentBolsa');
    const studentStatusInput = document.getElementById('studentStatus');
    const studentsTableContainer = document.getElementById('studentsTableContainer');

    function getStudentsFromStorage() {
        return JSON.parse(localStorage.getItem('students')) || [];
    }

    function saveStudentsToStorage(students) {
        localStorage.setItem('students', JSON.stringify(students));
    }

    function renderStudents() {
        const students = getStudentsFromStorage();
        let tableHTML = `<table border="1">
                            <tr>
                                <td><strong>Nome do Aluno</strong></td>
                                <td><strong>Participante do programa de bolsa</strong></td>
                                <td><strong>Mensalidade em dia</strong></td>
                                <td><strong>Ações</strong></td>
                            </tr>`;

        students.forEach((student, index) => {
            tableHTML += `<tr>
                            <td contenteditable="true" oninput="updateStudent(${index}, 'name', this.textContent)">${student.name}</td>
                            <td contenteditable="true" oninput="updateStudent(${index}, 'bolsa', this.textContent)">${student.bolsa}</td>
                            <td contenteditable="true" oninput="updateStudent(${index}, 'status', this.textContent)">${student.status}</td>
                            <td><button onclick="deleteStudent(${index})">Deletar</button></td>
                          </tr>`;
        });

        tableHTML += '</table>';
        studentsTableContainer.innerHTML = tableHTML;
    }

    studentForm.addEventListener('submit', (e) => {
        e.preventDefault();
        const newStudent = {
            name: studentNameInput.value,
            bolsa: studentBolsaInput.value,
            status: studentStatusInput.value,
        };

        const students = getStudentsFromStorage();
        students.push(newStudent);
        saveStudentsToStorage(students);
        renderStudents();
        studentForm.reset();
    });

    window.updateStudent = (index, key, value) => {
        const students = getStudentsFromStorage();
        students[index][key] = value;
        saveStudentsToStorage(students);
    };

    window.deleteStudent = (index) => {
        const students = getStudentsFromStorage();
        students.splice(index, 1);
        saveStudentsToStorage(students);
        renderStudents();
    };

    renderStudents();
});