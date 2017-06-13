Feature: EscrowInfoCardsValidation

Scenario Outline: Giving inputs from Excel file and validating Escrow Info cards value on Escrow Info page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <RowNumber>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aRowNumber>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <RowNumber>
	And user have Export data from excel sheet <eSheetName> for the scenario <RowNumber>
	And user have Escrow Info data from excel sheet <eiSheetName> for the scenario <RowNumber>
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
	And user navigates to Escrow Info Cards Page
Then updated/computed Insurance Initial Deposit value should display on Escrow Info
	And updated/computed Insurance Period Deposit value should display on Escrow Info
	And updated/computed Insurance Low Balance value should display on Escrow Info
	And updated/computed Insurance Cushion value should display on Escrow Info
	And updated/computed Insurance Total Annual Disbursed value should display on Escrow Info
	And updated/computed Tax Initial Deposit value should display on Escrow Info
	And updated/computed Tax Period Deposit value should display on Escrow Info
	And updated/computed Tax Low Balance value should display on Escrow Info
	And updated/computed Tax Cushion value should display on Escrow Info
	And updated/computed Tax Total Annual Disbursed value should display on Escrow Info
	And updated/computed PMI Initial Deposit value should display on Escrow Info
	And updated/computed PMI Period Deposit value should display on Escrow Info
	And updated/computed PMI Low Balance value should display on Escrow Info
	And updated/computed PMI Cushion value should display on Escrow Info
	And updated/computed PMI Total Annual Disbursed value should display on Escrow Info
	And updated/computed Other1 Initial Deposit value should display on Escrow Info
	And updated/computed Other1 Period Deposit value should display on Escrow Info
	And updated/computed Other1 Low Balance value should display on Escrow Info
	And updated/computed Other1 Cushion value should display on Escrow Info
	And updated/computed Other1 Total Annual Disbursed value should display on Escrow Info
	And updated/computed Other2 Initial Deposit value should display on Escrow Info
	And updated/computed Other2 Period Deposit value should display on Escrow Info
	And updated/computed Other2 Low Balance value should display on Escrow Info
	And updated/computed Other2 Cushion value should display on Escrow Info
	And updated/computed Other2 Total Annual Disbursed value should display on Escrow Info
	And updated/computed Aggregate Initial Deposit value should display on Escrow Info
	And updated/computed Aggregate Period Deposit value should display on Escrow Info
	And updated/computed Aggregate Low Balance value should display on Escrow Info
	And updated/computed Aggregate Cushion value should display on Escrow Info
	And updated/computed Aggregate Total Annual Disbursed value should display on Escrow Info
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName | eSheetName | eiSheetName |
	| 001        | 2         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 002        | 3         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 003        | 4         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 004        | 5         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 006        | 6         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 007        | 7         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 008        | 8         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 009        | 9         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 011        | 10        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 012        | 11        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 013        | 12        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 014        | 13        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 016        | 14        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 017        | 15        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 019        | 16        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 036        | 17        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARM Terms  | Export     | EscrowInfo  |
	| 037        | 18        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARM Terms  | Export     | EscrowInfo  |
	| 038        | 19        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARM Terms  | Export     | EscrowInfo  |
	| 039        | 20        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARM Terms  | Export     | EscrowInfo  |
	| 040        | 21        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 041        | 22        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 042        | 23        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 043        | 24        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 044        | 25        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 050        | 28        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 051        | 29        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 052        | 30        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 053        | 31        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 054        | 32        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 055        | 33        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 056        | 34        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 057        | 35        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 070        | 46        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 071        | 47        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 072        | 48        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 073        | 49        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 074        | 50        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 075        | 51        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 076        | 52        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 077        | 53        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 090        | 64        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 091        | 65        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 092        | 66        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 093        | 67        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 094        | 68        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 095        | 69        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 096        | 70        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 097        | 71        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 110        | 82        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 111        | 83        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 112        | 84        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 113        | 85        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 114        | 86        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 115        | 87        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 116        | 88        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |
	| 117        | 89        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARM Terms  | Export     | EscrowInfo  |


Scenario Outline: Uploading JSON file and validating Escrow Info cards value on Escrow Info page
Given user is at TRID application homepage
	And user have Escrow Info data from excel sheet <eiSheetName> for the scenario <RowNumber>
When user upload json file for the scenario
	And user navigates to Escrow Info Cards Page
Then updated/computed Insurance Initial Deposit value should display on Escrow Info
	And updated/computed Insurance Period Deposit value should display on Escrow Info
	And updated/computed Insurance Low Balance value should display on Escrow Info
	And updated/computed Insurance Cushion value should display on Escrow Info
	And updated/computed Insurance Total Annual Disbursed value should display on Escrow Info
	And updated/computed Tax Initial Deposit value should display on Escrow Info
	And updated/computed Tax Period Deposit value should display on Escrow Info
	And updated/computed Tax Low Balance value should display on Escrow Info
	And updated/computed Tax Cushion value should display on Escrow Info
	And updated/computed Tax Total Annual Disbursed value should display on Escrow Info
	And updated/computed PMI Initial Deposit value should display on Escrow Info
	And updated/computed PMI Period Deposit value should display on Escrow Info
	And updated/computed PMI Low Balance value should display on Escrow Info
	And updated/computed PMI Cushion value should display on Escrow Info
	And updated/computed PMI Total Annual Disbursed value should display on Escrow Info
	And updated/computed Other1 Initial Deposit value should display on Escrow Info
	And updated/computed Other1 Period Deposit value should display on Escrow Info
	And updated/computed Other1 Low Balance value should display on Escrow Info
	And updated/computed Other1 Cushion value should display on Escrow Info
	And updated/computed Other1 Total Annual Disbursed value should display on Escrow Info
	And updated/computed Other2 Initial Deposit value should display on Escrow Info
	And updated/computed Other2 Period Deposit value should display on Escrow Info
	And updated/computed Other2 Low Balance value should display on Escrow Info
	And updated/computed Other2 Cushion value should display on Escrow Info
	And updated/computed Other2 Total Annual Disbursed value should display on Escrow Info
	And updated/computed Aggregate Initial Deposit value should display on Escrow Info
	And updated/computed Aggregate Period Deposit value should display on Escrow Info
	And updated/computed Aggregate Low Balance value should display on Escrow Info
	And updated/computed Aggregate Cushion value should display on Escrow Info
	And updated/computed Aggregate Total Annual Disbursed value should display on Escrow Info
Examples:
	| ScenarioNo | RowNumber | eiSheetName |
	| 001        | 2         | EscrowInfo  |
	| 002        | 3         | EscrowInfo  |
	| 003        | 4         | EscrowInfo  |
	| 004        | 5         | EscrowInfo  |
	| 006        | 6         | EscrowInfo  |
	| 007        | 7         | EscrowInfo  |
	| 008        | 8         | EscrowInfo  |
	| 009        | 9         | EscrowInfo  |
	| 011        | 10        | EscrowInfo  |
	| 012        | 11        | EscrowInfo  |
	| 013        | 12        | EscrowInfo  |
	| 014        | 13        | EscrowInfo  |
	| 016        | 14        | EscrowInfo  |
	| 017        | 15        | EscrowInfo  |
	| 019        | 16        | EscrowInfo  |
	| 036        | 17        | EscrowInfo  |
	| 037        | 18        | EscrowInfo  |
	| 038        | 19        | EscrowInfo  |
	| 039        | 20        | EscrowInfo  |
	| 040        | 21        | EscrowInfo  |
	| 041        | 22        | EscrowInfo  |
	| 042        | 23        | EscrowInfo  |
	| 043        | 24        | EscrowInfo  |
	| 044        | 25        | EscrowInfo  |
	| 050        | 28        | EscrowInfo  |
	| 051        | 29        | EscrowInfo  |
	| 052        | 30        | EscrowInfo  |
	| 053        | 31        | EscrowInfo  |
	| 054        | 32        | EscrowInfo  |
	| 055        | 33        | EscrowInfo  |
	| 056        | 34        | EscrowInfo  |
	| 057        | 35        | EscrowInfo  |
	| 070        | 46        | EscrowInfo  |
	| 071        | 47        | EscrowInfo  |
	| 072        | 48        | EscrowInfo  |
	| 073        | 49        | EscrowInfo  |
	| 074        | 50        | EscrowInfo  |
	| 075        | 51        | EscrowInfo  |
	| 076        | 52        | EscrowInfo  |
	| 077        | 53        | EscrowInfo  |
	| 090        | 64        | EscrowInfo  |
	| 091        | 65        | EscrowInfo  |
	| 092        | 66        | EscrowInfo  |
	| 093        | 67        | EscrowInfo  |
	| 094        | 68        | EscrowInfo  |
	| 095        | 69        | EscrowInfo  |
	| 096        | 70        | EscrowInfo  |
	| 097        | 71        | EscrowInfo  |
	| 110        | 82        | EscrowInfo  |
	| 111        | 83        | EscrowInfo  |
	| 112        | 84        | EscrowInfo  |
	| 113        | 85        | EscrowInfo  |
	| 114        | 86        | EscrowInfo  |
	| 115        | 87        | EscrowInfo  |
	| 116        | 88        | EscrowInfo  |
	| 117        | 89        | EscrowInfo  |