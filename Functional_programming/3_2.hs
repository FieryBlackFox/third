minsum (x:y:xs) = minsum' (y:xs) (x+y)
minsum' (x:[]) min = min
minsum' (x:y:xs) min = if (x+y)<min
                       then minsum' (y:xs) (x+y)
                       else minsum' (y:xs) min