Feature: Add,Edit and Delete Skills from Profile page

Seller is able to add,update and delete skills from profile page


@tag1
Scenario Outline: 1 [Add skills to Profile]
	Given [Navigate to Skills tab]
	When [I add '<Skill>' and '<SkillLevel>' to Skills tab]
	Then [The '<Skill>' Record should be added successfully]

Examples: 
	| Skill          | SkillLevel   |
	| Java           | Beginner     |
	| Manual Testing | Intermediate |
	| C#             | Beginner     |
	| Automation     | Beginner     |
   

@tag1
Scenario: 2.[update skills in Profile page]
	Given [Click on Edit Button near '<Skill>'.]
	When [I update '<Skill1>' and '<SkillLevel1>' to Skills tab]
	Then [The '<Skill1>' and '<SkillLevel1>' should be updated successfully]

	Examples: 
| Skill  | Skill1   | SkillLevel1  |
|  C#    | SpecFlow | Intermediate |


Scenario: 3. [delete skills in Profile page]
	Given [Navigate to the Skills tab.]
	When  [I delete '<Skill1>' in Skills tab]
    Then [The '<Skill1>' should be deleted successfully.]
 Examples: 
| Skill1   |
| SpecFlow |
	
