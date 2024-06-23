document.getElementById('consultarPendencias').addEventListener('click', async function () {
    response = await fetch("https://375f818b-2156-47fc-8e41-92f636bfb6ac.mock.pstmn.io/api/Financeiro/01765142016")

    json = await response.json()
    console.log(json.dados)
    console.log(json.dados.situacaoPagamento)

    const hasPendingDues = json.dados.situacaoPagamento === 'Pendente';

    const resultadoConsulta = hasPendingDues
        ? 'Você tem pendências com sua mensalidade. Favor entrar em contato com nosso suporte!!'
        : 'Não há pendências na mensalidade';

    document.getElementById('resultadoConsulta').textContent = resultadoConsulta;

});
