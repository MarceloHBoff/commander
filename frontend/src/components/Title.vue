<template>
  <div class="title">
    {{ text }}
  </div>
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
  name: 'Title',
  props: { text: { type: String, required: true } },
});
</script>

<style lang="scss" scoped>
.title {
  color: #41b883;
  font-weight: bold;
  letter-spacing: 1px;
  font-size: 32px;
}
</style>
