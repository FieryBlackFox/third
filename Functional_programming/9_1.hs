multTable n = multTable' n n []
multTable' n 0 xss = xss
multTable' n i xss = multTable' n (i-1) ((map(\x->x*i) [1..n]):xss)