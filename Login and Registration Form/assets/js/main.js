const login = document.getElementById('login');
const register = document.getElementById('register');
const container = document.getElementById('container');
const buttonLogin = document.getElementById('toggle-login');
const buttonRegister = document.getElementById('toggle-register');

buttonLogin.onclick = function () {
    if (register.style.display !== "none") {
        register.style.display = "none";
        login.style.display = "flex";
    }
};

buttonRegister.onclick = function () {
    if (login.style.display !== "none") {
        login.style.display = "none";
        register.style.display = "flex";
    }
};