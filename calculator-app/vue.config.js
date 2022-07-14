const { defineConfig } = require('@vue/cli-service')

module.exports = defineConfig({
  transpileDependencies: true,

  // this is here so we don't get CORS issues when trying to communicate with the api.
  devServer: {
    proxy: {
      '/api': {
        target: 'https://localhost:44325',
        changeOrigin: true,
        pathRewrite: {
          '^/api': ''       
        }     
      }
    }
  }
})