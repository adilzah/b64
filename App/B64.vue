<template>
<div >

    <div class="jumbotron">
        <h2 class="display-4">
           Base64
        </h2>

        <p class="lead">Used to encode and decode strings to and from UTF-16 strings for now</p>
    </div>

        <div class="row">

            <div class="col-md-6">
       <h2>Encode</h2>   

         <input class="form-control" v-on:keyup="encode" label="What do you want to encode?" v-model="stringToEncode" />
                       
                  
  <div class="card" v-if="encodedResult">
                    <div class="card-body">
                                                       <p class="lead"><code>{{ encodedResult }}</code></p>

                    </div>
                    </div>
                </diV>

                     <div class="col-md-6">
            <h2>Decode</h2>   

         <input class="form-control" v-on:keyup="decode" label="What do you want to decode?" v-model="stringToDecode" />
                       
   <div class="card" v-if="decodedResult">
                    <div class="card-body">
                                                       <p class="lead"><code>{{ decodedResult }}</code></p>

                    </div>
                    </div>
            </div>
            </div>

                    
         
</div>
</template>

<script>
import axios from "axios";

export default {
  data() {
    return {
      stringToEncode: null,
      stringToDecode: null,
      encodedResult: null,
      decodedResult: null,
      error: null
    };
  },
  methods: {
    encode: function() {
      axios
        .get("/api/encode/" + this.stringToEncode)
        .then(response => {
          this.encodedResult = response.data;
        })
        .catch(e => {});
    },
    decode: function() {
      axios
        .get("/api/decode/" + this.stringToDecode)
        .then(response => {
          this.decodedResult = response.data;
        })
        .catch(e => {
          this.error = e.response.data;
        });
    }
  },
  created: function() {}
};
</script>

<style lang="scss">
.class {
  background-color: pink;
}
</style>