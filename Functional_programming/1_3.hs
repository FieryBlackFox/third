sumcos n = sumcos' n 0 0
sumcos' 0 p t = (cos p)/t
sumcos' n p t = sumcos' (n-1) (p+n) (t+cos n)