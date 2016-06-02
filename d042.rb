m = ARGF.read.split.map(&:to_i)
p m[0] * m[3] - m[2] * m[1]
