findMajor xs = if s/=0
               then Just s
               else Nothing
               where s = foldr(\x res->if (su-x) < x
                                       then res+x
                                       else res) 0 xs
                     su = sum xs