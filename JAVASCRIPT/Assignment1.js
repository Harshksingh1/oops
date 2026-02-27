// 1)Sample  program to print a welcome message
// 2)program to read a number user and display it 
// 3)program to read a floating point number from user 
// //4)program to read a string from user and display it on the screen 
// //5)program to perform all arithmetic operations*/
// 6) program to find the area of circle */
// //7) program to find whether the given number is Even or Odd */
// //8)program to find the greatest of 2 numbers */
// //9) program to find whether a given number is positive ,negative or zero*/
// //10) program to find the greatest of three numbers
// //10a) program to find the greatest of three numbers using nested if*/ 
// 11) program to find the greatest of 3 numbers
// using conditional operator 
// 12) program to read student num,name,marks and calculate 
// total and average and print result and division 
// 13)program to read eno,ename,basic salary and calculate  
// pf,hra,da,net salary and gross salary and print eno,ename,basic salary,
// gross salary and net salary

// pf= 12% of basic salary.
// hra=20% of basic salary.
// da= 15% of basic salary.
// gross salary=pf+hra+da+basic salary;
// net salary=gross salary - pf;



var num=Number(prompt("enter the no: "));
console.log(num);
let a=10;
let b=5;
let add=a+b;
let sub=a-b;
let mul=a*b;
let div=a/b;
console.log("Addition: "+add);
console.log("Subtraction: "+sub);
console.log("Multiplication: "+mul);
console.log("Divide: "+div);
var rad=12;
console.log(Math.PI*rad*rad);
var num=12;
if(num%2==0) console.log("Even");
else console.log("odd");
var num1=24
var num2=34
if(num1>num2) console.log(num1+" is greater");
else console.log(num2+" is greater");
var num1=21
if(num1>0) console.log("number is positive");
else if(num1<0) console.log("num is negative");
else console.log("num is zero");
let num1 = 20;
let num2 = 30;
var num3 = 25;
if (num1 > num2 && num1 > num3) {
console.log(num1 + " is greater");
}
else if (num2 > num1 && num2 > num3) {
console.log(num2 + " is greater");
}
else {
console.log(num3 + " is greater");
}
var num1 = 20;
var num2 = 30;
var num3 = 25;
if(num1>num2){
if(num1>num3) console.log("num1 id greater");
else{
if(num2>num3) console.log(num2+" is greater");
}
}
let num = prompt("Enter Student Number:");
let name = prompt("Enter Student Name:");
let m1 = parseFloat(prompt("Enter Marks of Subject 1:"));
let m2 = parseFloat(prompt("Enter Marks of Subject 2:"));
let m3 = parseFloat(prompt("Enter Marks of Subject 3:"));
let total = m1 + m2 + m3;
let avg = total / 3;
let division;
if (avg >= 60) {
division = "First Division";
} else if (avg >= 50) {
division = "Second Division";
} else if (avg >= 40) {
division = "Third Division";
} else {
division = "Fail";
}
console.log("Student Result");
console.log("Student No: " + num);
console.log("Name: " + name);
console.log("Total Marks: " + total);
console.log("Average: " + avg.toFixed(2));
console.log("Division: " + division);
let eno = prompt("Enter Employee Number:");
let ename = prompt("Enter Employee Name:");
let basic = parseFloat(prompt("Enter Basic Salary:"));
let pf = basic * 0.12;
let hra = basic * 0.20;
let da = basic * 0.15;
let gross = basic + pf + hra + da;
let net = gross - pf;
console.log("Employee Salary Details:");
console.log("Employee No: " + eno);
console.log("Employee Name: " + ename);
console.log("Basic Salary: " + basic);
console.log("Gross Salary: " + gross.toFixed(2));
console.log("Net Salary: " + net.toFixed(2));