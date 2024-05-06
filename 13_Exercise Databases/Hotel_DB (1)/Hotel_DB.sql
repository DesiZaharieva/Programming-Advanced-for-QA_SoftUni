CREATE DATABASE IF NOT EXISTS `hotel`; 
USE `hotel`;

CREATE TABLE departments (
	id INT PRIMARY KEY AUTO_INCREMENT,
	name VARCHAR(50)
);

INSERT INTO departments(name) VALUES('Front Office'), ('Support'), ('Kitchen'), ('Housekeeping');

CREATE TABLE employees (
	id INT PRIMARY KEY AUTO_INCREMENT,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	job_title VARCHAR(50) NOT NULL,
	department_id INT,
	salary DOUBLE NOT NULL,
    `hire_date` TIMESTAMP(6) NOT NULL,
	CONSTRAINT `fk_department_id` FOREIGN KEY (`department_id`) REFERENCES `departments` (`id`)
);

INSERT INTO `employees` (`first_name`,`last_name`, `job_title`,`department_id`,`salary`, `hire_date`)
VALUES
    ('John', 'Smith', 'Manager',1, 900.00, '2023-07-01 09:00:00'),
    ('John', 'Johnson', 'Customer Service',2, 880.00, '2022-08-02 10:30:00'),
    ('Smith', 'Johnson', 'Porter', 4, 1100.00, '2023-09-03 11:15:00'),
    ('Peter', 'Petrov', 'Front Desk Clerk', 1, 1100.00, '2021-10-04 14:00:00'),
    ('Peter', 'Ivanov', 'Sales', 2, 1500.23, '2022-11-05 15:45:00'),
    ('Ivan' ,'Petrov', 'Waiter', 3, 990.00, '2016-12-06 08:30:00'),
    ('Jack', 'Jackson', 'Executive Chef', 3, 1800.00, '2018-01-07 12:45:00'),
    ('Pedro', 'Petrov', 'Front Desk Supervisor', 1, 2100.00, '2017-02-08 17:00:00'),
    ('Anette', 'Fall', 'Maintenance', NULL, 1200.00, '2009-03-09 09:30:00'),
    ('Philip', 'Barov', 'Technician', NULL, 2100.00, '2002-04-10 10:00:00'),
    ('Nikolay', 'Ivanov', 'Housekeeping', 4, 1600.00, '2012-05-11 11:30:00');
			
CREATE TABLE rooms (
	id INT PRIMARY KEY AUTO_INCREMENT,
	`type` VARCHAR(30)
);

INSERT INTO rooms(`type`) VALUES('apartment'), ('single room');

CREATE TABLE clients (
	id INT PRIMARY KEY AUTO_INCREMENT,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	room_id INT NOT NULL,
    CONSTRAINT fk_clients_rooms
    FOREIGN KEY (room_id)
    REFERENCES rooms(id)
);

INSERT INTO clients(`first_name`,`last_name`,`room_id`) 
VALUES('Pesho','Petrov', 1),('Gosho','Georgiev', 2),
('Mariya','Marieva', 2), ('Katya','Katerinova', 1), ('Nikolay','Nikolaev', 2);
