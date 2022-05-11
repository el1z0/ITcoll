import { createRouter, createWebHashHistory } from 'vue-router'
import auth from '../views/Auth.vue'
import recov from '../views/Recovery.vue'
import reg from '../views/Registr.vue'
import welc from '../views/Welcome.vue'

const routes = [
  {
    path: '/',
    component: auth
  },
  {
    path: '/recov',
    component: recov
  },
  {
    path: '/reg',
    component: reg
  },
  {
    path: '/welc',
    component: welc
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router
