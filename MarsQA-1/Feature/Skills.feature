Feature: Add,Edit and Delete Skills from Profile page

Seller is able to add,update and delete skills from profile page


@tag1
Scenario Outline: 1 [Add skills to Profile]
	Given [Navigate to Skills tab]
	When [I add '<Skill>' and '<SkillLevel>' to Skills tab]
	Then [The Skill Record should be created successfully]

Examples: 
	| Skill          | SkillLevel   |
	| Java           | Beginner     |
	| Manual Testing | Intermediate |
	| C#             | Beginner     |
	| Automation     | Beginner     |
   
Scenario Outline: 2.Reading the records created for Skills Tab
Given : I am on my Profile Page.
Then : '<count>' Records must have been created successfully in Skills tab.
Examples: 
| count |
| 4     |

@tag1
Scenario: 3.[update skills in Profile page]
	Given [Click on Edit Button near '<Skill>'.]
	When [I update '<Skill1>' and '<SkillLevel1>' to Skills tab]
	Then [The '<Skill1>' and '<SkillLevel1>' should be updated successfully]

	Examples: 
| Skill  | Skill1   | SkillLevel1  |
|  C#    | SpecFlow | Intermediate |

Scenario Outline: 4. Reading the skill that has been edited
  Given  [Navigate to the Skills tab.]
  Then  Then the record is updated with new details '<Skill1>' and '<SkillLevel1>'. 
 Examples: 
| Skill1   | SkillLevel1  |
| SpecFlow | Intermediate |

Scenario: 5. [delete skills in Profile page]
	Given [Navigate to the Skills tab.]
	When  [I delete '<Skill1>' in Skills tab]
    Then [The '<Skill1>' should be deleted successfully.]
 Examples: 
| Skill1   |
| SpecFlow |
	
