minsum (x:xs) = minimum (map (\(y,z)-> y+z) (zip (x:xs) xs))