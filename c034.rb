a = ARGF.read.gsub('=','==').split
i = a.find_index { |n| n == 'x' }
10.times do |n|
  a[i] = n
  break p n if eval a.join
end
