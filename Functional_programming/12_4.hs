data Scheme = OneScheme Double | ParallelScheme Scheme Scheme | StepScheme Scheme Scheme
totalResistance (OneScheme r) = r
totalResistance (ParallelScheme a b) = c*d/(c+d)
                                       where c = totalResistance a
                                             d = totalResistance b
totalResistance (StepScheme a b) = totalResistance a + (totalResistance b)
test = totalResistance(StepScheme(ParallelScheme (OneScheme 2) (OneScheme 2)) (OneScheme 2))