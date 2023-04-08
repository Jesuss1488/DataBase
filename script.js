let json1 = {
    "firstName": "Андрей",
    "lastName": "Андреев",
    "age": 20,
    "adress":{
        "streetAddress":"пл.Гагарина, 1",
        "city":"Ростов-на-дону",
        "postalCode":344000
    },
    "phoneNumbers":[
        {
            "type1":"home",
            "number1":"634-5625-45-63"
        },
        {
            "type2":"fax",
            "number2":"634-5625-45-64"
        }
    ]
}

let data = JSON.parse(json1);
console.log(data);
console.log(data.firstName.age);
console.log(data.adress.caty);
console.log(data.phoneNumbers);
console.log(data.number2);
let json2 = JSON.stringify(data);
console.log(json2);
