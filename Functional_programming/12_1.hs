cross n = map(\i-> map(\j-> if i == j || i+j==n+1
                            then 1
                            else 0 )[1..n]) [1..n]