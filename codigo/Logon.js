let Nome = document.querySelector('#Nome');
let LabelNome = document.querySelector('#LabelNome');
let validNome = false;

let Login = document.querySelector('#Login');
let LabelLogin = document.querySelector('#LabelLogin');
let validLogin = false;

let Cpf = document.querySelector('#Cpf');
let LabelCpf = document.querySelector('#LabelCpf');
let validCpf = false;

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

Login.addEventListener('keyup', () => {
    if (Login.value.length <= 4) {
        Login.setAttribute('style', 'border-color: red');
        validLogin = false;
    } else {
        Login.setAttribute('style', 'border-color: white');
        validLogin = true;
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

function cadastrar() {
    if (validNome && validLogin && validCpf && validSenha && validConfirmeSenha) {
        let ListaUser = JSON.parse(localStorage.getItem('ListaUser') || '[]');

        ListaUser.push({
            LoginCad: Login.value,
            CpfCad: Cpf.value,
            ConfirmeSenhaCad: ConfirmeSenha.value,
            NomeCad: Nome.value,
            SenhaCad: Senha.value,
        });

        localStorage.setItem('ListaUser', JSON.stringify(ListaUser));
        window.location.href = 'Login.html';
        alert('Cadastrado');
    } else {
        alert('Campo Invalido');
    }
}