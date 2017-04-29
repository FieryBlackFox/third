rules = 300 : 300 : 300 : 300 : 300 : 1000 : 1000 : rules
checkMyRules xs = all(>=0) (zipWith (-) rules xs)