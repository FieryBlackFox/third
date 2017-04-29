data Rat = Rat Int Int
                      deriving(Show)
instance Eq Rat where
            (Rat a b) == (Rat c d) =
            ((a `div` b) == (c `div` d)) && ((a `mod` b) == (c `mod` d))
instance Eq Rat where
            (Rat a b) < (Rat c d) =
            a*d-b*c<0
instance Num Rat where
            (Rat a b) + (Rat c d) =
            (Rat (a*d+c*b) (b*d))