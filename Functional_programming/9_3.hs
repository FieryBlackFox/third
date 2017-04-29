myfoldl f e [] = e
myfoldl f e (x:xs) = myfoldl f (f e x) xs