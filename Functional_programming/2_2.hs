numPath n = numPath' n n
numPath' 1 y = 1
numPath' x 1 = 1
numPath' x y = numPath'(x-1)(y-1) + numPath'(x-1) y + numPath' x (y-1)