import app from "./app.js";
const PORT=process.env.PORT

app.listen(PORT, () => {
    console.log(`rodando em http://localhost:${PORT}/factories`);
});