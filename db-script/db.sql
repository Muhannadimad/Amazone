
CREATE TABLE user (
 id INT NOT NULL AUTO_INCREMENT UNIQUE,
  first name VARCHAR(30) NOT NULL , 
 last name VARCHAR(30) NOT NULL ,  
password VARCHAR(20) NOT NULL , 
 email VARCHAR(20) NOT NULL , 
 address VARCHAR(50) NOT NULL ,
  phone VARCHAR(20) NOT NULL , 
   PRIMARY KEY  (id)
) 

CREATE TABLE product ( 
p_id INT NOT NULL AUTO_INCREMENT UNIQUE, 
 p_price INT NOT NULL ,
  p_quantity INT NOT NULL ,
  p_description MEDIUMTEXT NOT NULL ,
  p_image VARCHAR(50) ,
    PRIMARY KEY  (p_id)
)

CREATE TABLE order (
 o_id INT NOT NULL AUTO_INCREMENT UNIQUE,
  id INT NOT NULL , 
 p_id INT NOT NULL ,
  quantity INT NOT NULL ,
    PRIMARY KEY  (o_id) ,
FOREIGN KEY (id) REFERENCES Persons(id),
FOREIGN KEY (p_id) REFERENCES Persons(p_id)
) 