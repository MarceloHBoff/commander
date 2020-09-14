import Vue from 'vue';
import Vuex from 'vuex';

import { Command } from '@/@types';
import api from '@/services/api';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    commands: [] as Command[],
  },
  mutations: {
    addCommand(state, newCommand: Command) {
      state.commands.push(newCommand);
    },
    setCommands(state, payload) {
      state.commands = payload;
    },
  },
  actions: {
    async getCommands(context) {
      const response = await api.get('/api/commands');

      context.commit('setCommands', response.data);
    },

    async setCommans(context, newCommand) {
      await api.post('/api/commands', { ...newCommand });

      context.commit('addCommand', newCommand);
    },
  },
  modules: {},
});
