
const baseUrl = "https://energythingy.azurewebsites.net/api/"
Vue.createApp({
    data(){
        return{
            woodPallets: [],
            id: null,
            brand: null,
            price: null,
            quality: null
        }
    },
    async created() {
        try{
            const response = await axios.get(baseUrl)
            this.woodPallets = await response.data
            console.log(this.woodPallets)
        }catch(ex){
                alert(ex.message)
            }
        },
        methods:{
            async getAll(){   
                try{
                    const response = await axios.get(baseUrl)
                    this.woodPallets = await response.data
                }catch(ex){
                alert(ex.message)
            }
        },

        async addWoodPallet() {
            try {
              // create the data payload with the user input
              const data = {
                woodPallets: this.woodPallets,
                value: this.value

              }
          
              // make the POST request to the server with the data payload
              const response = await axios.post(baseUrl, data)
          
              // reset the form fields
              this.id = ''
              this.brand = ''
              this.price = ''
              this.quality = ''
          
              // refresh the list of energies
              this.getAll()
            } catch (ex) {
              alert(ex.message)
            }
          }
        }
    }).mount("#app")
