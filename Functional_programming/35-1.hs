data Expr = Num Integer | X | Add Expr Expr | Mult Expr Expr deriving (Show, Eq)
simplify (Num i) = Num i
simplify X = X
simplify (Add x y) = Add (simplify x) (simplify y)
simplify (Mult (Num 1) e) = simplify e
simplify (Mult e (Num 1)) = simplify e
simplify (Mult x y) = let xx = simplify x
                          yy = simplify y
                      in if xx == (Num 1)
                         then yy
                         else if yy == (Num 1)
                              then xx
                              else Mult xx yy