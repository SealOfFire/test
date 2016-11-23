class Node():
	value = 0
	sum = 0
	level = 0
	parent = None
	left = None
	right = None
	text = ""

	def  __init__(self,parent, value, level):
		self.parent = parent
		self.value = value
		self.level = level
		if parent is not None:
			self.sum = parent.sum + value
			if value > 0:
				self.text = parent.text + "R"
				pass
			else:
				self.text = parent.text + "L"

line1 = raw_input()
line1 = line1.split(" ")

length = int(line1[0])
count = int(line1[1])
input = []
last = []
last.append(Node(None,0,0))

for i in range(0,count):
	input.append(int(raw_input()))
	newLine = []

	for n in last:
		left = Node(n, 0 - input[i], i)
		right = Node(n, input[i], i)

		if abs(left.sum) <= length:
			n.left = left
			newLine.append(left)

		if abs(right.sum) <= length:
			n.right = right
			newLine.append(right)

	last = newLine

print last[0].text;