{--isLine (x:xs) =  if all(\y->fst y == fst x) xs
                 then let ps = map(\y-> snd y) (x:xs)
                      in (isA ps (minimum ps) (maximum ps))
                 else if all(\y->snd y == snd x) xs
                      then let ns = map(\y-> fst y) xs
                           in (isA ns (minimum ns) (maximum ns))
                      else False
isA ns a b = length fulls == length ss
              where fulls = [a..b]
                    ss = [x|x<-ns, y<-fulls, x==y]
isLine [] = False
isLine ((_,_):[]) = False
isLine xs = isLine' xs True True
isLine' ((x,y):[]) ox oy = ox || oy
isLine' ((x,y):(x1,y1):xs) ox oy = isLine' ((x1,y1):xs) (x==x1&&ox) (y==y1&&oy)--}


isLine xs = if all (\x -> x == head fs) fs
            then part ss
            else if all (\x -> x == head ss) ss
                 then part fs
                 else False
           where fs = first xs
                 ss = second xs
part xs = (maximum xs - minimum xs) == (length xs - 1)
first xs = map (\x-> fst x) xs 
second xs = map (\x-> snd x) xs 