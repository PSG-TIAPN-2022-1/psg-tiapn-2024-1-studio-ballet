const AlunoApiUrl = 'http://localhost:5095/api/Aluno';
let Nome = document.querySelector('#Nome');
let LabelNome = document.querySelector('#LabelNome');
let validNome = false;

let Cpf = document.querySelector('#Cpf');
let LabelCpf = document.querySelector('#LabelCpf');
let validCpf = false;

let Modalidade = document.querySelector('#Modalidade');
let LabelModalidade = document.querySelector('#LabelModalidade');
let validModalidade = false;

let Senha = document.querySelector('#Senha');
let LabelSenha = document.querySelector('#LabelSenha');
let validSenha = false;

let ConfirmeSenha = document.querySelector('#ConfirmeSenha');
let LabelConfirmeSenha = document.querySelector('#LabelConfirmeSenha');
let validConfirmeSenha = false;

Nome.addEventListener('keyup', () => {
    const nomeValue = Nome.value;
    const nomeRegex = /^[A-Za-z\s]+$/;

    if (nomeValue.length <= 2 || !nomeRegex.test(nomeValue)) {
        Nome.setAttribute('style', 'border-color: red');
        validNome = false;
    } else {
        Nome.setAttribute('style', 'border-color: white');
        validNome = true;
    }
});

Cpf.addEventListener('keyup', () => {
    const cpfValue = Cpf.value;
    const cpfRegex = /^[0-9]*$/;

    if (cpfValue.length != 11 || !cpfRegex.test(cpfValue)) {
        Cpf.setAttribute('style', 'border-color: red');
        validCpf = false;
    } else {
        Cpf.setAttribute('style', 'border-color: white');
        validCpf = true;
    }
});

Modalidade.addEventListener('keyup', () => {
    if (Modalidade.value.length == 0) {
        Modalidade.setAttribute('style', 'border-color: red');
        validModalidade = false;
    } else {
        Modalidade.setAttribute('style', 'border-color: white');
        validModalidade = true;
    }
});

Senha.addEventListener('keyup', () => {
    if (Senha.value.length <= 7) {
        Senha.setAttribute('style', 'border-color: red');
        validSenha = false;
    } else {
        Senha.setAttribute('style', 'border-color: white');
        validSenha = true;
    }
});

ConfirmeSenha.addEventListener('keyup', () => {
    if (Senha.value != ConfirmeSenha.value) {
        ConfirmeSenha.setAttribute('style', 'border-color: red');
        validConfirmeSenha = false;
    } else {
        ConfirmeSenha.setAttribute('style', 'border-color: white');
        validConfirmeSenha = true;
    }
});

document.querySelector('#submitBtn').addEventListener('click', cadastrar);

async function cadastrar(event) {
    event.preventDefault();  // Prevenir o envio padrão do formulário

    if (validNome && validCpf && validModalidade && validSenha && validConfirmeSenha) {
        let alunoData = {
            cpf: Cpf.value,
            nome: Nome.value,
            dataDeNascimento: "2000-01-01",  // Ajustar para uma data de nascimento válida
            nota: null,
            disciplina: Modalidade.value,
            faltas: "0",
            email: null,
            senha: Senha.value
        };

        console.log("Dados do aluno a serem enviados:", alunoData);

        try {
            let response = await fetch(AlunoApiUrl, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(alunoData)
            });

            if (response.ok) {
                alert('Cadastrado com sucesso!');
                window.location.href = 'Login.html';
            } else {
                let errorData = await response.json();
                console.error('Erro no cadastro:', errorData);
                let errorMessages = Object.values(errorData.errors).flat().join('\n');
                alert('Erro ao cadastrar: ' + errorMessages);
            }
        } catch (error) {
            console.error('Erro de rede:', error);
            alert('Erro ao cadastrar. Tente novamente.');
        }
    } else {
        alert('Campo Inválido');
    }
}
