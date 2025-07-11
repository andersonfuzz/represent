import express from "express";
import {
    listFactories,
    createFactory,
} from "../controllers/FactoryController.js";

const router = express.Router();

router.get("/", listFactories); // GET /factories — lista
router.post("/", createFactory); // POST /factories — cria

export default router;
