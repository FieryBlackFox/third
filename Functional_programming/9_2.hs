countEven xs = foldr ch 0 xs
ch x res = if x `mod` 2 == 0
           then (res+1)
           else res
countEven1 xs = sum (map(\x->if x `mod` 2 == 0 then 1 else 0) xs)