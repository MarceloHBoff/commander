<template>
  <div class="newCommand">
    <router-link class="back" to="/">Back</router-link>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
  name: 'NewCommand',
});
</script>

<style lang="scss">
.newCommand {
  margin-top: 80px;
}

.back {
  border-radius: 8px;
  padding: 10px;
  font-size: 18px;
  font-weight: bold;
  background: #41b883;
  color: #34495e;
}
</style>
