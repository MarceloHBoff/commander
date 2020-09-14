<template>
  <div class="command">
    <div class="text">{{ command.howTo }}</div>
    <div class="text">{{ command.line }}</div>
    <button
      v-clipboard="() => command.line"
      v-clipboard:success="clipboardSuccessHandler"
    >
      <img src="../assets/copy.svg" />
      <div v-if="this.showClipboardSuccess" class="clipboardSuccess">
        Success
      </div>
    </button>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import Clipboard from 'v-clipboard';

import { Command } from '../@types';

Vue.use(Clipboard);

export default Vue.extend({
  name: 'Command',
  data() {
    return {
      showClipboardSuccess: false,
    };
  },
  props: { command: { type: Object as () => Command, required: true } },
  methods: {
    clipboardSuccessHandler() {
      this.showClipboardSuccess = true;

      setTimeout(() => {
        this.showClipboardSuccess = false;
      }, 2000);
    },
  },
});
</script>

<style lang="scss" scoped>
.command {
  margin-top: 10px;
  padding: 10px;
  border-radius: 8px;
  border: 1px solid #fff;
  display: grid;
  grid-template-columns: 1fr 1fr 30px;

  &:hover {
    background: #666;
  }

  button {
    position: relative;
  }

  button img {
    width: 25px;
    height: 25px;
  }
}

.text {
  display: flex;
  align-items: center;
}

.clipboardSuccess {
  position: absolute;
  top: 0;
  right: -85px;
  background: #fff;
  padding: 8px;
  border-top-right-radius: 4px;
  border-bottom-right-radius: 4px;

  &::before {
    content: '';
    position: absolute;
    top: 0;
    left: -16px;
    border-bottom: 16px solid transparent;
    border-top: 16px solid transparent;
    border-right: 16px solid #fff;
  }
}
</style>
