import express from 'express';
import dotenv from 'dotenv';
import FactoryRouter from './src/routers/FactoryRouter.js'

const app = express();
dotenv.config();

app.use(express.json())
app.use('/factories', FactoryRouter)

export default app;