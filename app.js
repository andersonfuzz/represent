import express from 'express';
import indexRouter from './src/routers/index.js';
import dotenv from 'dotenv';

const app = express();
const PORT = process.env.PORT || 3000;

dotenv.config();
app.use('/', indexRouter)

export default app;