Feature: Add Certification to Profile

Seller is able to add Certification to profile page

@tag1
Scenario Outline: 1. [Add Certification to Profile]
	Given I am on my Profile Page
	When [I add '<Certificate>' and '<CertifiedFrom>' and '<Year>' to Certification tab]
	Then [The Certification tab with '<Certificate>' should be created successfully.]

Examples: 
	| Certificate                                | CertifiedFrom      | Year |
	| Certified Tester Foundation Level (CTFL) | ISTQB            | 2014 |
	| Certified Test Analyst                   | Industry Connect | 2022 |
    
