'use strict';

class listNode {
    constructor(date) {
        this.date = date;
    }

    
    get date () {
        return this._date;
    }

    set date (value) {
        if(typeof value !== 'string'){
            throw new Error("date must be valid number");
        }
        this._date = value;
    }
}

class LinkedList {
    constructor() {
        
    }
    
    
}
const list = new listNode(10);
list.date = 50;
//listNode.date = {};
console.log(list.date);

//module.exports = LinkedList;