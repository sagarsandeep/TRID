Feature: CardsValidation


Scenario Outline: Validating cards value on Closing Disclosure page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <RowNumber>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aRowNumber>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <RowNumber>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is Other1 Escrowed
	And user selects value for Is Other2 Escrowed
	And user enters input values for Cushion Months
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow Other1 Calculations Inputs
	And user enters values for Escrow Other2 Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Closing Disclosure Cards Page
Then updated/computed Principal and Interest value should display on Closing Disclosure
	And updated/computed Mortgage Insurance value should display on Closing Disclosure
	And updated/computed Scheduled PMI Termination Date value should display on Closing Disclosure
	And updated/computed Estimated Total Monthly Payment value should display on Closing Disclosure
	And updated/computed Prepaid Charges value should display on Closing Disclosure
	And updated/computed Amount Financed value should display on Closing Disclosure
	#And updated/computed Escrow Property Costs over one year 11 Months value should display on Closing Disclosure
	#And updated/computed Escrow Property Costs over one year 12 Months value should display on Closing Disclosure
	And updated/computed APR value should display on Closing Disclosure
	And updated/computed Balloon Amount value should display on Closing Disclosure
	And updated/computed Total of Payments value should display on Closing Disclosure
	And updated/computed Finance Charge value should display on Closing Disclosure
	And updated/computed TIP value should display on Closing Disclosure
	#And updated/computed Initial Escrow Payment value should display on Closing Disclosure
	#And updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	#And updated/computed Estimated Escrow value should display on Closing Disclosure
	#And updated/computed Estimated Taxes, Insurance & Assessments value should display on Closing Disclosure
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName |
	| 1R         | 2         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 2R         | 3         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 3R         | 4         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 4R         | 5         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 6R         | 6         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 7R         | 7         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 8R         | 8         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 9R         | 9         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 11R        | 10        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 12R        | 11        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 13R        | 12        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 14R        | 13        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 16R        | 14        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 17R        | 15        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 19R        | 16        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 36R        | 17        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARM Terms  |
	| 37R        | 18        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARM Terms  |
	| 38R        | 19        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARM Terms  |
	| 38.1R      | 20        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARM Terms  |
	| 39R        | 21        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 40R        | 22        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 41R        | 23        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 42R        | 24        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 43R        | 25        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 50         | 28        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 51         | 29        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 52         | 30        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 53         | 31        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 54         | 32        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 55         | 33        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 56         | 34        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 57         | 35        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 70         | 46        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 71         | 47        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 72         | 48        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 73         | 49        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 74         | 50        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 75         | 51        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 76         | 52        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 77         | 53        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 90         | 64        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 91         | 65        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 92         | 66        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 93         | 67        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 94         | 68        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 95         | 69        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 96         | 70        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 97         | 71        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 110        | 82        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 111        | 83        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 112        | 84        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 113        | 85        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 114        | 86        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 115        | 87        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 116        | 88        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 117        | 89        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |



Scenario Outline: Validating cards value on Loan Estimate page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <RowNumber>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aRowNumber>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <RowNumber>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And Enter Loan detail input values for computation 
    And user navigate to Amortization Page
    And user navigate to Loan Inputs Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is Other1 Escrowed
	And user selects value for Is Other2 Escrowed
	And user enters input values for Cushion Months
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow Other1 Calculations Inputs
	And user enters values for Escrow Other2 Calculations Inputs
	And user enters all input values for Prepaid Charges
	#And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	And user navigates to Loan Estimate Cards Page
Then updated/computed in 5 Years value should display on Loan Estimate
	And updated/computed in 5 Years principal value should display on Loan Estimate
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName |
	| 1R         | 2         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 2R         | 3         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 3R         | 4         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 4R         | 5         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 6R         | 6         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 7R         | 7         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 8R         | 8         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 9R         | 9         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 11R        | 10        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 12R        | 11        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 13R        | 12        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 14R        | 13        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 16R        | 14        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 17R        | 15        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 19R        | 16        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 36R        | 17        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARM Terms  |
	| 37R        | 18        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARM Terms  |
	| 38R        | 19        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARM Terms  |
	| 38.1R      | 20        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARM Terms  |
	| 39R        | 21        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 40R        | 22        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 41R        | 23        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 42R        | 24        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 43R        | 25        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 50         | 28        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 51         | 29        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 52         | 30        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 53         | 31        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 54         | 32        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 55         | 33        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 56         | 34        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 57         | 35        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 70         | 46        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 71         | 47        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 72         | 48        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 73         | 49        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 74         | 50        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 75         | 51        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 76         | 52        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 77         | 53        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 90         | 64        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 91         | 65        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 92         | 66        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 93         | 67        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 94         | 68        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 95         | 69        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 96         | 70        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 97         | 71        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 110        | 82        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 111        | 83        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 112        | 84        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 113        | 85        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 114        | 86        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 115        | 87        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 116        | 88        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 117        | 89        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |