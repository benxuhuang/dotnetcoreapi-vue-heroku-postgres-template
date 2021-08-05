<template>
  <table class='table table-striped' aria-labelledby="tableLabel" v-if="products">
        <thead>
            <tr>
                <th>id</th>
                <th>name</th>
                <th>isDelete</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="product of products" v-bind:key="product">
                <td>{{ product.id }}</td>
                <td>{{ product.name }}</td>
                <td>{{ product.isDelete }}</td>
            </tr>
        </tbody>
  </table>
</template>

<script>
import axios from 'axios';

export default ({
  name: 'GetProducts',
  data() {
    return {
      products: [],
    };
  },
  methods: {
    getProducts() {
      axios.get('/product')
        .then((response) => {
          this.products = response.data;
        })
        .catch((error) => {
          console.log(error);
        });
    },
  },
  mounted() {
    this.getProducts();
  },
});
</script>
