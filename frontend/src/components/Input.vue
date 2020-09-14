<template>
  <div class="container">
    <input
      type="text"
      v-model="value"
      :placeholder="text"
      @change="updateInput"
    />
    <div v-if="this.error" class="error">Field {{ this.text }} is required</div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
  name: 'Input',
  props: {
    text: { type: String, required: false },
    validate: { type: Boolean, required: true },
  },
  data() {
    return {
      value: '',
      error: false,
    };
  },
  watch: {
    validate() {
      if (this.validate && this.value === '') {
        this.error = true;

        setTimeout(() => {
          this.error = false;
        }, 3000);
      }
    },
  },
  methods: {
    updateInput() {
      this.$emit('changeInput', this.value);
    },
  },
});
</script>

<style lang="scss" scoped>
.container {
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  position: relative;
}

input {
  width: 100%;
  margin: 10px 0;
  padding: 12px 16px;
  background: #fff;
  border-radius: 8px;

  font-size: 18px;
}

.error {
  position: absolute;
  width: 30%;
  top: 15px;
  left: 1050px;
  color: #000;
  background: #fff;
  padding: 8px;
  border-top-right-radius: 4px;
  border-bottom-right-radius: 4px;

  &::before {
    content: '';
    position: absolute;
    top: 0;
    left: -17px;
    border-bottom: 17px solid transparent;
    border-top: 17px solid transparent;
    border-right: 17px solid #fff;
  }
}
</style>
