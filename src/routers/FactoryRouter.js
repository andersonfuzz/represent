import express from 'express';
import { listFactories, createFactory } from '../controllers/FactoryController.js';

const router = express.Router();

router.get('/', listFactories);
router.post('/newfactory', createFactory);

export default router;
