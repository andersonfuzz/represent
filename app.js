import express from 'express';
import dotenv from 'dotenv';
dotenv.config();

const PORT = process.env.PORT || 3000;
const app = express();

app.get('/', (req, res) => {
    res.send('hello word!')
})

app.listen(3000, () => {
    console.log(`rodando em https://localhost:3000`)
})