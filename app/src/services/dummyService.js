import axiosInstance from './axiosConfig';

export const getDummyData = async () => {
  // This is a dummy API call
  try {
    const response = await axiosInstance.get('/dummy-endpoint');
    return response.data;
  } catch (error) {
    throw error;
  }
};