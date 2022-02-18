Feature: Add,Update and Delete languages to Profile

Seller is able to add,update and delete languages to profile page

@tag1
Scenario Outline: 1 [Add languages to Profile]
	Given [Navigate to Language tab]
	When [I add '<Language>' and '<LanguageLevel>' to Languages tab]
	Then [The Record should be created successfully.]

Examples: 
	| Language | LanguageLevel    |
	| Hindi    | Basic            |
	| Telugu   | Native/Bilingual |
	| English  | Fluent           |

Scenario Outline: 2.Reading the record created for Language
Given : I am on my Profile Page
Then : '<count>' Records must have been created successfully.
Examples: 
| count |
| 3     |
    
Scenario Outline: 3  [update language in Language tab]
	Given [Click on Edit Button near '<Language>']
	When [I update '<Language1>' and '<LanguageLevel1>' in Languages tab]
	Then [The '<Language1>' and '<LanguageLevel1>' should be updated successfully.]

Examples: 
	| Language | Language1 | LanguageLevel1   |
	| Hindi    | Sanskrit  | Native/Bilingual |

Scenario Outline: 4.Reading the language that has been edited
Given : I am on my Profile Page
Then : the record is updated with new details '<Language1>' ,'<LanguageLevel1>'.
Examples: 
| Language1 | LanguageLevel1   |
| Sanskrit  | Native/Bilingual |

Scenario: 5 [delete language in Language tab]
	Given [Navigate to the Languages tab.]
	When  [I delete a '<Language1>' in Languages tab]
    Then [The '<Language1>' should be deleted successfully]
Examples: 
| Language1 |
| Sanskrit  |
