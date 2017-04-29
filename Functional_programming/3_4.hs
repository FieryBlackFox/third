checkSum [] = False
checkSum (x:xs) = if x>10
                  then checkSum xs
                  else if findY (10-x) xs
                       then True
                       else checkSum xs
findY y [] = False
findY y (x:xs) = if y==x
                 then True
                 else findY y xs