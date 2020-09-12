import Vue from 'vue';
import VueRouter, { RouteConfig } from 'vue-router';
import Home from '../views/Home.vue';
import NewCommand from '../views/NewCommand.vue';

Vue.use(VueRouter);

const routes: Array<RouteConfig> = [
  { path: '/', name: 'Home', component: Home },
  { path: '/new', name: 'NewCommand', component: NewCommand },
];

const router = new VueRouter({
  routes,
});

export default router;
