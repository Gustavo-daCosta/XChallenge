import axios from "axios";

export const NoticiaResource = "/Noticia";

const apiPort = "7160"
const localApiUrl = `https://localhost:${apiPort}/api`

const api = axios.create({ baseURL: localApiUrl });

export default api;