CREATE SCHEMA school;

CREATE TABLE school.students (
    student_id INTEGER PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email VARCHAR(100) UNIQUE,
    city VARCHAR(50),
    joined_date DATE
);

CREATE TABLE school.courses (
    course_id INTEGER PRIMARY KEY,
    course_name VARCHAR(100) NOT NULL,
    instructor VARCHAR(100),
    fee DECIMAL(10,2)
);

CREATE TABLE school.enrollments (
    enrollment_id INTEGER PRIMARY KEY,
    student_id INTEGER,
    course_id INTEGER,
    enrollment_date DATE,
    grade INTEGER,

    FOREIGN KEY (student_id)
        REFERENCES school.students(student_id),

    FOREIGN KEY (course_id)
        REFERENCES school.courses(course_id)
);

INSERT INTO school.students
(student_id, first_name, last_name, email, city, joined_date)
VALUES
(1, 'Paul', 'Casey', 'paul.casey.1@gslingacademy.com', 'Dallas', '2026-01-10'),
(2, 'Danielle', 'Sandoval', 'danielle.sandoval.2@gslingacademy.com', 'Austin', '2026-01-15'),
(3, 'Tina', 'Andrews', 'tina.andrews.3@gslingacademy.com', 'Seattle', '2026-02-01'),
(4, 'Tara', 'Clark', 'tara.clark.4@gslingacademy.com', 'Boston', '2026-02-12'),
(5, 'Anthony', 'Campos', 'anthony.campos.5@gslingacademy.com', 'Chicago', '2026-03-05');

INSERT INTO school.courses
(course_id, course_name, instructor, fee)
VALUES
(101, 'Mathematics', 'Neha Kapoor', 550.00),
(102, 'History', 'Vikram Shah', 475.00),
(103, 'Physics', 'Ananya Iyer', 650.00),
(104, 'Chemistry', 'Rahul Menon', 700.00);

INSERT INTO school.enrollments
(enrollment_id, student_id, course_id, enrollment_date, grade)
VALUES
(1001, 1, 101, '2026-04-01', 73),
(1002, 1, 103, '2026-04-02', 93),
(1003, 2, 101, '2026-04-03', 90),
(1004, 2, 104, '2026-04-04', 100),
(1005, 3, 102, '2026-04-05', 97),
(1006, 3, 103, '2026-04-06', 95),
(1007, 4, 102, '2026-04-07', 74),
(1008, 4, 104, '2026-04-08', 80);


SELECT
    student_id,
    COUNT(course_id) AS course_count
FROM school.enrollments
GROUP BY student_id
HAVING COUNT(course_id) > 1;


SELECT *
FROM school.students
WHERE student_id NOT IN (
    SELECT student_id
    FROM school.enrollments
);


INSERT INTO school.students
(student_id, first_name, last_name, email, city, joined_date)
VALUES
(6, 'Kelly', 'Wade', 'kelly.wade.6@gslingacademy.com', 'Denver', '2026-03-20');


UPDATE school.students
SET city = 'Houston'
WHERE student_id = 1;


UPDATE school.courses
SET fee = 575.00
WHERE course_id = 101;


DELETE FROM school.enrollments
WHERE enrollment_id = 1008;


SELECT *
FROM school.students
ORDER BY student_id;



SELECT *
FROM school.students;

SELECT first_name, last_name, email
FROM school.students;


SELECT *
FROM school.students
WHERE city = 'Houston';

SELECT *
FROM school.courses
WHERE fee > 500;


SELECT *
FROM school.courses
ORDER BY fee DESC;

SELECT AVG(fee) AS average_fee
FROM school.courses;

SELECT
    MIN(fee) AS minimum_fee,
    MAX(fee) AS maximum_fee
FROM school.courses;

SELECT COUNT(*) AS total_students
FROM school.students;

SELECT
    course_id,
    COUNT(student_id) AS student_count
FROM school.enrollments
GROUP BY course_id;




SELECT
    s.first_name, s.last_name, c.course_name, c.instructor, e.grade    
FROM school.students s, school.enrollments e, school.courses c   
WHERE s.student_id = e.student_id
AND e.course_id = c.course_id;


SELECT
    s.first_name,
    s.last_name,
    e.grade
FROM school.students s,
     school.enrollments e
WHERE s.student_id = e.student_id
AND e.grade = (
    SELECT MAX(grade)
    FROM school.enrollments
);


SELECT
    c.course_name,
    AVG(e.grade) AS average_grade
FROM school.courses c,
     school.enrollments e
WHERE c.course_id = e.course_id
GROUP BY c.course_name;



SELECT
    s.student_id,
    s.first_name,
    s.last_name,
    COUNT(e.course_id) AS course_count
FROM school.students s,
     school.enrollments e
WHERE s.student_id = e.student_id
GROUP BY
    s.student_id,
    s.first_name,
    s.last_name
HAVING COUNT(e.course_id) > 1;

SELECT *
FROM school.students
WHERE student_id NOT IN (
    SELECT student_id
    FROM school.enrollments
);

SELECT *
FROM school.courses
WHERE fee = (
    SELECT MAX(fee)
    FROM school.courses
);



