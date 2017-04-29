data Candy = Cake String Double | Sweet String Double Double
value (Cake _ n) = n
value (Sweet _ p n) = p*n
totalPrice xs = sum (map value xs)
test = totalPrice [Sweet "S1" 0.5 500, Cake "C1" 300, Cake "C2" 200, Cake "C3" 250]