begin
  group = Hash.new { |h, k| h[k] = [] }
  result = Hash.new { |h, k| h[k] = [] }
  fmt = gets.split.map(&:to_i)
  n = fmt[0]
  g = fmt[1]
  m = fmt[2]
  1.upto(g) { |n| a = gets.split.map(&:to_i); a.delete_at(0); group[n] = a }
  m.times do |i|
    row = gets.split
    result[row[0].to_i] << row[3]
    if row[1] == '1'
      group[row[2].to_i].each { |n| result[n] << row[3] }
    else
      result[row[2].to_i] << row[3]
    end
  end
rescue
  puts ''
end
i = 0
result.sort.each do |_, v|
  v.uniq.each { |vv| puts vv }
  i += 1
  break if result.size == i
  puts '--'
end