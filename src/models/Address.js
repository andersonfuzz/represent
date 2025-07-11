import { v4 as uuidv4 } from "uuid";
export default class Address {
    id = null;
    street = "";
    city = "";
    uf = "";
    zipCode = "";
    constructor(street, city, uf, zipCode) {
        this.id = uuidv4();
        this.street = street;
        this.city = city;
        this.uf = uf;
        this.zipCode = zipCode;
    }
}
