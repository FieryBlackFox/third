sumfact n = sumfact' n 1 1 0
sumfact' 0 t p s = s
sumfact' n t p s = sumfact' (n-1) (t+1) (p*t) (s+p*t)