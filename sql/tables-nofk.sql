/*  
MAINTAINED BY JEFF Kranenburg
Uncomment LINE 6 - 15 to recreate the database
*/

USE Master
Go

If EXISTS(select * from sys.databases where name = 'Rugby7db')
DROP DATABASE Rugby7db

CREATE DATABASE Rugby7db
Go

USE Rugby7db

DROP TABLE IF EXISTS "players";
DROP TABLE IF EXISTS "staff";
DROP TABLE IF EXISTS "game_shedule";
DROP TABLE IF EXISTS "pool_points";
DROP TABLE IF EXISTS "teams";

CREATE TABLE "teams" (
  "team_id" varchar(4) NOT NULL,
  "pool" varchar(10) NOT NULL,
  "name" varchar(255) NOT NULL,
  PRIMARY KEY ("team_id")
)

CREATE TABLE "players" (
  "player_id" smallint NOT NULL IDENTITY(1,1),
  "name" varchar(255) NOT NULL,
  PRIMARY KEY ("player_id"),
  "team_id" varchar(4) NOT NULL
)

CREATE TABLE "staff" (
  "staff_id" smallint NOT NULL IDENTITY(1,1),
  "title" varchar(255) NOT NULL,
  "name" varchar(255) NOT NULL,
  PRIMARY KEY ("staff_id"),
  "team_id" varchar(4) NOT NULL
)

CREATE TABLE "game_shedule" (
  "game_id" smallint NOT NULL,
  "field_number" smallint NOT NULL,
  "time" varchar(7) NOT NULL,
  "team_a" varchar(4) NOT NULL,
  "team_b" varchar(4) NOT NULL,
  "team_a_score" smallint DEFAULT NULL,
  "team_b_score" smallint DEFAULT NULL,
  PRIMARY KEY ("game_id","team_a","team_b"),
)

CREATE TABLE "pool_points" (
  "ppid" int NOT NULL IDENTITY(1,1),
  "team_id" varchar(4) NOT NULL,
  "game_id" smallint NOT NULL, -- Should be a FK 
  "points" smallint NOT NULL,
  -- PRIMARY KEY ("team_id","game_id")
  PRIMARY KEY ("ppid")
) 

SELECT * FROM Rugby7db.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'
Go