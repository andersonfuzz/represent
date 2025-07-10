import FactoryRepository from '../repositories/FactoryRepository.js';
import { v4 as uuidv4 } from "uuid";


export const listFactories = async (req, res) => {
  try {
    const factories = await FactoryRepository.findAll();
    res.json(factories);
  } catch (error) {
    console.error('Erro ao listar fábricas:', error);
    res.status(500).json({ message: 'Erro interno do servidor' });
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
      dateOfRegistration,
      address,
      contact
    } = req.body;

    const factoryData = {
      id: uuidv4(),
      corporateName,
      tradeName,
      cnpj,
      stateRegistration,
      site,
      dateOfRegistration: dateOfRegistration || new Date().toISOString().split('T')[0],
      address,
      contact
    };

    const newFactory = await FactoryRepository.create(factoryData);
    res.status(201).json(newFactory);
  } catch (error) {
    console.error('Erro ao criar fábrica:', error);
    res.status(500).json({ message: 'Erro interno do servidor' });
  }
};
