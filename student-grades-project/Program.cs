// initialize variables - graded assignments 
decimal currentAssignments = 5M;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

Console.WriteLine("Grade Sums:");
Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolasSum);
Console.WriteLine("Zahirah: " + zahirahSum);
Console.WriteLine("Jeong: " + jeongSum);

// resultado decimal pois "currentAssignments" é decimal
decimal sophiaScore = sophiaSum / currentAssignments;
decimal nicolasScore = nicolasSum / currentAssignments;
decimal zahirahScore = zahirahSum / currentAssignments;
decimal jeongScore = jeongSum / currentAssignments;

Console.WriteLine();
Console.WriteLine("Student Scores:");

string sophiaGrade = GetStudentGrade(sophiaScore);
string nicolasGrade = GetStudentGrade(nicolasScore);
string zahirahGrade = GetStudentGrade(zahirahScore);
string jeongGrade = GetStudentGrade(jeongScore);

Console.WriteLine($"Sophia:\t\t{sophiaScore}\t{sophiaGrade}");
Console.WriteLine($"Nicolas:\t{nicolasScore}\t{nicolasGrade}");
Console.WriteLine($"Zahirah:\t{zahirahScore}\t{zahirahGrade}");
Console.WriteLine($"Jeong:\t\t{jeongScore}\t{jeongGrade}");

string GetStudentGrade(decimal studentScore)
{
  if (studentScore >= 90)
  {
    return "A";
  }
  else if (studentScore >= 80)
  {
    return "B";
  }
  else if (studentScore >= 70)
  {
    return "C";
  }
  else if (studentScore >= 60)
  {
    return "D";
  }
  else
  {
    return "F";
  }
}
