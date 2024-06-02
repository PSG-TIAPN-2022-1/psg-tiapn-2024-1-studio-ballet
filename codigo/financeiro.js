document.getElementById('consultarPendencias').addEventListener('click', function() {
    // Envie uma requisição para a página de controle para verificar pendências
    fetch('controle.html')
        .then(response => response.text())
        .then(html => {
            // Suponha que 'controle.html' retorne uma lista de alunos com pendências
            const resultadoConsulta = 'Você tem pendências com sua mensalidade. Favor entrar em contato com nosso suporte!!';
            document.getElementById('resultadoConsulta').textContent = resultadoConsulta;
        })
        .catch(error => console.error('Erro ao consultar pendências:', error));
});