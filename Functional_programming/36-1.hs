find cond (x:xs) = if cond x 
                   then (x, xs) 
                   else find cond xs
f >>>= g = \xs -> let (x, xs1) = f xs 
                  in g x xs1
return1 x xs = (x, xs)
f = find (>3) >>>= \x ->
                   find (>x) >>>= \y ->
                                   return1 (x+y)