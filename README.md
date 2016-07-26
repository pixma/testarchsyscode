ArchTestDemo
================

The goal of this problem is to find all _lines_ that have more than two points on them from the input set.

Given input set: A list of 2D (all different) points: (x_1, y_1), ..., (x_K, y_K); all numbers use floating point representation.

Problem description: As known from basic geometry, one can draw a straight line between any two such points. Your goal is to create a program that finds all the _lines_ that have more than two points on them from a given input set. You can choose any way to represent a line, but the common one is 
y = m * x + b.  Feel free to use the formatting and language with which you are most comfortable to express your answer.

Example: If the input set is {(0, 0), (1,1), (3,5), (2,2)}, the output should 
be (m=1, b=0) because this line has three points from the input set: 
(0, 0), (1,1), (2,2). 

Developed By Annim Banerjee
Tech Used
- Language C#
- Program type : UI

Valid Input format in general 
1,2,3,5,6,7,7,7,7,7,5,4,4.......


For example:
write directly the x y data points in input box like this below
14,12,45,23,12,2,12,34... The press Process.

For generating such input data sets, use the Generator window in the application.
Valid Input for that is:(m,c, n) [n for number of data points do you want]
2,3,50,3,1,90,6,0,10...

This means first input, m = 2, c = 3 and you want 50 data points from that line's equation and so on...
Then you copy the generated values and past it to main window for the target problem.
