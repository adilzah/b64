import Vue from 'vue'
import VueRouter from 'vue-router'
import Vuetify from 'vuetify'
import axios from 'axios';

const App = r => require.ensure([], () => r(require('./App.vue')))

Vue.config.productionTip = false
Vue.use(VueRouter)
Vue.use(Vuetify)

const routes = [
  { 
    path: '/', 
    component: App
  }
]

const router = new VueRouter({
  routes,
  mode: 'history'
})

new Vue({
  el: '#app',
  template: "<div><router-view></router-view></div>",
  router,
  axios
})