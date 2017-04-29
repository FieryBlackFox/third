brackets' (x:xs) = ('[':x++[']']):brackets' xs
brackets = "[]": brackets' brackets