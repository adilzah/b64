import Vue from 'vue'
import VueRouter from 'vue-router'
import Vuetify from 'vuetify'
import axios from 'axios';
import BootstrapVue from 'bootstrap-vue'

import App from './App'
import B64 from './B64'

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

Vue.config.productionTip = false
Vue.use(VueRouter)
Vue.use(BootstrapVue)

const routes = [
  { 
    path: '/', 
    component: App
  },
  { 
    path: '/base64', 
    component: B64
  }
]

const router = new VueRouter({
  routes
})

new Vue({
  el: '#app',
  router,
  axios
})