Use Master 
 Go

 Drop Database if Exists Cleveland

Create Database Cleveland

Use Cleveland

Begin Transaction

CREATE TABLE employee (
employee_id int identity(1,1),
department_id integer NOT NULL,
first_name varchar(20) NOT NULL,
last_name varchar(30) NOT NULL,
job_title varchar(50) NOT NULL,
birth_date date NOT NULL,
gender char(1) NOT NULL,
hire_date date NOT NULL,
CONSTRAINT pk_employee_employee_id PRIMARY KEY (employee_id),
CONSTRAINT ck_gender CHECK (gender IN ('M', 'F'))
);

CREATE TABLE department (
department_id int identity(1,1),
name varchar(40) UNIQUE NOT NULL,
CONSTRAINT pk_department_department_id PRIMARY KEY (department_id)
);

CREATE TABLE project (
project_id int identity(1,1),
name varchar(40) UNIQUE NOT NULL,
from_date date not null,
to_date date not null,
CONSTRAINT pk_project_project_id PRIMARY KEY (project_id)
);

CREATE TABLE project_employee (
project_id integer NOT NULL,
employee_id integer NOT NULL,
CONSTRAINT pk_project_employee PRIMARY KEY (project_id, employee_id)
);

ALTER TABLE employee ADD CONSTRAINT fk_employee_department FOREIGN KEY (department_id) REFERENCES department(department_id);

ALTER TABLE project_employee ADD FOREIGN KEY (project_id) REFERENCES project(project_id);
ALTER TABLE project_employee ADD FOREIGN KEY (employee_id) REFERENCES employee(employee_id);


INSERT INTO department (name) VALUES ('Cleveland Browns');
INSERT INTO department (name) VALUES ('Cleveland Indians');
INSERT INTO department (name) VALUES ('Cleveland Cavs');


INSERT INTO project (name, from_date, to_date) VALUES ('Jersey Sales', '2006-09-25', '2016-03-27');
INSERT INTO project (name, from_date, to_date) VALUES ('Concession Sales', '2004-06-25', '2018-11-05');
INSERT INTO project (name, from_date, to_Date) VALUES ('Ticket Sales', '2012-09-29', '2017-05-05');
INSERT INTO project (name, from_date, to_date) VALUES ('Raffel Sales', '2014-04-14', '2019-09-26');

INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES (1, 'Sam', 'Vandevere', '1985-05-25', 'M', '2010-05-05', 'Marketing');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES (1, 'Neel', 'Gangoda', '1975-10-16', 'F', '2017-07-04', 'Rubdown');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES (2, 'Bob', 'Berger', '1967-07-10', 'M', '2004-03-01', 'Sales Management');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES (2, 'Alex', 'Bush', '1989-08-05', 'M', '2006-07-06', 'Timekeeoer');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES (2, 'Jon', 'Alder', '1990-01-26', 'M', '2013-12-07', 'Accounting');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES (3, 'Justin', 'Harris', '1988-12-28', 'M', '2007-11-07', 'Commercial');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES (3, 'Clark', 'Harris', '1978-07-17', 'F', '2016-07-04', 'IT Director');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES (3, 'Tyler', 'Gobio', '1994-05-12', 'M', '2004-07-08', 'CEO');


INSERT INTO project_employee (project_id, employee_id) VALUES (1, 3);
INSERT INTO project_employee (project_id, employee_id) VALUES (1, 4);
INSERT INTO project_employee (project_id, employee_id) VALUES (2, 1);
INSERT INTO project_employee (project_id, employee_id) VALUES (3, 5);
INSERT INTO project_employee (project_id, employee_id) VALUES (3, 7);
INSERT INTO project_employee (project_id, employee_id) VALUES (2, 2);
INSERT INTO project_employee (project_id, employee_id) VALUES (4, 6);
INSERT INTO project_employee (project_id, employee_id) VALUES (4, 8);

