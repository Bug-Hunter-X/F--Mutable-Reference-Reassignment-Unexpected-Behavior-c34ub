# F# Mutable Reference Reassignment Bug

This example demonstrates a potential point of confusion when working with mutable references in F#.  Reassigning the reference itself doesn't modify the value at the original memory location.