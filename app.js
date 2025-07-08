import express from 'express';
const app = express();

import dotenv from 'dotenv';
dotenv.config();
const PORT = process.env.PORT || 3000;

import indexRouter from './src/routers/index.js';



app.use('/', indexRouter)

export default app;