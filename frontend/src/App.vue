<template>
  <div id="app">
    <router-view />
  </div>
</template>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  max-width: 1020px;
  margin: 0 auto;
}

* {
  margin: 0;
  padding: 0;
  outline: 0;
  box-sizing: border-box;
}

button,
input {
  border: 0;
  background: transparent;
}

button {
  cursor: pointer;
}

a {
  text-decoration: none;
}

body {
  background: #282828;
  color: #fff;
}
</style>
