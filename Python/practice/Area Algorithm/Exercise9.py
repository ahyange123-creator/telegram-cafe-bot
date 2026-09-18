# square 


side = float(input("Enter the side Length of the square: "))
if side > 0:
    area = side * side
    print(f"Success! The area of the square is: {area:.2f}")
elif side == 0:
    print("Error")
else :
    print("Error: Side Length cannot be negative.")


# retangle 


length = float(input("Enter the side Length of the retangel: "))
Width = float(input("Enter the side Width of the retangel: "))
if length and  Width > 0:
    area = length * Width
    print(f"The area of retangle is: {area:.2f}")
else:
    print("Error! The demension must be greater than 0")


# Rhombus 


D1 = float(input("Enter the side Diagonal1 of the Rhombus: "))
D2 = float(input("Enter the side Diagonal2 of the Rhombus: "))
if D1 and  D2 > 0:
    area = (D1*D2)/2
    print(f"The area of Rhombus is: {area:.2f}")
else:
    print("Error! The Diagonal must be greater than 0")


# Parallelogram 


base = float(input("Enter the side base of the Parallelogram: "))
height = float(input("Enter the side height of the Parallelogram: "))
if base and  height > 0:
    area = base*height
    print(f"The area of Parallelogram is: {area:.2f}")
else:
    print("Error! The Diagonal must be greater than 0")



# Triangle 


base = float(input("Enter the side base of the Triangle: "))
height = float(input("Enter the side height of the Triangle: "))
if base and  height > 0:
    area = (base*height)
    print(f"The area of Triangle is: {area:.2f}")
else:
    print("Error! The Triangle must be greater than 0")


# Circle
Radius = float(input("Enter the radius of the Circle: "))
if Radius >0:
    area= 3.14 * Radius * Radius
    print(f"The area of Circle is: {area:.2f}")
elif Radius == 0:
    print("Error ! Radius can not be 0")

else:
    print("Error! Radius can not be negative ")





