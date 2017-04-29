b n = b' (n-1) 1
b' 0 p = False
b' n p =if n < p
        then False 
        else if bin n 
             then True 
             else b' (n-p) (p*2)
bin n = if n `mod` 2 == 0
        then bin(n `div` 2) 
        else if n==1 
             then True 
             else False