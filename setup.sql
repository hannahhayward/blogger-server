DROP  Table ;
CREATE TABLE Profile(  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    name VARCHAR(255) COMMENT 'what is your name',
    email VARCHAR(255) COMMENT 'what is your email',
    picture VARCHAR(255) COMMENT 'what is your picture'
) default charset utf8 comment '';
CREATE TABLE Blogs(  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    title VARCHAR(255) COMMENT 'what is your name',
    body VARCHAR(255) COMMENT 'what is your email',
    creator VARCHAR(255) COMMENT 'what is your creator',
    createdAt DATETIME  DEFAULT CURRENT_TIMESTAMP COMMENT 'created at',
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'updated at',
    creatorId int NOT NULL COMMENT 'FK: Profile',
    FOREIGN KEY (creatorId) REFERENCES Profile(id) ON DELETE CASCADE 
) default charset utf8 comment '';

CREATE TABLE Comments(  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    body VARCHAR(255) COMMENT 'what is your email',
    creator VARCHAR(255) COMMENT 'what is your picture',
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'created at',
    creatorId int NOT NULL COMMENT 'FK: Profile',
    blogId int NOT NULL COMMENT 'FK: Blog',
    FOREIGN KEY (blogId) REFERENCES Blogs(id) ON DELETE CASCADE, 
    FOREIGN KEY (creatorId) REFERENCES Profile(id) ON DELETE CASCADE 
) default charset utf8 comment '';
INSERT INTO 
Profile(name, email, id, picture)
VALUES ('test2', 'testtesttest2', 2, 'test2');
INSERT INTO 
Blogs(title, body, id, creatorId, creator)
VALUES ('test blog', 'this is a test blog', 1, 1, 'test');

INSERT INTO 
Comments(body, creator, creatorId, blogId)
VALUES ('test comment', 'test2', 2, 1);
