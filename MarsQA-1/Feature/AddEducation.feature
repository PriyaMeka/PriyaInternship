Feature: Add Education to Profile

Seller is able to add Education to profile page

@tag1
Scenario Outline: [Add Education to Profile]
	Given [Navigate to Education tab]
	When [I add '<Country>' and '<University>' and '<Title>' and '<Degree>' and '<Year>' to Education tab]
	Then [The '<Country>' and '<University>' and '<Title>' and '<Degree>' and '<Year>' should be created successfully.]

Examples: 
	| Country | University| Title  | Degree                 | Year |
	| India   | JNTU      | M.Tech | Software Engineering   | 2013 |
	
    