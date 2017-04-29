data Tree = Empty | Node Integer Tree Tree
            deriving (Show)
renumerate t = renumerate' t 0
renumerate' (Node v Empty Empty) i = (Node (i+1) Empty Empty)
renumerate' (Node v Empty r) i = (Node (i+1) Empty (renumerate' r (i+1)))
renumerate' (Node v l Empty) i = (Node (i+1) (renumerate' l (i+1)) Empty) 
renumerate' (Node v l r) i = (Node (i+1) (renumerate' l (i+1)) (renumerate' r (countNode l + i + 1)))
countNode Empty = 0
countNode (Node v l r) = 1 + countNode l + countNode r