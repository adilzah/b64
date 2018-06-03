<template>
    <v-app>
      <v-content>
       
        <v-container grid-list-md>
            <v-layout row wrap>
                <v-flex xs12>
                    
                    <v-card v-if="result" transition="slide-y-transition">
                        <v-card-title>
                            <h3 class="headline">Your string as B64</h3>
                        </v-card-title>
                        <blockquote class="blockquote">{{ result }}</blockquote>
                    </v-card>
                    <br/>
                    <v-text-field label="What do you want to encode?" v-model="stringToEncode" />
                      <v-btn v-on:click="encode">
                         Encode
                    </v-btn>
                    
                </v-flex>
            </v-layout>
        </v-container>
      </v-content>
    </v-app>
</template>

<script type="text/babel">
import axios from 'axios';
export default { 
    data() {
        return  {
            stringToEncode : null,
            result : null
        };
    },
    methods: {
        encode : function()
        {
            axios.get('/api/encode/' + this.stringToEncode)
            .then(response => {
                this.result = response.data;

            })
            .catch(e => {
            })
        }
    },
    created : function()
    {
        
    }
    
}
</script>

<style lang="scss">

</style>