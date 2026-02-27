// // ATM Machine System

// const readline = require("readline");

// const rl = readline.createInterface({
//     input: process.stdin,
//     output: process.stdout
// });

// let correctPin = 1234;
// let balance = 5000;

// rl.question("Enter your PIN: ", function (pin) {
//     pin = Number(pin);

//     if (pin === correctPin) {

//         rl.question("Enter withdrawal amount: ", function (amount) {
//             amount = Number(amount);

//             if (balance >= amount) {
//                 balance -= amount;
//                 console.log("Withdrawal Successful");
//                 console.log("Remaining Balance: ₹" + balance);
//             } else {
//                 console.log("Insufficient Balance");
//             }

//             rl.close();
//         });

//     } else {
//         console.log("Incorrect PIN");
//         rl.close();
//     }
// });


// // Electricity Bill Calculator

// var units = Number(prompt("Enter electricity units consumed:"));
// var bill = 0;

// if (units >= 0 && units <= 100) {
//     bill = units * 5;
// }
// else if (units >= 101 && units <= 200) {
//     bill = units * 7;
// }
// else if (units > 200) {
//     bill = units * 10;
// }
// else {
//     document.write("Invalid units entered");
// }

// if (bill > 0) {
//     document.write("Total Electricity Bill: ₹" + bill);
// }




// let menu=2;
// switch(menu){
// case 1:
// console.log("Pizza-> "+200);
// break;
// case 2:
// console.log("Burger-> "+150);
// break;
// default:
// console.log("Pasta-> "+180);
// }




// while(condition){
// let Number1 = 7;
// let guess = parseInt(prompt("Enter the number:"));
// while (guess !== Number1) {
// console.log("Wrong guess");
// guess = parseInt(prompt("Guess the number again:"));
// }
// console.log("no is correct");
// }



// do {
// // ask password
// } while(condition)
// let currpass="Admin123";
// let attempt=0;
// do{
// let pass=prompt("Enter the pass")
// if(pass===currpass){
// console.log("Password is matching")
// break;
// }
// else attempt++;
// }while(attempt<=3)
// console.log("Not matching");


// let num=10
// for(let i=1;i<=10;i++){
// console.log(num+" * "+i+" = "+i*num);
// }




// Employee Salary List
// let salaries = [25000, 30000, 40000, 28000];
// let totalSalary = 0;

// for (let salary of salaries) {
//     document.write("Salary:" + salary );
//     totalSalary = totalSalary + salary;
// }
// document.write("Total Salary" + totalSalary);


// Student Marks Using for-in

// let student = {
//     name: "Harsh",
//     math: 80,
//     science: 75,
//     english: 90
// };

// for (let key in student) {
//     document.write(key + " : " + student[key]);
// }

// let marks=[45,78,90,66,58];
// let ans=marks.map(num=>num+5);
// console.log(ans);
// let ans1=marks.filter(num=>num>60);
// console.log(ans1);
// let ans2=marks.reduce((sum,value)=>sum+value,0);
// console.log(ans2);
// //-------------------------------------
// let employees=[{name:"Harsh",salary:30000},
// {name:"Abhi",salary:40000},
// {name:"Kuku",salary:35000}
// ];
// let x=employees.map(function(emp){
// return{
// name:emp.name,
// salary:emp.salary*1.10
// };
// });
// console.log(x);
// let y=employees.map(emp=>emp.name);
// console.log(y);
// let z=employees.filter(emp=>emp.salary>=35000);
// console.log(z);
// //------------------------------------------
// let cart=[{product:"Laptop",price:50000,qty:1},
// {product:"Mouse",price:500,qty:2},
// {product:"Keyboard",price:1500,qty:1}
// ];
// let total=cart.reduce((sum,item)=>sum+(item.price*item.qty),0);
// console.log(total);
// let nm=cart.map(item=>item.product);
// console.log(nm);
// let inc=cart.map(function(item)
// {
// return{
// product:item.product,
// price:item.price*1.05,
// qty:item.qty
// };
// });
// console.log(inc);
// let students=[{name:"Abhi",marks:88},
// {name:"Puja",marks:95},
// {name:"Amit",marks: 78}
// ]
// let highes=students.reduce((max,item)=>Math.max(max,item.marks),0);
// console.log(highes);
// var topper=students.reduce((item,max)=>item.marks>max.marks?item:max);
// console.log(topper.name);
// var upper=students.map(function(emp){
// return{
// name:emp.name.toUpperCase(),
// marks:emp.marks,
// };
// });
// console.log(upper);
// //-------------------------------------------------
// let users = ["Ravi", "Priya", "Amit", "Rahul"];
// var check=(val)=>{
// for(var i=0;i<users.length;i++){
// if(users[i].toLocaleLowerCase()==val.toLocaleLowerCase()){
// return true;
// }
// }
// return false
// }
// if(check("ravi")){
// console.log("Found");
// }else{
// console.log("not found");
// }