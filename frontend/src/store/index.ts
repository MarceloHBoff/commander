import Vue from 'vue';
import Vuex from 'vuex';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    commands: [
      { id: 1, howTo: 'build App', line: 'dotnet ef go' },
      { id: 2, howTo: 'build App', line: 'dotnet ef go' },
      { id: 3, howTo: 'build App', line: 'dotnet ef go' },
    ],
  },
  mutations: {},
  actions: {},
  modules: {},
});
