/*  
MAINTAINED BY JEFF Kranenburg
Uncomment LINE 6 - 15 to recreate the database
*/

USE Master;

DROP DATABASE IF EXISTS Rugby7db;
CREATE DATABASE Rugby7db;

DROP TABLE IF EXISTS "players";
DROP TABLE IF EXISTS "staff";
DROP TABLE IF EXISTS "game_shedule";
DROP TABLE IF EXISTS "pool_points";
DROP TABLE IF EXISTS "teams";

CREATE TABLE "teams" (
  "team_id" varchar NOT NULL,
  "pool" varchar NOT NULL,
  "name" varchar NOT NULL,
  PRIMARY KEY ("team_id")
)

CREATE TABLE "players" (
  "player_id" smallint NOT NULL IDENTITY(1,1),
  "name" varchar NOT NULL,
  PRIMARY KEY ("player_id"),
  "team_id" varchar FOREIGN KEY REFERENCES "teams"("team_id")
)

CREATE TABLE "staff" (
  "staff_id" smallint NOT NULL IDENTITY(1,1),
  "title" varchar NOT NULL,
  "name" varchar NOT NULL,
  PRIMARY KEY ("staff_id"),
  "team_id" varchar FOREIGN KEY REFERENCES "teams"("team_id")
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
  "team_id" varchar FOREIGN KEY REFERENCES "teams"("team_id"),
  "game_id" smallint NOT NULL, -- Should be a FK 
  "points" smallint NOT NULL,
  PRIMARY KEY ("team_id","game_id")
) 