<template>
  <div class="header">
    <div>How To</div>
    <div>Command</div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
  name: 'HeaderTable',
});
</script>

<style lang="scss">
.header {
  margin-top: 10px;
  padding: 14px 10px;
  border-radius: 8px;
  background: #41b883;
  color: #34495e;
  font-weight: bold;
  display: grid;
  grid-template-columns: 1fr 1fr 30px;
}
</style>
