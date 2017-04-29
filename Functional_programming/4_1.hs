upDown [] = False
upDown (x:[]) = False
upDown (x:y:xs) = if x<y
                  then up (y:xs)
                  else False
up (x:[]) = False
up (x:y:xs) = if x<y
              then up (y:xs)
              else down (y:xs)
down (x:[]) = True
down (x:y:xs) = if x>y
                then down (y:xs)
                else False