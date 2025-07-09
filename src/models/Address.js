export default class Address {
    street = ""
    city = ""
    uf = ""
    zipCode = ""
    constructor(street, city, uf, zipCode) {
        this.street = street
        this.city = city
        this.uf = uf
        this.zipCode = zipCode
    }
}