<template>
  <div>
    <header>
      <Title text="Commander" />

      <router-link class="new" to="/new">New</router-link>
    </header>

    <HeaderTable />

    <div class="list" v-for="command in commands" :key="command.id">
      <Command :command="command" />
    </div>
  </div>
</template>

<script lang="ts">
import { mapState } from 'vuex';
import Vue from 'vue';

import Command from '../components/Command.vue';
import HeaderTable from '../components/HeaderTable.vue';
import Title from '../components/Title.vue';

export default Vue.extend({
  name: 'Home',
  components: { Command, HeaderTable, Title },
  computed: {
    ...mapState(['commands']),
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

.new {
  width: 100px;
  border-radius: 8px;
  padding: 10px;
  font-size: 18px;
  font-weight: bold;
  background: #41b883;
  color: #34495e;
  text-align: center;
}
</style>
