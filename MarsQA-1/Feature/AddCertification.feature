Feature: Add Certification to Profile

Seller is able to add Certification to profile page

@tag1
Scenario Outline: [Add Certification to Profile]
	Given [Navigate to Certification tab]
	When [I add '<Certificate>' and '<CertifiedFrom>' and '<Year>' to Certification tab]
	Then [The '<Certificate>' and '<CertifiedFrom>' and '<Year>' should be created successfully.]

Examples: 
	| Certificate                              | CertifiedFrom    | Year |
	| Certified Tester Foundation Level (CTFL) | ISTQB            | 2014 |
	| Certified Test Analyst                   | Industry Connect | 2022 |
    