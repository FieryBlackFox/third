findSame xs = let ys = xs >>= \x -> if length (filter (==x) xs) > 1
                                    then [x]
                                    else []
              in if length ys == 0
                 then 1
                 else (head ys)*10
{--���� ������������� ����� ����, �� ���������� ��� ����� *10, ����� ������ 1--}