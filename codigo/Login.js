function entrar(event) {
    event.preventDefault(); 

    let Login = document.querySelector('#Login');
    let LoginLabel = document.querySelector('#LoginLabel');

    let Senha = document.querySelector('#Senha');
    let SenhaLabel = document.querySelector('#SenhaLabel');

    let ListaUser = [];

    let UserValid = {
        Login: '',
        Senha: ''
    };

    ListaUser = JSON.parse(localStorage.getItem('ListaUser'));

    ListaUser.forEach((item) => {
        if (Login.value == item.LoginCad && Senha.value == item.SenhaCad) {
            UserValid = {
                Login: item.LoginCad,
                Senha: item.SenhaCad
            };
        }
    });

    if (Login.value.trim() === '' || Senha.value.trim() === '') {
        alert('Campo em Branco');
    }
    else if (Login.value == UserValid.Login && Senha.value == UserValid.Senha) {
        window.location.href = 'https://www.google.com.br/';

        let token = Math.random().toString(11).substring(2) + Math.random().toString(19).substring(2);
        localStorage.setItem('token', token);
    } else {
        alert('Invalido');
    }
}
