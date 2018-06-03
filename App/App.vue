<template>
    <v-app>
      <v-content>
        <v-container grid-list-md>
            <v-layout row wrap>
                <v-flex xs12>
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

<script>

import { mapState } from 'vuex'

export default { 
    data : {
        stringToEncode : ""
    },
    methods: {
        encode : function()
        {
            alert(this.stringToEncode)
        }
    }
}
</script>

<style lang="scss">

</style>