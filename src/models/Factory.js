import { v4 as uuidv4 } from "uuid"
import Contact from "./Contact.js"
import Address from "./Address.js"

export default class Factory {
    id = null
    corporateName = ''
    tradeName = ''
    cnpj = ''
    stateRegistration = ''
    site = ''
    dateOfRegistration = new Date().toLocaleDateString()
    address = new Address()
    contact = new Contact()

    constructor(corporateName, tradeName, cnpj, stateRegistration, site, address, contact) {
        this.id = uuidv4()
        this.corporateName = corporateName;
        this.tradeName = tradeName;
        this.cnpj = cnpj;
        this.stateRegistration = stateRegistration;
        this.site = site;
        this.address = address ?? this.address;
        this.contact = contact ?? this.contact;
    }
}