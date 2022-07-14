<template>
  <img class="logo" src="./assets/logo.png">
  <SimpleCalculator />
</template>

<script>
import SimpleCalculator from './components/SimpleCalculator.vue'

export default {
  name: 'App',
  components: {
    SimpleCalculator
  }
}
</script>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;

  .logo {
    height: 100px;
    width: 100px;
    margin-bottom: 10px;
  }
}

</style>
