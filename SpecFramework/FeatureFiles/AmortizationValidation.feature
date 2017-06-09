Feature: AmortizationValidation

Scenario Outline: Giving inputs from Excel file and validating Payment Schedule values on Amortization page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <RowNumber>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aRowNumber>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <RowNumber>
	And user have Payment Schedule data from excel sheet <psSheetName> for the scenario <RowNumber>
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
	And user enters input value for prepaid custom fields
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for closing disclousre section
	And user enters disclsoed input values for Loan Estimate
	And user enters disclosed input values for Prepaid Charges
	And user enters disclosed input values for Escrow Property
	#And user navigates to Export Page
	#And user enters all input values for Export Page
	#And user clicks on Export button to generate JSON file
	And user navigates to Amortization Page
Then updated/computed Payment Stream Number value should display on Payment Schedule Grid
	And updated/computed Number of Payments value should display on Payment Schedule Grid
	And updated/computed Payment Amount value should display on Payment Schedule Grid
	And updated/computed Monthly Payment value should display on Payment Schedule Grid
	And updated/computed Monthly PMI value should display on Payment Schedule Grid
	And updated/computed Ins Escrowed Amount value should display on Payment Schedule Grid
	And updated/computed Tax Escrowed Amount value should display on Payment Schedule Grid
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName | psSheetName     |
	| 001        | 2         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 002        | 3         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 003        | 4         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 004        | 5         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 006        | 6         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 007        | 7         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 008        | 8         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 009        | 9         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 011        | 10        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 012        | 11        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 013        | 12        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 014        | 13        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 016        | 14        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 017        | 15        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 019        | 16        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 036        | 17        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARM Terms  | PaymentSchedule |
	| 037        | 18        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARM Terms  | PaymentSchedule |
	| 038        | 19        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARM Terms  | PaymentSchedule |
	| 039        | 20        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARM Terms  | PaymentSchedule |
	| 040        | 21        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 041        | 22        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 042        | 23        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 043        | 24        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 044        | 25        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 050        | 28        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 051        | 29        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 052        | 30        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 053        | 31        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 054        | 32        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 055        | 33        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 056        | 34        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 057        | 35        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 070        | 46        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 071        | 47        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 072        | 48        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 073        | 49        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 074        | 50        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 075        | 51        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 076        | 52        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 077        | 53        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 090        | 64        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 091        | 65        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 092        | 66        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 093        | 67        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 094        | 68        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 095        | 69        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 096        | 70        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 097        | 71        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 110        | 82        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 111        | 83        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 112        | 84        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 113        | 85        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 114        | 86        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 115        | 87        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 116        | 88        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |
	| 117        | 89        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | PaymentSchedule |


Scenario Outline: Uploading JSON file and validating Payment Schedule values on Amortization page
Given user is at TRID application homepage
	And user have Payment Schedule data from excel sheet <psSheetName> for the scenario <RowNumber>
When user upload json file for the scenario
	And user navigates to Amortization Page
Then updated/computed Payment Stream Number value should display on Payment Schedule Grid
	And updated/computed Number of Payments value should display on Payment Schedule Grid
	And updated/computed Payment Amount value should display on Payment Schedule Grid
	And updated/computed Monthly Payment value should display on Payment Schedule Grid
	And updated/computed Monthly PMI value should display on Payment Schedule Grid
	And updated/computed Ins Escrowed Amount value should display on Payment Schedule Grid
	And updated/computed Tax Escrowed Amount value should display on Payment Schedule Grid
Examples:
	| ScenarioNo | RowNumber | psSheetName     |
	| 001        | 2         | PaymentSchedule |
	| 002        | 3         | PaymentSchedule |
	| 003        | 4         | PaymentSchedule |
	| 004        | 5         | PaymentSchedule |
	| 006        | 6         | PaymentSchedule |
	| 007        | 7         | PaymentSchedule |
	| 008        | 8         | PaymentSchedule |
	| 009        | 9         | PaymentSchedule |
	| 011        | 10        | PaymentSchedule |
	| 012        | 11        | PaymentSchedule |
	| 013        | 12        | PaymentSchedule |
	| 014        | 13        | PaymentSchedule |
	| 016        | 14        | PaymentSchedule |
	| 017        | 15        | PaymentSchedule |
	| 019        | 16        | PaymentSchedule |
	| 036        | 17        | PaymentSchedule |
	| 037        | 18        | PaymentSchedule |
	| 038        | 19        | PaymentSchedule |
	| 039        | 20        | PaymentSchedule |
	| 040        | 21        | PaymentSchedule |
	| 041        | 22        | PaymentSchedule |
	| 042        | 23        | PaymentSchedule |
	| 043        | 24        | PaymentSchedule |
	| 044        | 25        | PaymentSchedule |
	| 050        | 28        | PaymentSchedule |
	| 051        | 29        | PaymentSchedule |
	| 052        | 30        | PaymentSchedule |
	| 053        | 31        | PaymentSchedule |
	| 054        | 32        | PaymentSchedule |
	| 055        | 33        | PaymentSchedule |
	| 056        | 34        | PaymentSchedule |
	| 057        | 35        | PaymentSchedule |
	| 070        | 46        | PaymentSchedule |
	| 071        | 47        | PaymentSchedule |
	| 072        | 48        | PaymentSchedule |
	| 073        | 49        | PaymentSchedule |
	| 074        | 50        | PaymentSchedule |
	| 075        | 51        | PaymentSchedule |
	| 076        | 52        | PaymentSchedule |
	| 077        | 53        | PaymentSchedule |
	| 090        | 64        | PaymentSchedule |
	| 091        | 65        | PaymentSchedule |
	| 092        | 66        | PaymentSchedule |
	| 093        | 67        | PaymentSchedule |
	| 094        | 68        | PaymentSchedule |
	| 095        | 69        | PaymentSchedule |
	| 096        | 70        | PaymentSchedule |
	| 097        | 71        | PaymentSchedule |
	| 110        | 82        | PaymentSchedule |
	| 111        | 83        | PaymentSchedule |
	| 112        | 84        | PaymentSchedule |
	| 113        | 85        | PaymentSchedule |
	| 114        | 86        | PaymentSchedule |
	| 115        | 87        | PaymentSchedule |
	| 116        | 88        | PaymentSchedule |
	| 117        | 89        | PaymentSchedule |