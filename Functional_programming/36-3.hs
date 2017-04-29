data Expr = Num Integer | Var String | Add Expr Expr | Mult Expr Expr | Let String Expr Expr
eval (Num i) _ = i
eval (Var name) env = eval (getValue name env) env
eval (Add x y) env = eval x env + eval y env
eval (Mult x y) env = eval x env * eval y env
eval (Let name expr inExpr) env = eval inExpr ((name, expr):env)
getValue name env = head [v | (n, v) <- env, n == name]