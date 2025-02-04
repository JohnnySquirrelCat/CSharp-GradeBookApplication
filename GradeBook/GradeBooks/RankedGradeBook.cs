﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GradeBook.GradeBooks
{
  public class RankedGradeBook : BaseGradeBook
  {
    public RankedGradeBook(string name, bool IsWeighted) : base(name, IsWeighted)
    {
      Type = Enums.GradeBookType.Ranked;
    }

    public override char GetLetterGrade(double averageGrade)
    {
      
      if (Students.Count < 5)
      {
        throw new InvalidOperationException(" Ranked-grading requires a minimum of 5 students to work please add more students. ");
      }

      int threshold = (int)Math.Ceiling(Students.Count * 0.2);
      List<double> grades = Students.OrderByDescending(s => s.AverageGrade).Select(s => s.AverageGrade).ToList();

      if (averageGrade >= grades[threshold - 1])
        return 'A';
      if (averageGrade >= grades[(threshold * 2) - 1])
        return 'B';
      if (averageGrade >= grades[(threshold * 3) - 1])
        return 'C';
      if (averageGrade >= grades[(threshold * 4) - 1])
        return 'D';

      return 'F';
    }

    public override void CalculateStatistics()
    {
      if (Students.Count() < 5)
      {
        Console.WriteLine(" Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade. ");

        return;
      }

      base.CalculateStatistics();
    }

    public override void CalculateStudentStatistics(string name)
    {
      if (Students.Count() < 5)
      {
        Console.WriteLine(" Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade. ");

        return;
      }

      base.CalculateStudentStatistics(name);
    }

  }

}
