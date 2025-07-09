import express from 'express';
import { listFactories, createFactory } from '../controllers/factoryController.js';

const router = express.Router();

router.get('/factories', listFactories);
router.post('/newfactory', createFactory);

export default router;
