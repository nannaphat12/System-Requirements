##Class Diagram

```mermaid
classDiagram

class Person {
  <<abstract>>
  -string name
  +Person(name)
  +GetName() string
  +Display() void
}

class Student {
  -string studentId
  -double score
  +Student(name, id, score)
  +GetStudentId() string
  +GetScore() double
  +GetGrade() string
  +Display() void
}

class SpecialStudent {
  +GetGrade() string
}

class Course {
  -string courseName
  -string courseId
  -List~Student~ students
  +Course(name, id)
  +AddStudent(Student)
  +ShowAllStudents()
  +ShowMaxMinScore()
  +ShowAverage()
}

Person <|-- Student
Student <|-- SpecialStudent
Course "1" --> "*" Student
