Feature: Add languages to Profile

Seller is able to add languages to profile page

@tag1
Scenario Outline: [Add languages to Profile]
	Given [Navigate to Language tab]
	When [I add '<Language>' and '<LanguageLevel>' to Languages tab]
	Then [The '<Language>' and '<LanguageLevel>' should be created successfully.]

Examples: 
	| Language | LanguageLevel    |
	| English  | Fluent           |
	| Telugu   | Native/Bilingual |
    