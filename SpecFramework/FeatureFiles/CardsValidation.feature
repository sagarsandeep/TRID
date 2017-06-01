Feature: CardsValidation


Scenario Outline: Validating cards value on Closing Disclosure page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <RowNumber>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aRowNumber>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <RowNumber>
	And user have Export data from excel sheet <eSheetName> for the scenario <RowNumber>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And user enters Loan detail input values for computation 
	And user enters pmi rate values
	And user enters other pmi input values
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is Other1 Escrowed
	And user selects value for Is Other2 Escrowed
	And user enters input values for Cushion Months
	And user enters input value for Date Of First Monthly PMI Disbursement
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
	And user navigates to Export Page
	And user enters all input values for Export Page
	And user clicks on Export button to generate JSON file
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
	And APRWIN info value should display on Closing Disclosure
	And updated/computed Balloon Amount value should display on Closing Disclosure
	And updated/computed Total of Payments value should display on Closing Disclosure
	And updated/computed Finance Charge value should display on Closing Disclosure
	And updated/computed TIP value should display on Closing Disclosure
	#And updated/computed Initial Escrow Payment value should display on Closing Disclosure
	#And updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	#And updated/computed Estimated Escrow value should display on Closing Disclosure
	#And updated/computed Estimated Taxes, Insurance & Assessments value should display on Closing Disclosure
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName | eSheetName |
	| 1R         | 2         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 2R         | 3         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 3R         | 4         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 4R         | 5         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 6R         | 6         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 7R         | 7         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 8R         | 8         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 9R         | 9         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 11R        | 10        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 12R        | 11        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 13R        | 12        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 14R        | 13        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 16R        | 14        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 17R        | 15        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 19R        | 16        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 36R        | 17        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARM Terms  | Export     |
	| 37R        | 18        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARM Terms  | Export     |
	| 38R        | 19        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARM Terms  | Export     |
	| 38.1R      | 20        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARM Terms  | Export     |
	| 39R        | 21        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 40R        | 22        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 41R        | 23        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 42R        | 24        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 43R        | 25        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 50         | 28        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 51         | 29        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 52         | 30        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 53         | 31        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 54         | 32        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 55         | 33        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 56         | 34        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 57         | 35        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 70         | 46        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 71         | 47        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 72         | 48        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 73         | 49        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 74         | 50        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 75         | 51        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 76         | 52        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 77         | 53        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 90         | 64        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 91         | 65        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 92         | 66        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 93         | 67        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 94         | 68        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 95         | 69        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 96         | 70        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 97         | 71        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 110        | 82        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 111        | 83        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 112        | 84        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 113        | 85        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 114        | 86        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 115        | 87        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 116        | 88        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 117        | 89        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |



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
    And user enters Loan detail input values for computation 
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
	#And user navigates to Export Page
	#And user enters all input values for Export Page
	#And user clicks on Export button to generate JSON file
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




Scenario Outline: Uploading JSON file and Validating cards value on Closing Disclosure page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
When user upload json file for the scenario
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
	And APRWIN info value should display on Closing Disclosure
	And updated/computed Balloon Amount value should display on Closing Disclosure
	And updated/computed Total of Payments value should display on Closing Disclosure
	And updated/computed Finance Charge value should display on Closing Disclosure
	And updated/computed TIP value should display on Closing Disclosure
	#And updated/computed Initial Escrow Payment value should display on Closing Disclosure
	#And updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	#And updated/computed Estimated Escrow value should display on Closing Disclosure
	#And updated/computed Estimated Taxes, Insurance & Assessments value should display on Closing Disclosure
Examples:
	| ScenarioNo | RowNumber | cdSheetName       |
	| 1R         | 2         | ClosingDisclosure |
	| 2R         | 3         | ClosingDisclosure |
	| 3R         | 4         | ClosingDisclosure |
	| 4R         | 5         | ClosingDisclosure |
	| 6R         | 6         | ClosingDisclosure |
	| 7R         | 7         | ClosingDisclosure |
	| 8R         | 8         | ClosingDisclosure |
	| 9R         | 9         | ClosingDisclosure |
	| 11R        | 10        | ClosingDisclosure |
	| 12R        | 11        | ClosingDisclosure |
	| 13R        | 12        | ClosingDisclosure |
	| 14R        | 13        | ClosingDisclosure |
	| 16R        | 14        | ClosingDisclosure |
	| 17R        | 15        | ClosingDisclosure |
	| 19R        | 16        | ClosingDisclosure |
	| 36R        | 17        | ClosingDisclosure |
	| 37R        | 18        | ClosingDisclosure |
	| 38R        | 19        | ClosingDisclosure |
	| 38.1R      | 20        | ClosingDisclosure |
	| 39R        | 21        | ClosingDisclosure |
	| 40R        | 22        | ClosingDisclosure |
	| 41R        | 23        | ClosingDisclosure |
	| 42R        | 24        | ClosingDisclosure |
	| 43R        | 25        | ClosingDisclosure |
	| 50         | 28        | ClosingDisclosure |
	| 51         | 29        | ClosingDisclosure |
	| 52         | 30        | ClosingDisclosure |
	| 53         | 31        | ClosingDisclosure |
	| 54         | 32        | ClosingDisclosure |
	| 55         | 33        | ClosingDisclosure |
	| 56         | 34        | ClosingDisclosure |
	| 57         | 35        | ClosingDisclosure |
	| 70         | 46        | ClosingDisclosure |
	| 71         | 47        | ClosingDisclosure |
	| 72         | 48        | ClosingDisclosure |
	| 73         | 49        | ClosingDisclosure |
	| 74         | 50        | ClosingDisclosure |
	| 75         | 51        | ClosingDisclosure |
	| 76         | 52        | ClosingDisclosure |
	| 77         | 53        | ClosingDisclosure |
	| 90         | 64        | ClosingDisclosure |
	| 91         | 65        | ClosingDisclosure |
	| 92         | 66        | ClosingDisclosure |
	| 93         | 67        | ClosingDisclosure |
	| 94         | 68        | ClosingDisclosure |
	| 95         | 69        | ClosingDisclosure |
	| 96         | 70        | ClosingDisclosure |
	| 97         | 71        | ClosingDisclosure |
	| 110        | 82        | ClosingDisclosure |
	| 111        | 83        | ClosingDisclosure |
	| 112        | 84        | ClosingDisclosure |
	| 113        | 85        | ClosingDisclosure |
	| 114        | 86        | ClosingDisclosure |
	| 115        | 87        | ClosingDisclosure |
	| 116        | 88        | ClosingDisclosure |
	| 117        | 89        | ClosingDisclosure |



Scenario Outline: Uploading JSON file and Validating cards value on Loan Estimate page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
When user upload json file for the scenario
	And user navigates to Loan Estimate Cards Page
Then updated/computed in 5 Years value should display on Loan Estimate
	And updated/computed in 5 Years principal value should display on Loan Estimate
Examples:
	| ScenarioNo | RowNumber | cdSheetName       |
	| 1R         | 2         | ClosingDisclosure |
	| 2R         | 3         | ClosingDisclosure |
	| 3R         | 4         | ClosingDisclosure |
	| 4R         | 5         | ClosingDisclosure |
	| 6R         | 6         | ClosingDisclosure |
	| 7R         | 7         | ClosingDisclosure |
	| 8R         | 8         | ClosingDisclosure |
	| 9R         | 9         | ClosingDisclosure |
	| 11R        | 10        | ClosingDisclosure |
	| 12R        | 11        | ClosingDisclosure |
	| 13R        | 12        | ClosingDisclosure |
	| 14R        | 13        | ClosingDisclosure |
	| 16R        | 14        | ClosingDisclosure |
	| 17R        | 15        | ClosingDisclosure |
	| 19R        | 16        | ClosingDisclosure |
	| 36R        | 17        | ClosingDisclosure |
	| 37R        | 18        | ClosingDisclosure |
	| 38R        | 19        | ClosingDisclosure |
	| 38.1R      | 20        | ClosingDisclosure |
	| 39R        | 21        | ClosingDisclosure |
	| 40R        | 22        | ClosingDisclosure |
	| 41R        | 23        | ClosingDisclosure |
	| 42R        | 24        | ClosingDisclosure |
	| 43R        | 25        | ClosingDisclosure |
	| 50         | 28        | ClosingDisclosure |
	| 51         | 29        | ClosingDisclosure |
	| 52         | 30        | ClosingDisclosure |
	| 53         | 31        | ClosingDisclosure |
	| 54         | 32        | ClosingDisclosure |
	| 55         | 33        | ClosingDisclosure |
	| 56         | 34        | ClosingDisclosure |
	| 57         | 35        | ClosingDisclosure |
	| 70         | 46        | ClosingDisclosure |
	| 71         | 47        | ClosingDisclosure |
	| 72         | 48        | ClosingDisclosure |
	| 73         | 49        | ClosingDisclosure |
	| 74         | 50        | ClosingDisclosure |
	| 75         | 51        | ClosingDisclosure |
	| 76         | 52        | ClosingDisclosure |
	| 77         | 53        | ClosingDisclosure |
	| 90         | 64        | ClosingDisclosure |
	| 91         | 65        | ClosingDisclosure |
	| 92         | 66        | ClosingDisclosure |
	| 93         | 67        | ClosingDisclosure |
	| 94         | 68        | ClosingDisclosure |
	| 95         | 69        | ClosingDisclosure |
	| 96         | 70        | ClosingDisclosure |
	| 97         | 71        | ClosingDisclosure |
	| 110        | 82        | ClosingDisclosure |
	| 111        | 83        | ClosingDisclosure |
	| 112        | 84        | ClosingDisclosure |
	| 113        | 85        | ClosingDisclosure |
	| 114        | 86        | ClosingDisclosure |
	| 115        | 87        | ClosingDisclosure |
	| 116        | 88        | ClosingDisclosure |
	| 117        | 89        | ClosingDisclosure |
