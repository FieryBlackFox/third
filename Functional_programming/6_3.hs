data Tree = Empty | Node Integer Tree Tree
height (Node _ Empty Empty) = 0
height Empty = 0
height (Node _ l r) = max (height r) (height l) + 1