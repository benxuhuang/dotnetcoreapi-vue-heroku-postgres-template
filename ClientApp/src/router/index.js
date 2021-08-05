import { createRouter, createWebHistory } from 'vue-router';
import FetchData from '@/components/FetchData.vue';
import GetProducts from '@/components/GetProducts.vue';
import Home from '../views/Home.vue';

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home,
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue'),
  },
  {
    path: '/FetchData',
    name: 'FetchData',
    component: FetchData,
  },
  {
    path: '/GetProducts',
    name: 'GetProducts',
    component: GetProducts,
  },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
