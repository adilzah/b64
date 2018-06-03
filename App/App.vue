<template>
    <v-app>
      <v-content>
       
        <v-container grid-list-md>
            <v-layout row wrap>
              
                <v-flex xs12>

                      <h1 class="display-1">B64 Converter</h1>

                <p>Turns strings into B64 and back using UTF-16 for now</p>
                   <v-alert :value="error" color="error" icon="warning">
                        {{error}}
                    </v-alert>


                    <v-card>
                        <v-card-title>
                            <h3 class="headline">String to Base64</h3>
                        </v-card-title>
                        
                        <v-card-text>
                        
                        <p class="display-1" v-if="encodedResult">  
                            <code>{{ encodedResult }}</code>
                            </p>
                      
                        <v-text-field label="What do you want to encode?" v-model="stringToEncode" />
                             <v-btn v-on:click="encode">
                                Encode
                            </v-btn>
                        </v-card-text>
                    </v-card>
                    
                  
                    
                </v-flex>

                  <v-flex xs12>
                    <v-card>
                        <v-card-title>
                            <h3 class="headline">Base64 to String</h3>
                        </v-card-title>
                        
                        <v-card-text>
                        <p v-if="decodedResult" class="display-1"> <code>{{ decodedResult }}</code></p>

                        <v-text-field label="What do you want to decode?" v-model="stringToDecode" />
                             <v-btn v-on:click="decode">
                                Decode
                            </v-btn>
                        </v-card-text>
                    </v-card>
                    
                </v-flex>
            </v-layout>
        </v-container>
      </v-content>
    </v-app>
</template>

<script>
import axios from 'axios';

export default { 
    data() {
        return  {
            stringToEncode : null,
            stringToDecode : null,
            encodedResult : null,
            decodedResult : null,
            error : null,
        };
    },
    methods: {
        encode : function()
        {
            axios.get('/api/encode/' + this.stringToEncode)
            .then(response => {
                this.encodedResult = response.data;

            })
            .catch(e => {
            })
        },
        decode : function()
        {
            axios.get('/api/decode/' + this.stringToDecode)
            .then(response => {
                this.decodedResult = response.data;

            })
            .catch(e => {
                this.error = e.response.data;
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