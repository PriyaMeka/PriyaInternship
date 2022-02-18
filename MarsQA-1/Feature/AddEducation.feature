Feature: Add Education to Profile

Seller is able to add Education to profile page

@tag1
Scenario Outline: [Add Education to Profile]
	Given I am on my Profile page
	When [I add '<Country>' and '<University>' and '<Title>' and '<Degree>' and '<Year>' to Education tab]
	Then [The Education Record with '<Degree>' should be created successfully]

Examples: 
	| Country | University   | Title  | Degree                   | Year |
	| India   | JNTU       | M.Tech | Software Engineering   | 2013 |
	| India   | JNTU       | B.Tech | Information Technology | 2011 |
 
Scenario Outline: 2.Reading the record created for Education tab
Given  I am on my Profile Page
Then : '<count>' Records must have been created successfully for education tab.
Examples: 
| count |
| 2     |   