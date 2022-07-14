<template>
  <div class="calculator">
    <div class="display">
      <input v-model="a" @keypress="handleInput" @change="handleInput" type="number" />
      <select @change="handleInput" v-model="operation">
        <option v-for="op in operations" :key="op">{{op}}</option>
      </select>
      <input v-model="b" @keypress="handleInput" @change="handleInput" type="number" />
      <div>=</div>
      <div class="solution">{{solution}}</div>
    </div>
    <div>
      <button :disabled="error.length > 0" @click="calculate">Calculate!</button>
    </div>
    <div v-if="error.length" class="error">{{error}}</div>
  </div>
</template>

<script>
// todo: refactor the inputs in a component of their own, and make the solution box use this component also (they share styling) but with input disabled
import { operations } from '../enums/operations';
import axios from 'axios';

export default {
  name: 'SimpleCalculator',
  data() {
    return {
      a: undefined,
      b: undefined,
      operation: undefined,
      operations,
      solution: '',
      error: ''
    }
  },
  // todo: would be better to use computed properties to track the validity of each input rather than just checking on submit and clearing errors on change.
  methods: {
    handleInput() {
      this.error = '';
    },
    validateInput(val) {
      if (typeof val === 'undefined' || isNaN(parseInt(val))) {
        return false;
      }
      return true;
    },
    calculate() {
      if (!this.validateInput(this.a) || !this.validateInput(this.b)){ 
        this.error = 'Please enter valid numbers to the calculator';
        return;
      }
      if (!(this.operation in operations)) {
        this.error = 'Please enter a valid operation to the calculator';
        return;
      }
      axios.get(`/api/calculator/${this.operation}?start=${this.a}&amount=${this.b}`).
      then(response => {
        // todo: add error handling.
        this.solution = response.data;
      })
    }
  }
}
</script>

<!-- Todo: Add mobile styling -->
<style scoped lang="scss">
.calculator {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-items: center;
  width: 600px;

  .display {
    display: flex;
    flex-direction: row;
    width: 100%;
    margin-bottom: 10px;
    justify-content: space-evenly;

    input {
      width: 100px;
    }

    input, .solution {
      border: 1px black solid;
      border-radius: 5px;
      height: 20px;
      padding: 0 5px;
    }

    .solution {
      width: auto;
      min-width: 100px;
    }
  }

  button:disabled,
  button[disabled]{
    cursor: not-allowed;
  }

  .error {
    color: red;
  }
}
</style>
