<template>
<div class=main>
<h2>Product Reviews for {{name}}</h2>
<p class="description">{{description}}</p>
    </div>
  
</template>

<script>
export default {
    name: "product-review",
    // data() is a fuction that returns an object full of oroperties
    data(){
        return{
            name: `Cigar Parties for Dummies`,
            description: `Host and plan the perfect cigar party for all your squirelly friends`,
        };

    },


}
</script>

<style scoped>

</style>