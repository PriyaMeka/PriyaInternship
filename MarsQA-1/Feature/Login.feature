Feature:Login
	As a seller I wanted to login to skillswap website

@mytag
Scenario Outline: [Login to website with valid credentials]
	Given [Login to the SkillSwap page using '<Email>' and '<Password>' successfully.]
	Examples: 
	| Email                    | Password     |
	| priyanka.mekha@gmail.com | Bollepalli88 |


	
  