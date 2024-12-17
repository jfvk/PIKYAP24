import sys
def eq(a, b, c):
  D= b**2 - 4*a*c
  if D < 0:
    return []
  elif D == 0:
    y = -b / (2 * a)
    return [y ** 0.5, y ** 0.5]
  else:
    y1 = (-b + D**0.5) / (2 * a) ; y2 = (-b - D**0.5) / (2 * a)
    if y1 >= 0:
      x1 = y1**0.5 ; x2 = -y1**0.5
    else: x1 = x2 = False
    if y2 >= 0:
      x3 = y2**0.5 ; x4 = -y2**0.5
    else: x3 = x4 = False
    return [x for x in [x1, x2, x3, x4] if x is not False]
if __name__ == "__main__":
  if len(sys.argv) == 4:
    a, b, c = sys.argv[1:]
    if all(x.replace("-", "").isdigit() for x in [a, b, c]):
      a = float(a);   b = float(b); c = float(c)
    else:
      print("Invalid input. Try again.")
      a = b = c = False
  else:
    a = b = c = False

  while a is False:
    a = input("A: ")
    if a.replace("-", "").isdigit():
      a = float(a)
      if a == 0:
        print("If A is equal to zero then it is not a biquadratic equation. Try again.")
        a = False
    else:
      print("Invalid input. Try again.")
  while b is False:
    b = input("B: ")
    if b.isnumeric():
      b = float(b)
    else:
      print("Invalid input. Try again.")
  while c is False:
    c = input("C: ")
    if c.isnumeric():
      c = float(c)
    else:
      print("Invalid input. Try again.")
  r = eq(a, b, c)
  if r:
    print("Real roots:", *r)
  else:
    print("No real roots.")
