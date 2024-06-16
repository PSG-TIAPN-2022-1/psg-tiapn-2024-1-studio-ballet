function entrar(event) {
    event.preventDefault();

    let Login = document.querySelector('#Login');
    let LoginLabel = document.querySelector('#LoginLabel');

    let Cpf = document.querySelector('#Cpf');
    let CpfLabel = document.querySelector('#CpfLabel');

    let Senha = document.querySelector('#Senha');
    let LabelSenha = document.querySelector('#LabelSenha');

    let l = Senha.value

    let ListaUser = [];

    let UserValid = {
        Login: '',
        Cpf: '',
        index: -1 
    };

    ListaUser = JSON.parse(localStorage.getItem('ListaUser'));

    ListaUser.forEach((item, index) => {
        if (Login.value == item.LoginCad && Cpf.value == item.CpfCad) {
            UserValid = {
                Login: item.LoginCad,
                Cpf: item.CpfCad,
                index: index 
            };

        }
    });

    if (Login.value.trim() === '' || Cpf.value.trim() === '') {
        alert('Campo em Branco');
    } else if (Login.value == UserValid.Login && Cpf.value == UserValid.Cpf && l.trim() !== '') {
        ListaUser[UserValid.index].ConfirmeSenhaCad = Senha.value;
        ListaUser[UserValid.index].SenhaCad = Senha.value;
        localStorage.setItem('ListaUser', JSON.stringify(ListaUser));
        alert("Concluido troca de senha")
        window.location.href = 'Login.html';
    } else {
        alert('Invalido');
    }
}
