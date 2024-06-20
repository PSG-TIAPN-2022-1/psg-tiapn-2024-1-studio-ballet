document.getElementById('consultarPendencias').addEventListener('click', function() {
    const students = JSON.parse(localStorage.getItem('students')) || [];
    
    const hasPendingDues = students.some(student => student.status === 'Pendente');
    
    const resultadoConsulta = hasPendingDues 
        ? 'Você tem pendências com sua mensalidade. Favor entrar em contato com nosso suporte!!' 
        : 'Não há pendências na mensalidade';
    
    document.getElementById('resultadoConsulta').textContent = resultadoConsulta;
});
