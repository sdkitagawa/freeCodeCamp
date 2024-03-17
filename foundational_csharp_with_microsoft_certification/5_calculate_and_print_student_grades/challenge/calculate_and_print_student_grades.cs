// initialize variables - graded assignments 
int currentAssignments = 5;

int sophiaGrade1 = 93;
int sophiaGrade2 = 87;
int sophiaGrade3 = 98;
int sophiaGrade4 = 95;
int sophiaGrade5 = 100;

int nicolasGrade1 = 80;
int nicolasGrade2 = 83;
int nicolasGrade3 = 82;
int nicolasGrade4 = 88;
int nicolasGrade5 = 85;

int zahirahGrade1 = 84;
int zahirahGrade2 = 96;
int zahirahGrade3 = 73;
int zahirahGrade4 = 85;
int zahirahGrade5 = 79;

int jeongGrade1 = 90;
int jeongGrade2 = 92;
int jeongGrade3 = 98;
int jeongGrade4 = 100;
int jeongGrade5 = 97;

int sophiaGradesSum = sophiaGrade1 + sophiaGrade2 + sophiaGrade3 + sophiaGrade4 + sophiaGrade5;
int nicolasGradesSum = nicolasGrade1 + nicolasGrade2 + nicolasGrade3 + nicolasGrade4 + nicolasGrade5;
int zahirahGradesSum = zahirahGrade1 + zahirahGrade2 + zahirahGrade3 + zahirahGrade4 + zahirahGrade5;
int jeongGradesSum = jeongGrade1 + jeongGrade2 + jeongGrade3 + jeongGrade4 + jeongGrade5;

decimal sophiaScore = (decimal) sophiaGradesSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasGradesSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahGradesSum / currentAssignments;
decimal jeongScore = (decimal) jeongGradesSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");
