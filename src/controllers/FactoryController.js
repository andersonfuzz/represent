import FactoryRepository from "../repositories/FactoryRepository.js";

export const listFactories = async (req, res) => {
    try {
        const factories = await FactoryRepository.findAll();
        res.json(factories);
    } catch (error) {
        console.error("Erro ao listar fábricas:", error);
        res.status(500).json({ message: "Erro interno do servidor" });
    }
};

export const createFactory = async (req, res) => {
    try {
        const {
            corporateName,
            tradeName,
            cnpj,
            stateRegistration,
            site,
            address,
            contact,
        } = req.body;

        // Aqui o id e a data são gerados internamente no repositório
        const factoryData = {
            corporateName,
            tradeName,
            cnpj,
            stateRegistration,
            site,
            dateOfRegistration: new Date().toISOString().split("T")[0], // se quiser garantir aqui
            address,
            contact,
        };

        const newFactory = await FactoryRepository.create(factoryData);
        res.status(201).json(newFactory);
    } catch (error) {
        console.error("Erro ao criar fábrica:", error);
        res.status(500).json({ message: "Erro interno do servidor" });
    }
};
