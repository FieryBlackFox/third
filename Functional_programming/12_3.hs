data Tree = Empty | Node Integer Tree Tree
foldTree f e (Node v Empty Empty) = v
foldTree f e (Node v Empty r) = f v (foldTree f e r)
foldTree f e (Node v l Empty) = f (foldTree f e l) v
foldTree f e (Node v l r) = f (f (foldTree f e l) (foldTree f e r)) v
