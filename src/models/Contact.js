import { v4 as uuidv4 } from "uuid";
export default class Contact {
    id = null;
    name = "";
    phone = "";
    email = "";

    constructor(name, phone, email) {
        this.id = uuidv4();
        this.name = name;
        this.phone = phone;
        this.email = email;
    }
}
