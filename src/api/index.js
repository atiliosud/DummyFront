import axios from './axios'

export default {
    getUsers: async ({limit = 10, page = 0}) => {
        return axios.get(`/api/Comment/GetList?page=${page}&limit=${limit}&own=false`)
    }
}