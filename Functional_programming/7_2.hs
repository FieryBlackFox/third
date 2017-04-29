euclid a b = bezu a b 1 0 0 1
bezu 0 b p q r s = (r,s)
bezu a 0 p q r s = (p,q)
bezu a b p q r s = if a>=b
                   then bezu (a-b) b (p-r) (q-s) r s
                   else bezu a (b-a) p q (r-p) (s-q)