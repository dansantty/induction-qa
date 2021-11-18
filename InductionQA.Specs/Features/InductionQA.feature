Feature: Induction QA Automation

@mytag
Scenario Outline: Buying ticket air for London
	Given i want go to London
	And be a day of <day>
	And <vip> vip customer <initialValue>
	When i do the payment
	Then i will pay <finalValue>

	Examples:
		| day | vip      | finalValue | initialValue |
		| 0   | i am     | 80         | 100          |
		| 0   | i am not | 100        | 100          |
		| 1   | i am     | 16         | 20           |
		| 1   | i am not | 20         | 20           |
		| 2   | i am     | 16         | 20           |
		| 2   | i am not | 20         | 20           |
		| 3   | i am     | 16         | 20           |
		| 3   | i am not | 20         | 20           |
		| 4   | i am     | 40         | 50           |
		| 4   | i am not | 50         | 50           |
		| 5   | i am     | 40         | 50           |
		| 5   | i am not | 50         | 50           |
		| 6   | i am     | 80         | 100          |
		| 6   | i am not | 100        | 100          |