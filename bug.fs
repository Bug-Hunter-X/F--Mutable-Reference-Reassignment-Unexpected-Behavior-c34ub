let mutable x = 10
let y = &x

//Modifying the mutable variable through the reference
!y <- 20

printfn "%d" x //Prints 20

//Attempting to reassign the reference to a different mutable variable
y <- & (100)

printfn "%d" x //Prints 20
printfn "%d" !y  //Prints 100

//The reference y now points to a different location in memory that holds the value 100
//However, this doesn't affect the original variable x, which retains its value of 20.