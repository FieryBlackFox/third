tripleOdd xs = xs >>= \x-> if mod x 2 == 0
                     then [x]
                     else [x,x,x]