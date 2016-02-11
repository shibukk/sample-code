begin
  total = 0
  gets
  while live = gets
    sum = live.chomp.split(" ").map(&:to_i).inject(:+)
    total += [sum, 0].max
  end
  p [total, 0].max
rescue
  p 0
end
