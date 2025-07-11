import pool from "../config/db.js";
import { v4 as uuidv4 } from "uuid";

const create = async (factory) => {
    const client = await pool.connect();
    try {
        await client.query("BEGIN");

        // 1. Criar o endereço
        const addressId = uuidv4();
        const insertAddressQuery = `
      INSERT INTO addresses (id, street, city, uf, zip_code)
      VALUES ($1, $2, $3, $4, $5)
    `;
        await client.query(insertAddressQuery, [
            addressId,
            factory.address.street,
            factory.address.city,
            factory.address.uf,
            factory.address.zipCode,
        ]);

        // 2. Criar o contato
        const contactId = uuidv4();
        const insertContactQuery = `
      INSERT INTO contacts (id, name, phone, email)
      VALUES ($1, $2, $3, $4)
    `;
        await client.query(insertContactQuery, [
            contactId,
            factory.contact.name,
            factory.contact.phone,
            factory.contact.email,
        ]);

        // 3. Criar a fábrica com os ids do endereço e contato
        const factoryId = uuidv4();
        const insertFactoryQuery = `
      INSERT INTO factories (
        id, corporate_name, trade_name, cnpj, state_registration,
        site, date_of_registration, address_id, contact_id
      ) VALUES ($1,$2,$3,$4,$5,$6,$7,$8,$9)
      RETURNING *;
    `;
        const result = await client.query(insertFactoryQuery, [
            factoryId,
            factory.corporateName,
            factory.tradeName,
            factory.cnpj,
            factory.stateRegistration,
            factory.site,
            factory.dateOfRegistration,
            addressId,
            contactId,
        ]);

        await client.query("COMMIT");

        return result.rows[0];
    } catch (error) {
        await client.query("ROLLBACK");
        console.error("Erro no create factory repository:", error);
        throw error;
    } finally {
        client.release();
    }
};

const findAll = async () => {
    const query = `
    SELECT
      f.id, f.corporate_name, f.trade_name, f.cnpj, f.state_registration,
      f.site, f.date_of_registration,
      a.street, a.city, a.uf, a.zip_code,
      c.name, c.phone, c.email
    FROM factories f
    LEFT JOIN addresses a ON f.address_id = a.id
    LEFT JOIN contacts c ON f.contact_id = c.id
  `;

    const result = await pool.query(query);

    // Opcional: mapear para um formato com sub-objetos address e contact
    return result.rows.map((row) => ({
        id: row.id,
        corporateName: row.corporate_name,
        tradeName: row.trade_name,
        cnpj: row.cnpj,
        stateRegistration: row.state_registration,
        site: row.site,
        dateOfRegistration: row.date_of_registration,
        address: {
            street: row.street,
            city: row.city,
            uf: row.uf,
            zipCode: row.zip_code,
        },
        contact: {
            name: row.name,
            phone: row.phone,
            email: row.email,
        },
    }));
};

export default {
    create,
    findAll,
};
