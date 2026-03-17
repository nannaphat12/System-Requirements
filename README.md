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


## คุณสมบัติของระบบ

- เพิ่มรายวิชา
- เพิ่มนักศึกษา
- คำนวณเกรดอัตโนมัติ
- แสดง:
  - รายชื่อนักศึกษา
  - คะแนนสูงสุด / ต่ำสุด
  - ค่าเฉลี่ย

## OOP ที่ใช้

### 1. Encapsulation
- ใช้ private variables
- ใช้ method ในการเข้าถึงข้อมูล

### 2. Inheritance
- Student สืบทอดจาก Person

### 3. Polymorphism
- Override method GetGrade() ใน SpecialStudent

### 4. Abstraction
- ใช้ abstract class Person

## วิธีรันโปรแกรม

1. เปิด Visual Studio
2. สร้าง Console App
3. วางโค้ด
4. Run

## ผู้พัฒนา
นางสาวนันท์นภัส วุฒิวรรณ
