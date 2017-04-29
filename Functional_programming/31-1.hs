data Scheme a = R a | S (Scheme a) (Scheme a) | P (Scheme a) (Scheme a)
instance Foldable Scheme where
                              foldr f e (R a) = f a e
                              foldr f e (S l r) = let res1 = foldr f e l
                                                      res2 = foldr f res1 r
                                                  in res2
                              foldr f e (P l r) = let res1 = foldr f e l
                                                      res2 = foldr f res1 r
                                                  in res2