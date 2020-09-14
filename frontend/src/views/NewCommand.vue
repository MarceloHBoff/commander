<template>
  <div>
    <header>
      <router-link class="back" to="/">Back</router-link>

      <Title text="New Command" />
    </header>

    <div class="input-group">
      <Input
        text="How To"
        :validate="this.validate"
        @changeInput="value => (this.howTo = value)"
      />
      <Input
        text="Line command"
        :validate="this.validate"
        @changeInput="value => (this.line = value)"
      />
      <Input
        text="Platform"
        :validate="this.validate"
        @changeInput="value => (this.platform = value)"
      />
    </div>

    <button class="save" @click="addCommand">Save</button>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import Input from '../components/Input.vue';
import Title from '../components/Title.vue';

export default Vue.extend({
  name: 'NewCommand',
  components: { Input, Title },
  data() {
    return {
      howTo: '',
      line: '',
      platform: '',
      validate: false,
    };
  },
  methods: {
    addCommand() {
      this.validate = true;

      if (this.howTo !== '' && this.line !== '' && this.platform !== '') {
        this.$store.dispatch('setCommans', { ...this.$data });
        this.howTo = '';
        this.line = '';
        this.platform = '';
        this.$router.push('/');
      }

      setTimeout(() => {
        this.validate = false;
      }, 100);
    },
  },
});
</script>

<style lang="scss" scoped>
header {
  margin-top: 80px;
  display: flex;
  justify-content: space-between;
  align-items: center;

  font-size: 30px;
  margin-bottom: 50px;
}

.back,
.save {
  width: 100px;
  border-radius: 8px;
  padding: 10px;
  font-size: 18px;
  font-weight: bold;
  background: #41b883;
  color: #34495e;
  text-align: center;
}

.save {
  width: 200px;
  margin-top: 20px;
}

.input-group {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;

  margin-top: 30px;
}
</style>
