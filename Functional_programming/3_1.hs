minlist (x:xs) = minlist' xs x
minlist' [] min = min
minlist' (x:xs) min = if x<min
                      then minlist' xs x
                      else minlist' xs min