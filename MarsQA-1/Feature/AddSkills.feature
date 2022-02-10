Feature: Add Skills to Profile

Seller is able to add skills to profile page


@tag1
Scenario Outline: [Add skills to Profile]
	Given [Navigate to Skills tab]
	When [I add '<Skill>' and '<SkillLevel>' to Skills tab]
	Then [The '<Skill>' and '<SkillLevel>' should be created successfully]

Examples: 
	| Skill          | SkillLevel   |
	| Java           | Beginner     |
	| Manual Testing | Intermediate |
	| C#             | Beginner     |
	| Automation     | Beginner     |
    