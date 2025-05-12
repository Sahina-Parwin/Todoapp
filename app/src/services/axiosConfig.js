import axios from 'axios';

const axiosInstance = axios.create({
  baseURL: 'https://api.example.com', // Change to your API base URL
  timeout: 10000,
  headers: {
    'Content-Type': 'application/json',
  },
});

export default axiosInstance;