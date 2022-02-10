Feature: Add Education to Profile

Seller is able to add Education to profile page

@tag1
Scenario Outline: [Add Education to Profile]
	Given [Navigate to Education tab]
	When [I add '<Name>' and '<Country>' and '<Title>' and '<Degree>' and '<Year>' to Education tab]
	Then [The '<Name>' and '<Country>' and '<Title>' and '<Degree>' and '<Year>' should be created successfully.]

Examples: 
	| Name | Country | Title  | Degree                 | Year |
	| JNTU | India   | M.Tech | Software Engineering   | 2013 |
	| JNTU | India   | B.Tech | Information Technology | 2011 |
    