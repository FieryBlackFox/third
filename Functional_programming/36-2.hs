elka n = elka' n n
elka' 1 n = elka'' n 7
elka' p n = do elka'' n 7
               elka' (p-1) n
elka'' 1 n = print n
elka'' p n = do print n
                elka'' (p-1) (n*10+7)