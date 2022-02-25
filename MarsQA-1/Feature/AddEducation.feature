Feature: Add Education to Profile

Seller is able to add Education to profile page

@tag1
Scenario Outline:1 [Add Education to Profile]
	Given I am on my Profile page
	When [I add '<Country>' and '<University>' and '<Title>' and '<Degree>' and '<Year>' to Education tab]
	Then [The Education Record with '<Degree>' should be created successfully]

Examples: 
	| Country | University   | Title  | Degree                   | Year |
	| India   | JNTU       | M.Tech | Software Engineering   | 2013 |
	| India   | JNTU       | B.Tech | Information Technology | 2011 |
 
