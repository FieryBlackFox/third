f <=< g = \x -> 
                case g x of
                    Nothing -> Nothing
                    Just a -> f a
f i = if i > 0 then Just (-i) else Nothing
g i = if mod i 2 == 0 then Just (div i 2) else Nothing