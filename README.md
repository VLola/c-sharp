# Project 46.

Write your clone of NotePad++
___
# Project 45.

Write your provider-contacts. The application should display a list of contacts. Should be functional:
+ Adding a contact
+ Deleting a contact
+ Search by name/surname/patronymic/operator/date added
+ Sort by first name/last name/middle name/operator/date added
+ When you click on the card - a window with more detailed information should open


The card consists of:
+ Name *
+ Surname
+ Middle name
+ Date of Birth
+ Phone number (1*-10) with operator auto-detection
+ Address (country / city / street / house / apartment)
+ Machine (make / model / reg number)
+ Company (name / position)

\* required fields

___
# Project 44.

Convert phonebook using disconnected mode of operation
___
# Project 43.

Create an application for convenient reading of books.

On the start window in the form of a shelf of books, display everything.
It should be possible to add a new one (with a random cover, from a txt file) or remove it.
When you click on a specific one - open it in a separate window

In the reading window - display the opportunity
+ page flipping forward/backward
+ closing the book (the next time you open it, it should return to the same page)
+ Voice over content

___
# Project 42.

## Task 1:
Display your (short!) summary using the MessageBox sequence (at least three in number).
Moreover, the title of the latter should display
average number of characters per page (total number of characters in summary / number of MessageBoxes).

## Task 2:
Write a function that "guesses" the number conceived by the user from 1 to 2000.
To query the user, use MessageBox.
After the number is guessed, it is necessary to display the number of requests,
required for this, and provide the user with the opportunity to play again,
without leaving the program (MessageBoxes are decorated with buttons and icons according to the situation).

## Task 3:
Imagine you have a rectangle on your form,
whose borders are 10 pixels apart from the borders of the form's workspace.
You need to create the following handlers:
+ Handler for pressing the left mouse button,
which outputs a message about where the current point is:
inside the rectangle, outside, on the border of the rectangle.
If the Control (Ctrl) button was pressed when the left mouse button was pressed,
then the application should close; 
+ Right click handler
which displays in the window title information about the size of the client (working) area of  the window in the form:
Width = x, Height y - the corresponding parameters of your window;
+ Handler for moving the mouse pointer within the workspace,
which should display the current x and y coordinates of the mouse in the window title.

## Task 4:
Develop an application based on a form.
  + The user "clicks" the left mouse button on the form and,
without releasing the button, moves the mouse over it,
and at the moment of releasing the button, according to the obtained coordinates of the rectangle
(you know, of course, that two points on the plane are enough to create a rectangle)
you need to create a "static", which contains its serial number
(meaning the order of appearance on the form)
  + The minimum size of a "static" is 10x10,
when trying to create an element of smaller sizes, the user should see a corresponding warning.
  + When right-clicking over a static surface
information about its area and coordinates (relative to the shape) should appear in the window title.
If there are several "statics" at the click point,
then preference is given to "static" with a serial number.
___
# Project 41.

Develop a class "Account for payment".

Provide the following fields in the class:
+ payment per day;
+ number of days;
+ a penalty for one day of delay in payment;
+ number of days to delay payment;
+ amount payable without penalty (calculated field);
+ penalty (calculated field);
+ total amount due (calculated field).

In the class, declare a static property of type bool,
the value of which affects the process of formatting objects of this class.

If the value of this property is true, then all fields are serialized and deserialized,
if false, calculated fields are not serialized.

Develop an application in which you want to demonstrate the use of this class,
results must be written to and read from a file.
___
# Project 40.

Develop the Tamagotchi app.

The life cycle of a character is 1-2 minutes.
The character randomly issues requests (but the same request is not issued in a row).

Requests can be the following: Feed, Walk, Put to bed, Treat, Play.
If requests are not granted three times,
the character "gets sick" and asks him to be treated.
If it fails, it "dies".

The character is displayed in the console window using pseudo-graphics.

The dialogue with the character is carried out by calling the Show() method of the MessageBox class from the System.Windows.Forms namespace.

For more information on working with this method, contact your instructor or MSDN.

To solve this problem, you will need the Timer class from the System.Timers namespace, whose event is Elapsed,
delegate type ElapsedEventHandler, occurs after a certain time interval,
which is set in the Interval property.

The Start() and Stop() methods start and stop the timer, respectively.

You may also want to pause the application,
in this case, you can call the Sleep() method of the Thread class from the System.

Threading namespace, transferring the required number of milliseconds to it.
___
# Project 39.

Create a primitive English-Russian and Russian-English dictionary,
containing pairs of words - the names of countries in Russian and English.

The user should be able to choose the direction of the transfer and request a transfer.
___
# Project 38.

Write a Money class designed to store a sum of money (in hryvnias and cents).

Implement operator overloading for a class:
##### + (addition of monetary amounts)
##### - (subtraction of sums)
##### / (dividing the sum by an integer)
##### * (multiplying the sum by an integer)
##### ++ (the amount increases by 1 cent)
##### -- (the amount is reduced by 1 cent)
##### <
##### >
##### ==
##### !=
The class cannot contain a negative sum.
If the execution of any operation results in a negative amount of money,
then the class throws a Bankrupt exception.

The program should use the menu to demonstrate all the features of the Money class.
Exception handling is done in the program.
___
# Project 37.

Write an application that will display the simplest geometric shapes specified by the user in the console.

The user selects a shape and sets its position on the screen,
as well as size and color using the menu.

All user-defined shapes are displayed simultaneously on the screen.

Shapes (rectangle, rhombus, triangle, trapezoid, polygon) are drawn with asterisks or other symbols.

To implement the program, it is necessary to develop a class hierarchy (think about the possibility of abstraction).

To store all user-defined shapes, create a Geometric Shapes Collection class with the Display All Shapes method.

To display all the shapes with the specified method, you need to use the foreach statement,
why in the class "Collection of geometric shapes" it is necessary to implement the appropriate interfaces.
___
# Project 36.

- #### Task 1:
Develop your own structural data type to store the integer coefficients A and B of the linear equation AxX + BxY = 0.
In the class, implement the static Parse() method,
which takes a string with the values of the coefficients,
separated by comma or space.

- #### Task 2:
Develop a method for solving a system of 2 linear equations:

A1xX + B1xY = 0

A2xX + B2xY = 0

The method, using output parameters, should return the found solution or error,
if no solution exists.

- #### Task 3:
Implement a class for storing a complex number.
In it, overload all the necessary operators to successfully compile the following code snippet:

Complexz = new Complex(1,1);

Complexz1;

z1 = z - (z * z * z - 1) / (3 * z * z);

Console.WriteLine("z1 = {0}", z1);

- #### Task 4:
Develop a Fraction class that represents a simple fraction.
In the class, provide two fields: the numerator and denominator of the fraction.
### Overload the following operators: +,-,*,/,==,!=,<,>, true, and false. 

Arithmetic operations and comparison are performed in accordance with the rules for working with fractions.
The true operator returns true if the fraction is correct (the numerator is less than the denominator),
the false operator returns true if the fraction is not correct (the numerator is greater than the denominator).
Overload the operators necessary to successfully compile the following code snippet:

Fraction f = new Fraction(3, 4);

int a = 10;

Fraction f1 = f*a;

Fraction f2 = a*f;

double d = 1.5;

Fraction f3 = f + d;
___
# Project 35.

Write an application that will display the simplest geometric shapes specified by the user in the console.
The user selects a shape and sets its position on the screen, as well as the size and color using the menu.
All user-defined shapes are displayed simultaneously on the screen.
Shapes (rectangle, rhombus, triangle, trapezoid, polygon)
drawn with asterisks or other symbols.
To implement the program, it is necessary to develop a class hierarchy
(think about the possibility of abstraction).
To store all user defined shapes,
create a class "Collection of geometric shapes" with the method "Display all shapes".
To display all the shapes with the specified method, you need to use the foreach statement,
why in the class "Collection of geometric shapes" it is necessary to implement the appropriate interfaces.
___
# Project 34.

Develop an abstract class Geometric Shape with Shape Area and Shape Perimeter fields.
Develop child classes: 
+ Triangle, 
+ Square, 
+ Rhombus, 
+ Rectangle, 
+ Parallelogram, 
+ Trapezium,
+ Circle, 
+ Ellipse.

And implement properties that uniquely define the objects of these classes.
Implement the Simple N Square interface, which has the properties:
+ Height,
+ Base, 
+ Angle Between Base and Adjacent Side, 
+ Number of Sides,
+ Side lengths, 
+ Area, 
+ Perimeter.

Implement a Composite Shape class that can consist of any number of Simple N Squares.
For this class, define a method for finding the area of a figure.
Provide options for the impossibility of specifying a figure
(negative side lengths are entered, or when creating a triangle object, there is a pair of sides,
the sum of the lengths of which is less than the length of the third side, etc.)
___
# Project 33.

 Write an application that will display the simplest geometric shapes selected by the user in the console:
  + "rectangle", 
  + "rhombus", 
  + "triangle", 
  + "trapezium", 
  + "polygon".

From the menu, the user selects the shapes and selects the colors for each shape.
Shapes are drawn with asterisks or other symbols.
To implement the program, it is necessary to develop a hierarchy.
classes (think about the possibility of abstraction).
All user-defined shapes are stored in the Generic Shape object,
which has a "display all selected shapes" method.
___
# Project 32.

Develop an application that compares
the population of the three capitals from different countries.
Moreover, the country would be designated by a namespace, and the city by a class in this space.
___
# Project 31.

Develop the application "7 wonders of the world", where each
miracle will be represented by a separate class. Create an additional class containing the entry point.
Divide the application into project files and use the namespace to make the classes interoperable.
___
# Project 30.

- #### Task 1:
Describe an Article structure containing the following
fields: product code; Product Name; the price of the goods.

- #### Task 2:
Describe a Client structure containing fields: code
client; FULL NAME; the address; telephone; the number of orders
carried out by the client; total orders
client

- #### Task 3:
Come up with a class that describes the student. Provide for the following points in it: last name, first name,
patronymic, group, age, array (jagged) scores by
programming, administration and design.
And also add methods for working with the listed data:
the ability to set / receive an assessment, obtaining an average score for a given subject,
student data printout.

- #### Task 4:
Describe the Request structure containing the fields: code
order; customer; order date; list of ordered goods;
order amount (implemented as a computed property).

- #### Task 5:
Describe an ArticleType enum defining
product types, and add the corresponding field
into the Article structure from task #1.

- #### Task 6:
Describe a ClientType enum defining
the importance of the client, and add the corresponding field
into the Client structure from task #2.

- #### Task 7:
Describe the PayType enum that defines the form
payment by the customer of the order, and add the corresponding
field to the Request structure from task #4.
___
# Project 29.

- #### Task 1:
Declare a one-dimensional (5 elements) array named A and a two-dimensional array (3 rows, 4 columns) of fractional numbers named B. Fill one-dimensional array A with numbers entered from the keyboard by the user, and two-dimensional array B with random numbers using loops. Display the values of arrays: array A in one line, array B - in the form of a matrix. Find in these arrays the total maximum element, the minimum element, the total sum of all elements, the total product of all elements, the sum of even elements of array A, the sum of odd columns of array B.

- #### Task 2:
Given 2 arrays of dimensions M and N, respectively. It is necessary to rewrite the common elements of the first two arrays into the third array without repetitions.

- #### Task 3:
Given a two-dimensional array of dimensions 5x5, filled with random numbers from the range from -100 to 100. Determine the sum of the array elements located between the minimum and maximum elements.
___
# Project 28.

- #### Task 1:
Given positive integers A, B, C.
The program should ask the user for the value of these numbers.
A rectangle of size A*B contains as many squares as possible with side C.
The squares do not overlap.
Find the number of squares placed on the rectangle, as well as the area of the unoccupied part of the rectangle.
It is necessary to provide service messages in the event that
if no squares with side C can be placed in a rectangle
(for example, if the value of C is greater than the size of the sides of the rectangle).

- #### Task 2:
The initial deposit in the bank is 10,000 UAH.
Every month the amount of the deposit increases by P
percent of the available amount
(P is a real number, 0 < P < 25).
The program must receive the value of P from the user.
According to this P, determine in how many months the amount of the deposit will exceed UAH 11,000,
and output the found number of months K (integer)
and the final size of the contribution S (real number).

- #### Task 3:
Given positive integers A and B (A < B).
Output all integers from A to B inclusive;
each number should be displayed on a new line;
each number should be displayed the number of times,
equal to its value (for example, the number 3 is displayed 3 times). 
For example: if A = 3 and B = 7, then the program should generate the following output in the console:

###### 3 3 3
###### 4 4 4 4
###### 5 5 5 5 5
###### 6 6 6 6 6 6
###### 7 7 7 7 7 7 7

- #### Task 4:
Given an integer N greater than 0, find the number
obtained by reading the number N from right to left.
For example, if the number 345 was entered, then the program should output the number 543.
___