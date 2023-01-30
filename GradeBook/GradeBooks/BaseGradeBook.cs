using System;
using System.Linq;

using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Collections;
using System.Data.Odbc;

namespace GradeBook.GradeBooks
{

  //public sealed class OleDbDataReader : System.Data.Common.DbDataReader
  //{
  //  public override object this[int ordinal] => throw new NotImplementedException();

  //  public override object this[string name] => throw new NotImplementedException();

  //  public override int Depth => throw new NotImplementedException();

  //  public override int FieldCount => throw new NotImplementedException();

  //  public override bool HasRows => throw new NotImplementedException();

  //  public override bool IsClosed => throw new NotImplementedException();

  //  public override int RecordsAffected => throw new NotImplementedException();

  //  public override bool GetBoolean(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override byte GetByte(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override char GetChar(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override string GetDataTypeName(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override DateTime GetDateTime(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override decimal GetDecimal(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override double GetDouble(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override IEnumerator GetEnumerator()
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override Type GetFieldType(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override float GetFloat(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override Guid GetGuid(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override short GetInt16(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override int GetInt32(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override long GetInt64(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override string GetName(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override int GetOrdinal(string name)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override string GetString(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override object GetValue(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override int GetValues(object[] values)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override bool IsDBNull(int ordinal)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override bool NextResult()
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public override bool Read()
  //  {
  //    throw new NotImplementedException();
  //  }
  //}


  //public abstract class DbDataReader : MarshalByRefObject, IDisposable, System.Collections.IEnumerable, System.Data.IDataReader
  //{
  //  public object this[int i] => throw new NotImplementedException();

  //  public object this[string name] => throw new NotImplementedException();

  //  public int Depth => throw new NotImplementedException();

  //  public bool IsClosed => throw new NotImplementedException();

  //  public int RecordsAffected => throw new NotImplementedException();

  //  public int FieldCount => throw new NotImplementedException();

  //  public void Close()
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public void Dispose()
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public bool GetBoolean(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public byte GetByte(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public char GetChar(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public IDataReader GetData(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public string GetDataTypeName(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public DateTime GetDateTime(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public decimal GetDecimal(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public double GetDouble(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public IEnumerator GetEnumerator()
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public Type GetFieldType(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public float GetFloat(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public Guid GetGuid(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public short GetInt16(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public int GetInt32(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public long GetInt64(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public string GetName(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public int GetOrdinal(string name)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public DataTable GetSchemaTable()
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public string GetString(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public object GetValue(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public int GetValues(object[] values)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public bool IsDBNull(int i)
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public bool NextResult()
  //  {
  //    throw new NotImplementedException();
  //  }

  //  public bool Read()
  //  {
  //    throw new NotImplementedException();
  //  }
  //}



  public abstract class BaseGradeBook
  {
    public string Name { get; set; }

    public List<Student> Students { get; set; }

    public GradeBookType Type { get; set; }

    public bool IsWeighted { get; set; }


    public BaseGradeBook(string name, bool isWeighted)
    {
      Name = name;
      Students = new List<Student>();
      IsWeighted = isWeighted;
    }

    public void AddStudent(Student student)
    {
      if (string.IsNullOrEmpty(student.Name))
        throw new ArgumentException("A Name is required to add a student to a gradebook.");
      Students.Add(student);
    }

    public void RemoveStudent(string name)
    {
      if (string.IsNullOrEmpty(name))
        throw new ArgumentException("A Name is required to remove a student from a gradebook.");
      var student = Students.FirstOrDefault(e => e.Name == name);
      if (student == null)
      {
        Console.WriteLine("Student {0} was not found, try again.", name);
        return;
      }
      Students.Remove(student);
    }

    public void AddGrade(string name, double score)
    {
      if (string.IsNullOrEmpty(name))
        throw new ArgumentException("A Name is required to add a grade to a student.");
      var student = Students.FirstOrDefault(e => e.Name == name);
      if (student == null)
      {
        Console.WriteLine("Student {0} was not found, try again.", name);
        return;
      }
      student.AddGrade(score);
    }

    public void RemoveGrade(string name, double score)
    {
      if (string.IsNullOrEmpty(name))
        throw new ArgumentException("A Name is required to remove a grade from a student.");
      var student = Students.FirstOrDefault(e => e.Name == name);
      if (student == null)
      {
        Console.WriteLine("Student {0} was not found, try again.", name);
        return;
      }
      student.RemoveGrade(score);
    }

    public void ListStudents()
    {      
      Console.WriteLine();
      Console.WriteLine("Here is a list of all students in " + GradeBook.UserInterfaces.GradeBookUserInterface.GradeBook.Name + "'s Grade Book. ");
      Console.WriteLine();
      foreach (var student in Students)
      {
        Console.WriteLine("{0} : {1} : {2}", student.Name, student.Type, student.Enrollment);
      }
    }
    
    public static BaseGradeBook Load(string name)
    {
      if (!File.Exists(name + ".gdbk"))
      {
        Console.WriteLine("Gradebook could not be found.");
        return null;
      }

      using (var file = new FileStream(name + ".gdbk", FileMode.Open, FileAccess.Read))
      {
        using (var reader = new StreamReader(file))
        {
          var json = reader.ReadToEnd();
          return ConvertToGradeBook(json);
        }
      }
    }

    public static void ReadMDBGradeBook(string connectionString, string queryString)
    {      
      //using (OleDbConnection connection = new OleDbConnection(connectionString))
      //{
      //  OleDbCommand command = new OleDbCommand(queryString, connection);

      //  connection.Open();
      //  OleDbDataReader reader = command.ExecuteReader();

      //  while (reader.Read())
      //  {
      //    Console.WriteLine(reader[0].ToString());
      //  }
      //  reader.Close();
      //}
    }

    public static void LoadMDBGradeBook(string name)
    {
      DataTable dtGradeBook = new DataTable();
      
      // need a check to see if the named grade book exists

      // do need to return the loaded grade book
      
    }

    public void SaveMDBGradeBook()
    {

    }

    public void Save()
    {
      using (var file = new FileStream(Name + ".gdbk", FileMode.Create, FileAccess.Write))
      {
        using (var writer = new StreamWriter(file))
        {
          var json = JsonConvert.SerializeObject(this);
          writer.Write(json);
        }
      }
    }   

    public virtual double GetGPA(char letterGrade, StudentType studentType)
    {

      int GPA = 0;

      switch (letterGrade)
      {
        case 'A':
          GPA = 4;
          break;
        case 'B':
          GPA = 3;
          break;
        case 'C':
          GPA = 2;
          break;
        case 'D':
          GPA = 1;
          break;
        case 'F':
          GPA = 0;
          break;
      }

      if (IsWeighted == true && studentType != StudentType.Standard)
        GPA++;

      return GPA;
    }

    public virtual void CalculateStatistics()
    {
      var allStudentsPoints = 0d;
      var campusPoints = 0d;
      var statePoints = 0d;
      var nationalPoints = 0d;
      var internationalPoints = 0d;
      var standardPoints = 0d;
      var honorPoints = 0d;
      var dualEnrolledPoints = 0d;

      foreach (var student in Students)
      {
        student.LetterGrade = GetLetterGrade(student.AverageGrade);
        student.GPA = GetGPA(student.LetterGrade, student.Type);

        Console.WriteLine("{0} ({1}:{2}) GPA: {3}.", student.Name, student.LetterGrade, student.AverageGrade, student.GPA);
        allStudentsPoints += student.AverageGrade;

        switch (student.Enrollment)
        {
          case EnrollmentType.Campus:
            campusPoints += student.AverageGrade;
            break;
          case EnrollmentType.State:
            statePoints += student.AverageGrade;
            break;
          case EnrollmentType.National:
            nationalPoints += student.AverageGrade;
            break;
          case EnrollmentType.International:
            internationalPoints += student.AverageGrade;
            break;
        }

        switch (student.Type)
        {
          case StudentType.Standard:
            standardPoints += student.AverageGrade;
            break;
          case StudentType.Honors:
            honorPoints += student.AverageGrade;
            break;
          case StudentType.DualEnrolled:
            dualEnrolledPoints += student.AverageGrade;
            break;
        }
      }

      // #todo refactor into it's own method with calculations performed here
      Console.WriteLine("Average Grade of all students is " + (allStudentsPoints / Students.Count));
      if (campusPoints != 0)
        Console.WriteLine("Average for only local students is " + (campusPoints / Students.Where(e => e.Enrollment == EnrollmentType.Campus).Count()));
      if (statePoints != 0)
        Console.WriteLine("Average for only state students (excluding local) is " + (statePoints / Students.Where(e => e.Enrollment == EnrollmentType.State).Count()));
      if (nationalPoints != 0)
        Console.WriteLine("Average for only national students (excluding state and local) is " + (nationalPoints / Students.Where(e => e.Enrollment == EnrollmentType.National).Count()));
      if (internationalPoints != 0)
        Console.WriteLine("Average for only international students is " + (internationalPoints / Students.Where(e => e.Enrollment == EnrollmentType.International).Count()));
      if (standardPoints != 0)
        Console.WriteLine("Average for students excluding honors and dual enrollment is " + (standardPoints / Students.Where(e => e.Type == StudentType.Standard).Count()));
      if (honorPoints != 0)
        Console.WriteLine("Average for only honors students is " + (honorPoints / Students.Where(e => e.Type == StudentType.Honors).Count()));
      if (dualEnrolledPoints != 0)
        Console.WriteLine("Average for only dual enrolled students is " + (dualEnrolledPoints / Students.Where(e => e.Type == StudentType.DualEnrolled).Count()));
    }

    public virtual void CalculateStudentStatistics(string name)
    {
      var student = Students.FirstOrDefault(e => e.Name == name);
      student.LetterGrade = GetLetterGrade(student.AverageGrade);
      student.GPA = GetGPA(student.LetterGrade, student.Type);

      Console.WriteLine("{0} ({1}:{2}) GPA: {3}.", student.Name, student.LetterGrade, student.AverageGrade, student.GPA);
      Console.WriteLine();
      Console.WriteLine("Grades:");
      foreach (var grade in student.Grades)
      {
        Console.WriteLine(grade);
      }
    }

    public virtual char GetLetterGrade(double averageGrade)
    {
      if (averageGrade >= 90)
        return 'A';
      else if (averageGrade >= 80)
        return 'B';
      else if (averageGrade >= 70)
        return 'C';
      else if (averageGrade >= 60)
        return 'D';
      else
        return 'F';
    }

    /// <summary>
    ///     Converts json to the appropriate gradebook type.
    ///     Note: This method contains code that is not recommended practice.
    ///     This has been used as a compromise to avoid adding additional complexity to the learner.
    /// </summary>
    /// <returns>The to gradebook.</returns>
    /// <param name="json">Json.</param>
    public static dynamic ConvertToGradeBook(string json)
    {
      // Get GradeBookType from the GradeBook.Enums namespace
      var gradebookEnum = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                           from type in assembly.GetTypes()
                           where type.FullName == "GradeBook.Enums.GradeBookType"
                           select type).FirstOrDefault();

      var jobject = JsonConvert.DeserializeObject<JObject>(json);
      var gradeBookType = jobject.Property("Type")?.Value?.ToString();

      // Check if StandardGradeBook exists
      if ((from assembly in AppDomain.CurrentDomain.GetAssemblies()
           from type in assembly.GetTypes()
           where type.FullName == "GradeBook.GradeBooks.StandardGradeBook"
           select type).FirstOrDefault() == null)
        gradeBookType = "Base";
      else
      {
        if (string.IsNullOrEmpty(gradeBookType))
          gradeBookType = "Standard";
        else
          gradeBookType = Enum.GetName(gradebookEnum, int.Parse(gradeBookType));
      }

      // Get GradeBook from the GradeBook.GradeBooks namespace
      var gradebook = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                       from type in assembly.GetTypes()
                       where type.FullName == "GradeBook.GradeBooks." + gradeBookType + "GradeBook"
                       select type).FirstOrDefault();


      // Protection code
      if (gradebook == null)
        gradebook = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                     from type in assembly.GetTypes()
                     where type.FullName == "GradeBook.GradeBooks.StandardGradeBook"
                     select type).FirstOrDefault();

      return JsonConvert.DeserializeObject(json, gradebook);
    }
  }
}
