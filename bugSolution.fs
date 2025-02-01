The issue isn't a bug, but rather an expected behavior of references.  To modify the original value via a reference, use the dereference operator (!).  If you want to change the original variable's value through a reference, you have to use the dereference operator to assign the new value directly to the memory location referred to by `y`.  There's no direct way to make `y` automatically point to and modify `x` after `y` has been reassigned. 

```fsharp
let mutable x = 10
let y = &x

//Modifying the mutable variable through the reference
!y <- 20

printfn "%d" x //Prints 20

//Modifying the mutable variable through the reference (Correct way to affect x)
let mutable z = 100
let y2 = &z
!y2 <- 200
printfn "%A" z //Prints 200
```