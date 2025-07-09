import pool from '../config/db.js';

const create = async (factory) => {
  const query = `
    INSERT INTO factories (
      id, corporate_name, trade_name, cnpj, state_registration,
      site, date_of_registration, address_street, address_city,
      address_uf, address_zip_code, contact_name, contact_phone, contact_email
    )
    VALUES (
      $1, $2, $3, $4, $5,
      $6, $7, $8, $9,
      $10, $11, $12, $13, $14
    ) RETURNING *;
  `;

  const values = [
    factory.id,
    factory.corporateName,
    factory.tradeName,
    factory.cnpj,
    factory.stateRegistration,
    factory.site,
    factory.dateOfRegistration,
    factory.address.street,
    factory.address.city,
    factory.address.uf,
    factory.address.zipCode,
    factory.contact.name,
    factory.contact.phone,
    factory.contact.email
  ];

  const result = await pool.query(query, values);
  return result.rows[0];
};

const findAll = async () => {
  const result = await pool.query('SELECT * FROM factories;');
  return result.rows;
};

export default {
  create,
  findAll
};