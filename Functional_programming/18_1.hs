lcos x = cos x : lcos (x+1)
bigCos x = head (filter (>=x) (lcos 1))