<template>
  <table class='table table-striped' aria-labelledby="tableLabel" v-if="forecasts">
        <thead>
            <tr>
                <th>Date</th>
                <th>Temp. (C)</th>
                <th>Temp. (F)</th>
                <th>Summary</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="forecast of forecasts" v-bind:key="forecast">
                <td>{{ forecast.date }}</td>
                <td>{{ forecast.temperatureC }}</td>
                <td>{{ forecast.temperatureF }}</td>
                <td>{{ forecast.summary }}</td>
            </tr>
        </tbody>
  </table>
</template>

<script>
import axios from 'axios';

export default ({
  name: 'FetchData',
  data() {
    return {
      forecasts: [],
    };
  },
  methods: {
    getWeatherForecasts() {
      axios.get('/weatherforecast')
        .then((response) => {
          this.forecasts = response.data;
        })
        .catch((error) => {
          console.log(error);
        });
    },
  },
  mounted() {
    this.getWeatherForecasts();
  },
});
</script>
