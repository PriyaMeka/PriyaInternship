Feature: Add,Update and Delete languages to Profile

Seller is able to add,update and delete languages to profile page

@tag1
Scenario Outline: 1 [Add languages to Profile]
	Given [Navigate to Language tab]
	When [I add '<Language>' and '<LanguageLevel>' to Languages tab]
	Then [The '<Language>' should be created successfully.]

Examples: 
	| Language | LanguageLevel    |
	| Hindi    | Basic            |
	| Telugu   | Native/Bilingual |
	| English  | Fluent           |

    
Scenario Outline: 2  [update language in Language tab]
	Given [Click on Edit Button near '<Language>']
	When [I update '<Language1>' and '<LanguageLevel1>' in Languages tab]
	Then [The '<Language1>' and '<LanguageLevel1>' should be updated successfully.]

Examples: 
	| Language | Language1 | LanguageLevel1   |
	| Hindi    | Sanskrit  | Native/Bilingual |

Scenario: 3 [delete language in Language tab]
	Given [Navigate to the Languages tab.]
	When  [I delete a '<Language1>' in Languages tab]
    Then [The '<Language1>' should be deleted successfully]
Examples: 
| Language1 |
| Sanskrit  |
