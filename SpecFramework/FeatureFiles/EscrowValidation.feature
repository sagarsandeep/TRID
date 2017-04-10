Feature: EscrowValidation
Escrow page validation with Insurance, Tax and PMI values

@Escrow
Scenario Outline: Add two numbers
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user selects Frequency of Payments in Closing Disclosure Page 
	And user selects Loan Term in Closing Disclosure Page 
	And user selects Repayment Term Type in Closing Disclosure Page 
	And Enter Loan detail input values for computation for Closing Disclosure page
	And Enter Disclosed input values for Closing Disclosure page
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
	And user navigate to Escrow Page
	And user selects value for Is Ins Escrowed
	And user selects value for Is Tax Escrowed
	And user selects value for Is PMI Escrowed
	And user enters values for Escrow Calculations start period Date
	And user enters values for Cushion Months for Insurance
	And user enters values for Cushion Months for Tax
	And user enters values for Escrow insurance Inputs
	And user enters values for Escrow Tax Calculations Inputs
	And user enters values for Escrow PMI Calculations Inputs
	And user clicks on Escrow Calculation Input Test Button
	And user enters all other input values in Escrow Page
	And user clicks on Disclosure For Escrow Test Button
	Examples: 
	| No | pcScenarioNo | pcSheetName    | miScenarioNo | miSheetName       | cdScenarioNo | cdSheetName       | eScenarioNo | eSheetName |
	| 1  | 1            | PrepaidCharges | 1            | MortgageInsurance | 1            | ClosingDisclosure | 1           | Escrow     |
	| 2  | 1            | PrepaidCharges | 1            | MortgageInsurance | 2            | ClosingDisclosure | 2           | Escrow     |
	| 3  | 1            | PrepaidCharges | 1            | MortgageInsurance | 3            | ClosingDisclosure | 3           | Escrow     |
	| 4  | 1            | PrepaidCharges | 1            | MortgageInsurance | 4            | ClosingDisclosure | 4           | Escrow     |
	| 5  | 1            | PrepaidCharges | 1            | MortgageInsurance | 5            | ClosingDisclosure | 5           | Escrow     |
	| 6  | 1            | PrepaidCharges | 1            | MortgageInsurance | 6            | ClosingDisclosure | 6           | Escrow     |
	| 7  | 1            | PrepaidCharges | 1            | MortgageInsurance | 7            | ClosingDisclosure | 7           | Escrow     |
	| 8  | 1            | PrepaidCharges | 1            | MortgageInsurance | 8            | ClosingDisclosure | 8           | Escrow     |
	| 9  | 1            | PrepaidCharges | 1            | MortgageInsurance | 9            | ClosingDisclosure | 9           | Escrow     |
