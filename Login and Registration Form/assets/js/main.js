const login = document.getElementById('login');
const register = document.getElementById('register');
const forget = document.getElementById('forget');
const container = document.getElementById('container');
const buttonLogin = document.getElementById('toggle-login');
const buttonRegister = document.getElementById('toggle-register');
const buttonForget = document.getElementById('toggle-forget');
const backToLogin = document.getElementById('toggle-back-to-login');

buttonLogin.onclick = function () {
    if (register.style.display !== "none") {
        register.style.display = "none";
        forget.style.display = "none";
        login.style.display = "flex";
    }
};

buttonRegister.onclick = function () {
    if (login.style.display !== "none") {
        login.style.display = "none";
        forget.style.display = "none";
        register.style.display = "flex";
    }
};

buttonForget.onclick = function () {
    if (login.style.display !== "none") {
        login.style.display = "none";
        register.style.display = "none";
        forget.style.display = "flex";
    }
}

backToLogin.onclick = function () {
    if (forget.style.display !== "none") {
        register.style.display = "none";
        forget.style.display = "none";
        login.style.display = "flex";
    }
};