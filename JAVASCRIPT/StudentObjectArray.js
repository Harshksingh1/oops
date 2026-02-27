var person={
    name:"peter",
    age:23,
    gender:false,
    displayname:function(){
        console.log("Inside Method -> Name:",this.name);
    }
};
console.log(person);
console.log(person.name);
console.log(person.displayname());

var book={
    "name":"harry potter and goblet of fire",
    "author":"J. k rowling",
    "year":2008
};
console.log(book);
for(var it in book){
    console.log(it+"->"+book[it]);
}


var student={
    name:"Ravi",
    age:35,
    skills:["Javascript","C#",".NET"],
    address:{
        city:"Hyderabad",
        country:"India"
    }
};
console.log(student);
console.log(student.skills[0]);
console.log(student.address.city);

var students=[
    {
        id:1,
        name:"Harsh",
        age:21,
        grade:"B",
        },
        {
            id:2,
            name:"Sidhant",
            age:23,
            grade:"A+"
        },
         {
            id:3,
            name:"Shubham",
            age:22,
            grade:"B+"
        }
];
console.log(students[0].name);
console.log(students[0].grade);

for(let i=0;i<students.length;i++){
    console.log(students[i].id);
    console.log(students[i].name);
    console.log(students[i].age);
    console.log(students[i].grade);

    console.log("\n\n");
}