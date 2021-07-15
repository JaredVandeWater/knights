CREATE TABLE IF NOT EXISTS knights(
  id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'create time',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'update time',
  name varchar(255) COMMENT 'Knights Name',
  weapon varchar(255) COMMENT 'Knights Weapon'
) default charset utf8 comment '';
CREATE TABLE IF NOT EXISTS quests(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'create time',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'update time',
  questTitle varchar(255) COMMENT 'Quest Title',
  questReward varchar(255) COMMENT 'Quest Reward',
  knightId int NOT NULL COMMENT 'FK: Knight',
  FOREIGN KEY (knightId) REFERENCES knights(id) ON DELETE CASCADE
) default charset utf8 COMMENT '';