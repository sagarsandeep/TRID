Feature: CardsValidation


Scenario Outline: Giving inputs from Excel file and validating cards value on Closing Disclosure page
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
	And user enters input value for prepaid custom fields
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
	And updated/computed APR value should display on Closing Disclosure
	And APRWIN info value should display on Closing Disclosure
	And updated/computed Balloon Amount value should display on Closing Disclosure
	And updated/computed Total of Payments value should display on Closing Disclosure
	And updated/computed Finance Charge value should display on Closing Disclosure
	And updated/computed Prepaid Charges value should display on Closing Disclosure
	And updated/computed Amount Financed value should display on Closing Disclosure
	And updated/computed TIP value should display on Closing Disclosure
	And updated/computed Escrow Property Costs over one year 11 Months value should display on Closing Disclosure
	And updated/computed Escrow Property Costs over one year 12 Months value should display on Closing Disclosure
	And updated/computed Initial Escrow Payment value should display on Closing Disclosure
	And updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	And updated/computed Estimated Escrow value should display on Closing Disclosure
	And updated/computed Estimated Taxes, Insurance & Assessments value should display on Closing Disclosure
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName | eSheetName |
	| 001        | 2         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 002        | 3         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 003        | 4         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 004        | 5         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 006        | 6         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 007        | 7         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 008        | 8         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 009        | 9         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 011        | 10        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 012        | 11        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 013        | 12        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 014        | 13        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 016        | 14        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 017        | 15        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 019        | 16        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 036        | 17        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARM Terms  | Export     |
	| 037        | 18        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARM Terms  | Export     |
	| 038        | 19        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARM Terms  | Export     |
	| 039        | 20        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARM Terms  | Export     |
	| 040        | 21        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 041        | 22        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 042        | 23        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 043        | 24        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 044        | 25        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 050        | 28        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 051        | 29        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 052        | 30        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 053        | 31        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 054        | 32        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 055        | 33        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 056        | 34        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 057        | 35        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 070        | 46        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 071        | 47        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 072        | 48        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 073        | 49        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 074        | 50        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 075        | 51        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 076        | 52        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 077        | 53        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 090        | 64        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 091        | 65        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 092        | 66        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 093        | 67        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 094        | 68        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 095        | 69        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 096        | 70        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 097        | 71        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 110        | 82        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 111        | 83        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 112        | 84        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 113        | 85        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 114        | 86        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 115        | 87        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 116        | 88        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |
	| 117        | 89        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     |



Scenario Outline: Giving inputs from Excel file and validating cards value on Loan Estimate page
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
	And user enters input value for prepaid custom fields
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
	| 001        | 2         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 002        | 3         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 003        | 4         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 004        | 5         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 006        | 6         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 007        | 7         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 008        | 8         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 009        | 9         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 011        | 10        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 012        | 11        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 013        | 12        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 014        | 13        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 016        | 14        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 017        | 15        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 019        | 16        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 036        | 17        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARM Terms  |
	| 037        | 18        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARM Terms  |
	| 038        | 19        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARM Terms  |
	| 039        | 20        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARM Terms  |
	| 040        | 21        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 041        | 22        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 042        | 23        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 043        | 24        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 044        | 25        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 050        | 28        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 051        | 29        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 052        | 30        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 053        | 31        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 054        | 32        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 055        | 33        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 056        | 34        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 057        | 35        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 070        | 46        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 071        | 47        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 072        | 48        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 073        | 49        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 074        | 50        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 075        | 51        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 076        | 52        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 077        | 53        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 090        | 64        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 091        | 65        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 092        | 66        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 093        | 67        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 094        | 68        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 095        | 69        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 096        | 70        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
	| 097        | 71        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  |
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
	And updated/computed Escrow Property Costs over one year 11 Months value should display on Closing Disclosure
	And updated/computed Escrow Property Costs over one year 12 Months value should display on Closing Disclosure
	And updated/computed APR value should display on Closing Disclosure
	And APRWIN info value should display on Closing Disclosure
	And updated/computed Balloon Amount value should display on Closing Disclosure
	And updated/computed Total of Payments value should display on Closing Disclosure
	And updated/computed Finance Charge value should display on Closing Disclosure
	And updated/computed TIP value should display on Closing Disclosure
	And updated/computed Initial Escrow Payment value should display on Closing Disclosure
	And updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	And updated/computed Estimated Escrow value should display on Closing Disclosure
	And updated/computed Estimated Taxes, Insurance & Assessments value should display on Closing Disclosure
Examples:
	| ScenarioNo | RowNumber | cdSheetName       |
	| 001        | 2         | ClosingDisclosure |
	| 002        | 3         | ClosingDisclosure |
	| 003        | 4         | ClosingDisclosure |
	| 004        | 5         | ClosingDisclosure |
	| 006        | 6         | ClosingDisclosure |
	| 007        | 7         | ClosingDisclosure |
	| 008        | 8         | ClosingDisclosure |
	| 009        | 9         | ClosingDisclosure |
	| 011        | 10        | ClosingDisclosure |
	| 012        | 11        | ClosingDisclosure |
	| 013        | 12        | ClosingDisclosure |
	| 014        | 13        | ClosingDisclosure |
	| 016        | 14        | ClosingDisclosure |
	| 017        | 15        | ClosingDisclosure |
	| 019        | 16        | ClosingDisclosure |
	| 036        | 17        | ClosingDisclosure |
	| 037        | 18        | ClosingDisclosure |
	| 038        | 19        | ClosingDisclosure |
	| 039        | 20        | ClosingDisclosure |
	| 040        | 21        | ClosingDisclosure |
	| 041        | 22        | ClosingDisclosure |
	| 042        | 23        | ClosingDisclosure |
	| 043        | 24        | ClosingDisclosure |
	| 044        | 25        | ClosingDisclosure |
	| 050        | 28        | ClosingDisclosure |
	| 051        | 29        | ClosingDisclosure |
	| 052        | 30        | ClosingDisclosure |
	| 053        | 31        | ClosingDisclosure |
	| 054        | 32        | ClosingDisclosure |
	| 055        | 33        | ClosingDisclosure |
	| 056        | 34        | ClosingDisclosure |
	| 057        | 35        | ClosingDisclosure |
	| 070        | 46        | ClosingDisclosure |
	| 071        | 47        | ClosingDisclosure |
	| 072        | 48        | ClosingDisclosure |
	| 073        | 49        | ClosingDisclosure |
	| 074        | 50        | ClosingDisclosure |
	| 075        | 51        | ClosingDisclosure |
	| 076        | 52        | ClosingDisclosure |
	| 077        | 53        | ClosingDisclosure |
	| 090        | 64        | ClosingDisclosure |
	| 091        | 65        | ClosingDisclosure |
	| 092        | 66        | ClosingDisclosure |
	| 093        | 67        | ClosingDisclosure |
	| 094        | 68        | ClosingDisclosure |
	| 095        | 69        | ClosingDisclosure |
	| 096        | 70        | ClosingDisclosure |
	| 097        | 71        | ClosingDisclosure |
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
	| 001        | 2         | ClosingDisclosure |
	| 002        | 3         | ClosingDisclosure |
	| 003        | 4         | ClosingDisclosure |
	| 004        | 5         | ClosingDisclosure |
	| 006        | 6         | ClosingDisclosure |
	| 007        | 7         | ClosingDisclosure |
	| 008        | 8         | ClosingDisclosure |
	| 009        | 9         | ClosingDisclosure |
	| 011        | 10        | ClosingDisclosure |
	| 012        | 11        | ClosingDisclosure |
	| 013        | 12        | ClosingDisclosure |
	| 014        | 13        | ClosingDisclosure |
	| 016        | 14        | ClosingDisclosure |
	| 017        | 15        | ClosingDisclosure |
	| 019        | 16        | ClosingDisclosure |
	| 036        | 17        | ClosingDisclosure |
	| 037        | 18        | ClosingDisclosure |
	| 038        | 19        | ClosingDisclosure |
	| 039        | 20        | ClosingDisclosure |
	| 040        | 21        | ClosingDisclosure |
	| 041        | 22        | ClosingDisclosure |
	| 042        | 23        | ClosingDisclosure |
	| 043        | 24        | ClosingDisclosure |
	| 044        | 25        | ClosingDisclosure |
	| 050        | 28        | ClosingDisclosure |
	| 051        | 29        | ClosingDisclosure |
	| 052        | 30        | ClosingDisclosure |
	| 053        | 31        | ClosingDisclosure |
	| 054        | 32        | ClosingDisclosure |
	| 055        | 33        | ClosingDisclosure |
	| 056        | 34        | ClosingDisclosure |
	| 057        | 35        | ClosingDisclosure |
	| 070        | 46        | ClosingDisclosure |
	| 071        | 47        | ClosingDisclosure |
	| 072        | 48        | ClosingDisclosure |
	| 073        | 49        | ClosingDisclosure |
	| 074        | 50        | ClosingDisclosure |
	| 075        | 51        | ClosingDisclosure |
	| 076        | 52        | ClosingDisclosure |
	| 077        | 53        | ClosingDisclosure |
	| 090        | 64        | ClosingDisclosure |
	| 091        | 65        | ClosingDisclosure |
	| 092        | 66        | ClosingDisclosure |
	| 093        | 67        | ClosingDisclosure |
	| 094        | 68        | ClosingDisclosure |
	| 095        | 69        | ClosingDisclosure |
	| 096        | 70        | ClosingDisclosure |
	| 097        | 71        | ClosingDisclosure |
	| 110        | 82        | ClosingDisclosure |
	| 111        | 83        | ClosingDisclosure |
	| 112        | 84        | ClosingDisclosure |
	| 113        | 85        | ClosingDisclosure |
	| 114        | 86        | ClosingDisclosure |
	| 115        | 87        | ClosingDisclosure |
	| 116        | 88        | ClosingDisclosure |
	| 117        | 89        | ClosingDisclosure |