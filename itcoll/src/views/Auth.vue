<template>
    <img src="..\assets\preview.png" />

    <div class="panel1">
        <div class="panel2">
            <label style="display: block; text-align: center; font-size: 24px;">Авторизация</label>
            <div style="display: grid; margin-top: 30px;">
                <label>Email</label>
                <input type="email" id="log">
            </div>
            <div style="display: grid; margin-top: 30px;">
                <label>Пароль</label>
                <input class="password" type="password" id="pass" name="password">
            </div>
            <nav style="text-align: center; margin-top: 10px;">
                <router-link to="/recov">Забыли пароль?</router-link>
            </nav>

            <button @click="$router.push('welc')">Войти</button>

        </div>
        <label style="display: block; text-align: center;">Ещё нет аккаунта? <router-link to="/reg">Зарегистрируйтесь
            </router-link></label>
    </div>
</template>

<script>

</script>

<style>
button {
    margin-top: 15%;
    width: 100%;
    height: 40px;
    font-size: 16px;
    color: white;
    background-color: #304ffd;
    border-color: #304ffd;
    border-radius: 10px;
}

body {
    background-color: #304ffd;
}

.panel2 {
    margin: 30% 10%;
    vertical-align: middle;
}

img {
    margin: 5%;
    vertical-align: middle;
}

.panel1 {
    padding: 10px;
    position: absolute;
    display: block;

    right: 10%;
    top: 5%;
    bottom: 5%;

    width: 400px;
    background-color: white;
    border-radius: 20px;
}
</style>