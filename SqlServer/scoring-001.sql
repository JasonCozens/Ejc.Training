DECLARE @Answer1a INT = 1000
DECLARE @Answer1b INT = 2000
DECLARE @Answer2 INT = 2000
DECLARE @Answer3 INT = 2000
DECLARE @Answer4 INT = 2000
DECLARE @Answer5 INT = 2000

DECLARE @Actual1a INT = 951
DECLARE @Actual1b INT = 2187
DECLARE @Actual2 INT = 2000
DECLARE @Actual3 INT = 2000
DECLARE @Actual4 INT = 2000
DECLARE @Actual5 INT = 2000

DECLARE @Range1a INT = 100
DECLARE @Range1b INT = 100
DECLARE @Range2 INT = 100
DECLARE @Range3 INT = 100
DECLARE @Range4 INT = 100
DECLARE @Range5 INT = 100

DECLARE @MaxScore1a INT = 10
DECLARE @MaxScore1b INT = 10
DECLARE @MaxScore2 INT = 30
DECLARE @MaxScore3 INT = 25
DECLARE @MaxScore4 INT = 50
DECLARE @MaxScore5 INT = 60

IF OBJECT_ID('tempdb..#Scores') IS NOT NULL
    DROP TABLE #Scores

CREATE TABLE #Scores
(
	Question VARCHAR(32),
	Score INT
)

IF ABS(@Actual1a - @Answer1a) < @Range1a
	INSERT INTO #Scores 
	SELECT 'Question 1a' AS Question, ((@Range1a - ABS(@Actual1a - @Answer1a)) * @MaxScore1a) / @Range1a AS Score
ELSE
	INSERT INTO #Scores 
	SELECT 'Question 1a' AS Question, 0 AS Score 

IF ABS(@Actual1b - @Answer1b) < @Range1b
	INSERT INTO #Scores 
	SELECT 'Question 1b' AS Question, ((@Range1b - ABS(@Actual1b - @Answer1b)) * @MaxScore1b) / @Range1b AS Score
ELSE
	INSERT INTO #Scores 
	SELECT 'Question 1b' AS Question, 0 AS Score

IF ABS(@Actual2 - @Answer2) < @Range2
	INSERT INTO #Scores 
	SELECT 'Question 2' AS Question, ((@Range2 - ABS(@Actual2 - @Answer2)) * @MaxScore2) / @Range2 AS Score
ELSE
	INSERT INTO #Scores 
	SELECT 'Question 2' AS Question, 0 AS Score

IF ABS(@Actual3 - @Answer3) < @Range3
	INSERT INTO #Scores 
	SELECT 'Question 3' AS Question, ((@Range3 - ABS(@Actual3 - @Answer3)) * @MaxScore3) / @Range3 AS Score
ELSE
	INSERT INTO #Scores 
	SELECT 'Question 3' AS Question, 0 AS Score

IF ABS(@Actual4 - @Answer4) < @Range4
	INSERT INTO #Scores 
	SELECT 'Question 4' AS Question, ((@Range4 - ABS(@Actual4 - @Answer4)) * @MaxScore4) / @Range4 AS Score
ELSE
	INSERT INTO #Scores 
	SELECT 'Question 4' AS Question, 0 AS Score

IF ABS(@Actual5 - @Answer5) < @Range5
	INSERT INTO #Scores 
	SELECT 'Question 5' AS Question, ((@Range5 - ABS(@Actual5 - @Answer5)) * @MaxScore5) / @Range5 AS Score
ELSE
	INSERT INTO #Scores 
	SELECT 'Question 5' AS Question, 0 AS Score

SELECT * FROM #Scores

SELECT SUM(Score) AS Total FROM #Scores